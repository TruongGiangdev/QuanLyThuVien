using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace BLL
{
    public class TacGiaBLL
    {
        TacGiaDAL tgDAL = new TacGiaDAL();

        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = tgDAL.truyenViewVaodgv_DAL();

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

        public bool ThemTG_BLL(TacGia tacGia)
        {
            bool res = false;
            try
            {
                return tgDAL.ThemTG_DAL(tacGia.SMaTG, tacGia.STenTG, tacGia.BGioiTinh);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1) // Custom error number and state from the trigger
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm tác giả mới thất bại !");
                }
            }
            return res;
        }

        public bool SuaTG_BLL(TacGia tacGia)
        {
            return tgDAL.SuaTG_DAL(tacGia.SMaTG, tacGia.STenTG, tacGia.BGioiTinh);
        }

        public bool XoaTG_BLL(TacGia tacGia)
        {
            return tgDAL.XoaTG_DAL(tacGia.SMaTG);
        }


        public DataTable TimKiemTacGia_BLL(string timKiem)
        {
            try
            {
                return tgDAL.TimKiemTacGia_DAL(timKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
