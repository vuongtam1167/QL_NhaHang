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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_NhaHang
{
    public partial class frmQLNguyenLieu : Form
    {
        LOAINGUYENLIEU_BUS loaibus = new LOAINGUYENLIEU_BUS();
        NHACUNGCAP_BUS nhaccbus = new NHACUNGCAP_BUS();
        NGUYENLIEU_BUS nlbus = new NGUYENLIEU_BUS();
        List<NGUYENLIEU_DTO> lsnl;
        NGUYENLIEU_DTO nl;
        public frmQLNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmQLNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadLoaiNL();
            LoadNhaCC();
            dgvNguyenLieu.AutoGenerateColumns = false;
            LoadDSNL();

        }

        private void LoadNhaCC()
        {
            List<NHACUNGCAP_DTO> lsnhacc = nhaccbus.loadNhaCungCap();
            cboNhaCungCap.DataSource = lsnhacc;
            cboNhaCungCap.DisplayMember = "TENNHACUNGCAP";
            cboNhaCungCap.ValueMember = "MANHACUNGCAP";

            colMaNCC.DataSource = lsnhacc;
            colMaNCC.DisplayMember = "TENNHACUNGCAP";
            colMaNCC.ValueMember = "MANHACUNGCAP";
        }

        private void LoadDSNL()
        {
            lsnl = nlbus.DanhSachNL();
            dgvNguyenLieu.DataSource = lsnl;
        }

        private void LoadLoaiNL()
        {
            List<LOAINGUYENLIEU_DTO> lsloai = loaibus.DanhSachLoai();
            cboLoaiNL.DataSource = lsloai;
            cboLoaiNL.DisplayMember = "TENLOAINGUYENLIEU";
            cboLoaiNL.ValueMember = "MALOAINL";

            colLoaiNL.DataSource = lsloai;
            colLoaiNL.DisplayMember = "TENLOAINGUYENLIEU";
            colLoaiNL.ValueMember = "MALOAINL";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }
            nl = new NGUYENLIEU_DTO();
            nl.MANGUYENLIEU = nlbus.LayNguyenLieuTiepTheo();
            LayThongTinNguyenLieu();
            if (nlbus.ThemMoiNguyenLieu(nl))
            {
                MessageBox.Show($"Thêm mới nguyên liệu có mã {nl.MANGUYENLIEU} thành công!", "Thêm Mới");
                LoadDSNL();
            }
            else
            {
                MessageBox.Show($"Thêm nguyên liệu không thành công!", "Thêm Mới");
            }
        }
        private void LayThongTinNguyenLieu()
        {
            nl.TENNGUYENLIEU = txtTenNL.Text;
            nl.SOLUONGCON = (int)nudSLton.Value;
            nl.LOAINGUYENLIEU = (int)cboLoaiNL.SelectedValue;
            nl.MANHACUNGCAP = (int)cboNhaCungCap.SelectedValue;
            nl.GIATIEN = (int)nudGiaTien.Value;
            nl.MOTA = rtbMoTa.Text;
        }

        private void dgvNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                nl = dgvNguyenLieu.CurrentRow.DataBoundItem as NGUYENLIEU_DTO;

            }
            else
            {
                nl = null;
            }
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            if (nl != null)
            {
                txtMaNL.Text = nl.MANGUYENLIEU.ToString();
                txtTenNL.Text = nl.TENNGUYENLIEU; 
                nudSLton.Value = nl.SOLUONGCON;
                cboLoaiNL.SelectedValue = nl.LOAINGUYENLIEU;
                cboNhaCungCap.SelectedValue = nl.MANHACUNGCAP;
                nudGiaTien.Value = int.Parse(nl.GIATIEN.ToString());
                rtbMoTa.Text = nl.MOTA;
            }
            else
            {
                txtMaNL.Clear();
                txtTenNL.Clear();
                nudSLton.Value = 0;
                cboLoaiNL.SelectedIndex = 1;
                cboNhaCungCap.SelectedIndex = 1;
                nudGiaTien.Value = 0;
                rtbMoTa.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                LayThongTinNguyenLieu();
                if (nlbus.SuaNguyenLieu(nl))
                {
                    MessageBox.Show($"Sửa nguyên liệu có mã {nl.MANGUYENLIEU} thành công!", "Sửa");
                    LoadDSNL();
                }
                else
                {
                    MessageBox.Show($"Sửa nguyên liệu không thành công!", "Sửa");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNguyenLieu.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                if (nlbus.XoaNguyenLieu(int.Parse(txtMaNL.Text)))
                {
                    MessageBox.Show($"Xóa nguyên liệu có mã {nl.MANGUYENLIEU} thành công!", "Sửa");
                    LoadDSNL();
                }
                else
                {
                    MessageBox.Show($"Xóa nguyên liệu không thành công!", "Sửa");
                }
            }
        }
    }
}
