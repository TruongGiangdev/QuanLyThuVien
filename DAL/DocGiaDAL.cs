using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_DocGia");
        }

        

        public bool ThemDG_DAL(string sMaDG, string sTenDG, DateTime dNgaySinh,
            bool bGioiTinh, string sDiaChi, string sDT)
        {
            return ThemDG_Access(sMaDG, sTenDG, dNgaySinh, bGioiTinh, sDiaChi, sDT);
        }

        public bool SuaDG_DAL(string sMaDG, string sTenDG, DateTime dNgaySinh,
            bool bGioiTinh, string sDiaChi, string sDT)
        {
            return SuaDocGia_Access(sMaDG, sTenDG, dNgaySinh, bGioiTinh, sDiaChi, sDT);
        }

        public bool XoaDG_DAL(string sMaDG)
        {
            return XoaDocGia_Access(sMaDG);
        }

        public DataTable TimKiemDocGia_DAL(string timKiem)
        {
            return TimKiemDocGia_Access(timKiem);
        }
    }
}
