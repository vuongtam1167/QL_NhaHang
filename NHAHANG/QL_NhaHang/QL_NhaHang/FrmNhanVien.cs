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
    public partial class frmNhanVien : Form
    {
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        List<NHANVIEN_DTO> lsNV = new List<NHANVIEN_DTO>();
        NHANVIEN_DTO nv;
        string strPathHinh = "Dulieu/NhanVien/";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvtt.AutoGenerateColumns = false;
            loadDSNV();
        }

        private void loadDSNV()
        {
            lsNV = nvBUS.loadNhanVien();
            dgvtt.DataSource = lsNV;
        }

        private void dgvtt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtt.SelectedRows.Count > 0)
            {
                nv = dgvtt.SelectedRows[0].DataBoundItem as NHANVIEN_DTO;
            }
            else
            {
                nv = null;
            }
            hienThiThongTin();
        }

        private void hienThiThongTin()
        {
            if (nv != null)
            {
                txtMaNV.Text = nv.MANV;
                txtTenNV.Text = nv.HOTEN;
                txtEmNV.Text = nv.EMAIL;
                txtSDTNV.Text = nv.SDT;
                txtCCCD.Text = nv.CCCD;
                txtChucV.Text = nv.CHUCVU;
                txtThanhTich.Text = nv.THANHTICH.ToString();
                txtTongTG.Text = nv.TONGTHOIGIANLAM.ToString();
                ckbTrangThai.Checked = true;
                picNhanVien.Image = Utils.HinhAnhTuDuongDan(nv.HINHANH);

            }
            else
            {
                txtMaNV.Clear();
                txtTenNV.Clear(); txtEmNV.Clear(); txtCCCD.Clear(); txtThanhTich.Clear(); txtTongTG.Clear();
                ckbTrangThai.Checked = false;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmTrangChu f = (frmTrangChu)this.MdiParent;
            
            if (f.tkdn.LOAITK.Equals("QL"))
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm mới");
                    return;
                }
                if (picNhanVien.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh", "Thêm mới");
                    return;
                }
                nv = new NHANVIEN_DTO();
                nv.MANV = nvBUS.layMaTT().ToString();
                nv.HINHANH = strPathHinh + nv.MANV + ".png";
                layTT();
                if (nvBUS.themMoi(nv))
                {
                    picNhanVien.Image.Save(nv.HINHANH);
                    MessageBox.Show("Thêm mới thành công", "Thêm mới");
                    loadDSNV();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại ", "Thêm mới");
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản bạn không đủ quyền chi cập", "Thông Báo");
            }

        }

        private void layTT()
        {

            nv.HOTEN = txtTenNV.Text;
            nv.EMAIL = txtEmNV.Text;
            nv.SDT = txtSDTNV.Text;
            nv.CCCD = txtCCCD.Text;
            nv.CHUCVU = txtChucV.Text;
            nv.THANHTICH = int.Parse(txtThanhTich.Text);
            nv.TONGTHOIGIANLAM = int.Parse(txtTongTG.Text);
            if (ckbTrangThai.Checked)
                nv.TRANGTHAI = 1;
            else nv.TRANGTHAI = 0;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            frmTrangChu f = (frmTrangChu)this.MdiParent;

            if (f.tkdn.LOAITK.Equals("QL"))
            {
            if (dgvtt.SelectedRows.Count > 0)
            {
                layTT();
                if (nvBUS.suaTT(nv))
                {
                    picNhanVien.Image.Save(nv.HINHANH);
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    loadDSNV();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Thông báo");
                }
            }
            }
            else
            {
                MessageBox.Show("Tài Khoản bạn không đủ quyền chi cập", "Thông Báo");
            }

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            frmTrangChu f = (frmTrangChu)this.MdiParent;

            if (f.tkdn.LOAITK.Equals("QL"))
            {
            if (dgvtt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa", "Thông báo");
                return;
            }
            else
            {
                if (nvBUS.xoaTT(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadDSNV();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
            }
            else
            {
                MessageBox.Show("Tài Khoản bạn không đủ quyền chi cập", "Thông Báo");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvtt.ClearSelection();
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình Ảnh|*.jpg;*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                picNhanVien.Image = Utils.HinhAnhTuDuongDan(ofd.FileName);
            }
            else
            {
                picNhanVien.Image = Properties.Resources.defaut;
            }
        }

        private void txtChucV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
