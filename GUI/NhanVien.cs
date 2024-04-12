using BLL;
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
using System.Reflection;

namespace GUI
{
    public partial class f_NhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL(); 
        public f_NhanVien()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void f_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLTVDataSet.ChucVu);
            nhanVienBLL.HienThiDataLenDataGridView(dgv_NhanVien);
            dgv_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NhanVien.AllowUserToAddRows = false;
        }

        public bool CheckGioiTinh()
        {
            if (rad_Nam.Checked == true) { return true; }
            else { return false; }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.SMaNV = tb_MaNV.Text;
            nhanVien.STenNV= tb_TenNV.Text;
            nhanVien.BGioiTinh = CheckGioiTinh();
            nhanVien.SDiaChi = tb_DiaChi.Text;
            nhanVien.SDT = tb_DienThoai.Text;
            nhanVien.SMaChucVu = cbb_ChucVu.Text;
            nhanVien.DNgaySinh = dateTime_NgaySinh.Value;
            //string ngaySinhFormatted = nhanVien.DNgaySinh.ToString("dd/MM/yyyy");

            if (tb_TenNV.Text.Trim() != "" && tb_MaNV.Text.Trim() != "" &&
                tb_DiaChi.Text.Trim() != "" && (rad_Nam.Checked == true || rad_Nu.Checked == true) &&
                tb_DienThoai.Text.Trim() != "" && cbb_ChucVu.Text.Trim() != "")
            {
                bool res = nhanVienBLL.ThemNV_BLL(nhanVien);


                if (res == true)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công");
                    
                    tb_MaNV.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên mới thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            nhanVienBLL.HienThiDataLenDataGridView(dgv_NhanVien);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.SMaNV = tb_MaNV.Text;
            nhanVien.STenNV = tb_TenNV.Text;
            nhanVien.BGioiTinh = CheckGioiTinh();
            nhanVien.SDiaChi = tb_DiaChi.Text;
            nhanVien.SDT = tb_DienThoai.Text;
            nhanVien.SMaChucVu = cbb_ChucVu.Text;
            nhanVien.DNgaySinh = dateTime_NgaySinh.Value;
           

            if (tb_TenNV.Text.Trim() != "" && tb_MaNV.Text.Trim() != "" &&
                tb_DiaChi.Text.Trim() != "" && (rad_Nam.Checked == true || rad_Nu.Checked == true) &&
                tb_DienThoai.Text.Trim() != "" && cbb_ChucVu.Text.Trim() != "")
            {
                bool res = nhanVienBLL.SuaNV_BLL(nhanVien);


                if (res == true)
                {
                    MessageBox.Show("Sửa nhân viên thành công");

                    tb_MaNV.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            nhanVienBLL.HienThiDataLenDataGridView(dgv_NhanVien);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.SMaNV = tb_MaNV.Text;
            if (tb_TenNV.Text.Trim() != "") 
            {
                DialogResult result = MessageBox.Show
                    ("Bạn chắc chắn muốn xóa nhân viên có mã: " + nhanVien.SMaNV + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    bool res = nhanVienBLL.XoaNV_BLL(nhanVien);
                    if (res == true)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi xóa");
            }
            nhanVienBLL.HienThiDataLenDataGridView(dgv_NhanVien);
        }

        private void cbb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng tương ứng với ô được chọn
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                // Điền thông tin từ dòng được chọn vào các control
                tb_MaNV.Text = row.Cells["Mã nhân viên"].Value.ToString();
                tb_TenNV.Text = row.Cells["Tên nhân viên"].Value.ToString();

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
                cbb_ChucVu.Text = row.Cells["Tên chức vụ"].Value.ToString();
                
                
                dateTime_NgaySinh.Value = Convert.ToDateTime(row.Cells["Ngày sinh"].Value);
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiemNV = tb_TimKiem.Text;
            if (!string.IsNullOrEmpty(timKiemNV))
            {
                dgv_NhanVien.DataSource = nhanVienBLL.TimKiemNhanVien_BLL(timKiemNV);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
