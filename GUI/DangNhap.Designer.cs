namespace GUI
{
    partial class f_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_DangNhap));
            this.lb__TenDangNhap = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.cb_GhiNhoDN = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb__TenDangNhap
            // 
            this.lb__TenDangNhap.AutoSize = true;
            this.lb__TenDangNhap.Location = new System.Drawing.Point(164, 254);
            this.lb__TenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb__TenDangNhap.Name = "lb__TenDangNhap";
            this.lb__TenDangNhap.Size = new System.Drawing.Size(119, 20);
            this.lb__TenDangNhap.TabIndex = 0;
            this.lb__TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Location = new System.Drawing.Point(184, 305);
            this.lb_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(77, 20);
            this.lb_MatKhau.TabIndex = 1;
            this.lb_MatKhau.Text = "Mật khẩu";
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.Location = new System.Drawing.Point(304, 251);
            this.tb_TenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(399, 27);
            this.tb_TenDangNhap.TabIndex = 2;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(304, 302);
            this.tb_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(399, 27);
            this.tb_MatKhau.TabIndex = 3;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(355, 406);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(140, 54);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // cb_GhiNhoDN
            // 
            this.cb_GhiNhoDN.AutoSize = true;
            this.cb_GhiNhoDN.Location = new System.Drawing.Point(355, 356);
            this.cb_GhiNhoDN.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GhiNhoDN.Name = "cb_GhiNhoDN";
            this.cb_GhiNhoDN.Size = new System.Drawing.Size(171, 24);
            this.cb_GhiNhoDN.TabIndex = 5;
            this.cb_GhiNhoDN.Text = "Ghi nhớ đăng nhập";
            this.cb_GhiNhoDN.UseVisualStyleBackColor = true;
            this.cb_GhiNhoDN.CheckedChanged += new System.EventHandler(this.cb_GhiNhoDN_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // f_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_GhiNhoDN);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDangNhap);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb__TenDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "f_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.f_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb__TenDangNhap;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.TextBox tb_TenDangNhap;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.CheckBox cb_GhiNhoDN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

