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
    public class SachBLL
    {
        SachDAL sachDAL = new SachDAL();    
        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = sachDAL.truyenViewVaodgv_DAL();

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

        public bool ThemSach_BLL(Sach sach)
        {
            bool res = false;
            try
            {
                return sachDAL.ThemSach_DAL(sach.SMaSach, sach.STenSach, sach.DNamXB,
                    sach.ISoLuong, sach.FGia, sach.SMaLoai, sach.SMaNXB, sach.SMaTacGia);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1) // Custom error number and state from the trigger
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm sách mới thất bại !");
                }
            }
            return res;
        }

        public bool SuaSach_BLL(Sach sach)
        {
            return sachDAL.SuaSach_DAL(sach.SMaSach, sach.STenSach, sach.DNamXB,
                sach.ISoLuong, sach.FGia, sach.SMaLoai, sach.SMaNXB, sach.SMaTacGia);
        }

        public bool XoaSach_BLL(Sach sach)
        {
            return sachDAL.XoaSach_DAL(sach.SMaSach);
        }


        public DataTable TimKiemSach_BLL(string timKiem)
        {
            try
            {
                return sachDAL.TimKiemSach_DAL(timKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
