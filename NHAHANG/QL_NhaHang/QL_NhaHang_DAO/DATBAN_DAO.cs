using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class DATBAN_DAO
    {
        public List<DATBAN_DTO> LayDanhSachDatBan()
        {
            try
            {
                List<DATBAN_DTO> lsDatBan = new List<DATBAN_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "select * from DATBAN";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    DATBAN_DTO db = new DATBAN_DTO();
                    db.MADATBAN = (int)sdr["MADATBAN"];
                    db.SOBAN = (int)sdr["SOBAN"];
                    db.MANV = sdr["MANV"].ToString();
                    db.MAKH = sdr["MAKH"].ToString();
                    db.THOIGIANDAT = sdr["THOIGIANDAT"].ToString();
                    db.NGAYDAT = (DateTime)sdr["NGAYDAT"];
                    db.GHICHU = sdr["GHICHU"].ToString();
                    lsDatBan.Add(db);
                }
                sdr.Close();
                conn.Close();
                return lsDatBan;
            }
            catch (Exception ex)
            {
                return new List<DATBAN_DTO>();
            }
        }

        public int LayMaBanLonNhat()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MADATBAN) from DATBAN", conn);
                int kq = (int)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string LayMaKhachHang(int madb)
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand($"Select DATBAN.MAKH from KHACHHANG inner join DATBAN on KHACHHANG.MAKH = DATBAN.MAKH where MADATBAN = {madb}", conn);
                string kq = com.ExecuteScalar().ToString();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int LaySoBan(int mahd)
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand($"select SOBAN from HOADON inner join DATBAN on HOADON.MADATBAN = DATBAN.MADATBAN where MAHD = {mahd}", conn);
                int kq = (int)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool SuaDatBan(DATBAN_DTO db)
        {
            try
            {
                string strInsert = "Update DATBAN set SOBAN=@SOBAN,MANV=@MANV,MAKH=@MAKH,THOIGIANDAT=@THOIGIANDAT,NGAYDAT=@NGAYDAT,GHICHU=@GHICHU where MADATBAN=@MADATBAN";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("MADATBAN", db.MADATBAN);
                param[1] = new SqlParameter("SOBAN", db.SOBAN);
                param[2] = new SqlParameter("MANV", db.MANV);
                param[3] = new SqlParameter("MAKH", db.MAKH);
                param[4] = new SqlParameter("THOIGIANDAT", db.THOIGIANDAT);
                param[5] = new SqlParameter("NGAYDAT", db.NGAYDAT);
                param[6] = new SqlParameter("GHICHU", db.GHICHU);

                bool kq = DataProvider.ThucThi(strInsert, param, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool ThemMoiDatBan(DATBAN_DTO db)
        {
            try
            {
                string strInsert = "Insert into DATBAN(MADATBAN,SOBAN,MANV,MAKH,THOIGIANDAT,NGAYDAT,GHICHU) Values(@MADATBAN,@SOBAN,@MANV,@MAKH,@THOIGIANDAT,@NGAYDAT,@GHICHU)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("MADATBAN", db.MADATBAN);
                param[1] = new SqlParameter("SOBAN", db.SOBAN);

                param[2] = new SqlParameter("MANV", db.MANV);
                param[3] = new SqlParameter("MAKH", db.MAKH);
                param[4] = new SqlParameter("THOIGIANDAT", db.THOIGIANDAT);
                param[5] = new SqlParameter("NGAYDAT", db.NGAYDAT);
                param[6] = new SqlParameter("GHICHU", db.GHICHU);

                bool kq = DataProvider.ThucThi(strInsert, param, conn);
                conn.Close();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }

        public bool XoaDatBan(string maban)
        {
            try
            {
                string strDelete = $"Delete from DATBAN where MADATBAN ='{maban}'";
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
    }
}
