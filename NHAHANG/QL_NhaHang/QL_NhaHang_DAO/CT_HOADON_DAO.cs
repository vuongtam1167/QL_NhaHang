using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class CT_HOADON_DAO
    {
        public bool LuuChiTietHDBan(CT_HOADON_DTO ct)
        {
            try
            {
                string insert = "insert into CT_HOADON(MAHD,MAMON,GIA,SOLUONG)  values (@MAHD,@MAMON,@GIA,@SOLUONG)";
                SqlParameter[] sp = new SqlParameter[4];
                sp[0] = new SqlParameter("MAHD", ct.MAHD);
                sp[1] = new SqlParameter("MAMON", ct.MAMON);
                sp[2] = new SqlParameter("GIA", ct.GIA);
                sp[3] = new SqlParameter("SOLUONG", ct.SOLUONG);
                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(insert, sp, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CT_HOADON_DTO> LayDanhSachSanPhamTheoHoaDon(int mahd)
        {
            List<CT_HOADON_DTO> lsCTs = new List<CT_HOADON_DTO>();
            string sql = "Select CT.*, M.TENMON From CT_HOADON CT join MON M on CT.MAMON=M.MAMON where MAHD=" + mahd;
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(sql, conn);
            while (sdr.Read())
            {
                CT_HOADON_DTO ct = new CT_HOADON_DTO();
                ct.MAHD = mahd;
                ct.MAMON = (int)sdr["MAMON"];
                ct.TENMON = sdr["TENMON"].ToString();
                ct.SOLUONG = (int)sdr["SOLUONG"];
                ct.GIA = int.Parse(sdr["GIA"].ToString());
                lsCTs.Add(ct);
            }
            sdr.Close();
            conn.Close();
            return lsCTs;
        }
    }
}
