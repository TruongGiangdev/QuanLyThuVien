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
    public class DocGiaBLL
    {
        DocGiaDAL docGiaDAL = new DocGiaDAL();
        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = docGiaDAL.truyenViewVaodgv_DAL();

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

        public bool ThemDG_BLL(DocGia docGia)
        {
            bool res = false;
            try
            {
                return docGiaDAL.ThemDG_DAL(docGia.SMaDG, docGia.STenDG, docGia.DNgaySinh,
                    docGia.BGioiTinh, docGia.SDiaChi, docGia.SSdt);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1) // Custom error number and state from the trigger
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm độc giả mới thất bại !");
                }
            }
            return res;
        }

        public bool SuaDG_BLL(DocGia docGia)
        {
            return docGiaDAL.SuaDG_DAL(docGia.SMaDG, docGia.STenDG, docGia.DNgaySinh,
                docGia.BGioiTinh, docGia.SDiaChi, docGia.SSdt);
        }

        public bool XoaDG_BLL(DocGia docGia)
        {
            return docGiaDAL.XoaDG_DAL(docGia.SMaDG);
        }


        public DataTable TimKiemDocGia_BLL(string timKiem)
        {
            try
            {
                return docGiaDAL.TimKiemDocGia_DAL(timKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
