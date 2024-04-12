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
    public partial class f_ThongTinTaiKhoan : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public f_ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void f_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLTVDataSet.ChucVu);
            tb_LayTenDN.Enabled = false;
            tb_MaNV.Enabled = false;
            LayThongTinNV();
        }

        private void LayThongTinNV()
        {
            NhanVien nhanVien = new NhanVien();
            tb_LayTenDN.Text = f_DangNhap.LayTenDN;
            List<string> list = taiKhoanBLL.LayThongTinNV(f_DangNhap.LayTenDN);
            tb_MaNV.Text = list[0]; //vị trí thứ 0 là mã nv
            tb_TenNV.Text = list[1]; //vị trí thứ 1 là tên nv
            if (list[2] == "Nam")//vị trí thứ 2 là giới tính
            {
                rad_Nam.Checked = true;
                rad_Nu.Checked = false;
            }
            else 
            { 
                rad_Nu.Checked = true; 
                rad_Nam.Checked = false;
            }
            tb_DiaChi.Text = list[3]; //vị trí thứ 3 là địa chỉ
            tb_DT.Text = list[4];   //vị trí thứ 4 là số điện thoại
            dateTime_NgaySinh.Value = Convert.ToDateTime(list[5]); //vị trí thứ  5 là ngày sinh
            cbb_ChucVu.Text = list[6];
            
        }





        public bool CheckGioiTinh()
        {
            if (rad_Nam.Checked == true) { return true; }
            else { return false; }
        }
        private void btn_ChinhSuaTT_Click(object sender, EventArgs e)
        {
            if (tb_TenNV.Text.Trim() != "" && tb_MaNV.Text.Trim() != "" &&
                tb_DiaChi.Text.Trim() != "" && (rad_Nam.Checked == true || rad_Nu.Checked == true) &&
                tb_DT.Text.Trim() != "" && cbb_ChucVu.Text.Trim() != "")
            {
                bool res = taiKhoanBLL.SuaThongTinTK_BLL(tb_MaNV.Text, tb_TenNV.Text, CheckGioiTinh(),
                    tb_DiaChi.Text, tb_DT.Text, dateTime_NgaySinh.Value, cbb_ChucVu.Text);


                if (res == true)
                {
                    MessageBox.Show("Sửa tài khoản thành công");

                    tb_MaNV.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }
    }
}
