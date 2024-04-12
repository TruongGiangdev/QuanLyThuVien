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
    public class PhieuMuonBLL
    {
        PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        public void HienThiDataLenDataGridView(DataGridView datagridview)
        {
            // Gọi phương thức truyền view vào DataSet từ DAL
            DataSet dataSet = phieuMuonDAL.truyenViewVaodgv_DAL();

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

        public bool ThemPM_BLL(PhieuMuon phieuMuon)
        {
            bool res = false;
            try
            {
                res = phieuMuonDAL.ThemPM_DAL(phieuMuon.SMaPhieuMuon, phieuMuon.SMaDocGia, phieuMuon.SMaNV);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn mới thất bại !");
                }
            }
            return res;
        }

        //sửa phiếu mượn 
        public bool SuaPM_BLL(PhieuMuon phieuMuon, string MaSachCu)
        {
            bool res = false;
            try
            {
                res = phieuMuonDAL.SuaPM_DAL(phieuMuon.SMaPhieuMuon, phieuMuon.SMaDocGia,
                        phieuMuon.SMaNV, phieuMuon.SMaSach, phieuMuon.DNgayMuon, phieuMuon.DNgayHenTra, MaSachCu);
            }
            catch(SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            return res;
        }

        public bool XoaPM_BLL(PhieuMuon phieuMuon)
        {
            return phieuMuonDAL.XoaPM_DAL(phieuMuon.SMaPhieuMuon);
        }

        public DataTable TimKiemPM_BLL(string timKiem)
        {
            return phieuMuonDAL.TimKiemPM(timKiem);
        }

        public bool ThemChiTietPhieuMuon_BLL(string sMaPhieuMuon, List<string> lstMaSach, DateTime dNgayMuon, DateTime dNgayTra)
        {
            bool result = true;
            try
            {
                foreach (string maSach in lstMaSach)
                {
                    if (!phieuMuonDAL.ThemChiTietPhieuMuon_DAL(sMaPhieuMuon, maSach, dNgayMuon, dNgayTra))
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch(SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn mới thất bại !");
                }
            }
            

            return result;
        }

    }
}
