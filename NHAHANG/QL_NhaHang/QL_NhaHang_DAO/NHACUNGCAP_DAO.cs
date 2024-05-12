using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class NHACUNGCAP_DAO
    {
        public int LayMaNhaCungCapLonNhat()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MANHACUNGCAP) from NHACUNGCAP", conn);
                int kq = (int)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<NHACUNGCAP_DTO> loadDSNhaCungCap()
        {
            try
            {
                List<NHACUNGCAP_DTO> lsNCC = new List<NHACUNGCAP_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strTruyVan = "Select * From NHACUNGCAP";
                SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
                while (sdr.Read())
                {
                    NHACUNGCAP_DTO NCC = new NHACUNGCAP_DTO();
                    NCC.MANHACUNGCAP = (int)sdr["MANHACUNGCAP"];
                    NCC.TENNHACUNGCAP = sdr["TENNHACUNGCAP"].ToString();
                    NCC.DIACHI = sdr["DIACHI"].ToString();
                    NCC.GHICHU = sdr["GHICHU"].ToString();
                    NCC.TRANGTHAI = (int)sdr["TRANGTHAI"];
                    lsNCC.Add(NCC);
                }
                sdr.Close();
                conn.Close();
                return lsNCC;
            }
            catch (Exception ex)
            {
                return new List<NHACUNGCAP_DTO>();
            }
        }

        public bool suaThongTin(NHACUNGCAP_DTO ncc)
        {
            try
            {
                string strUpdate = "Update NHACUNGCAP set TENNHACUNGCAP=@TENNHACUNGCAP,DIACHI=@DIACHI,GHICHU=@GHICHU,TRANGTHAI=@TRANGTHAI " +
                    " WHERE MANHACUNGCAP=@MANHACUNGCAP";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("MANHACUNGCAP", ncc.MANHACUNGCAP);
                param[1] = new SqlParameter("TENNHACUNGCAP", ncc.TENNHACUNGCAP);
                param[2] = new SqlParameter("DIACHI", ncc.DIACHI);
                param[3] = new SqlParameter("GHICHU", ncc.GHICHU);
                param[4] = new SqlParameter("TRANGTHAI", ncc.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strUpdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool themMoiNhaCungCap(NHACUNGCAP_DTO ncc)
        {
            try
            {
                string strThem = "Insert Into NHACUNGCAP(MANHACUNGCAP,TENNHACUNGCAP,DIACHI,GHICHU,TRANGTHAI) " +
                    " values (@MANHACUNGCAP,@TENNHACUNGCAP,@DIACHI,@GHICHU,@TRANGTHAI)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("MANHACUNGCAP", ncc.MANHACUNGCAP);
                param[1] = new SqlParameter("TENNHACUNGCAP", ncc.TENNHACUNGCAP);
                param[2] = new SqlParameter("DIACHI", ncc.DIACHI);
                param[3] = new SqlParameter("GHICHU", ncc.GHICHU);
                param[4] = new SqlParameter("TRANGTHAI", ncc.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strThem, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool xoaTK(string maNCC)
        {
            try
            {
                string strXoa = $"Delete From NHACUNGCAP Where MANHACUNGCAP='{maNCC}'";
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strXoa, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
