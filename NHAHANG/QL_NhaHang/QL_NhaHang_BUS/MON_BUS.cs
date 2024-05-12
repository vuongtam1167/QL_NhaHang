using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class MON_BUS
    {
        MON_DAO mondao = new MON_DAO();
        public List<MON_DTO> DSMon()
        {
            return mondao.LayDanhSachMon();
        }

        public int LayMaMonTT()
        {
            int max = mondao.LayMaMonKeTiep();
            if (max == 0)
            {
                return 1;
            }
            else
            {
                return max + 1;
            }
        }

        public bool SuaMon(MON_DTO mon)
        {
            return mondao.SuaMon(mon);
        }

        public bool ThemMoiMon(MON_DTO mon)
        {
            return mondao.ThemMonMoi(mon);
        }

        public bool XoaMon(string mon)
        {
            return mondao.XoaMon(mon);
        }
    }
}
