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
    public partial class frmHoaDon : Form
    {
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        KHACHHANG_BUS khBUS = new KHACHHANG_BUS();

        HOADON_BUS hdBUS = new HOADON_BUS();
        List<HOADON_DTO> lsHoaDon;
        HOADON_DTO hd;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadMaNV();
            LoadKH();
            dgvtt.AutoGenerateColumns = false;
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            lsHoaDon = hdBUS.DanhSachHoaDon();
            dgvtt.DataSource = lsHoaDon;
        }

        private void LoadKH()
        {
            List<KHACHHANG_DTO> lskh = khBUS.DanhSachKhachHang();
            cboTenKH.DataSource = lskh;
            cboTenKH.DisplayMember = "HOTEN";
            cboTenKH.ValueMember = "MAKH";

            colTenKH.DataSource = lskh;
            colTenKH.DisplayMember = "HOTEN";
            colTenKH.ValueMember = "MAKH";
        }

        private void LoadMaNV()
        {
            List<NHANVIEN_DTO> lsnv = nvBUS.loadNhanVien();
            cboTenNV.DataSource = lsnv;
            cboTenNV.DisplayMember = "HOTEN";
            cboTenNV.ValueMember = "MANV";

            colTenNV.DataSource = lsnv;
            colTenNV.DisplayMember = "HOTEN";
            colTenNV.ValueMember = "MANV";
        }

        private void btnTMHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn bạn muốn tìm");
                return;
            }
            if (hdBUS.TimHoaDon(txtTimMaHD.Text))
            {
                lsHoaDon = new List<HOADON_DTO>();
                MessageBox.Show($"Tìm thấy mã hóa đơn'{txtTimMaHD.Text}'");
                lsHoaDon = hdBUS.DSHDTim(int.Parse(txtTimMaHD.Text));
                dgvtt.DataSource = lsHoaDon;
            }
            else
            {
                LoadHoaDon();
                MessageBox.Show("Không tìm thấy mã hóa đơn");
            }
        }


        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgvtt_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtt.SelectedRows.Count > 0)
            {
                hd = dgvtt.SelectedRows[0].DataBoundItem as HOADON_DTO;
            }
            else
            {
                hd = null;
            }
            hienThiThongTin();
        }

        private void hienThiThongTin()
        {
            if (hd != null)
            {
                txtMaHD.Text = hd.MAHD.ToString();
                cboTenNV.SelectedValue = hd.MANV;
                cboTenKH.SelectedValue = hd.MAKH;
                dtpHD.Value = hd.NGAYLAP;
                lblTongTien.Text = hd.TONGTIENVAVAT.ToString();
            }
        }
    }
}
