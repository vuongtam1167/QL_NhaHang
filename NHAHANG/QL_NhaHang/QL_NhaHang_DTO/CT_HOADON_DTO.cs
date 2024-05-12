using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_DTO
{
    public class CT_HOADON_DTO
    {
        public int MAHD { get; set; }
        public int MAMON { get; set; }
        public int GIA { get; set; }
        public int SOLUONG { get; set; }
        public string TENMON { get; set; }
        public double ThanhTien
        {
            get { return SOLUONG * GIA; }
        }
    }
}
