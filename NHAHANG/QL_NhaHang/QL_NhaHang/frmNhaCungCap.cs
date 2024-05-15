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
    public partial class frmNhaCungCap : Form
    {
        NHACUNGCAP_BUS NCCBUS = new NHACUNGCAP_BUS();
        List<NHACUNGCAP_DTO> lsNCC = new List<NHACUNGCAP_DTO>();
        NHACUNGCAP_DTO ncc;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }


        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.AutoGenerateColumns = false;
            loadDSNCC();
        }

        private void loadDSNCC()
        {
            lsNCC = NCCBUS.loadNhaCungCap();
            dgvNhaCungCap.DataSource = lsNCC;
        }

        private void dgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count > 0)
            {
                ncc = dgvNhaCungCap.SelectedRows[0].DataBoundItem as NHACUNGCAP_DTO;
            }
            else
            {
                ncc = null;
            }
            hienThiThongTin();
        }

        private void hienThiThongTin()
        {
            if (ncc != null)
            {
                txtMaNhaCungCap.Text = ncc.MANHACUNGCAP.ToString();
                txtTenNhaCungCap.Text = ncc.TENNHACUNGCAP;
                txtDiaChi.Text = ncc.DIACHI;
                txtGhiChu.Text = ncc.GHICHU;
                ckbTrangThai.Checked = true;
            }
            else
            {
                txtMaNhaCungCap.Clear();
                txtTenNhaCungCap.Clear();
                txtDiaChi.Clear();
                txtGhiChu.Clear();
                ckbTrangThai.Checked = false;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm mới");
                return;
            }
            ncc = new NHACUNGCAP_DTO();
            ncc.MANHACUNGCAP = NCCBUS.LayMaTT();
            layThongTin();
            if (NCCBUS.themMoi(ncc))
            {
                MessageBox.Show("Thêm mới thành công", "Thêm mới");
                loadDSNCC();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại ", "Thêm mới");
            }
        }

        private void layThongTin()
        {
            ncc.TENNHACUNGCAP = txtTenNhaCungCap.Text;
            ncc.DIACHI = txtDiaChi.Text;
            ncc.GHICHU = txtGhiChu.Text;
            if (ckbTrangThai.Checked)
                ncc.TRANGTHAI = 1;
            else ncc.TRANGTHAI = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvNhaCungCap.ClearSelection();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa", "Thông báo");
                return;
            }
            else
            {
                if (NCCBUS.xoaTT(txtMaNhaCungCap.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadDSNCC();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count > 0)
            {
                layThongTin();
                if (NCCBUS.suaTT(ncc))
                {
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    loadDSNCC();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại", "Thông báo");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimMaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp bạn muốn tìm");
                return;
            }
            if (NCCBUS.TimNCC(txtTimMaNCC.Text))
            {
                lsNCC = new List<NHACUNGCAP_DTO>();
                MessageBox.Show($"Tìm thấy nhà cung cấp có  mã '{txtTimMaNCC.Text}'");
                lsNCC = NCCBUS.DSHDTim(txtTimMaNCC.Text);
                dgvNhaCungCap.DataSource = lsNCC;
            }
            else
            {
                loadDSNCC();
                MessageBox.Show("Không tìm thấy mã hóa đơn");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadDSNCC();
        }
    }
}
