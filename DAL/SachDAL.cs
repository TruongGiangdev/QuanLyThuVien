using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SachDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_ThongTinSach");
        }

        public bool ThemSach_DAL(string sMaSach, string sTenSach, DateTime dNamXB,
    int iSoLuong, float fGia, string sMaLoai, string sMaTacGia,  string sMaNXB)
        {
            return ThemSach_Access(sMaSach, sTenSach, dNamXB, iSoLuong,
                fGia, sMaLoai, sMaTacGia, sMaNXB);
        }

        public bool SuaSach_DAL(string sMaSach, string sTenSach, DateTime dNamXB, int iSoLuong,
    float fGia, string sMaLoai, string sMaNXB, string sMaTacGia)
        {
            return SuaSach_Access(sMaSach, sTenSach, dNamXB, iSoLuong,
                fGia, sMaLoai, sMaNXB, sMaTacGia);
        }

        public bool XoaSach_DAL(string sMaSach)
        {
            return XoaSach_Access(sMaSach);
        }

        public DataTable TimKiemSach_DAL(string timKiem)
        {
            return TimKiemSach_Access(timKiem);
        }

    }
}
