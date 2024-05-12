using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class LOAINGUYENLIEU_BUS
    {
        LOAINGUYENLIEU_DAO loaidao = new LOAINGUYENLIEU_DAO();
        public List<LOAINGUYENLIEU_DTO> DanhSachLoai()
        {
            return loaidao.LayDanhSachLoaiNguyenLieu();
        }
    }
}
