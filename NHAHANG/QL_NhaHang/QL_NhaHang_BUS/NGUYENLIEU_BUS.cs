using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class NGUYENLIEU_BUS
    {
        NGUYENLIEU_DAO nldao = new NGUYENLIEU_DAO();
        public List<NGUYENLIEU_DTO> DanhSachNL()
        {
            return nldao.LayDanhSachNguyenLieu();
        }


        public int LayNguyenLieuTiepTheo()
        {
            int max = nldao.LayMaNguyenLieuLonNhat();
            if (max == 0)
            {
                return 1;
            }
            else
            {
                return max + 1;
            }
        }

        public bool SuaNguyenLieu(NGUYENLIEU_DTO nl)
        {
            return nldao.SuaNguyenLieu(nl);
        }

        public bool ThemMoiNguyenLieu(NGUYENLIEU_DTO nl)
        {
            return nldao.ThemMoiNguyenLieu(nl);
        }

        public bool XoaNguyenLieu(int manl)
        {
            return nldao.XoaNguyenLieu(manl);
        }
    }
}
