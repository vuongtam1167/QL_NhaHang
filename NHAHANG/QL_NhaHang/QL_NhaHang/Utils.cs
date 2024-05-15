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
        public static string MaHoaMD5MK(string chuoi)
        {
            // Encode the string as UTF-8 bytes
            byte[] bytes = Encoding.UTF8.GetBytes(chuoi);

            // Create an MD5 hash object
            MD5 md5 = MD5.Create();

            // Compute the hash
            byte[] hash = md5.ComputeHash(bytes);

            // Convert the hash bytes to a hexadecimal string (without StringBuilder)
            string hexString = "";
            foreach (byte b in hash)
            {
                hexString += b.ToString("x2");
            }

            return hexString;
        }
    }
}
