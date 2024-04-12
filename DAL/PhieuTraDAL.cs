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
    public class PhieuTraDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_PhieuTra");
        }

        public bool ThemPT_DAL(string sMaPhieuTra, string sMaPhieuMuon,
            string sMaNV, string sMaDocGia, string sMaTinhTrang)
        {
            return ThemPT_Access(sMaPhieuTra ,sMaPhieuMuon, sMaNV, sMaDocGia, sMaTinhTrang);
        }

        public bool SuaPT_DAL(string sMaPhieuTra, string sMaPhieuMuon,
            string sMaNV, string sMaDocGia,
            string sMaSachMoi, DateTime dNgayTra, string sMaTinhTrang, string MaSachCu)
        {
            return SuaPT_Access(sMaPhieuTra, sMaPhieuMuon, sMaNV, sMaDocGia,
                sMaSachMoi, dNgayTra, sMaTinhTrang, MaSachCu);
        }


        public bool XoaPT_DAL(string maPhieuTra)
        {
            return XoaPT_Access(maPhieuTra);
        }

        public DataTable TimKiem_DAL(string timKiem)
        {
            return TimKiemPT_Access(timKiem);
        }


        public bool ThemChiTietPhieuTra_DAL(string sMaPhieuTra, string sMaSach, DateTime dNgayTra)
        {
            string proc_Them = "ThemChiTietPhieuTra";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuTra", sMaPhieuTra);
                    cmd.Parameters.AddWithValue("@MaSach", sMaSach);
                    cmd.Parameters.AddWithValue("@NgayTra", dNgayTra);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
