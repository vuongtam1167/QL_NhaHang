using QL_NhaHang_DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class TAIKHOAN_DAO
    {
        public TAIKHOAN_DTO KiemTraDangNhap(string strTK, string strMK)
        {
            TAIKHOAN_DTO tk = null;
            string strSelectTK = "Select * From TAIKHOAN where TENDANGNHAP= @TENDANGNHAP and MATKHAU=@MATKHAU and TRANGTHAI = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("TENDANGNHAP", strTK);
            par[1] = new SqlParameter("MATKHAU", strMK);
            SqlDataReader sdr = DataProvider.TruyVan(strSelectTK, par, conn);
            if (sdr.Read())
            {
                tk = new TAIKHOAN_DTO();
                tk.MANV = sdr["MANV"].ToString();
                tk.TENDANGNHAP = strTK;
                tk.MATKHAU = strMK;
                tk.LOAITK = sdr["LOAITK"].ToString();
                tk.TRANGTHAI = (int)sdr["TRANGTHAI"];
            }
            sdr.Close();
            conn.Close();
            return tk;
        }

        public List<TAIKHOAN_DTO> LayDanhSachTaiKhoan()
        {
            try
            {
                List<TAIKHOAN_DTO> lsTK = new List<TAIKHOAN_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "select * from TAIKHOAN";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    TAIKHOAN_DTO s = new TAIKHOAN_DTO();
                    s.MANV = sdr["MANV"].ToString();
                    s.TENDANGNHAP = sdr["TENDANGNHAP"].ToString();
                    s.MATKHAU = sdr["MATKHAU"].ToString();
                    s.LOAITK = sdr["LOAITK"].ToString();
                    s.TRANGTHAI = (int)sdr["TRANGTHAI"];
                    lsTK.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lsTK;
            }
            catch (Exception ex)
            {
                return new List<TAIKHOAN_DTO>();
            }
        }

        public string LayHinhAnh(string maNV)
        {
            string kq = null;
            string strSelectHA = $"select HINHANH from TAIKHOAN inner join NHANVIEN on TAIKHOAN.MANV = NHANVIEN.MANV where TAIKHOAN.MANV = '{maNV}'";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand com = new SqlCommand(strSelectHA, conn);
            kq = com.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }
    }
}
