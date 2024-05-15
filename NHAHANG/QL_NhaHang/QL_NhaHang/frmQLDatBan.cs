using QL_NhaHang_BUS;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaHang
{
    public partial class frmQLDatBan : Form
    {
        KHACHHANG_BUS khbus = new KHACHHANG_BUS();
        NHANVIEN_BUS nvbus = new NHANVIEN_BUS();

        DATBAN_BUS dbBUS = new DATBAN_BUS();
        List<DATBAN_DTO> lsDatBan;
        DATBAN_DTO db;

        public frmQLDatBan()
        {
            InitializeComponent();
        }

        private void frmQLDatban_Load(object sender, EventArgs e)
        {
            cboSoBan.SelectedIndex = 0;
            cboTG.SelectedIndex = 0;
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            colNgayDat.DefaultCellStyle.Format = dtpNgayDat.CustomFormat;
            LoadMaKH();
            LoadMaNV();
            dgvDB.AutoGenerateColumns = false;
            LoaddsDatBan();
        }

        private void LoadMaKH()
        {
            List<KHACHHANG_DTO> lskh = khbus.DanhSachKhachHang();
            cboMaKH.DataSource = lskh;
            cboMaKH.DisplayMember = "HOTEN";
            cboMaKH.ValueMember = "MAKH";

            colMaKH.DataSource = lskh;
            colMaKH.DisplayMember = "HOTEN";
            colMaKH.ValueMember = "MAKH";
        }

        private void LoadMaNV()
        {
            List<NHANVIEN_DTO> lsnv = nvbus.loadNhanVien();
            cboMaNV.DataSource = lsnv;
            cboMaNV.DisplayMember = "HOTEN";
            cboMaNV.ValueMember = "MANV";

            colMaNV.DataSource = lsnv;
            colMaNV.DisplayMember = "HOTEN";
            colMaNV.ValueMember = "MANV";
        }

        private void LoaddsDatBan()
        {
            lsDatBan = dbBUS.DanhSachDatBan();
            dgvDB.DataSource = lsDatBan;
        }

        private void HienThiThongTin()
        {
            if (db != null)
            {
                txtMaDatBan.Text = db.MADATBAN.ToString();

                cboSoBan.SelectedValue = db.SOBAN;
                cboMaNV.SelectedValue = db.MANV;
                cboMaKH.SelectedValue = db.MAKH;
                cboTG.SelectedValue = db.THOIGIANDAT;

                dtpNgayDat.Value = db.NGAYDAT;
                txtGC.Text = db.GHICHU.ToString();

            }
            else
            {
                txtMaDatBan.Clear();
                cboSoBan.SelectedIndex = 0;
                cboMaNV.SelectedIndex = 0;
                cboMaKH.SelectedIndex = 0;
                cboTG.SelectedIndex = 0;
                dtpNgayDat.Value = DateTime.Now;
                txtGC.Clear();
            }
        }

        private void LayThongtin()
        {
            db.SOBAN = cboSoBan.SelectedIndex + 1;
            db.MANV = cboMaNV.SelectedValue.ToString();
            db.MAKH = cboMaKH.SelectedValue.ToString();
            db.THOIGIANDAT = cboTG.Text;
            db.NGAYDAT = DateTime.ParseExact(dtpNgayDat.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            db.GHICHU = txtGC.Text;

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSoBan.Text) || string.IsNullOrWhiteSpace(cboMaKH.Text) || string.IsNullOrWhiteSpace(cboMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy thông tin", "Thông Báo");
                return;
            }
            db = new DATBAN_DTO();
            db.MADATBAN = dbBUS.LayMaBanTiepTheo();
            LayThongtin();
            if (dbBUS.ThemMoiDatBan(db))
            {
                MessageBox.Show("Thêm mới đặt bàn có mã " + db.MADATBAN + " thành công!", "Thêm Mới");
                LoaddsDatBan();
            }
            else
            {
                MessageBox.Show("Thêm đặt bàn không thành công!", "Thêm Mới");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDatBan.Text) || string.IsNullOrWhiteSpace(cboSoBan.Text) || string.IsNullOrWhiteSpace(cboMaKH.Text) || string.IsNullOrWhiteSpace(cboMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy thông tin", "Thông Báo");
                return;
            }
            if (dgvDB.SelectedRows.Count > 0)
            {
                LayThongtin();
                if (dbBUS.SuaDatBan(db))
                {
                    MessageBox.Show("Sửa thành công đặt bàn");
                    LoaddsDatBan();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDB.SelectedRows.Count > 0)
            {
                if (dbBUS.XoaDatBan(txtMaDatBan.Text))
                {
                    MessageBox.Show("Xóa thành công khách hàng", "Thông báo");
                    LoaddsDatBan();
                }
                else

                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
        }

        private void btnRS_Click_1(object sender, EventArgs e)
        {
            dgvDB.ClearSelection();
        }

        private void dgvDB_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvDB.SelectedRows.Count > 0)
            {
                db = dgvDB.SelectedRows[0].DataBoundItem as DATBAN_DTO;
            }
            else
            {
                db = null;
            }
            HienThiThongTin();
        }
    }
}
