using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class CT_HOADON_BUS
    {
        CT_HOADON_DAO ctDAO = new CT_HOADON_DAO();
        public bool LuuChiTietHD(CT_HOADON_DTO ct)
        {
            return ctDAO.LuuChiTietHDBan(ct);
        }
        public List<CT_HOADON_DTO> LayDanhSachChiTiet(int mhd)
        {
            return ctDAO.LayDanhSachSanPhamTheoHoaDon(mhd);
        }

        public void TruNguyenLieu(List<CT_HOADON_DTO> lscthd)
        {
            ctDAO.TruNguyenLieu(lscthd);
        }
    }
}
