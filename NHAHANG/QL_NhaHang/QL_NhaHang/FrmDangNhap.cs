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
    public partial class frmDangNhap : Form
    {
        TAIKHOAN_BUS tkbus = new TAIKHOAN_BUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTk.Text = "vuongtm";
            txtMk.Text = "123456";
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTk.Text) || string.IsNullOrEmpty(txtMk.Text))
            {
                    MessageBox.Show("Vui lòng nhập các thông tin để đăng nhập!", "Đăng Nhập");
                    return;
            }
                string mahoaMK = Utils.MaHoaMD5(txtMk.Text);
                TAIKHOAN_DTO tk = tkbus.DangNhap(txtTk.Text, mahoaMK);
                if (tk != null)
                {
                    frmTrangChu f = (frmTrangChu)this.MdiParent;
                    f.tkdn = tk;
                    f.KiemTraDangNhap();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!", "Đăng Nhập");
                }
        }
    }
}
