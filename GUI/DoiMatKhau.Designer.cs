namespace GUI
{
    partial class f_DoiMatKhau
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
            this.lb_MatKhauHienTai = new System.Windows.Forms.Label();
            this.lbl_MatKhauMoi = new System.Windows.Forms.Label();
            this.lbl_NhapLai = new System.Windows.Forms.Label();
            this.tb_MKCu = new System.Windows.Forms.TextBox();
            this.tb_MKMoi = new System.Windows.Forms.TextBox();
            this.tb_NhapLaiMK = new System.Windows.Forms.TextBox();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.lbl_TruyenTenDN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MatKhauHienTai
            // 
            this.lb_MatKhauHienTai.AutoSize = true;
            this.lb_MatKhauHienTai.Location = new System.Drawing.Point(82, 79);
            this.lb_MatKhauHienTai.Name = "lb_MatKhauHienTai";
            this.lb_MatKhauHienTai.Size = new System.Drawing.Size(136, 20);
            this.lb_MatKhauHienTai.TabIndex = 6;
            this.lb_MatKhauHienTai.Text = "Mật khẩu hiện tại";
            // 
            // lbl_MatKhauMoi
            // 
            this.lbl_MatKhauMoi.AutoSize = true;
            this.lbl_MatKhauMoi.Location = new System.Drawing.Point(82, 130);
            this.lbl_MatKhauMoi.Name = "lbl_MatKhauMoi";
            this.lbl_MatKhauMoi.Size = new System.Drawing.Size(109, 20);
            this.lbl_MatKhauMoi.TabIndex = 7;
            this.lbl_MatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbl_NhapLai
            // 
            this.lbl_NhapLai.AutoSize = true;
            this.lbl_NhapLai.Location = new System.Drawing.Point(82, 181);
            this.lbl_NhapLai.Name = "lbl_NhapLai";
            this.lbl_NhapLai.Size = new System.Drawing.Size(175, 20);
            this.lbl_NhapLai.TabIndex = 8;
            this.lbl_NhapLai.Text = "Nhập lại mật khẩu mới";
            // 
            // tb_MKCu
            // 
            this.tb_MKCu.Location = new System.Drawing.Point(266, 79);
            this.tb_MKCu.Name = "tb_MKCu";
            this.tb_MKCu.Size = new System.Drawing.Size(285, 27);
            this.tb_MKCu.TabIndex = 1;
            // 
            // tb_MKMoi
            // 
            this.tb_MKMoi.Location = new System.Drawing.Point(266, 127);
            this.tb_MKMoi.Name = "tb_MKMoi";
            this.tb_MKMoi.Size = new System.Drawing.Size(285, 27);
            this.tb_MKMoi.TabIndex = 2;
            // 
            // tb_NhapLaiMK
            // 
            this.tb_NhapLaiMK.Location = new System.Drawing.Point(266, 178);
            this.tb_NhapLaiMK.Name = "tb_NhapLaiMK";
            this.tb_NhapLaiMK.Size = new System.Drawing.Size(285, 27);
            this.tb_NhapLaiMK.TabIndex = 3;
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(238, 229);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(142, 46);
            this.btn_DoiMatKhau.TabIndex = 4;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = true;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDN.Location = new System.Drawing.Point(12, 9);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(115, 16);
            this.lbl_TenDN.TabIndex = 9;
            this.lbl_TenDN.Text = "Tên đăng nhập:";
            // 
            // lbl_TruyenTenDN
            // 
            this.lbl_TruyenTenDN.AutoSize = true;
            this.lbl_TruyenTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TruyenTenDN.Location = new System.Drawing.Point(133, 9);
            this.lbl_TruyenTenDN.Name = "lbl_TruyenTenDN";
            this.lbl_TruyenTenDN.Size = new System.Drawing.Size(217, 16);
            this.lbl_TruyenTenDN.TabIndex = 10;
            this.lbl_TruyenTenDN.Text = "Truyền tên đăng nhập vào đây";
            // 
            // f_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 340);
            this.Controls.Add(this.lbl_TruyenTenDN);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.tb_NhapLaiMK);
            this.Controls.Add(this.tb_MKMoi);
            this.Controls.Add(this.tb_MKCu);
            this.Controls.Add(this.lbl_NhapLai);
            this.Controls.Add(this.lbl_MatKhauMoi);
            this.Controls.Add(this.lb_MatKhauHienTai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.f_DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MatKhauHienTai;
        private System.Windows.Forms.Label lbl_MatKhauMoi;
        private System.Windows.Forms.Label lbl_NhapLai;
        private System.Windows.Forms.TextBox tb_MKCu;
        private System.Windows.Forms.TextBox tb_MKMoi;
        private System.Windows.Forms.TextBox tb_NhapLaiMK;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.Label lbl_TruyenTenDN;
    }
}