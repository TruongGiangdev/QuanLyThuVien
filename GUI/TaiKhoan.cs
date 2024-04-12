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
    public partial class f_TaiKhoan : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public f_TaiKhoan()
        {
            InitializeComponent();
        }

        private void f_TaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLTVDataSet.NhanVien);
            taiKhoanBLL.HienThiDataLenDataGridView(dgv_TaiKhoan);
            dgv_TaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TaiKhoan.AllowUserToAddRows = false;
        }

        private bool CheckQuyenHan()
        {
            if(rad_Admin.Checked) { return true;}
            else { return false;}
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.SLoginName = tb_TenDN.Text;
            taiKhoan.SMatKhau = tb_MatKhau.Text;
            taiKhoan.BQuyenHan = CheckQuyenHan();
            taiKhoan.SMaNV = cbb_MaNV.Text;

            if(tb_TenDN.Text.Trim() != "" && tb_MatKhau.Text.Trim() != "" && cbb_MaNV.Text.Trim() != "" &&
                (rad_Admin.Checked == true || rad_User.Checked == true))
            {
                bool res = taiKhoanBLL.ThemTK_BLL(taiKhoan);

                if(res)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }

            taiKhoanBLL.HienThiDataLenDataGridView(dgv_TaiKhoan);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.SLoginName = tb_TenDN.Text;
            taiKhoan.SMatKhau = tb_MatKhau.Text;
            taiKhoan.BQuyenHan = CheckQuyenHan();
            taiKhoan.SMaNV = cbb_MaNV.Text;

            if (tb_TenDN.Text.Trim() != "" && tb_MatKhau.Text.Trim() != "" && cbb_MaNV.Text.Trim() != "" &&
                (rad_Admin.Checked == true || rad_User.Checked == true))
            {
                bool res = taiKhoanBLL.SuaTK_BLL(taiKhoan);

                if (res)
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }

            taiKhoanBLL.HienThiDataLenDataGridView(dgv_TaiKhoan);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.SLoginName = tb_TenDN.Text;
            if (tb_TenDN.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa tài khoản: " + taiKhoan.SLoginName + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = taiKhoanBLL.XoaTK_BLL(taiKhoan);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa tài khoản thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản trước khi xóa");
            }
            taiKhoanBLL.HienThiDataLenDataGridView(dgv_TaiKhoan);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemTK = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemTK))
            {
                dgv_TaiKhoan.DataSource = taiKhoanBLL.TimKiemTK_BLL(timKiemTK);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_TaiKhoan.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_TenDN.Text = row.Cells["Tên đăng nhập"].Value.ToString();
                

                string quyenHan = row.Cells["Quyền hạn"].Value.ToString();
                if (quyenHan == "Admin")
                {
                    rad_Admin.Checked = true;
                    rad_User.Checked = false;
                }
                else if (quyenHan == "User")
                {
                    rad_Admin.Checked = false;
                    rad_User.Checked = true;
                }
                cbb_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
                
            }
        }
    }
}
