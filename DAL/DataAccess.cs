using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Linq.Expressions;


namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strCon = @"Data Source=PAVILION\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
    }
    public class DataAccess
    {
        public static string KiemTraDangNhapDataAccess(TaiKhoan taiKhoan)
        {
            string procQuery = "proc_Login";
            string user = null;
            //hàm connect tới database
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procQuery, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@loginUser", taiKhoan.SLoginName);
                    cmd.Parameters.AddWithValue("@matKhau", taiKhoan.SMatKhau);

                    cmd.Connection = conn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            user = reader.GetString(0);
                            return user;
                        }
                        reader.Close();
                        
                    }
                    else
                    { return "tên đăng nhập hoặc mật khẩu không chính xác"; }
                }
            }
            return user;
        }

        public static DataSet truyenViewVaodgv_DataAccess(string viewQuerry)
        {
            
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlDataAdapter dataAdap = new SqlDataAdapter())
                {
                    dataAdap.SelectCommand = new SqlCommand(viewQuerry, conn); 
                        

                        dataAdap.Fill(dataSet);
                        
                        
                }
                
            }
            return dataSet;
        }



        //thêm nv
        public static bool ThemNV_Access(string sMaNV, string sTenNV, bool bGioiTinh,
            string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            string proc_Them = "ThemNhanVien";
            using(SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmd.Parameters.AddWithValue("@TenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@DT", sDT);
                    cmd.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cmd.Parameters.AddWithValue("@MaChucVu", sMaChucVu);

                    int rowsAffected =  cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }

        

        //sửa nv
        public static bool SuaNhanVien_Access(string sMaNV, string sTenNV, bool bGioiTinh,
            string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            string proc_Sua = "SuaThongTinNhanVien";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmd.Parameters.AddWithValue("@TenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@DT", sDT);
                    cmd.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cmd.Parameters.AddWithValue("@MaChucVu", sMaChucVu);
                   

                    int rowsAffected =  cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        //xóa nv
        public static bool XoaNhanVien_Access(string maNV)
        {
            string proc_Xoa = "XoaNhanVien";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        //tìm nv
        public static DataTable TimKiemNhanVien_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemNhanVienFull";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);
                        
                        dataAdap.Fill(dataTable);


                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }


        //thêm DG
        public static bool ThemDG_Access(string sMaDG, string sTenDG, DateTime dNgaySinh,
            bool bGioiTinh, string sDiaChi, string sDT)
        {
            string proc_Them = "ThemDocGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDG);
                    cmd.Parameters.AddWithValue("@TenDocGia", sTenDG);
                    cmd.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@SDT", sDT);
                    
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }



        //sửa DG
        public static bool SuaDocGia_Access(string sMaDG, string sTenDG, DateTime dNgaySinh,
            bool bGioiTinh, string sDiaChi, string sDT)
        {
            string proc_Sua = "SuaDocGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDG);
                    cmd.Parameters.AddWithValue("@TenDocGia", sTenDG);
                    cmd.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@SDT", sDT);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        //xóa DG
        public static bool XoaDocGia_Access(string maDG)
        {
            string proc_Xoa = "XoaDocGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDocGia", maDG);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static DataTable TimKiemDocGia_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemDocGia";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);


                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }




        //thêm TG
        public static bool ThemTG_Access(string sMaTG, string sTenTG, bool bGioiTinh)
        {
            string proc_Them = "ThemTacGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTacGia", sMaTG);
                    cmd.Parameters.AddWithValue("@TenTacGia", sTenTG);
                    
                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    
                   


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }



        //sửa DG
        public static bool SuaTacGia_Access(string sMaTG, string sTenTG, bool bGioiTinh)
        {
            string proc_Sua = "SuaTacGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTacGia", sMaTG);
                    cmd.Parameters.AddWithValue("@TenTacGia", sTenTG);

                    cmd.Parameters.AddWithValue("@GioiTinh", bGioiTinh);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        //xóa DG
        public static bool XoaTacGia_Access(string maTG)
        {
            string proc_Xoa = "XoaTacGia";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTacGia", maTG);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static DataTable TimKiemTacGia_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemTacGia";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }

        //thêm sách
        public static bool ThemSach_Access(string sMaSach, string sTenSach, DateTime dNamXB, int iSoLuong,
    float fGia, string sMaLoai, string sMaNXB, string sMaTacGia)
        {
            string proc_Them = "ThemSach";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSach", sMaSach);
                    cmd.Parameters.AddWithValue("@TenSach", sTenSach);
                    cmd.Parameters.AddWithValue("@NamXB", dNamXB);
                    cmd.Parameters.AddWithValue("@SoLuong", iSoLuong);
                    cmd.Parameters.AddWithValue("@Gia", fGia);
                    cmd.Parameters.AddWithValue("@MaLoai", sMaLoai);
                    cmd.Parameters.AddWithValue("@MaNXB", sMaNXB);
                    cmd.Parameters.AddWithValue("@MaTacGia", sMaTacGia);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        //Sửa thông tin sách
        public static bool SuaSach_Access(string sMaSach, string sTenSach, DateTime dNamXB, int iSoLuong,
    float fGia, string sMaLoai, string sMaNXB, string sMaTacGia)
        {
            string proc_Sua = "SuaThongTinSach";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSach", sMaSach);
                    cmd.Parameters.AddWithValue("@TenSach", sTenSach);
                    cmd.Parameters.AddWithValue("@NamXB", dNamXB);
                    cmd.Parameters.AddWithValue("@SoLuong", iSoLuong);
                    cmd.Parameters.AddWithValue("@Gia", fGia);
                    cmd.Parameters.AddWithValue("@MaLoai", sMaLoai);
                    cmd.Parameters.AddWithValue("@MaNXB", sMaNXB);
                    cmd.Parameters.AddWithValue("@MaTacGia", sMaTacGia);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        //xóa sách
        public static bool XoaSach_Access(string maSach)
        {
            string proc_Xoa = "XoaSach";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSach", maSach);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        //tìm kiếm sách
        public static DataTable TimKiemSach_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemSach";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }

        //thêm phiếu mượn
        public static bool ThemPM_Access(string sMaPhieuMuon, string sMaDocGia, string sMaNV)
        {
            string proc_Them = "ThemPhieuMuon";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", sMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDocGia);
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }

        //sửa phiếu mượn
        public static bool SuaPM_Access(string sMaPhieuMuon, string sMaDocGia, string sMaNV,
            string sMaSachMoi, DateTime dNgayMuon, DateTime dNgayHenTra, string MaSachCu)
        {
            string proc_Them = "SuaThongTinPhieuMuon";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", sMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDocGia);
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmd.Parameters.AddWithValue("@MaSachCu", MaSachCu);
                    cmd.Parameters.AddWithValue("@MaSachMoi", sMaSachMoi);
                    cmd.Parameters.AddWithValue("@NgayMuon", dNgayMuon);
                    cmd.Parameters.AddWithValue("@NgayHenTra", dNgayHenTra);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }


        //xóa phiếu mượn
        public static bool XoaPM_Access(string MaPhieuMuon)
        {
            string proc_Xoa = "XoaPhieuMuon";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", MaPhieuMuon);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        



        //tìm kiếm phiếu mượn
        public static DataTable TimKiemPM_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemPhieuMuon";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }



        //thêm phiếu trả
        public static bool ThemPT_Access(string sMaPhieuTra, string sMaPhieuMuon,
            string sMaNV, string sMaDocGia, string sMaTinhTrang)
        {
            string proc_Them = "ThemPhieuTra";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuTra", sMaPhieuTra);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", sMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDocGia); 
                    cmd.Parameters.AddWithValue("@MaTinhTrang", sMaTinhTrang);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }


        //sửa phiếu trả
        public static bool SuaPT_Access(string sMaPhieuTra, string sMaPhieuMuon,
            string sMaNV, string sMaDocGia,
            string sMaSachMoi, DateTime dNgayTra, string sMaTinhTrang, string MaSachCu)
        {
            string proc_Them = "SuaThongTinPhieuTra";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuTra", sMaPhieuTra);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", sMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                    cmd.Parameters.AddWithValue("@MaDocGia", sMaDocGia);
                    cmd.Parameters.AddWithValue("@MaSachMoi", sMaSachMoi);
                    cmd.Parameters.AddWithValue("@MaSachCu", MaSachCu);
                    cmd.Parameters.AddWithValue("@NgayTra", dNgayTra);
                    cmd.Parameters.AddWithValue("@MaTinhTrang", sMaTinhTrang);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }

        //xóa phiếu trả
        public static bool XoaPT_Access(string MaPhieuTra)
        {
            string proc_Xoa = "XoaPhieuTra";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuTra", MaPhieuTra);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        //tìm kiếm phiếu trả
        public static DataTable TimKiemPT_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemPhieuTra";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }

        // thêm phiếu phạt
        public static bool ThemPhieuPhat_Access(PhieuPhat phieuPhat)
        {
            string proc_Them = "ThemPhieuPhat";
            using(SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(@proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuPhat", phieuPhat.SMaPhieuPhat);
                    cmd.Parameters.AddWithValue("@MaPhieuTra", phieuPhat.SMaPhieuTra);
                    cmd.Parameters.AddWithValue("@TienPhat", phieuPhat.FTienPhat);
                    cmd.Parameters.AddWithValue("@NoiDung", phieuPhat.SNoiDung);

                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }

        }

        //sửa phiếu phạt
        public static bool SuaPhieuPhat_Access(PhieuPhat phieuPhat)
        {
            string proc_Them = "SuaThongTinPhieuPhat";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@proc_Them, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuPhat", phieuPhat.SMaPhieuPhat);
                    cmd.Parameters.AddWithValue("@MaPhieuTra", phieuPhat.SMaPhieuTra);
                    cmd.Parameters.AddWithValue("@TienPhat", phieuPhat.FTienPhat);
                    cmd.Parameters.AddWithValue("@NoiDung", phieuPhat.SNoiDung);

                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }

        }

        //xóa phiếu phạt
        public static bool XoaPhieuPhat_Access(string MaPhieuPhat)
        {
            string proc_Xoa = "XoaPhieuPhat";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Xoa, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuPhat", MaPhieuPhat);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        //tìm kiếm phiếu phạt
        public static DataTable TimKiemPhieuPhat_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemPhieuPhat";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc_TimKiem, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", timKiem);

                        SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);

                        dataAdap.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }




    }
}
