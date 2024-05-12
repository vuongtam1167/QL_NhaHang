using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class LOAIMON_DAO
    {
        public List<LOAIMON_DTO> LayDSLoai()
        {
            try
            {
                List<LOAIMON_DTO> lsmon = new List<LOAIMON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "Select * from LOAIMON";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    LOAIMON_DTO loai = new LOAIMON_DTO();
                    loai.MALOAI = (int)sdr["MALOAI"];
                    loai.TENLOAI = sdr["TENLOAI"].ToString();
                    lsmon.Add(loai);
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
    }
}
