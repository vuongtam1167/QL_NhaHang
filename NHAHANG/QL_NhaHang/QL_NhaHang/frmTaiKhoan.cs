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
    public partial class frmTaiKhoan : Form
    {
        NHANVIEN_BUS nvBUS = new NHANVIEN_BUS();
        TAIKHOAN_BUS tkBUS = new TAIKHOAN_BUS();
        List<TAIKHOAN_DTO> lsTK;
        TAIKHOAN_DTO tk;

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadMaNV();
            dgv.AutoGenerateColumns = false;
            LoadDanhSachTaiKhoan();
        }

        private void LoadMaNV()
        {
            List<NHANVIEN_DTO> lsnv = nvBUS.loadNhanVien();
            cobManv.DataSource = lsnv;
            cobManv.DisplayMember = "HOTEN";
            cobManv.ValueMember = "MANV";

            colMaNV.DataSource = lsnv;
            colMaNV.DisplayMember = "HOTEN";
            colMaNV.ValueMember = "MANV";
        }

        private void LoadDanhSachTaiKhoan()
        {
            lsTK = tkBUS.DanhSachTaiKhoan();
            dgv.DataSource = lsTK;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
