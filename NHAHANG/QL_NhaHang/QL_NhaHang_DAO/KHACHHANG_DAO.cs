using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class KHACHHANG_DAO
    {
        public List<KHACHHANG_DTO> LayDanhSachKhachHang()
        {
            try
            {
                List<KHACHHANG_DTO> lskhach = new List<KHACHHANG_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "Select * from KHACHHANG";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    KHACHHANG_DTO s = new KHACHHANG_DTO();
                    s.MAKH = sdr["MAKH"].ToString();
                    s.HOTEN = sdr["HOTEN"].ToString();
                    s.CCCD = sdr["CCCD"].ToString();
                    s.SDT = sdr["SDT"].ToString();
                    lskhach.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lskhach;
            }
            catch (Exception ex)
            {
                return new List<KHACHHANG_DTO>();
            }
        }
        public string LayMaKhachHangLonNhat()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MAKH) from KHACHHANG", conn);
                string kq = (string)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool ThemMoiKhachHang(KHACHHANG_DTO s)
        {
            try
            {
                string strInsert = "Insert into KHACHHANG(MAKH,HOTEN,CCCD,SDT) Values(@MAKH,@HOTEN,@CCCD,@SDT)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("MAKH", s.MAKH);
                param[1] = new SqlParameter("HOTEN", s.HOTEN);
                param[2] = new SqlParameter("CCCD", s.CCCD);
                param[3] = new SqlParameter("SDT", s.SDT);
                bool kq = DataProvider.ThucThi(strInsert, param, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool SuaKhachHang(KHACHHANG_DTO s)
        {
            try
            {
                string strUp = " Update KHACHHANG set HOTEN=@HOTEN,CCCD=@CCCD,SDT=@SDT where MAKH=@MAKH";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("MAKH", s.MAKH);
                param[1] = new SqlParameter("HOTEN", s.HOTEN);
                param[2] = new SqlParameter("CCCD", s.CCCD);
                param[3] = new SqlParameter("SDT", s.SDT);
                bool kq = DataProvider.ThucThi(strUp, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }



        public bool XoaKhachHang(string ma)
        {

            try
            {
                string strDelete = $"Delete from KHACHHANG where MAKH ='{ma}'";
                SqlConnection conn = DataProvider.TaoKetNoi();

                bool kq = DataProvider.ThucThi(strDelete, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool TimKhachHang(string timma)
        {
            try
            {
                string kq = null;
                string strSearch = $"select CCCD from KHACHHANG where MAKH = '{timma}'";
                SqlConnection conn = DataProvider.TaoKetNoi();

                SqlCommand com = new SqlCommand(strSearch, conn);
                if (com.ExecuteScalar() != null)
                {
                    kq = com.ExecuteScalar().ToString();
                }
                conn.Close();
                if (kq != null)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<KHACHHANG_DTO> LayDanhSachKHTim(string makh)
        {
            try
            {
                List<KHACHHANG_DTO> lskhach = new List<KHACHHANG_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = $"Select * from KHACHHANG where MAKH = '{makh}'";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    KHACHHANG_DTO s = new KHACHHANG_DTO();
                    s.MAKH = sdr["MAKH"].ToString();
                    s.HOTEN = sdr["HOTEN"].ToString();
                    s.CCCD = sdr["CCCD"].ToString();
                    s.SDT = sdr["SDT"].ToString();
                    lskhach.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lskhach;
            }
            catch (Exception ex)
            {
                return new List<KHACHHANG_DTO>();
            }
        }

        public int TongKhachHang()
        {
            try
            {
                int tongKhachHang = 0;
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "SELECT COUNT(*) FROM KHACHHANG";
                SqlCommand cmd = new SqlCommand(strSelect, conn);
                tongKhachHang = (int)cmd.ExecuteScalar();
                conn.Close();
                return tongKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
