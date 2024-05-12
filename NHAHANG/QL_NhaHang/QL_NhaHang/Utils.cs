using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang
{
    public class Utils
    {
        public static string MaHoaMD5(string chuoi)
        {
            string kq = "";
            MD5 md5 = MD5.Create();
            byte[] bytechuoi = Encoding.UTF8.GetBytes(chuoi);
            byte[] bamchuoi = md5.ComputeHash(bytechuoi);
            foreach (byte b in bamchuoi)
            {
                kq += b.ToString("x2");
            }
            return kq;
        }
        public static Image HinhAnhTuDuongDan(string chuoi)
        {
            if (File.Exists(chuoi))
            {
                byte[] byteHA = File.ReadAllBytes(chuoi);
                MemoryStream ms = new MemoryStream(byteHA);
                return Image.FromStream(ms);
            }
            return null;
        }
    }
}
