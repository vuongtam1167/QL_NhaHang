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
    public partial class frmQL_Mon : Form
    {
        LOAIMON_BUS loaimon = new LOAIMON_BUS();
        NGUYENLIEU_BUS nl = new NGUYENLIEU_BUS();
        MON_BUS monbus = new MON_BUS();
        CT_MON_BUS ctmonbus = new CT_MON_BUS();
        List<MON_DTO> lsmon;
        List<CT_MON_DTO> lsctmon;
        MON_DTO mon;
        CT_MON_DTO ctmon;
        string strPathHinh = "Dulieu/Mon/";
        public frmQL_Mon()
        {
            InitializeComponent();
        }

        private void frmQL_Mon_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
            LoadNL();
            dgvCTMon.AutoGenerateColumns = false;
            dgvMon.AutoGenerateColumns = false;
            LoadDSMon();
            LoadDSCT();
        }

        private void LoadDSCT()
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text)){
                return;
            }
            int mamon = int.Parse(txtMaMon.Text);
            lsctmon = ctmonbus.DSCTMon(mamon);
            dgvCTMon.DataSource = lsctmon;

        }

        private void LoadDSMon()
        {
            lsmon = monbus.DSMon();
            dgvMon.DataSource = lsmon;
        }

        private void LoadNL()
        {
            List<NGUYENLIEU_DTO> lsnl = nl.DanhSachNL();
            cboMaNL.DataSource = lsnl;
            cboMaNL.DisplayMember = "TENNGUYENLIEU";
            cboMaNL.ValueMember = "MANGUYENLIEU";

            colMaNL.DataSource = lsnl;
            colMaNL.DisplayMember = "TENNGUYENLIEU";
            colMaNL.ValueMember = "MANGUYENLIEU";
        }

        private void LoadLoaiMon()
        {
            List<LOAIMON_DTO> lsloai = loaimon.DSLoaiMon();
            cboMaLoai.DataSource = lsloai;
            cboMaLoai.DisplayMember = "TENLOAI";
            cboMaLoai.ValueMember = "MALOAI";

            colMaLoai.DataSource = lsloai;
            colMaLoai.DisplayMember = "TENLOAI";
            colMaLoai.ValueMember = "MALOAI";
        }

        private void dgvMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMon.SelectedRows.Count > 0)
            {
                mon = dgvMon.CurrentRow.DataBoundItem as MON_DTO;

            }
            else
            {
                mon = null;
            }
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            if (mon != null)
            {
                txtMaMon.Text = mon.MAMON.ToString();
                txtTenMon.Text = mon.TENMON;
                nudGiaTien.Value = mon.GIA;
                cboMaLoai.SelectedValue = mon.MALOAI;
                rtbMoTa.Text = mon.MOTA;
                picAnhMon.Image = Utils.HinhAnhTuDuongDan(mon.HINHANH);
            }
            else
            {
                txtMaMon.Clear();
                txtTenMon.Clear();
                nudGiaTien.Value = 0;
                cboMaLoai.SelectedIndex = 1;
                rtbMoTa.Clear();
                picAnhMon.Image = Properties.Resources.df;
            }    

        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            LoadDSCT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }
            mon = new MON_DTO();
            mon.MAMON = monbus.LayMaMonTT();
            mon.HINHANH = strPathHinh + mon.MAMON + ".png";
            LayThongTinMon();
            if (monbus.ThemMoiMon(mon))
            {
                picAnhMon.Image.Save(mon.HINHANH);
                MessageBox.Show($"Thêm mới món {mon.TENMON} thành công!", "Thêm Mới");
                LoadDSMon();
            }
            else
            {
                MessageBox.Show($"Thêm món không thành công!", "Thêm Mới");
            }
        }

        private void LayThongTinMon()
        {
            mon.TENMON = txtTenMon.Text;
            mon.GIA = (int)nudGiaTien.Value;
            mon.MALOAI = (int)cboMaLoai.SelectedValue;
            mon.MOTA = rtbMoTa.Text;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMon.ClearSelection();
        }

        private void picAnhMon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình Ảnh|*.jpg;*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                picAnhMon.Image = Utils.HinhAnhTuDuongDan(ofd.FileName);
            }
            else
            {
                picAnhMon.Image = Properties.Resources.df;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }
            mon = new MON_DTO();
            mon.MAMON = int.Parse(txtMaMon.Text);
            mon.HINHANH = strPathHinh + mon.MAMON + ".png";
            LayThongTinMon();
            if (monbus.SuaMon(mon))
            {
                picAnhMon.Image.Save(mon.HINHANH);
                MessageBox.Show($"Cập nhật món {mon.TENMON} thành công!", "Cập nhật");
                LoadDSMon();
            }
            else
            {
                MessageBox.Show($"Cập nhật món không thành công!", "Cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            mon = new MON_DTO();
            if (monbus.XoaMon(txtMaMon.Text))
            {
                MessageBox.Show($"Xóa món {mon.TENMON} thành công!", "Xóa");
                LoadDSMon();
            }
            else
            {
                MessageBox.Show($"Xóa món không thành công!", "Xóa");
            }
        }

        private void btnTangNL_Click(object sender, EventArgs e)
        {
            if (mon == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trước khi thêm nguyên liệu!", "Thông báo");
                return;
            }

            if (cboMaNL.SelectedIndex == -1 || nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu và nhập số lượng hợp lệ!", "Thông báo");
                return;
            }

            int maMon = mon.MAMON;
            int maNguyenLieu = (int)cboMaNL.SelectedValue;
            int soLuongMoi = (int)nudSoLuong.Value;

            CT_MON_DTO ctMonTonTai = lsctmon.Find(ct => ct.MANGUYENLIEU == maNguyenLieu && ct.MAMON == maMon);

            if (ctMonTonTai == null)
            {
                ctmon = new CT_MON_DTO();
                ctmon.MAMON = maMon;
                ctmon.MANGUYENLIEU = maNguyenLieu;
                ctmon.SOLUONG = soLuongMoi;

                if (ctmonbus.ThemMoiCTMon(ctmon))
                {
                    lsctmon.Add(ctmon);
                    MessageBox.Show($"Đã thêm {soLuongMoi} {cboMaNL.Text} vào món {mon.TENMON}!", "Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thể thêm nguyên liệu vào món ăn!", "Lỗi");
                }
            }
            else
            {
                ctMonTonTai.SOLUONG += soLuongMoi;

                if (ctmonbus.SuaCTMon(ctMonTonTai))
                {
                    MessageBox.Show($"Đã cập nhật số lượng {cboMaNL.Text} thành {ctMonTonTai.SOLUONG} cho món {mon.TENMON}!", "Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật số lượng nguyên liệu!", "Lỗi");
                }
            }
            LoadDSCT();

        }

        private void btnGiamNL_Click(object sender, EventArgs e)
        {
            if (mon == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trước khi giảm nguyên liệu!", "Thông báo");
                return;
            }

            if (cboMaNL.SelectedIndex == -1 || nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu và nhập số lượng hợp lệ!", "Thông báo");
                return;
            }

            int maMon = mon.MAMON;
            int maNguyenLieu = (int)cboMaNL.SelectedValue;
            int soLuongGiam = (int)nudSoLuong.Value;

            CT_MON_DTO ctMonTonTai = lsctmon.Find(ct => ct.MANGUYENLIEU == maNguyenLieu && ct.MAMON == maMon);

            if (ctMonTonTai == null)
            {
                MessageBox.Show("Nguyên liệu này không tồn tại trong món ăn!", "Thông báo");
                return;
            }

            if (soLuongGiam >= ctMonTonTai.SOLUONG)
            {
                if (ctmonbus.XoaCTMon(ctMonTonTai))
                {
                    lsctmon.Remove(ctMonTonTai);
                    MessageBox.Show($"Đã xóa {ctMonTonTai.SOLUONG} {cboMaNL.Text} khỏi món {mon.TENMON}!", "Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không thể xóa nguyên liệu khỏi món ăn!", "Lỗi");
                }
            }
            else
            {
                ctMonTonTai.SOLUONG -= soLuongGiam;

                if (ctmonbus.SuaCTMonGiam(ctMonTonTai))
                {
                    MessageBox.Show($"Đã cập nhật số lượng {cboMaNL.Text} thành {ctMonTonTai.SOLUONG} cho món {mon.TENMON}!", "Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật số lượng nguyên liệu!", "Lỗi");
                }
            }

            LoadDSCT();
        }

        private void dgvCTMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTMon.SelectedRows.Count > 0)
            {
                ctmon = dgvCTMon.CurrentRow.DataBoundItem as CT_MON_DTO;

            }
            else
            {
                ctmon = null;
            }
            HienThiThongTinCT();
        }

        private void HienThiThongTinCT()
        {
            if (ctmon != null)
            {
                cboMaNL.SelectedValue = ctmon.MANGUYENLIEU;
                nudSoLuong.Value = ctmon.SOLUONG;
            }
            else
            {
                cboMaNL.SelectedIndex = 0;
                nudSoLuong.Value = 0;
            }
        }
    }
}
