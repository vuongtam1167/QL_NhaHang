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
    public class KHACHHANG_BUS
    {
        KHACHHANG_DAO khachDAO = new KHACHHANG_DAO();
        public List<KHACHHANG_DTO> DanhSachKhachHang()
        {
            return khachDAO.LayDanhSachKhachHang();
        }
        public string LayMaKhachTiepTheo()
        {
            string max = khachDAO.LayMaKhachHangLonNhat();
            if (max == null)
            {
                return "KH001";
            }
            else
            {
                int somax = int.Parse(max.Substring(2));
                return string.Format("KH{0:000}", somax + 1);
            }
        }
        public bool ThemMoikhachHang(KHACHHANG_DTO khach)
        {
            return khachDAO.ThemMoiKhachHang(khach);
        }
        public bool SuaKhachHang(KHACHHANG_DTO khach)
        {
            return khachDAO.SuaKhachHang(khach);
        }

        public bool XoaKhachHang(string ma)
        {
            return khachDAO.XoaKhachHang(ma);
        }

        public bool TimKhachHang(string timma)
        {
            return khachDAO.TimKhachHang(timma);
        }

        public List<KHACHHANG_DTO> DSKHTim(string makh)
        {
            return khachDAO.LayDanhSachKHTim(makh);
        }

        public int TongKhachHang()
        {
            return khachDAO.TongKhachHang();
        }
    }
}
