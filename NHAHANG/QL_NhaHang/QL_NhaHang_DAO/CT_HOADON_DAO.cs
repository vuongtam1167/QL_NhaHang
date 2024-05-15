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

        public void TruNguyenLieu(List<CT_HOADON_DTO> lscthd)
        {
            foreach (CT_HOADON_DTO ct in lscthd)
            {
                CT_HOADON_DTO temp = new CT_HOADON_DTO();
                // Lấy thông tin nguyên liệu cần thiết cho món ăn
                NGUYENLIEU_DTO nguyenlieu = GetNguyenLieuByMon(ct.MAMON, ct.SOLUONG);

            }
        }
        private NGUYENLIEU_DTO GetNguyenLieuByMon(int mamon, int soluongMon)
        {
            // Lấy danh sách nguyên liệu cần thiết cho món ăn
            List<CT_MON_DTO> lstCTMon = GetCTMonByMon(mamon);

            // Khởi tạo biến tổng số lượng nguyên liệu cần trừ
            int tongSoLuongTru = 0;

            // Duyệt qua danh sách nguyên liệu cần thiết
            foreach (CT_MON_DTO ctMon in lstCTMon)
            {
                // Tính toán số lượng nguyên liệu cần trừ cho từng nguyên liệu
                int soLuongTru = soluongMon * ctMon.SOLUONG;

                // Cập nhật tổng số lượng nguyên liệu cần trừ
                tongSoLuongTru += soLuongTru;

                // Lấy thông tin nguyên liệu
                NGUYENLIEU_DTO nguyenlieu = GetNguyenLieuById(ctMon.MANGUYENLIEU);

                // Kiểm tra số lượng nguyên liệu còn lại
                if (nguyenlieu != null && nguyenlieu.SOLUONGCON >= soLuongTru)
                {
                    // Cập nhật số lượng nguyên liệu còn lại
                    nguyenlieu.SOLUONGCON -= soLuongTru;

                    // Cập nhật thông tin nguyên liệu trong database
                    UpdateNguyenLieu(nguyenlieu);

                }
            }
            // Nếu không tìm thấy nguyên liệu phù hợp, trả về null
            return null;
        }
        private List<CT_MON_DTO> GetCTMonByMon(int mamon)
        {
            // Lấy danh sách nguyên liệu cần thiết cho món ăn
            List<CT_MON_DTO> lstCTMon = new List<CT_MON_DTO>();

            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                string sql = "SELECT * FROM CT_MON WHERE MAMON = @MAMON";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAMON", mamon);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    CT_MON_DTO ctMon = new CT_MON_DTO();
                    ctMon.MAMON = mamon;
                    ctMon.MANGUYENLIEU = (int)sdr["MANGUYENLIEU"];
                    ctMon.SOLUONG = (int)sdr["SOLUONG"];

                    lstCTMon.Add(ctMon);
                }
                sdr.Close();
                conn.Close();
            }

            return lstCTMon;
        }
        private NGUYENLIEU_DTO GetNguyenLieuById(int manguyenlieu)
        {
            NGUYENLIEU_DTO nguyenlieu = null;

            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                string sql = "SELECT * FROM NGUYENLIEU WHERE MANGUYENLIEU = @MANGUYENLIEU";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANGUYENLIEU", manguyenlieu);

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    nguyenlieu = new NGUYENLIEU_DTO();
                    nguyenlieu.MANGUYENLIEU = manguyenlieu;
                    nguyenlieu.TENNGUYENLIEU = sdr["TENNGUYENLIEU"].ToString();
                    nguyenlieu.SOLUONGCON = (int)sdr["SOLUONGCON"];
                    nguyenlieu.LOAINGUYENLIEU = (int)sdr["LOAINGUYENLIEU"];
                    nguyenlieu.MANHACUNGCAP = (int)sdr["MANHACUNGCAP"];
                    nguyenlieu.GIATIEN = int.Parse(sdr["GIATIEN"].ToString());
                    nguyenlieu.MOTA = sdr["MOTA"].ToString();
                    nguyenlieu.TRANGTHAI = (int)sdr["TRANGTHAI"];
                }
                sdr.Close();
                conn.Close();
            }

            return nguyenlieu;
        }
        private void UpdateNguyenLieu(NGUYENLIEU_DTO nguyenlieu)
        {
            if (nguyenlieu != null)
            {
                using (SqlConnection conn = DataProvider.TaoKetNoi())
                {
                    string sql = "UPDATE NGUYENLIEU SET SOLUONGCON = @SOLUONGCON, LOAINGUYENLIEU = @LOAINGUYENLIEU, MANHACUNGCAP = @MANHACUNGCAP, GIATIEN = @GIATIEN, MOTA = @MOTA, TRANGTHAI = @TRANGTHAI WHERE MANGUYENLIEU = @MANGUYENLIEU";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MANGUYENLIEU", nguyenlieu.MANGUYENLIEU);
                    cmd.Parameters.AddWithValue("@SOLUONGCON", nguyenlieu.SOLUONGCON);
                    cmd.Parameters.AddWithValue("@LOAINGUYENLIEU", nguyenlieu.LOAINGUYENLIEU);
                    cmd.Parameters.AddWithValue("@MANHACUNGCAP", nguyenlieu.MANHACUNGCAP);
                    cmd.Parameters.AddWithValue("@GIATIEN", nguyenlieu.GIATIEN);
                    cmd.Parameters.AddWithValue("@MOTA", nguyenlieu.MOTA);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", nguyenlieu.TRANGTHAI);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
