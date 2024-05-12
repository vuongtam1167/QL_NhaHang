using QL_NhaHang_DAO;
using QL_NhaHang_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaHang_BUS
{
    public class LOAIMON_BUS
    {
        LOAIMON_DAO lmdao = new LOAIMON_DAO();
        public List<LOAIMON_DTO> DSLoaiMon()
        {
            return lmdao.LayDSLoai();
        }
    }
}
