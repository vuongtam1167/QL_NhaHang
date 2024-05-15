using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class NHANVIEN_DAO
    {
        public string LayMaNhanVien()
        {
            try
            {
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlCommand com = new SqlCommand("Select Max(MANV) from NHANVIEN", conn);
                string kq = (string)com.ExecuteScalar();
                conn.Close();
                return kq;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<NHANVIEN_DTO> loadDSNhanVien()
        {
            try
            {
                List<NHANVIEN_DTO> lsNV = new List<NHANVIEN_DTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                string strTruyVan = "Select * From NHANVIEN WHERE TRANGTHAI=1";
                SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
                while (sdr.Read())
                {
                    NHANVIEN_DTO NV = new NHANVIEN_DTO();
                    NV.MANV = sdr["MANV"].ToString();
                    NV.HOTEN = sdr["HOTEN"].ToString();
                    NV.EMAIL = sdr["EMAIL"].ToString();
                    NV.CCCD = sdr["CCCD"].ToString();
                    NV.SDT = sdr["SDT"].ToString();
                    NV.HINHANH = sdr["HINHANH"].ToString();
                    NV.CHUCVU = sdr["CHUCVU"].ToString();
                    NV.THANHTICH = (int)sdr["THANHTICH"];
                    NV.TONGTHOIGIANLAM = (int)sdr["TONGTHOIGIANLAM"];
                    NV.TRANGTHAI = (int)sdr["TRANGTHAI"];
                    lsNV.Add(NV);
                }
                sdr.Close();
                conn.Close();
                return lsNV;
            }
            catch (Exception ex)
            {
                return new List<NHANVIEN_DTO>();
            }
        }

        public bool suaNhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                string strCapNhat = "Update NHANVIEN set HOTEN=@HOTEN,EMAIL=@EMAIL,CCCD=@CCCD,SDT=@SDT,HINHANH=@HINHANH,CHUCVU=@CHUCVU,THANHTICH=@THANHTICH,TONGTHOIGIANLAM=@TONGTHOIGIANLAM,TRANGTHAI=1 " +
                    " Where MANV=@MANV";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("MANV", nv.MANV);
                param[1] = new SqlParameter("HOTEN", nv.HOTEN);
                param[2] = new SqlParameter("EMAIL", nv.EMAIL);
                param[3] = new SqlParameter("CCCD", nv.CCCD);
                param[4] = new SqlParameter("SDT", nv.SDT);
                param[5] = new SqlParameter("HINHANH", nv.HINHANH);
                param[6] = new SqlParameter("CHUCVU", nv.CHUCVU);
                param[7] = new SqlParameter("THANHTICH", nv.THANHTICH);
                param[8] = new SqlParameter("TONGTHOIGIANLAM", nv.TONGTHOIGIANLAM);
                param[9] = new SqlParameter("TRANGTHAI", nv.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strCapNhat, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool themMoiNhanVien(NHANVIEN_DTO nv)
        {
            try
            {
                string strThem = "insert into NHANVIEN(MANV,HOTEN,EMAIL,CCCD,SDT,HINHANH,CHUCVU,THANHTICH,TONGTHOIGIANLAM,TRANGTHAI) " +
                    " values (@MANV,@HOTEN,@EMAIL,@CCCD,@SDT,@HINHANH,@CHUCVU,@THANHTICH,@TONGTHOIGIANLAM,@TRANGTHAI)";
                SqlConnection conn = DataProvider.TaoKetNoi();
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("MANV", nv.MANV);
                param[1] = new SqlParameter("HOTEN", nv.HOTEN);
                param[2] = new SqlParameter("EMAIL", nv.EMAIL);
                param[3] = new SqlParameter("CCCD", nv.CCCD);
                param[4] = new SqlParameter("SDT", nv.SDT);
                param[5] = new SqlParameter("HINHANH", nv.HINHANH);
                param[6] = new SqlParameter("CHUCVU", nv.CHUCVU);
                param[7] = new SqlParameter("THANHTICH", nv.THANHTICH);
                param[8] = new SqlParameter("TONGTHOIGIANLAM", nv.TONGTHOIGIANLAM);
                param[9] = new SqlParameter("TRANGTHAI", nv.TRANGTHAI);
                bool kq = DataProvider.ThucThi(strThem, param, conn);
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool xoaNhanVien(string manv)
        {
            try
            {
                string strXoa = $"Delete From NHANVIEN Where MANV='{manv}'";
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
