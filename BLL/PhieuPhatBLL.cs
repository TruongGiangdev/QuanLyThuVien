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
    public class PhieuPhatBLL
    {
        PhieuPhatDAL phieuPhatDAL = new PhieuPhatDAL();
        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = phieuPhatDAL.truyenViewVaodgv_DAL();

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


        public bool ThemPhieuPhat_BLL(PhieuPhat phieuPhat)
        {
            bool res = false;
            try
            {
                res = phieuPhatDAL.ThemPhieuPhat_DAL(phieuPhat);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu phạt mới thất bại !");
                }
            }
            return res;
        }

        public bool SuaPhieuPhat_BLL(PhieuPhat phieuPhat)
        {
            return phieuPhatDAL.SuaPhieuPhat_DAL(phieuPhat);
        }

        public bool XoaPhieuPhat_BLL(string MaPhieuPhat)
        {
            return phieuPhatDAL.XoaPhieuPhat_DAL(MaPhieuPhat);
        }

        public DataTable TimKiemPhieuPhat_BLL(string timKiem)
        {
            return phieuPhatDAL.TimKiemPhieuPhat_DAL(timKiem);
        }
    }
}
