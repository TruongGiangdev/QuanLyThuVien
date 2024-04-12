using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class f_PhieuMuon : Form
    {
        PhieuMuonBLL phieuMuonBLL = new PhieuMuonBLL();
        private List<string> selectedItems = new List<string>();
        public f_PhieuMuon()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.SMaPhieuMuon = tb_MaPhieuMuon.Text;
            phieuMuon.SMaDocGia = cbb_MaDocGia.Text;
            phieuMuon.SMaNV = cbb_MaNV.Text;

            //string DSSach = string.Join(", ", selectedItems);
            //phieuMuon.SMaSach = DSSach;
            phieuMuon.DNgayMuon = dateTime_NgayMuon.Value;
            phieuMuon.DNgayHenTra = dateTime_NgayTra.Value;

            if (tb_MaPhieuMuon.Text.Trim() != "" && cbb_MaDocGia.Text.Trim() != "" &&
                cbb_MaNV.Text.Trim() != "" && cbb_MaSach.Text.Trim() != "")
            {
                //    bool res = phieuMuonBLL.ThemPM_BLL(phieuMuon);


                //    if (res == true)
                //    {
                //        MessageBox.Show("Thêm phiếu mượn mới thành công");

                //        tb_MaPhieuMuon.Enabled = false;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Thêm phiếu mượn mới thất bại !");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                //}

                //Thêm phiếu mượn
                if (phieuMuonBLL.ThemPM_BLL(phieuMuon))
                {
                    // Thêm chi tiết phiếu mượn
                    if (phieuMuonBLL.ThemChiTietPhieuMuon_BLL(phieuMuon.SMaPhieuMuon, selectedItems,
                        phieuMuon.DNgayMuon, phieuMuon.DNgayHenTra))
                    {
                        MessageBox.Show("Thêm phiếu mượn mới thành công");
                        //tb_MaPhieuMuon.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm chi tiết phiếu mượn thất bại !");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn mới thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuMuonBLL.HienThiDataLenDataGridView(dgv_PhieuMuon);
        }

        private void f_PhieuMuon_Load(object sender, EventArgs e)
        {
            this.docGiaTableAdapter.Fill(this.qLTVDataSet.DocGia);
            this.nhanVienTableAdapter.Fill(this.qLTVDataSet.NhanVien);
            this.sachTableAdapter.Fill(this.qLTVDataSet.Sach);
            phieuMuonBLL.HienThiDataLenDataGridView(dgv_PhieuMuon);
            dgv_PhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PhieuMuon.AllowUserToAddRows = false;
        }


        
        private void cbb_MaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbb_MaSach.Text.Trim();

            if (!selectedItems.Contains(selectedItem))
            {
                selectedItems.Add(selectedItem);
            }
            lbl_DSSach.Text = string.Join("\n", selectedItems);
        }

        private string MaSachCu;
        private void dgv_PhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_PhieuMuon.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaPhieuMuon.Text = row.Cells["Mã phiếu mượn"].Value.ToString();
                cbb_MaDocGia.Text = row.Cells["Mã độc giả"].Value.ToString();
                cbb_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
                lbl_DSSach.Text = row.Cells["Mã sách"].Value.ToString();
                MaSachCu = row.Cells["Mã sách"].Value.ToString();
                dateTime_NgayMuon.Value = Convert.ToDateTime(row.Cells["Ngày mượn"].Value);
                dateTime_NgayTra.Value = Convert.ToDateTime(row.Cells["Ngày trả"].Value);

            }
        }

        

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.SMaPhieuMuon = tb_MaPhieuMuon.Text;
            phieuMuon.SMaDocGia = cbb_MaDocGia.Text;
            phieuMuon.SMaNV = cbb_MaNV.Text;
            //string DSSach = string.Join("\n", selectedItems);
            phieuMuon.SMaSach = cbb_MaSach.Text;
            phieuMuon.DNgayMuon = dateTime_NgayMuon.Value;
            phieuMuon.DNgayHenTra = dateTime_NgayTra.Value;
            
            if (tb_MaPhieuMuon.Text.Trim() != "" && cbb_MaDocGia.Text.Trim() != "" &&
                cbb_MaNV.Text.Trim() != "" && cbb_MaSach.Text != "")
            {
                bool res = phieuMuonBLL.SuaPM_BLL(phieuMuon, MaSachCu);


                if (res == true)
                {
                    MessageBox.Show("Sửa phiếu mượn thành công");

                    tb_MaPhieuMuon.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa phiếu mượn thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuMuonBLL.HienThiDataLenDataGridView(dgv_PhieuMuon);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.SMaPhieuMuon = tb_MaPhieuMuon.Text;
            if (tb_MaPhieuMuon.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa phiếu mượn có mã: " + phieuMuon.SMaPhieuMuon + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = phieuMuonBLL.XoaPM_BLL(phieuMuon);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa phiếu mượn thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu mượn thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn trước khi xóa");
            }
            phieuMuonBLL.HienThiDataLenDataGridView(dgv_PhieuMuon);
        }
        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemPM = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemPM))
            {
                dgv_PhieuMuon.DataSource = phieuMuonBLL.TimKiemPM_BLL(timKiemPM);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
