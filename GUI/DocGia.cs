using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class f_DocGia : Form
    {
        DocGiaBLL docGiaBLL = new DocGiaBLL();  
        public f_DocGia()
        {
            InitializeComponent();
        }

        private void f_DocGia_Load(object sender, EventArgs e)
        {
            docGiaBLL.HienThiDataLenDataGridView(dgv_DocGia);
            dgv_DocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DocGia.AllowUserToAddRows = false;
        }

        public bool CheckGioiTinh()
        {
            if (rad_Nam.Checked == true) { return true; }
            else { return false; }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.SMaDG = tb_MaDocGia.Text;
            docGia.STenDG = tb_TenDocGia.Text;
            docGia.BGioiTinh = CheckGioiTinh(); 
            docGia.SDiaChi = tb_DiaChi.Text;
            docGia.SSdt = tb_DienThoai.Text;
            docGia.DNgaySinh = dateTime_NgaySinh.Value;
            string ngaySinhFormatted = docGia.DNgaySinh.ToString("dd/MM/yyyy");

            if (tb_TenDocGia.Text.Trim() != "" && tb_MaDocGia.Text.Trim() != "" &&
                tb_DiaChi.Text.Trim() != "" && (rad_Nam.Checked == true || rad_Nu.Checked == true) &&
                tb_DienThoai.Text.Trim() != "")
            {
                bool res = docGiaBLL.ThemDG_BLL(docGia);

                if (res == true)
                {
                    MessageBox.Show("Thêm độc giả mới thành công");

                    tb_MaDocGia.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm độc giả mới thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            docGiaBLL.HienThiDataLenDataGridView(dgv_DocGia);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.SMaDG = tb_MaDocGia.Text;
            docGia.STenDG = tb_TenDocGia.Text;
            docGia.BGioiTinh = CheckGioiTinh(); 
            docGia.SDiaChi = tb_DiaChi.Text;
            docGia.SSdt = tb_DienThoai.Text;
            docGia.DNgaySinh = dateTime_NgaySinh.Value;
            string ngaySinhFormatted = docGia.DNgaySinh.ToString("dd/MM/yyyy");

            if (tb_TenDocGia.Text.Trim() != "" && tb_MaDocGia.Text.Trim() != "" &&
                tb_DiaChi.Text.Trim() != "" && (rad_Nam.Checked == true || rad_Nu.Checked == true) &&
                tb_DienThoai.Text.Trim() != "")
            {
                bool res = docGiaBLL.SuaDG_BLL(docGia);

                if (res == true)
                {
                    MessageBox.Show("Sửa độc giả thành công");

                    tb_MaDocGia.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa độc giả thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            docGiaBLL.HienThiDataLenDataGridView(dgv_DocGia);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.SMaDG = tb_MaDocGia.Text;
            if (tb_TenDocGia.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa độc giả có mã: " + docGia.SMaDG + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = docGiaBLL.XoaDG_BLL(docGia);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa độc giả thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa độc giả thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả trước khi xóa");
            }
            docGiaBLL.HienThiDataLenDataGridView(dgv_DocGia);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemDG = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemDG))
            {
                dgv_DocGia.DataSource = docGiaBLL.TimKiemDocGia_BLL(timKiemDG);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_DocGia.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaDocGia.Text = row.Cells["Mã độc giả"].Value.ToString();
                tb_TenDocGia.Text = row.Cells["Tên độc giả"].Value.ToString();

                string gioiTinh = row.Cells["Giới tính"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rad_Nam.Checked = true;
                    rad_Nu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rad_Nam.Checked = false;
                    rad_Nu.Checked = true;
                }
                tb_DiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                tb_DienThoai.Text = row.Cells["SDT"].Value.ToString();
                
              
                
                dateTime_NgaySinh.Value = Convert.ToDateTime(row.Cells["Ngày sinh"].Value);
            }
        }
    }
}
