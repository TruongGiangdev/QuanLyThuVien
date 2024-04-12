using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class TaiKhoanDAL : DataAccess
    {

        public string KiemTraDangNhapDAL(TaiKhoan taiKhoan)
        {
            string info = KiemTraDangNhapDataAccess(taiKhoan);

            return info;
        }

        public DataSet TruyenViewVaodgv_DAL()
        {
            return truyenViewVaodgv_DataAccess("select * from View_TaiKhoan");
        }

        public bool ThemTK_DAL(TaiKhoan taiKhoan)
        {
            string proc_Them = "proc_ThemTK";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Them, conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", taiKhoan.SLoginName);
                    cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.SMatKhau);
                    cmd.Parameters.AddWithValue("@QuyenHan", taiKhoan.BQuyenHan);
                    cmd.Parameters.AddWithValue("@MaNV", taiKhoan.SMaNV);

                    int affectedRow = cmd.ExecuteNonQuery();
                    return (affectedRow > 0);
                }
            }
        }


        public bool SuaTK_DAL(TaiKhoan taiKhoan)
        {
            string proc_Sua = "proc_SuaTK";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", taiKhoan.SLoginName);
                    cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.SMatKhau);
                    cmd.Parameters.AddWithValue("@QuyenHan", taiKhoan.BQuyenHan);
                    cmd.Parameters.AddWithValue("@MaNV", taiKhoan.SMaNV);

                    int affectedRow = cmd.ExecuteNonQuery();
                    return (affectedRow > 0);
                }
            }
        }


        public bool XoaTK_DAL(TaiKhoan taiKhoan)
        {
            string proc_Sua = "proc_XoaTK";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(proc_Sua, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", taiKhoan.SLoginName);

                    int affectedRow = cmd.ExecuteNonQuery();
                    return (affectedRow > 0);
                }
            }
        }


        public DataTable TimKiemTaiKhoan_Access(string timKiem)
        {
            string proc_TimKiem = "TimKiemTaiKhoan";
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




        //đổi mật khẩu
        public bool DoiMatKhau_DAL(string userName ,string MatKhauCu, string MatKhauMoi)
        {
            string proc_DoiMK = "proc_DoiMatKhau";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(proc_DoiMK, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@MatKhauCu", MatKhauCu);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", MatKhauMoi);

                    int rowAffected = cmd.ExecuteNonQuery();
                    return (rowAffected > 0);
                }
            }
        }

        public string LayTenQuyen(string userName)
        {
            string tenQuyen = string.Empty;
            string procName = "proc_LayTenQuyen";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenQuyen = reader["QuyenHan"].ToString();
                        }
                    }
                }
            }

            return tenQuyen;
        }

        public List<string> LayThongTinNV(string userName)
        {
            List<string> list = new List<string>();
            string proc_Name = "proc_LayThongTinNVTuUser";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(proc_Name, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            list.Add(reader["Mã nhân viên"].ToString());
                            list.Add(reader["Tên nhân viên"].ToString());
                            list.Add(reader["Giới tính"].ToString());
                            list.Add(reader["Địa chỉ"].ToString());
                            list.Add(reader["Điện thoại"].ToString());
                            list.Add(reader["Ngày sinh"].ToString());
                            list.Add(reader["Chức vụ"].ToString());
                        }
                        
                    }
                }
            }
            return list;
        }





        public bool SuaThongTinTK_DAL(string sMaNV, string sTenNV, bool bGioiTinh,
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


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }


}

