using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DAO
{
    public class DataProvider
    {
        private static string strKN = @"Data Source=.;Initial Catalog=QL_NHAHANG;Integrated Security=True";
        public static SqlConnection TaoKetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strKN);
                conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu");
            }
        }
        public static SqlDataReader TruyVan(String strTV, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTV, conn);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Lỗi lấy dữ liệu");
            }
        }
        public static SqlDataReader TruyVan(String strTV, SqlParameter[] param, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTV, conn);
                com.Parameters.AddRange(param);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Lỗi lấy dữ liệu");
            }
        }
        public static bool ThucThi(string strTT, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTT, conn);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch
            {
                throw new Exception("Lỗi thực thi cập nhập dữ liệu");
            }
        }
        public static bool ThucThi(string strTT, SqlParameter[] param, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strTT, conn);
                com.Parameters.AddRange(param);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch
            {
                throw new Exception("Lỗi thực thi cập nhập dữ liệu");
            }
        }
    }
}
