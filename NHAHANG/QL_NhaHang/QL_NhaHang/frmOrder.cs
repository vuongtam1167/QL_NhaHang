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
    public partial class frmOrder : Form
    {
        List<MON_DTO> lsmon;
        List<CT_HOADON_DTO> lscthd = new List<CT_HOADON_DTO>();
        LOAIMON_BUS loaimon = new LOAIMON_BUS();
        DATBAN_BUS dbbus = new DATBAN_BUS();
        KHACHHANG_BUS khbus = new KHACHHANG_BUS();
        MON_BUS monbus = new MON_BUS();
        HOADON_BUS hdbus = null;
        CT_HOADON_BUS cthdbus = new CT_HOADON_BUS();
        MON_DTO mon;
        HOADON_DTO hd;



        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadDSBan();
            LoadLoaiMon();
            LoadDSMon();
            dgvCT.AutoGenerateColumns = false;

        }


        private void LoadDSBan()
        {
            List<DATBAN_DTO> lsdb = dbbus.DanhSachDatBan();
            cboMaDB.DataSource = lsdb;
            cboMaDB.DisplayMember = "MADATBAN";
            cboMaDB.ValueMember = "MADATBAN";
            
        }

        private void LoadLoaiMon()
        {
            List<LOAIMON_DTO> lsloai = loaimon.DSLoaiMon();
            cboMaLoai.DataSource = lsloai;
            cboMaLoai.DisplayMember = "TENLOAI";
            cboMaLoai.ValueMember = "MALOAI";

        }
        private void LoadDSMon()
        {
            lsmon = (new MON_BUS()).DSMon();
            imlMon.Images.Clear();
            foreach (MON_DTO mon in lsmon)
            {
                string ma = mon.MAMON.ToString();
                Image img = Utils.HinhAnhTuDuongDan(mon.HINHANH);
                if (img != null)
                {
                    imlMon.Images.Add(ma, img);
                }
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = ma;
                lvi.Text = mon.TENMON;
                lvwMon.Items.Add(lvi);
            }
            colTenMon.DataSource = lsmon;
            colTenMon.DisplayMember = "TENMON";
            colTenMon.ValueMember = "MAMON";
        }

        private void lvwMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMon.SelectedItems.Count > 0)
            {
                ListViewItem lviChon = lvwMon.SelectedItems[0];
                mon = lsmon.Find(o => o.MAMON.ToString() == lviChon.ImageKey);
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
                txtTenMon.Text = mon.TENMON;
                nudGiaTien.Value = mon.GIA;
                cboMaLoai.SelectedValue = mon.MAMON;
                rtbMoTa.Text = mon.MOTA;
                picAnhMon.Image = Utils.HinhAnhTuDuongDan(mon.HINHANH);
            }
            else
            {
                txtTenMon.Clear();
                nudGiaTien.Value = 0;
                cboMaLoai.SelectedIndex = 0;
                rtbMoTa.Clear();
                picAnhMon.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (hd != null)
                return;
            if (mon != null)
            {
                CT_HOADON_DTO ct = lscthd.Find(o => o.MAMON == mon.MAMON);
                if (ct == null)
                {
                    ct = new CT_HOADON_DTO();
                    ct.MAMON = mon.MAMON;
                    ct.GIA = mon.GIA;
                    ct.SOLUONG = (int)nudSoluong.Value;
                    lscthd.Add(ct);
                }
                else
                {
                    ct.SOLUONG += (int)nudSoluong.Value;
                }
                dgvCT.DataSource = null;
                dgvCT.DataSource = lscthd;  
                txtTongTien.Text = lscthd.Sum(o => o.ThanhTien).ToString();

            }
        }

        private void lvwMon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (hd != null) return;
            if (lvwMon.SelectedItems.Count > 0)
            {
                mon = lsmon.Find(o => o.MAMON == int.Parse(lvwMon.SelectedItems[0].ImageKey));
                CT_HOADON_DTO ct = lscthd.Find(o => o.MAMON == mon.MAMON);
                if (ct == null)
                {
                    ct = new CT_HOADON_DTO();
                    ct.MAMON = mon.MAMON;
                    ct.GIA = mon.GIA;
                    ct.SOLUONG = 1;
                    lscthd.Add(ct);
                }
                else
                {
                    ct.SOLUONG += 1;
                }
                dgvCT.DataSource = null;
                dgvCT.DataSource = lscthd;
                txtTongTien.Text = lscthd.Sum(o => o.ThanhTien).ToString();
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (hd != null)
                return;
            if (dgvCT.SelectedRows.Count > 0)
            {
                CT_HOADON_DTO ct = dgvCT.SelectedRows[0].DataBoundItem as CT_HOADON_DTO;
                lscthd.Remove(ct);
                dgvCT.DataSource = null;
                dgvCT.DataSource = lscthd;
                txtTongTien.Text = lscthd.Sum(o => o.ThanhTien).ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hd = null;
            lscthd.Clear();
            dgvCT.DataSource = null;
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kiểm tra lại các món!!!\n YES để lập hoá đơn", "Lập Hoá Đơn", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (lscthd.Count > 0)
                {
                    cthdbus.TruNguyenLieu(lscthd);
                    hdbus = new HOADON_BUS();
                    hd = new HOADON_DTO(); // ma hoa don tang tu dong nen khong tao ma hoa don moi
                    //nếu muốn giám sát mã hoá đơn thì nên làm cách tương tự như sản phẩm sữa
                    hd.MANV = ((frmTrangChu)this.MdiParent).tkdn.MANV;
                    hd.TONGTIEN = lscthd.Sum(o => o.ThanhTien);
                    hd.MADATBAN = int.Parse(cboMaDB.SelectedValue.ToString());
                    hd.MAKH = dbbus.LayMaKH(hd.MADATBAN);
                    hd.VAT = (double)hd.TONGTIEN * 0.1;
                    int mhd = hdbus.LapHoaDon(hd);
                    foreach (CT_HOADON_DTO ct in lscthd)
                    {
                        ct.MAHD = mhd;
                        cthdbus.LuuChiTietHD(ct);
                    }
                    hd.MAHD = mhd;
                    MessageBox.Show("Hoá đơn đã được lập thành công với mã '" + mhd + "'", "Lập Hoá Đơn");
                }
                else
                {
                    MessageBox.Show("Phải có sản phẩm mới lập hoá đơn", "Lập Hoá Đơn");
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (hdbus != null)
            {
                frmXemBaoCao f = new frmXemBaoCao();
                int soban = dbbus.LaySoBan(hd.MAHD);
                int vat = (int)hd.VAT;
                f.InHoaDonBan(hd.MAHD,soban,vat);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hoá Đơn Chưa Được Lập", "Lập Hoá Đơn");
            }
        }
    }
}
