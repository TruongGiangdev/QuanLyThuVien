using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuPhatDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_PhieuPhat");
        }

        public bool ThemPhieuPhat_DAL(PhieuPhat phieuPhat)
        {
            return ThemPhieuPhat_Access(phieuPhat);
        }

        public bool SuaPhieuPhat_DAL(PhieuPhat phieuPhat)
        {
            return SuaPhieuPhat_Access(phieuPhat);
        }

        public bool XoaPhieuPhat_DAL(string MaPhieuPhat)
        {
            return XoaPhieuPhat_Access(MaPhieuPhat);
        }

        public DataTable TimKiemPhieuPhat_DAL(string timKiem)
        {
            return TimKiemPhieuPhat_Access(timKiem);
        }

    }
}
