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
    public partial class frmKhachHang : Form
    {
        KHACHHANG_BUS khBUS = new KHACHHANG_BUS();
        List<KHACHHANG_DTO> lsKhachHang;
        KHACHHANG_DTO khach;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            dgvtt.AutoGenerateColumns = false;
            LoadsKhachHang();
        }

        private void LoadsKhachHang()
        {
            lsKhachHang = khBUS.DanhSachKhachHang();
            dgvtt.DataSource = lsKhachHang;
        }

        private void dgvtt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtt.SelectedRows.Count > 0)
            {
                khach = dgvtt.SelectedRows[0].DataBoundItem as KHACHHANG_DTO;
            }
            else
            {
                khach = null;
            }
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            if (khach != null)
            {
                txtMaKH.Text = khach.MAKH;
                txtTenKH.Text = khach.HOTEN;
                txtCCCD.Text = khach.CCCD;
                txtSDT.Text = khach.SDT;
            }
            else
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtCCCD.Clear();
                txtSDT.Clear();
            }
        }



        private void LayThongtin()
        {
            khach.HOTEN = txtTenKH.Text.Trim();
            khach.CCCD = txtCCCD.Text.Trim();
            khach.SDT = txtSDT.Text.Trim();
        }



        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvtt.SelectedRows.Count > 0)
            {
                if (khBUS.XoaKhachHang(txtMaKH.Text))
                {
                    MessageBox.Show($"Xóa thành công khách hàng'{txtMaKH.Text}'", "Thông báo");
                    LoadsKhachHang();
                }
                else

                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
        }






        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng bạn muốn tìm");
                return;
            }
            if (khBUS.TimKhachHang(txtTimMaKH.Text))
            {
                MessageBox.Show($"Tìm thấy mã khách hàng'{txtTimMaKH.Text}'");
                lsKhachHang = khBUS.DSKHTim(txtTimMaKH.Text);
                dgvtt.DataSource = lsKhachHang;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khách hàng");
            }
        }

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy thông tin", "Thông Báo");
                return;
            }
            khach = new KHACHHANG_DTO();
            khach.MAKH = khBUS.LayMaKhachTiepTheo();
            LayThongtin();
            if (khBUS.ThemMoikhachHang(khach))
            {
                MessageBox.Show("Thêm mới khách hàng có mã " + khach.MAKH + " thành công!", "Thêm Mới");
                LoadsKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm Khách hàng không thành công!", "Thêm Mới");
            }
        }

        private void btnSuaKH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy thông tin", "Thông Báo");
                return;
            }
            if (dgvtt.SelectedRows.Count > 0)
            {
                khach.MAKH = txtMaKH.Text;
                LayThongtin();
                if (khBUS.SuaKhachHang(khach))
                {
                    MessageBox.Show("Sửa thành công ");
                    LoadsKhachHang();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công ");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvtt.ClearSelection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadsKhachHang();
        }
    }
}
