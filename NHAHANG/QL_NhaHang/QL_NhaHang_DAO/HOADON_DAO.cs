using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class HOADON_DAO
    {
        public int LuuHoaDon(HOADON_DTO hd)
        {
            string sql = "Insert into HOADON(MADATBAN,MANV,MAKH,NGAYLAP,TONGTIEN,VAT)  values (@MADATBAN,@MANV,@MAKH,GetDate(),@TONGTIEN,@VAT);SELECT CAST(SCOPE_IDENTITY() as INT);";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("MADATBAN", hd.MADATBAN);
            com.Parameters.AddWithValue("MANV", hd.MANV);
            com.Parameters.AddWithValue("MAKH", hd.MAKH);
            com.Parameters.AddWithValue("TONGTIEN", hd.TONGTIEN);
            com.Parameters.AddWithValue("VAT", hd.VAT);
            int kq = (int)com.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public HOADON_DTO LayThongTinHoaDon(int maHD)
        {
            HOADON_DTO hd = new HOADON_DTO();
            string sql = "Select * From HOADON where MAHD=" + maHD;
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(sql, conn);
            if (sdr.Read())
            {
                hd.MAHD = maHD;
                hd.MANV = sdr["MANV"].ToString();
                hd.TONGTIEN = int.Parse(sdr["TONGTIEN"].ToString());
                hd.NGAYLAP = (DateTime)sdr["NGAYLAP"];

            }
            sdr.Close();
            conn.Close();
            return hd;
        }
        public List<HOADON_DTO> LayDanhSachHDTim(int mahd)
        {

            try
            {
                List<HOADON_DTO> lsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = $"Select * from HOADON where MAHD = {mahd}";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    HOADON_DTO s = new HOADON_DTO();
                    s.MADATBAN = (int)sdr["MADATBAN"];
                    s.MAHD = (int)sdr["MAHD"];
                    s.MANV = sdr["MANV"].ToString();
                    s.MAKH = sdr["MAKH"].ToString();
                    s.NGAYLAP = (DateTime)sdr["NGAYLAP"];
                    s.TONGTIEN = double.Parse(sdr["TONGTIEN"].ToString());
                    s.VAT = double.Parse(sdr["VAT"].ToString());
                    lsHoaDon.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lsHoaDon;
            }
            catch (Exception ex)
            {
                return new List<HOADON_DTO>();
            }
        }

        public List<HOADON_DTO> LayDanhSachHDTimNL(DateTime mahdnl)
        {
            try
            {
                List<HOADON_DTO> lsHoaDon = new List<HOADON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = $"Select * from HOADON where NGAYLAP = '{mahdnl}'";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    HOADON_DTO s = new HOADON_DTO();
                    s.MAHD = (int)sdr["MAHD"];
                    s.MANV = sdr["MANV"].ToString();
                    s.MAKH = sdr["MAKH"].ToString();
                    s.NGAYLAP = (DateTime)sdr["NGAYLAP"];
                    s.TONGTIEN = double.Parse(sdr["TONGTIEN"].ToString());
                    s.VAT = double.Parse(sdr["VAT"].ToString()); ;
                    lsHoaDon.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lsHoaDon;
            }
            catch (Exception ex)
            {
                return new List<HOADON_DTO>();
            }
        }

        public List<HOADON_DTO> LayDanhSachHoaDon()
        {
            try
            {
                List<HOADON_DTO> lsHD = new List<HOADON_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strSelect = "select * from HOADON";
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    HOADON_DTO s = new HOADON_DTO();
                    s.MADATBAN = (int)sdr["MADATBAN"];
                    s.MAHD = (int)sdr["MAHD"];
                    s.MANV = sdr["MANV"].ToString();
                    s.MAKH = sdr["MAKH"].ToString();
                    s.NGAYLAP = (DateTime)sdr["NGAYLAP"];
                    s.TONGTIEN = double.Parse(sdr["TONGTIEN"].ToString());
                    s.VAT = double.Parse(sdr["VAT"].ToString());
                    lsHD.Add(s);
                }
                sdr.Close();
                conn.Close();
                return lsHD;



            }
            catch (Exception ex)
            {
                return new List<HOADON_DTO>();
            }
        }

        public int SoLuongMonDaBan()
        {
            int soLuong = 0;
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                string query = "SELECT COUNT(*) FROM HOADON";
                SqlCommand cmd = new SqlCommand(query, conn);
                soLuong = (int)cmd.ExecuteScalar();
                conn.Close();
                return soLuong;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool TimHoaDon(string timma)
        {
            try
            {
                string kq = null;
                string strSearch = $"select * from HOADON where MAHD = '{timma}'";
                SqlConnection conn = DataProvider.TaoKetNoi();

                SqlCommand com = new SqlCommand(strSearch, conn);
                    kq = com.ExecuteScalar().ToString();
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

        public bool TimHoaDonNL(DateTime timNLHD)
        {
            try
            {
                string kq = null;
                string strSearch = $"select * from HOADON where NGAYLAP = '{timNLHD}'";
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

        public double TongTienMonAnVoiVAT(List<HOADON_DTO> danhSachHoaDon)
        {
            double tongTienMonAn = 0;
            foreach (var hoaDon in danhSachHoaDon)
            {
                tongTienMonAn += hoaDon.TONGTIEN;
            }
            return tongTienMonAn * 1.1;
        }

        public DateTime LayNgayHD(List<HOADON_DTO> dsHD)
        {

            dsHD.Sort((x, y) => DateTime.Compare(x.NGAYLAP, y.NGAYLAP));
            return dsHD[0].NGAYLAP;
        }
    }
}
