using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class CT_MON_BUS
    {
        CT_MON_DAO ctmdao = new CT_MON_DAO();
        public List<CT_MON_DTO> DSCTMon(int mamon)
        {
            return ctmdao.LayCT(mamon);
        }

        public bool SuaCTMon(CT_MON_DTO ctmon)
        {
            return ctmdao.SuaMon(ctmon);
        }

        public bool SuaCTMonGiam(CT_MON_DTO ctmon)
        {
            return ctmdao.SuaMonGiam(ctmon);
        }

        public bool ThemMoiCTMon(CT_MON_DTO ctmon)
        {
            return ctmdao.ThemCT(ctmon);
        }

        public bool XoaCTMon(CT_MON_DTO ctmon)
        {
            return ctmdao.XoaCTMon(ctmon);
        }
    }
}
