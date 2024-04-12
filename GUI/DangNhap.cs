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
using BLL;

namespace GUI
{
    public partial class f_DangNhap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public f_DangNhap()
        {
            InitializeComponent();
        }

        public static string LayTenDN { get; set; }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            taiKhoan.SLoginName = tb_TenDangNhap.Text;
            taiKhoan.SMatKhau = tb_MatKhau.Text;
            string getUser = TKBLL.KiemTraDangNhapBLL(taiKhoan);

            if (tb_TenDangNhap.Text != "")
            {
                LayTenDN = tb_TenDangNhap.Text;
            }
            //kiểm tra xem có nhập không 
            switch (getUser)
            {
                case "sai tài khoản":
                    MessageBox.Show("Tài khoản không được trống!");
                    return;
                case "sai mật khẩu":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "tên đăng nhập hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Đăng nhập thành công!");
            f_TrangChu formHome = new f_TrangChu();
            formHome.ShowDialog();
            Hide();
            
        }

        
        

        private void cb_GhiNhoDN_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void f_DangNhap_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}
