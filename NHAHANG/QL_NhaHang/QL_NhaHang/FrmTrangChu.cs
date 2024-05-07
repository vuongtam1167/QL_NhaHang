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
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void picAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void lblManv_Click(object sender, EventArgs e)
        {

        }

        private void btnDNDX_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTGHT.Text = DateTime.Now.ToString();
        }

        private void picAnhDaiDien_Click_1(object sender, EventArgs e)
        {

        }

        private void grbtt_Enter(object sender, EventArgs e)
        {

        }

        private void lblManv_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTGHT.Text = lblTGHT.Text = DateTime.Now.ToString();
        }

        private void nhậpNguyênLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
