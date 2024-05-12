using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class NHANVIEN_BUS
    {
        NHANVIEN_DAO NVDAO = new NHANVIEN_DAO();

        public string layMaTT()
        {
            string max = NVDAO.LayMaNhanVien();
            if (max == null)
            {
                return "NV00001";
            }
            else
            {
                int somax = int.Parse(max.Substring(2));
                return string.Format("NV{0:00000}", somax + 1);
            }
        }

        public List<NHANVIEN_DTO> loadNhanVien()
        {
            return NVDAO.loadDSNhanVien();
        }

        public bool suaTT(NHANVIEN_DTO nv)
        {
            return NVDAO.suaNhanVien(nv);
        }

        public bool themMoi(NHANVIEN_DTO nv)
        {
            return NVDAO.themMoiNhanVien(nv);
        }

        public bool xoaTT(string manv)
        {
            return NVDAO.xoaNhanVien(manv);
        }
    }
}
