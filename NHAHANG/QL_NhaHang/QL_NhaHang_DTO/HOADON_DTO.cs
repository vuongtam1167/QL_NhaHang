using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DTO
{
    public class HOADON_DTO
    {
        public int MAHD { get; set;}
        public string MANV { get; set;}
        public string MAKH { get; set;}
        public int MADATBAN { get; set; }
        public DateTime NGAYLAP { get; set;}
        public double TONGTIEN { get; set;}
        public double VAT { get; set;}

        public double TONGTIENVAVAT {
            get
            {
                return TONGTIEN + VAT;
            }
        }
    }
}
