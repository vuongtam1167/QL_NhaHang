using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class DATBAN_BUS
    {
        DATBAN_DAO dbDAO = new DATBAN_DAO();
        public List<DATBAN_DTO> DanhSachDatBan()
        {
            return dbDAO.LayDanhSachDatBan();
        }

        public int LayMaBanTiepTheo()
        {
            int max = dbDAO.LayMaBanLonNhat();
            if (max == 0)
            {
                return 1;
            }
            else
            {
                return max + 1;
            }
        }

        public string LayMaKH(int madb)
        {
            return dbDAO.LayMaKhachHang(madb);
        }

        public int LaySoBan(int mahd)
        {
            return dbDAO.LaySoBan(mahd);
        }

        public bool SuaDatBan(DATBAN_DTO db)
        {
            return dbDAO.SuaDatBan(db);
        }

        public bool ThemMoiDatBan(DATBAN_DTO db)
        {
            return dbDAO.ThemMoiDatBan(db);
        }

        public bool XoaDatBan(string maban)
        {
            return dbDAO.XoaDatBan(maban);
        }
    }
}
