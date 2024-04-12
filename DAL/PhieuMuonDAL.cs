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
    public class PhieuMuonDAL : DataAccess
    {
        public DataSet truyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_PhieuMuon");
        }

        public bool ThemPM_DAL(string sMaPhieuMuon, string sMaDocGia, string sMaNV)
        {
            return ThemPM_Access(sMaPhieuMuon, sMaDocGia, sMaNV);
        }

        public bool SuaPM_DAL(string sMaPhieuMuon, string sMaDocGia, string sMaNV,
            string sMaSachMoi, DateTime dNgayMuon, DateTime dNgayHenTra, string MaSachCu)
        {
            return SuaPM_Access(sMaPhieuMuon, sMaDocGia, sMaNV, sMaSachMoi, dNgayMuon, dNgayHenTra, MaSachCu);
        }

        public bool XoaPM_DAL(string MaPhieuMuon)
        {
            return XoaPM_Access(MaPhieuMuon);
        }

        public DataTable TimKiemPM(string timKiem)
        {
            return TimKiemPM_Access(timKiem);
        }

        public bool ThemChiTietPhieuMuon_DAL(string sMaPhieuMuon, string sMaSach, DateTime dNgayMuon, DateTime dNgayTra)
        {
            string proc_Them = "ThemChiTietPhieuMuon";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", sMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaSach", sMaSach);
                    cmd.Parameters.AddWithValue("@NgayMuon", dNgayMuon);
                    cmd.Parameters.AddWithValue("@NgayTra", dNgayTra);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

    }
}
