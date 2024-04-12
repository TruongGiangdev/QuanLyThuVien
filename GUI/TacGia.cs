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
    public partial class f_TacGia : Form
    {
        TacGiaBLL tacGiaBLL = new TacGiaBLL();  
        public f_TacGia()
        {
            InitializeComponent();


        }

        private void f_TacGia_Load(object sender, EventArgs e)
        {
            tacGiaBLL.HienThiDataLenDataGridView(dgv_TacGia);
            dgv_TacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TacGia.AllowUserToAddRows = false;
        }

        public bool CheckGioiTinh()
        {
            if (rad_Nam.Checked == true) { return true; }
            else { return false; }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.SMaTG = tb_MaTacGia.Text;
            tacGia.STenTG = tb_TenTacGia.Text;
            tacGia.BGioiTinh = CheckGioiTinh();
            

            if (tb_TenTacGia.Text.Trim() != "" && tb_MaTacGia.Text.Trim() != "" &&
                (rad_Nam.Checked || rad_Nu.Checked))
            {
                bool res = tacGiaBLL.ThemTG_BLL(tacGia);

                if (res)
                {
                    MessageBox.Show("Thêm tác giả mới thành công");

                    tb_MaTacGia.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm tác giả mới thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            tacGiaBLL.HienThiDataLenDataGridView(dgv_TacGia);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.SMaTG = tb_MaTacGia.Text;
            tacGia.STenTG = tb_TenTacGia.Text;
            tacGia.BGioiTinh = CheckGioiTinh();
            

            if (tb_TenTacGia.Text.Trim() != "" && tb_MaTacGia.Text.Trim() != "" &&
               (rad_Nam.Checked || rad_Nu.Checked))
            {
                bool res = tacGiaBLL.SuaTG_BLL(tacGia);

                if (res)
                {
                    MessageBox.Show("Sửa tác giả thành công");

                    tb_MaTacGia.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa tác giả thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            tacGiaBLL.HienThiDataLenDataGridView(dgv_TacGia);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.SMaTG = tb_MaTacGia.Text;
            if (tb_TenTacGia.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa tác giả có mã: " + tacGia.SMaTG + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = tacGiaBLL.XoaTG_BLL(tacGia);
                    if (res)
                    {
                        MessageBox.Show("Xóa tác giả thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác giả trước khi xóa");
            }
            tacGiaBLL.HienThiDataLenDataGridView(dgv_TacGia);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemTG = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemTG))
            {
                dgv_TacGia.DataSource = tacGiaBLL.TimKiemTacGia_BLL(timKiemTG);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_TacGia.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaTacGia.Text = row.Cells["Mã tác giả"].Value.ToString();
                tb_TenTacGia.Text = row.Cells["Tên tác giả"].Value.ToString();

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
                
            }
        }
    }
}
