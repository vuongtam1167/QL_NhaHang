using QL_NhaHang_BUS;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaHang
{
    public partial class frmTrangChu : Form
    {
        public TAIKHOAN_DTO tkdn = null; 
        TAIKHOAN_BUS tkbus = new TAIKHOAN_BUS();
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTGHT.Text = DateTime.Now.ToString();
            KiemTraDangNhap();
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        public void KiemTraDangNhap()
        {
            if (tkdn == null)
            {
                menu.Enabled = false;
                picAnhDaiDien.Image = null;
                lblManv.Text = "";
                btnDNDX.Text = "Đăng Nhập";
                btnDNDX.Image = Properties.Resources.DangNhap;
            }
            else
            {
                menu.Enabled = true;
                string hinhanh = tkbus.LayHinhAnh(tkdn.MANV);
                picAnhDaiDien.Image = Utils.HinhAnhTuDuongDan(hinhanh);
                lblManv.Text = tkdn.MANV;
                btnDNDX.Text = "Đăng Xuất";
                btnDNDX.Image = Properties.Resources.DangXuat;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTGHT.Text = lblTGHT.Text = DateTime.Now.ToString();
        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmQL_Mon f = new frmQL_Mon();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmQLNguyenLieu f = new frmQLNguyenLieu();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmHoaDon f = new frmHoaDon();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void oDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmOrder f = new frmOrder();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmNhaCungCap f = new frmNhaCungCap();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkdn.LOAITK.Equals("QL"))
            {
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản bạn không đủ quyền chi cập", "Thông Báo");
            }
        }

        private void btnDNDX_Click_1(object sender, EventArgs e)
        {
            if (tkdn != null)
            {
                tkdn = null;
                KiemTraDangNhap();
            }
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
            
        }

        private void quảnLýĐặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmQLDatBan f = new frmQLDatBan();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmThongKe f = new frmThongKe();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void picAnhDaiDien_Click(object sender, EventArgs e)
        {

        }
    }
}
