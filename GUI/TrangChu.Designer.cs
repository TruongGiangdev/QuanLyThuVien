namespace GUI
{
    partial class f_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_TrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.home_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Sach = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_DocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_TacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.phieu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_PhieuMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_PhieuTra = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_PhieuPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoan_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinTaiKhoan_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ThemTKKhac = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiup_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Chinh = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_ToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.taiKhoan_ToolStripMenuItem,
            this.troGiup_ToolStripMenuItem,
            this.menuStrip_Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // home_ToolStripMenuItem
            // 
            this.home_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("home_ToolStripMenuItem.Image")));
            this.home_ToolStripMenuItem.Name = "home_ToolStripMenuItem";
            this.home_ToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.home_ToolStripMenuItem.Text = "Home";
            this.home_ToolStripMenuItem.Click += new System.EventHandler(this.home_ToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLy_ToolStripMenuItem,
            this.phieu_ToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quanLy_ToolStripMenuItem
            // 
            this.quanLy_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_NhanVien,
            this.MenuStrip_Sach,
            this.MenuStrip_DocGia,
            this.MenuStrip_TacGia});
            this.quanLy_ToolStripMenuItem.Name = "quanLy_ToolStripMenuItem";
            this.quanLy_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLy_ToolStripMenuItem.Text = "Quản lý";
            // 
            // menuStrip_NhanVien
            // 
            this.menuStrip_NhanVien.Name = "menuStrip_NhanVien";
            this.menuStrip_NhanVien.Size = new System.Drawing.Size(158, 26);
            this.menuStrip_NhanVien.Text = "Nhân viên";
            this.menuStrip_NhanVien.Click += new System.EventHandler(this.menuStrip_NhanVien_Click);
            // 
            // MenuStrip_Sach
            // 
            this.MenuStrip_Sach.Name = "MenuStrip_Sach";
            this.MenuStrip_Sach.Size = new System.Drawing.Size(158, 26);
            this.MenuStrip_Sach.Text = "Sách";
            this.MenuStrip_Sach.Click += new System.EventHandler(this.MenuStrip_Sach_Click);
            // 
            // MenuStrip_DocGia
            // 
            this.MenuStrip_DocGia.Name = "MenuStrip_DocGia";
            this.MenuStrip_DocGia.Size = new System.Drawing.Size(158, 26);
            this.MenuStrip_DocGia.Text = "Độc giả";
            this.MenuStrip_DocGia.Click += new System.EventHandler(this.MenuStrip_DocGia_Click);
            // 
            // MenuStrip_TacGia
            // 
            this.MenuStrip_TacGia.Name = "MenuStrip_TacGia";
            this.MenuStrip_TacGia.Size = new System.Drawing.Size(158, 26);
            this.MenuStrip_TacGia.Text = "Tác giả";
            this.MenuStrip_TacGia.Click += new System.EventHandler(this.MenuStrip_TacGia_Click);
            // 
            // phieu_ToolStripMenuItem
            // 
            this.phieu_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_PhieuMuon,
            this.MenuStrip_PhieuTra,
            this.MenuStrip_PhieuPhat});
            this.phieu_ToolStripMenuItem.Name = "phieu_ToolStripMenuItem";
            this.phieu_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phieu_ToolStripMenuItem.Text = "Phiếu";
            // 
            // MenuStrip_PhieuMuon
            // 
            this.MenuStrip_PhieuMuon.Name = "MenuStrip_PhieuMuon";
            this.MenuStrip_PhieuMuon.Size = new System.Drawing.Size(171, 26);
            this.MenuStrip_PhieuMuon.Text = "Phiếu mượn";
            this.MenuStrip_PhieuMuon.Click += new System.EventHandler(this.MenuStrip_PhieuMuon_Click);
            // 
            // MenuStrip_PhieuTra
            // 
            this.MenuStrip_PhieuTra.Name = "MenuStrip_PhieuTra";
            this.MenuStrip_PhieuTra.Size = new System.Drawing.Size(171, 26);
            this.MenuStrip_PhieuTra.Text = "Phiếu trả";
            this.MenuStrip_PhieuTra.Click += new System.EventHandler(this.MenuStrip_PhieuTra_Click);
            // 
            // MenuStrip_PhieuPhat
            // 
            this.MenuStrip_PhieuPhat.Name = "MenuStrip_PhieuPhat";
            this.MenuStrip_PhieuPhat.Size = new System.Drawing.Size(171, 26);
            this.MenuStrip_PhieuPhat.Text = "Phiếu phạt";
            this.MenuStrip_PhieuPhat.Click += new System.EventHandler(this.MenuStrip_PhieuPhat_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thongKeToolStripMenuItem.Text = "Báo cáo";
            // 
            // taiKhoan_ToolStripMenuItem
            // 
            this.taiKhoan_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinTaiKhoan_ToolStripMenuItem,
            this.doiMatKhauToolStripMenuItem,
            this.menuStrip_Admin,
            this.dangXuat_ToolStripMenuItem});
            this.taiKhoan_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taiKhoan_ToolStripMenuItem.Image")));
            this.taiKhoan_ToolStripMenuItem.Name = "taiKhoan_ToolStripMenuItem";
            this.taiKhoan_ToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.taiKhoan_ToolStripMenuItem.Text = "Tài khoản";
            // 
            // thongTinTaiKhoan_ToolStripMenuItem
            // 
            this.thongTinTaiKhoan_ToolStripMenuItem.Name = "thongTinTaiKhoan_ToolStripMenuItem";
            this.thongTinTaiKhoan_ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thongTinTaiKhoan_ToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thongTinTaiKhoan_ToolStripMenuItem.Click += new System.EventHandler(this.thongTinTaiKhoan_ToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // menuStrip_Admin
            // 
            this.menuStrip_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_ThemTKKhac});
            this.menuStrip_Admin.Name = "menuStrip_Admin";
            this.menuStrip_Admin.Size = new System.Drawing.Size(220, 26);
            this.menuStrip_Admin.Text = "Admin";
            // 
            // MenuStrip_ThemTKKhac
            // 
            this.MenuStrip_ThemTKKhac.Name = "MenuStrip_ThemTKKhac";
            this.MenuStrip_ThemTKKhac.Size = new System.Drawing.Size(228, 26);
            this.MenuStrip_ThemTKKhac.Text = "Thêm tài khoản khác";
            this.MenuStrip_ThemTKKhac.Click += new System.EventHandler(this.MenuStrip_ThemTKKhac_Click);
            // 
            // dangXuat_ToolStripMenuItem
            // 
            this.dangXuat_ToolStripMenuItem.Name = "dangXuat_ToolStripMenuItem";
            this.dangXuat_ToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.dangXuat_ToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuat_ToolStripMenuItem.Click += new System.EventHandler(this.dangXuat_ToolStripMenuItem_Click);
            // 
            // troGiup_ToolStripMenuItem
            // 
            this.troGiup_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("troGiup_ToolStripMenuItem.Image")));
            this.troGiup_ToolStripMenuItem.Name = "troGiup_ToolStripMenuItem";
            this.troGiup_ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.troGiup_ToolStripMenuItem.Text = "Trợ giúp";
            this.troGiup_ToolStripMenuItem.Click += new System.EventHandler(this.troGiup_ToolStripMenuItem_Click);
            // 
            // menuStrip_Thoat
            // 
            this.menuStrip_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("menuStrip_Thoat.Image")));
            this.menuStrip_Thoat.Name = "menuStrip_Thoat";
            this.menuStrip_Thoat.Size = new System.Drawing.Size(81, 24);
            this.menuStrip_Thoat.Text = "Thoát";
            this.menuStrip_Thoat.Click += new System.EventHandler(this.menuStrip_Thoat_Click);
            // 
            // pn_Chinh
            // 
            this.pn_Chinh.Location = new System.Drawing.Point(0, 31);
            this.pn_Chinh.Name = "pn_Chinh";
            this.pn_Chinh.Size = new System.Drawing.Size(1066, 697);
            this.pn_Chinh.TabIndex = 1;
            // 
            // f_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 728);
            this.Controls.Add(this.pn_Chinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "f_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.f_TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem home_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoan_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLy_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiup_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoan_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuat_ToolStripMenuItem;
        private System.Windows.Forms.Panel pn_Chinh;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Sach;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_DocGia;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_TacGia;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_PhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_PhieuTra;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_PhieuPhat;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Thoat;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Admin;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_ThemTKKhac;
    }
}