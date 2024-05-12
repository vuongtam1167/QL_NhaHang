using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class LOAINGUYENLIEU_DAO
    {
        public List<LOAINGUYENLIEU_DTO> LayDanhSachLoaiNguyenLieu()
        {
            try
            {
                List<LOAINGUYENLIEU_DTO> lsloai = new List<LOAINGUYENLIEU_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "Select * from LOAINGUYENLIEU";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    LOAINGUYENLIEU_DTO nl = new LOAINGUYENLIEU_DTO();
                    nl.MALOAINL = (int)sdr["MALOAINL"];
                    nl.TENLOAINGUYENLIEU = sdr["TENLOAINGUYENLIEU"].ToString();
                    lsloai.Add(nl);
                }
                sdr.Close();
                conn.Close();
                return lsloai;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
