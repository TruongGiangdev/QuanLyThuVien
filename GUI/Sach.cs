using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class f_Sach : Form
    {
        SachBLL sachBLL = new SachBLL();
        private List<string> selectedItems = new List<string>();
        public f_Sach()
        {
            InitializeComponent();
        }

        private void f_Sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter.Fill(this.qLTVDataSet.NhaXuatBan);
            // TODO: This line of code loads data into the 'qLTVDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.qLTVDataSet.TacGia);
            this.theLoaiSachTableAdapter.Fill(this.qLTVDataSet.TheLoaiSach);
            sachBLL.HienThiDataLenDataGridView(dgv_Sach);
            dgv_Sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Sach.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.SMaSach = tb_MaSach.Text;
            sach.STenSach = tb_TenSach.Text;
            sach.DNamXB = dateTime_NXB.Value;
            sach.ISoLuong = int.Parse(tb_SoLuong.Text);
            sach.FGia = float.Parse(tb_Gia.Text);
            sach.SMaLoai = cbb_MaLoai.Text;

            //thêm list tác giả
            string DanhsachTG = string.Join(",", selectedItems);
            sach.SMaTacGia = DanhsachTG;
            sach.SMaNXB = cbb_MaNXB.Text;

            if (tb_TenSach.Text.Trim() != "" && tb_MaSach.Text.Trim() != "" &&
                tb_SoLuong.Text.Trim() != "" && tb_Gia.Text.Trim() != "" &&
                cbb_MaLoai.Text.Trim() != "" && cbb_MaTacGia.Text.Trim() != "" &&
                cbb_MaNXB.Text.Trim() != "")
            {
                bool res = sachBLL.ThemSach_BLL(sach);

                if (res == true)
                {
                    MessageBox.Show("Thêm sách mới thành công");
                    tb_MaSach.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm sách mới thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            sachBLL.HienThiDataLenDataGridView(dgv_Sach);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.SMaSach = tb_MaSach.Text;
            sach.STenSach = tb_TenSach.Text;
            sach.DNamXB = dateTime_NXB.Value;
            sach.ISoLuong = int.Parse(tb_SoLuong.Text);
            sach.FGia = float.Parse(tb_Gia.Text);
            sach.SMaLoai = cbb_MaLoai.Text;

            //sửa list tg
            string DanhsachTG = string.Join(",", selectedItems);
            sach.SMaTacGia = DanhsachTG;
            sach.SMaNXB = cbb_MaNXB.Text;

            if (tb_TenSach.Text.Trim() != "" && tb_MaSach.Text.Trim() != "" &&
                tb_SoLuong.Text.Trim() != "" && tb_Gia.Text.Trim() != "" &&
                cbb_MaLoai.Text.Trim() != "" && cbb_MaTacGia.Text.Trim() != "" &&
                cbb_MaNXB.Text.Trim() != "")
            {
                bool res = sachBLL.SuaSach_BLL(sach);

                if (res == true)
                {
                    MessageBox.Show("Sửa thông tin sách thành công");
                    tb_MaSach.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sách thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            sachBLL.HienThiDataLenDataGridView(dgv_Sach);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.SMaSach = tb_MaSach.Text;
            if (tb_TenSach.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa sách có mã: " + sach.SMaSach + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool res = sachBLL.XoaSach_BLL(sach);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa sách thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách trước khi xóa");
            }
            sachBLL.HienThiDataLenDataGridView(dgv_Sach);
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemSach = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemSach))
            {
                dgv_Sach.DataSource = sachBLL.TimKiemSach_BLL(timKiemSach);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_Sach.Rows[e.RowIndex];
                

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaSach.Text = row.Cells["Mã sách"].Value.ToString();
                tb_TenSach.Text = row.Cells["Tên sách"].Value.ToString();

                // Chuyển đổi giá trị ngày sang định dạng dd/MM/yyyy
                
                dateTime_NXB.Value = Convert.ToDateTime(row.Cells["Năm xuất bản"].Value);


                tb_SoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                tb_Gia.Text = row.Cells["Giá"].Value.ToString();
                cbb_MaLoai.Text = row.Cells["Loại sách"].Value.ToString();
                cbb_MaNXB.Text = row.Cells["Nhà xuất bản"].Value.ToString();
                lbl_DSTG.Text = row.Cells["Mã tác giả"].Value.ToString();
            }
        }
        
        private void cbb_MaTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbb_MaTacGia.Text.Trim();

            if (!selectedItems.Contains(selectedItem))
            {
                selectedItems.Add(selectedItem);
            }
            lbl_DSTG.Text = string.Join(", ", selectedItems);
        }

        
    }
}
