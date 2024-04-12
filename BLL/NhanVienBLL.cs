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
    public class NhanVienBLL
    {
        NhanVienDAL nvDAL = new NhanVienDAL();



        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = nvDAL.truyenViewVaodgv_DAL();

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

        public bool ThemNV_BLL(NhanVien nhanVien)
        {
            bool res = false;
            try
            {
                res = nvDAL.ThemNV_DAL(nhanVien.SMaNV, nhanVien.STenNV, nhanVien.BGioiTinh, nhanVien.SDiaChi,
                                        nhanVien.SDT, nhanVien.DNgaySinh, nhanVien.SMaChucVu);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1) 
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên mới thất bại !");
                }
            }
            return res;
        }


        public bool SuaNV_BLL(NhanVien nhanVien)
        {
            return nvDAL.SuaNV_DAL(nhanVien.SMaNV, nhanVien.STenNV, nhanVien.BGioiTinh, nhanVien.SDiaChi,
                nhanVien.SDT, nhanVien.DNgaySinh, nhanVien.SMaChucVu);
        }

        public bool XoaNV_BLL(NhanVien nhanVien)
        {
            return nvDAL.XoaNV_DAL(nhanVien.SMaNV);
        }


        public DataTable TimKiemNhanVien_BLL(string timKiem)
        {
            try
            {
                return nvDAL.TimKiemNhanVien_DAL(timKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
