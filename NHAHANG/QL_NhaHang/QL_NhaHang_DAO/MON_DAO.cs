using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class MON_DAO
    {
        public List<MON_DTO> LayDanhSachMon()
        {
            try
            {
                List<MON_DTO> lsmon = new List<MON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "Select * from MON where TRANGTHAI = 1";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    MON_DTO mon = new MON_DTO();
                    mon.MAMON = (int)sdr["MAMON"];
                    mon.TENMON = sdr["TENMON"].ToString();
                    mon.GIA = int.Parse(sdr["GIA"].ToString());
                    mon.MALOAI = (int)sdr["MALOAI"];
                    mon.HINHANH = sdr["HINHANH"].ToString();
                    mon.MOTA = sdr["MOTA"].ToString();
                    lsmon.Add(mon);

                }
                sdr.Close();
                conn.Close();
                return lsmon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LayMaMonKeTiep()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MAMON) from MON", conn);
                int kq = (int)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool SuaMon(MON_DTO mon)
        {
            try
            {
                string strUpdate = " Update MON SET TENMON = @TENMON,MALOAI = @MALOAI,HINHANH = @HINHANH,GIA = @GIA,MOTA = @MOTA where MAMON = @MAMON";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("TENMON", mon.TENMON);
                param[1] = new SqlParameter("MALOAI", mon.MALOAI);
                param[2] = new SqlParameter("HINHANH", mon.HINHANH);
                param[3] = new SqlParameter("GIA", mon.GIA);
                param[4] = new SqlParameter("MOTA", mon.MOTA);
                param[5] = new SqlParameter("MAMON", mon.MAMON);
                bool kq = DataProvider.ThucThi(strUpdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMonMoi(MON_DTO mon)
        {
            try { 
            string strInsert = " insert into MON(MAMON,TENMON,MALOAI,HINHANH,GIA,MOTA,TRANGTHAI) " +
                                    "values(@MAMON, @TENMON, @MALOAI, @HINHANH, @GIA, @MOTA, 1)";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("MAMON", mon.MAMON);
            param[1] = new SqlParameter("TENMON", mon.TENMON);
            param[2] = new SqlParameter("MALOAI", mon.MALOAI);
            param[3] = new SqlParameter("HINHANH", mon.HINHANH);
            param[4] = new SqlParameter("GIA", mon.GIA);
            param[5] = new SqlParameter("MOTA", mon.MOTA);
            bool kq = DataProvider.ThucThi(strInsert, param, conn);
            conn.Close();
            return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaMon(string mon)
        {
            try
            {
                string strUpdate = $" Update MON SET TRANGTHAI = 0 where MAMON = {mon}";
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strUpdate, conn);
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
