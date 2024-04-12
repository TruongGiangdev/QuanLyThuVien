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
    public class PhieuTraBLL
    {
        PhieuTraDAL phieuTraDAL = new PhieuTraDAL();

        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = phieuTraDAL.truyenViewVaodgv_DAL();

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

        //thêm phiếu trả
        public bool ThemPT_BLL(PhieuTra phieuTra)
        {
            bool res = false;
            try
            {
                res = phieuTraDAL.ThemPT_DAL(phieuTra.SMaPhieuTra ,phieuTra.SMaPhieuMuon, phieuTra.SMaNV, 
                    phieuTra.SMaDocGia, phieuTra.SMaTinhTrang);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu trả mới thất bại !");
                }
            }
            return res;
        }


        //sửa phiếu trả
        public bool SuaPT_BLL(PhieuTra phieuTra, string MaSachCu)
        {
            bool res = false;   
            try
            {
                res = phieuTraDAL.SuaPT_DAL(phieuTra.SMaPhieuTra, phieuTra.SMaPhieuMuon,
                    phieuTra.SMaNV, phieuTra.SMaDocGia, phieuTra.SMaSach,
                    phieuTra.DNgayTra, phieuTra.SMaTinhTrang, MaSachCu);
            }
            catch(SqlException ex)
            {
                if(ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Sửa phiếu mượn thất bại!");
                }
            }
            return res;
                
        }

        public bool XoaPT_BLL(PhieuTra phieuTra)
        {
            return phieuTraDAL.XoaPT_DAL(phieuTra.SMaPhieuTra);
        }

        public DataTable TimKiemPT_BLL(string timKiem)
        {
            return phieuTraDAL.TimKiem_DAL(timKiem);
        }


        public bool ThemChiTietPhieuTra_BLL(string sMaPhieuTra, List<string> lstMaSach, DateTime dNgayTra)
        {
            bool result = true;
            try
            {
                foreach (string maSach in lstMaSach)
                {
                    if (!phieuTraDAL.ThemChiTietPhieuTra_DAL(sMaPhieuTra, maSach, dNgayTra))
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu trả mới thất bại !");
                }
            }


            return result;
        }
    }
}
