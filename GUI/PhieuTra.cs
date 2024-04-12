using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class f_PhieuTra : Form
    {
        PhieuTraBLL phieuTraBLL =  new PhieuTraBLL();
        private List<string> selectedItems = new List<string>();
        public f_PhieuTra()
        {
            InitializeComponent();
        }

        private void f_PhieuTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.TinhTrangSach' table. You can move, or remove it, as needed.
            this.tinhTrangSachTableAdapter.Fill(this.qLTVDataSet.TinhTrangSach);
            // TODO: This line of code loads data into the 'qLTVDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLTVDataSet.Sach);
            // TODO: This line of code loads data into the 'qLTVDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qLTVDataSet.DocGia);
            // TODO: This line of code loads data into the 'qLTVDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLTVDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLTVDataSet.PhieuMuon' table. You can move, or remove it, as needed.
            this.phieuMuonTableAdapter.Fill(this.qLTVDataSet.PhieuMuon);
            phieuTraBLL.HienThiDataLenDataGridView(dgv_PhieuTra);
            dgv_PhieuTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PhieuTra.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhieuTra phieuTra = new PhieuTra();
            phieuTra.SMaPhieuTra = tb_MaPhieuTra.Text;
            phieuTra.SMaPhieuMuon = cbb_MaPhieuMuon.Text;
            phieuTra.SMaNV = cbb_MaNV.Text;
            phieuTra.SMaDocGia = cbb_MaDG.Text;
            //string DSSach = string.Join("\n", selectedItems);
            //phieuTra.SMaSach = DSSach;
            phieuTra.DNgayTra = dateTime_NgayTra.Value;
            phieuTra.SMaTinhTrang = cbb_TinhTrang.Text;

            if (cbb_MaPhieuMuon.Text.Trim() != "" && cbb_MaNV.Text.Trim() != "" &&
                cbb_MaDG.Text.Trim() != "" && cbb_MaSach.Text.Trim() != "" &&
                cbb_TinhTrang.Text.Trim() != "" && tb_MaPhieuTra.Text.Trim() != "")
            {
                //bool res = phieuTraBLL.ThemPT_BLL(phieuTra);


                //if (res == true)
                //{
                //    MessageBox.Show("Thêm phiếu trả mới thành công");

                //    tb_MaPhieuTra.Enabled = false;
                //}
                //else
                //{
                //    MessageBox.Show("Thêm phiếu trả mới thất bại !");
                //}


                //Thêm phiếu mượn
                if (phieuTraBLL.ThemPT_BLL(phieuTra))
                {
                    // Thêm chi tiết phiếu mượn
                    if (phieuTraBLL.ThemChiTietPhieuTra_BLL(phieuTra.SMaPhieuTra, selectedItems, phieuTra.DNgayTra))
                    {
                        MessageBox.Show("Thêm phiếu trả mới thành công");
                        //tb_MaPhieuMuon.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm chi tiết phiếu trả thất bại !");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm phiếu trả mới thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuTraBLL.HienThiDataLenDataGridView(dgv_PhieuTra);
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


        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhieuTra phieuTra = new PhieuTra();
            phieuTra.SMaPhieuTra = tb_MaPhieuTra.Text;
            phieuTra.SMaPhieuMuon = cbb_MaPhieuMuon.Text;
            phieuTra.SMaNV = cbb_MaNV.Text;
            phieuTra.SMaDocGia = cbb_MaDG.Text;
            //string DSSach = string.Join("\n", selectedItems);
            phieuTra.SMaSach = cbb_MaSach.Text;
            
            phieuTra.DNgayTra = dateTime_NgayTra.Value;
            phieuTra.SMaTinhTrang = cbb_TinhTrang.Text;

            if (cbb_MaPhieuMuon.Text.Trim() != "" && cbb_MaNV.Text.Trim() != "" &&
                cbb_MaDG.Text.Trim() != "" && cbb_MaSach.Text.Trim() != "" &&
                cbb_TinhTrang.Text.Trim() != "" && tb_MaPhieuTra.Text.Trim() != "")
            {
                bool res = phieuTraBLL.SuaPT_BLL(phieuTra, MaSachCu);


                if (res == true)
                {
                    MessageBox.Show("Sửa phiếu trả thành công");

                    tb_MaPhieuTra.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa phiếu trả thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuTraBLL.HienThiDataLenDataGridView(dgv_PhieuTra);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhieuTra phieuTra = new PhieuTra();
            phieuTra.SMaPhieuTra = tb_MaPhieuTra.Text;

            if (tb_MaPhieuTra.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa phiếu xóa có mã: " + phieuTra.SMaPhieuTra + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = phieuTraBLL.XoaPT_BLL(phieuTra);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa phiếu trả thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu trả thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu trả trước khi xóa");
            }
            phieuTraBLL.HienThiDataLenDataGridView(dgv_PhieuTra);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemPT = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemPT))
            {
                dgv_PhieuTra.DataSource = phieuTraBLL.TimKiemPT_BLL(timKiemPT);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private string MaSachCu;
        private void dgv_PhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_PhieuTra.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaPhieuTra.Text = row.Cells["Mã phiếu trả"].Value.ToString();
                cbb_MaPhieuMuon.Text = row.Cells["Mã phiếu mượn"].Value.ToString();
                cbb_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
                cbb_MaDG.Text = row.Cells["Mã độc giả"].Value.ToString();

                lbl_DSSach.Text = row.Cells["Mã sách"].Value.ToString();
                MaSachCu = row.Cells["Mã sách"].Value.ToString();
                dateTime_NgayTra.Value = Convert.ToDateTime(row.Cells["Ngày trả"].Value);
                cbb_TinhTrang.Text = row.Cells["Tình trạng"].Value.ToString();

            }
        }
    }
}
