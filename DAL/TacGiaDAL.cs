using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL 
{
    public class TacGiaDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_TacGia");
        }

        public bool ThemTG_DAL(string sMaTG, string sTenTG, bool bGioiTinh)
        {
            return ThemTG_Access(sMaTG, sTenTG, bGioiTinh);
        }

        public bool SuaTG_DAL(string sMaTG, string sTenTG, bool bGioiTinh)
        {
            return SuaTacGia_Access(sMaTG, sTenTG, bGioiTinh);
        }

        public bool XoaTG_DAL(string sMaTG)
        {
            return XoaTacGia_Access(sMaTG);
        }

        public DataTable TimKiemTacGia_DAL(string timKiem)
        {
            return TimKiemTacGia_Access(timKiem);
        }
    }
}
