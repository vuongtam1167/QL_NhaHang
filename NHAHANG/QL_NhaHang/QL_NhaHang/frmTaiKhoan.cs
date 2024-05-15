using QL_NhaHang_BUS;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaHang
{
    public partial class frmTaiKhoan : Form
    {
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        TAIKHOAN_BUS tkBUS = new TAIKHOAN_BUS();
        List<TAIKHOAN_DTO> lsTK;
        TAIKHOAN_DTO tk = new TAIKHOAN_DTO();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            cboLoaiTK.SelectedIndex = 0;
            cboLoaiTK.SelectedIndex = 0;
            LoadMaNV();
            dgvTK.AutoGenerateColumns = false;
            LoadDanhSachTaiKhoan();
        }

        private void LoadMaNV()
        {
            List<NHANVIEN_DTO> lsnv = nvBUS.loadNhanVien();
            cboManv.DataSource = lsnv;
            cboManv.DisplayMember = "HOTEN";
            cboManv.ValueMember = "MANV";

            colMaNV.DataSource = lsnv;
            colMaNV.DisplayMember = "HOTEN";
            colMaNV.ValueMember = "MANV";
        }

        private void LoadDanhSachTaiKhoan()
        {
            lsTK = tkBUS.DanhSachTaiKhoan();
            dgvTK.DataSource = lsTK;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDN.Text)||string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm mới");
                return;
            }
            if (tkBUS.TenDangNhapTrung(txtTenDN.Text))
            {
                MessageBox.Show("Có tên trùng \nVui lòng nhập lại tên đăng nhập", "Thêm mới");
                return;
            }
            tk.MANV = cboManv.SelectedValue.ToString(); ;
            layTT();
            if (tkBUS.ThemMoiTK(tk))
            {
                MessageBox.Show("Thêm mới thành công", "Thêm mới");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại ", "Thêm mới");
            }
        }
        private void layTT()
        {

            tk.TENDANGNHAP = txtTenDN.Text;
            string matkhau = Utils.MaHoaMD5MK(txtMK.Text);
            tk.MATKHAU = matkhau;
            tk.LOAITK = cboLoaiTK.Text;
            if (chkTrangThai.Checked)
                tk.TRANGTHAI = 1;
            else tk.TRANGTHAI = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm mới");
                return;
            }

            tk.MANV = cboManv.SelectedValue.ToString(); ;
            layTT();
            if (tkBUS.SuaTK(tk))
            {
                MessageBox.Show("Sửa thành công", "Sửa");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Sửa thất bại ", "Sửa");
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTK.SelectedRows.Count > 0)
            {
                tk = dgvTK.SelectedRows[0].DataBoundItem as TAIKHOAN_DTO;
            }
            else
            {
                tk = null;
            }
            hienThiThongTin();
        }

        private void hienThiThongTin()
        {
            if(tk != null)
            {
                cboManv.SelectedValue = tk.MANV;
                txtTenDN.Text = tk.TENDANGNHAP;
                txtMK.Text = tk.MATKHAU;
                cboLoaiTK.SelectedValue = tk.LOAITK;
                if(tk.TRANGTHAI == 1)
                    chkTrangThai.Checked = true;
                else 
                    chkTrangThai.Checked = false;
                string hinhanh = tkBUS.LayHinhAnh(tk.MANV);
                picAnhDD.Image = Utils.HinhAnhTuDuongDan(hinhanh);
            }
            else
            {
                cboManv.SelectedIndex = 0;
                txtTenDN.Clear();
                txtMK.Clear();
                cboLoaiTK.SelectedIndex = 0;
                chkTrangThai.Checked = true;
                picAnhDD.Image = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (tkBUS.XoaTK(txtTenDN.Text))
                {
                    MessageBox.Show("Xóa thành công", "Xóa");
                    LoadDanhSachTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ", "Xóa");
                }
            }
        }
    }
}
