using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL TKAccess = new TaiKhoanDAL();
        public string KiemTraDangNhapBLL(TaiKhoan taiKhoan)
        {
            //kiểm tra nghiệp vụ
            if (taiKhoan.SLoginName == "")
            {
                return "sai tài khoản";
            }
            if (taiKhoan.SMatKhau == "")
            {
                return "sai mật khẩu";
            }
            string info = TKAccess.KiemTraDangNhapDAL(taiKhoan);
            return info;
        }


        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = TKAccess.TruyenViewVaodgv_DAL();

            // kiểm tra nếu dataset không rỗng và chứa ít nhất một bảng
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                // gán dữ liệu từ bảng đầu tiên của dataset vào datagridview
                datagridview.DataSource = dataSet.Tables[0];
            }
            else
            {
                // nếu không có dữ liệu, hiển thị thông báo
                MessageBox.Show("không có dữ liệu để hiển thị!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public bool DoiMK_BLL(string userName, string MatKhauCu, string MatKhauMoi)
        {
            return TKAccess.DoiMatKhau_DAL(userName, MatKhauCu, MatKhauMoi);
        }


        public bool ThemTK_BLL(TaiKhoan taiKhoan)
        {
            bool res = false;
            try
            {
                res = TKAccess.ThemTK_DAL(taiKhoan);
            }
            catch(SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm Tài khoản mới thất bại !");
                }
            }
            return res;
        }

        public bool SuaTK_BLL(TaiKhoan taiKhoan)
        {
            return TKAccess.SuaTK_DAL(taiKhoan);
        }

        public bool XoaTK_BLL(TaiKhoan taiKhoan)
        {
            return TKAccess.XoaTK_DAL(taiKhoan);
        }

        public DataTable TimKiemTK_BLL(string UserName)
        {
            return TKAccess.TimKiemTaiKhoan_Access(UserName);
        }


        public string LayTenQuyen(string userName)
        {
            return TKAccess.LayTenQuyen(userName);
        }

        public List<string> LayThongTinNV (string userName)
        {
            return TKAccess.LayThongTinNV(userName);
        }


        public bool SuaThongTinTK_BLL(string sMaNV, string sTenNV, bool bGioiTinh,
            string sDiaChi, string sDT, DateTime dNgaySinh, string sMaChucVu)
        {
            return TKAccess.SuaThongTinTK_DAL(sMaNV, sTenNV, bGioiTinh, sDiaChi, sDT, dNgaySinh, sMaChucVu);
        }
    }
}
