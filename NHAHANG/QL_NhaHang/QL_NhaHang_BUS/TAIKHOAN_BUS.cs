using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class TAIKHOAN_BUS
    {
        TAIKHOAN_DAO tkDAO = new TAIKHOAN_DAO();
        public TAIKHOAN_DTO DangNhap(string strTK, string strMK)
        {
            return tkDAO.KiemTraDangNhap(strTK, strMK);
        }

        public List<TAIKHOAN_DTO> DanhSachTaiKhoan()
        {
            return tkDAO.LayDanhSachTaiKhoan();
        }

        public string LayHinhAnh(string MaNV)
        {
            return tkDAO.LayHinhAnh(MaNV);
        }
    }
}
