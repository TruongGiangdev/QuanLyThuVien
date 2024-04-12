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

namespace GUI
{
    public partial class f_TrangChu : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public f_TrangChu()
        {
            InitializeComponent();
        }

        private void addForm(Form f)
        {
            pn_Chinh.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            Text = f.Text;
            pn_Chinh.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            pn_Chinh.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void f_TrangChu_Load(object sender, EventArgs e)
        {
            f_DangNhap dangNhap = new f_DangNhap();
            PicMenu picMenu = new PicMenu();
            addForm(picMenu);

            CheckQuyen();

        }

        public void CheckQuyen() 
        {
            //lấy tên đăng nhập và tên quyền
            string user = f_DangNhap.LayTenDN;
            string CheckQuyen = tkBLL.LayTenQuyen(user);

            //check quyền là user hay admin
            if (CheckQuyen == "User")
            {
                menuStrip_NhanVien.Visible = false;
                menuStrip_Admin.Visible = false;
            }
        }

        private void home_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicMenu picMenu = new PicMenu();
            addForm(picMenu);
        }

        private void menuStrip_NhanVien_Click(object sender, EventArgs e)
        {
            f_NhanVien formNV = new f_NhanVien();
            addForm(formNV);
        }

        private void MenuStrip_Sach_Click(object sender, EventArgs e)
        {
            f_Sach formSach = new f_Sach(); 
            addForm(formSach);
        }

        private void MenuStrip_DocGia_Click(object sender, EventArgs e)
        {
            f_DocGia formDocGia = new f_DocGia();
            addForm(formDocGia);
        }

        private void MenuStrip_TacGia_Click(object sender, EventArgs e)
        {
            f_TacGia formTG = new f_TacGia();
            addForm(formTG);
        }

        private void MenuStrip_PhieuMuon_Click(object sender, EventArgs e)
        {
            f_PhieuMuon formPhieuMuon = new f_PhieuMuon();  
            addForm(formPhieuMuon);
        }

        private void MenuStrip_PhieuTra_Click(object sender, EventArgs e)
        {
            f_PhieuTra formPhieuTra = new f_PhieuTra(); 
            addForm(formPhieuTra);
        }

        private void MenuStrip_PhieuPhat_Click(object sender, EventArgs e)
        {
            f_PhieuPhat formPhieuPhat = new f_PhieuPhat();  
            addForm(formPhieuPhat);
        }

        private void dangXuat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_DangNhap formDangNhap = new f_DangNhap();
            formDangNhap.Show();
            this.Close();
        }

        private void menuStrip_Thoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void troGiup_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_TroGiup formTroGiup = new f_TroGiup();
            addForm(formTroGiup);
        }

        private void thongTinTaiKhoan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ThongTinTaiKhoan thongTinTK = new f_ThongTinTaiKhoan();
            thongTinTK.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_DoiMatKhau doiMK = new f_DoiMatKhau();
            doiMK.Show();
        }

        private void MenuStrip_ThemTKKhac_Click(object sender, EventArgs e)
        {
            f_TaiKhoan tk = new f_TaiKhoan();
            tk.Show();
        }
    }
}
