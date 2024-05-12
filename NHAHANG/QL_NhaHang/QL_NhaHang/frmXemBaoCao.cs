using Microsoft.Reporting.WinForms;
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
    public partial class frmXemBaoCao : Form
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        public void InHoaDonBan(int mhd, int soban, int vat)
        {
            HOADON_DTO hd = (new HOADON_BUS()).LayThongTinHoaDon(mhd);
            List<CT_HOADON_DTO> lsCTs = (new CT_HOADON_BUS()).LayDanhSachChiTiet(mhd);
            rpvXemBC.LocalReport.ReportEmbeddedResource = "QL_NhaHang.rptHOADON.rdlc";
            rpvXemBC.LocalReport.SetParameters(new ReportParameter("paVAT", vat.ToString("#,##0")));
            rpvXemBC.LocalReport.SetParameters(new ReportParameter("paNGAYLAP", hd.NGAYLAP.ToString("dd/MM/yyyy")));
            rpvXemBC.LocalReport.SetParameters(new ReportParameter("paSOBAN", soban.ToString()));
            rpvXemBC.LocalReport.DataSources.Add(new ReportDataSource("dsCT_HOADON", lsCTs));
            rpvXemBC.RefreshReport();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rpvXemBC.RefreshReport();
        }
    }
}
