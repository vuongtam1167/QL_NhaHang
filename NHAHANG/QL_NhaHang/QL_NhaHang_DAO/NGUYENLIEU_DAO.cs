using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class NGUYENLIEU_DAO
    {
        public List<NGUYENLIEU_DTO> LayDanhSachNguyenLieu()
        {
        try { 

            List<NGUYENLIEU_DTO> lsnl = new List<NGUYENLIEU_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strSelect = "Select * from NGUYENLIEU where TRANGTHAI = 1";
            SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
            while (sdr.Read())
            {
                NGUYENLIEU_DTO nl = new NGUYENLIEU_DTO();
                nl.MANGUYENLIEU = (int) sdr["MANGUYENLIEU"];
                nl.TENNGUYENLIEU = sdr["TENNGUYENLIEU"].ToString();
                nl.SOLUONGCON = (int)sdr["SOLUONGCON"];
                nl.LOAINGUYENLIEU = (int)sdr["LOAINGUYENLIEU"];
                nl.MANHACUNGCAP = (int)sdr["MANHACUNGCAP"];
                nl.GIATIEN = int.Parse(sdr["GIATIEN"].ToString());
                nl.MOTA = sdr["MOTA"].ToString();
                lsnl.Add(nl);

            }
            sdr.Close();
            conn.Close();
            return lsnl;
        }
            catch(Exception ex) 
            {
                throw ex;
            }
    }

        public int LayMaNguyenLieuLonNhat()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MANGUYENLIEU) from NGUYENLIEU", conn);
                int kq = (int)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool SuaNguyenLieu(NGUYENLIEU_DTO nl)
        {
            try
            {
                string strUpdate = " Update NGUYENLIEU SET TENNGUYENLIEU = @TENNGUYENLIEU,SOLUONGCON = @SOLUONGCON,LOAINGUYENLIEU = @LOAINGUYENLIEU,MANHACUNGCAP = @MANHACUNGCAP,GIATIEN = @GIATIEN,MOTA = @MOTA where MANGUYENLIEU = @MANGUYENLIEU";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("MANGUYENLIEU", nl.MANGUYENLIEU);
                param[1] = new SqlParameter("TENNGUYENLIEU", nl.TENNGUYENLIEU);
                param[2] = new SqlParameter("SOLUONGCON", nl.SOLUONGCON);
                param[3] = new SqlParameter("LOAINGUYENLIEU", nl.LOAINGUYENLIEU);
                param[4] = new SqlParameter("MANHACUNGCAP", nl.MANHACUNGCAP);
                param[5] = new SqlParameter("GIATIEN", nl.GIATIEN);
                param[6] = new SqlParameter("MOTA", nl.MOTA);
                bool kq = DataProvider.ThucThi(strUpdate, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemMoiNguyenLieu(NGUYENLIEU_DTO nl)
        {
            try
            {
                string strInsert = " insert into NGUYENLIEU(MANGUYENLIEU,TENNGUYENLIEU,SOLUONGCON,LOAINGUYENLIEU,MANHACUNGCAP,GIATIEN,MOTA,TRANGTHAI) " +
                                        "values(@MANGUYENLIEU, @TENNGUYENLIEU, @SOLUONGCON, @LOAINGUYENLIEU, @MANHACUNGCAP, @GIATIEN, @MOTA, 1)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("MANGUYENLIEU", nl.MANGUYENLIEU);
                param[1] = new SqlParameter("TENNGUYENLIEU",nl.TENNGUYENLIEU);
                param[2] = new SqlParameter("SOLUONGCON", nl.SOLUONGCON);
                param[3] = new SqlParameter("LOAINGUYENLIEU", nl.LOAINGUYENLIEU);
                param[4] = new SqlParameter("MANHACUNGCAP", nl.MANHACUNGCAP);
                param[5] = new SqlParameter("GIATIEN", nl.GIATIEN);
                param[6] = new SqlParameter("MOTA", nl.MOTA);
                bool kq = DataProvider.ThucThi(strInsert, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaNguyenLieu(int manl)
        {
            try
            {
                string strDel = $" Update NGUYENLIEU SET TRANGTHAI = 0  where MANGUYENLIEU ={manl} ";
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
