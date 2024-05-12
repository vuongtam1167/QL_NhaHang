using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class HOADON_BUS
    {
        HOADON_DAO hdDAO = new HOADON_DAO();
        public int LapHoaDon(HOADON_DTO hd)
        {
            return hdDAO.LuuHoaDon(hd);
        }
        public HOADON_DTO LayThongTinHoaDon(int mhd)
        {
            return hdDAO.LayThongTinHoaDon(mhd);
        }
        public List<HOADON_DTO> DanhSachHoaDon()
        {
            return hdDAO.LayDanhSachHoaDon();
        }

        public List<HOADON_DTO> DSHDTim(int mahd)
        {
            return hdDAO.LayDanhSachHDTim(mahd);
        }

        public List<HOADON_DTO> DSHDTimNL(DateTime mahdnl)
        {
            return hdDAO.LayDanhSachHDTimNL(mahdnl);
        }

        public bool TimHoaDon(string timma)
        {
            return hdDAO.TimHoaDon(timma);
        }

        public bool TimHoaDonNL(DateTime timNLHD)
        {
            return hdDAO.TimHoaDonNL(timNLHD);
        }

        public int SoLuongMonDaBan()
        {
            return hdDAO.SoLuongMonDaBan();
        }

        public double TongTienMonAnVoiVAT()
        {

            List<HOADON_DTO> danhSachHoaDon = hdDAO.LayDanhSachHoaDon();
            return hdDAO.TongTienMonAnVoiVAT(danhSachHoaDon);
        }

        public DateTime LayNgayHD()
        {
            List<HOADON_DTO> ngaylap = hdDAO.LayDanhSachHoaDon();
            return hdDAO.LayNgayHD(ngaylap);
        }
    }
}
