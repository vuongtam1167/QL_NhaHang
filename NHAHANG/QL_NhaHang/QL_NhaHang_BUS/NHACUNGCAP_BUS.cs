using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class NHACUNGCAP_BUS
    {
        NHACUNGCAP_DAO nhaccdao = new NHACUNGCAP_DAO();

        public List<NHACUNGCAP_DTO> DSHDTim(string ma)
        {
            return nhaccdao.LayDanhSachTheoMa(ma);
        }

        public int LayMaTT()
        {
            int max = nhaccdao.LayMaNhaCungCapLonNhat();
            if (max == 0)
            {
                return 1;
            }
            else
            {
                return max + 1;
            }
        }

        public List<NHACUNGCAP_DTO> loadNhaCungCap()
        {
            return nhaccdao.loadDSNhaCungCap();
        }

        public bool suaTT(NHACUNGCAP_DTO ncc)
        {
            return nhaccdao.suaThongTin(ncc);
        }

        public bool themMoi(NHACUNGCAP_DTO ncc)
        {
            return nhaccdao.themMoiNhaCungCap(ncc);
        }

        public bool TimNCC(string ma)
        {
            return nhaccdao.TimNhaCC(ma);
        }

        public bool xoaTT(string maNCC)
        {
            return nhaccdao.xoaTK(maNCC);
        }
    }
}
