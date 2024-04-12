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
    public partial class f_PhieuPhat : Form
    {
        PhieuPhatBLL phieuPhatBLL = new PhieuPhatBLL();
        public f_PhieuPhat()
        {
            InitializeComponent();
        }

        private void f_PhieuPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.PhieuTra' table. You can move, or remove it, as needed.
            this.phieuTraTableAdapter.Fill(this.qLTVDataSet.PhieuTra);
            phieuPhatBLL.HienThiDataLenDataGridView(dgv_PhieuPhat);
            dgv_PhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_PhieuPhat.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhieuPhat phieuPhat = new PhieuPhat();
            phieuPhat.SMaPhieuPhat = tb_MaPhieuPhat.Text;
            phieuPhat.SMaPhieuTra = cbb_MaPhieuTra.Text;
            float tienPhat;
            bool chuyenDoi = float.TryParse(tb_TienPhat.Text, out tienPhat);
            phieuPhat.FTienPhat = tienPhat;
            phieuPhat.SNoiDung = tb_NoiDung.Text;

            if (tb_MaPhieuPhat.Text.Trim() != "" && cbb_MaPhieuTra.Text.Trim() != "" &&
                tb_NoiDung.Text.Trim() != "") 
            {
                bool res = phieuPhatBLL.ThemPhieuPhat_BLL(phieuPhat);


                if (res == true)
                {
                    MessageBox.Show("Thêm phiếu phạt mới thành công");

                    tb_MaPhieuPhat.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm phiếu phạt mới thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuPhatBLL.HienThiDataLenDataGridView(dgv_PhieuPhat);
        }

        private void dgv_PhieuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_PhieuPhat.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaPhieuPhat.Text = row.Cells["Mã phiếu phạt"].Value.ToString();
                cbb_MaPhieuTra.Text = row.Cells["Mã phiếu trả"].Value.ToString();
                tb_TienPhat.Text = row.Cells["Tiền phạt"].Value.ToString();
                tb_NoiDung.Text = row.Cells["Nội dung"].Value.ToString();

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            PhieuPhat phieuPhat = new PhieuPhat();
            phieuPhat.SMaPhieuPhat = tb_MaPhieuPhat.Text;
            phieuPhat.SMaPhieuTra = cbb_MaPhieuTra.Text;
            float tienPhat;
            bool chuyenDoi = float.TryParse(tb_TienPhat.Text, out tienPhat);
            phieuPhat.FTienPhat = tienPhat;
            phieuPhat.SNoiDung = tb_NoiDung.Text;

            if (tb_MaPhieuPhat.Text.Trim() != "" && cbb_MaPhieuTra.Text.Trim() != "" &&
                tb_NoiDung.Text.Trim() != "")
            {
                bool res = phieuPhatBLL.SuaPhieuPhat_BLL(phieuPhat);


                if (res == true)
                {
                    MessageBox.Show("Sửa phiếu phạt thành công");

                    //tb_MaPhieuPhat.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa phiếu phạt thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            phieuPhatBLL.HienThiDataLenDataGridView(dgv_PhieuPhat);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhieuPhat phieuPhat = new PhieuPhat();
            phieuPhat.SMaPhieuPhat = tb_MaPhieuPhat.Text;

            if (tb_MaPhieuPhat.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa phiếu phạt có mã: " + phieuPhat.SMaPhieuPhat + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = phieuPhatBLL.XoaPhieuPhat_BLL(phieuPhat.SMaPhieuPhat);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa phiếu phạt thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu phạt thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu phạt trước khi xóa");
            }
            phieuPhatBLL.HienThiDataLenDataGridView(dgv_PhieuPhat);

        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemPP = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemPP))
            {
                dgv_PhieuPhat.DataSource = phieuPhatBLL.TimKiemPhieuPhat_BLL(timKiemPP);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
