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
    public class NhanVienDAL : DataAccess
    {
        
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_NhanVien");
        }

      

        public bool ThemNV_DAL(string sMaNV, string sTenNV, bool bGioiTinh,
            string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            return ThemNV_Access(sMaNV, sTenNV, bGioiTinh, sDiaChi,
                sDT, dNgaySinh, sMaChucVu);
        }

        public bool SuaNV_DAL(string sMaNV, string sTenNV, bool bGioiTinh,
            string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            return SuaNhanVien_Access(sMaNV, sTenNV, bGioiTinh, sDiaChi,
                sDT, dNgaySinh, sMaChucVu);
        }

        public bool XoaNV_DAL(string sMaNV)
        {
            return XoaNhanVien_Access(sMaNV);
        }

        public DataTable TimKiemNhanVien_DAL(string timKiem)
        {
            return TimKiemNhanVien_Access(timKiem);
        }


    }
    
}
