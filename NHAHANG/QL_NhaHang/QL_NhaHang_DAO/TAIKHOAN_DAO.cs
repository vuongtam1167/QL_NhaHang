using QL_NhaHang_DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
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

        public bool SuaTK(TAIKHOAN_DTO tk)
        {
            try
            {
                string strupdate = "Update TAIKHOAN set MANV=@MANV,MATKHAU=@MATKHAU,LOAITK=@LOAITK,TRANGTHAI = @TRANGTHAI where TENDANGNHAP=@TENDANGNHAP";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("MANV", tk.MANV);
                param[1] = new SqlParameter("TENDANGNHAP", tk.TENDANGNHAP);
                param[2] = new SqlParameter("MATKHAU", tk.MATKHAU);
                param[3] = new SqlParameter("LOAITK", tk.LOAITK);
                param[4] = new SqlParameter("TRANGTHAI", tk.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strupdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemTaiKhoan(TAIKHOAN_DTO tk)
        {
            try
            {
                string strThem = "insert into TAIKHOAN(MANV,TENDANGNHAP,MATKHAU,LOAITK,TRANGTHAI) " +
                    " values (@MANV,@TENDANGNHAP,@MATKHAU,@LOAITK,@TRANGTHAI)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("MANV", tk.MANV);
                param[1] = new SqlParameter("TENDANGNHAP", tk.TENDANGNHAP);
                param[2] = new SqlParameter("MATKHAU", tk.MATKHAU);
                param[3] = new SqlParameter("LOAITK", tk.LOAITK);
                param[4] = new SqlParameter("TRANGTHAI", tk.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strThem, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XemcoTrungTDN(string tdn)
        {
            try
            {
                string seleten = $"select COUNT(TENDANGNHAP) from TAIKHOAN where TENDANGNHAP = '{tdn}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand(seleten,conn);
                bool kq;
                if ((int)com.ExecuteScalar() != 0)
                    kq = true;
                else
                    kq = false;
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaTaiKhoan(string tendn)
        {
            try
            {
                string strDel = $"delete from TAIKHOAN where TENDANGNHAP = '{tendn}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strDel, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
