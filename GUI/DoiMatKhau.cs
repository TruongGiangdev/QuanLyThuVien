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
    public partial class f_DoiMatKhau : Form
    {   
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public f_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void f_DoiMatKhau_Load(object sender, EventArgs e)
        {
            lbl_TruyenTenDN.Text = f_DangNhap.LayTenDN;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {

            bool res = false;
            if(tb_MKCu.Text != "" && tb_MKMoi.Text != "" && tb_NhapLaiMK.Text != "" ) 
            {
                
                if (tb_MKMoi.Text == tb_NhapLaiMK.Text)
                {
                    res = TKBLL.DoiMK_BLL(f_DangNhap.LayTenDN, tb_MKCu.Text, tb_MKMoi.Text);
                    
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu mới!");
                }

                if(res == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }

            
        }

        
    }
}
