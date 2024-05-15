using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class CT_MON_DAO
    {
        public List<CT_MON_DTO> LayCT(int mamon)
        {
            try
            {
                List<CT_MON_DTO> lsct = new List<CT_MON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = $"Select * from CT_MON where MAMON = {mamon}";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    CT_MON_DTO ct = new CT_MON_DTO();
                    ct.MAMON = (int)sdr["MAMON"];
                    ct.MANGUYENLIEU = (int)sdr["MANGUYENLIEU"];
                    ct.SOLUONG = (int)sdr["SOLUONG"];

                    lsct.Add(ct);

                }
                sdr.Close();
                conn.Close();
                return lsct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SuaMon(CT_MON_DTO mon)
        {
            try
            {
                string strUpdate = " Update CT_MON set SOLUONG = @SOLUONG where MAMON = @MAMON and MANGUYENLIEU = @MANGUYENLIEU ";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("MAMON", mon.MAMON);
                param[1] = new SqlParameter("MANGUYENLIEU", mon.MANGUYENLIEU);
                param[2] = new SqlParameter("SOLUONG", mon.SOLUONG);
                bool kq = DataProvider.ThucThi(strUpdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SuaMonGiam(CT_MON_DTO mon)
        {
            try
            {
                string strUpdate = " Update CT_MON set SOLUONG = @SOLUONG where MAMON = @MAMON AND MANGUYENLIEU = @MANGUYENLIEU";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("MAMON", mon.MAMON);
                param[1] = new SqlParameter("MANGUYENLIEU", mon.MANGUYENLIEU);
                param[2] = new SqlParameter("SOLUONG", mon.SOLUONG);
                bool kq = DataProvider.ThucThi(strUpdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemCT(CT_MON_DTO mon)
        {
            try
            {
                string strInsert = " insert into CT_MON(MAMON,MANGUYENLIEU,SOLUONG) " +
                                        "values(@MAMON, @MANGUYENLIEU, @SOLUONG)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("MAMON", mon.MAMON);
                param[1] = new SqlParameter("MANGUYENLIEU", mon.MANGUYENLIEU);
                param[2] = new SqlParameter("SOLUONG", mon.SOLUONG);
                bool kq = DataProvider.ThucThi(strInsert, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaCTMon(CT_MON_DTO ctmon)
        {
            try
            {
                string strDel = $"delete from CT_MON where MANGUYENLIEU ={ctmon.MANGUYENLIEU}";
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
