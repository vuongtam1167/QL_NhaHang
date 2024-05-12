using QL_NhaHang_BUS;
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
    public partial class frmThongKe : Form
    {
        KHACHHANG_BUS khBUS = new KHACHHANG_BUS();
        HOADON_BUS hdBUS = new HOADON_BUS();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            int kq = khBUS.TongKhachHang();
            lblTongKH.Text = kq.ToString();

            int tong = hdBUS.SoLuongMonDaBan();
            lblMon.Text = tong.ToString();

            double tongTienMonAn = hdBUS.TongTienMonAnVoiVAT();

            lblDoanhThu.Text = tongTienMonAn.ToString("#,##0.00");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
