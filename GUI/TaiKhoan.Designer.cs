namespace GUI
{
    partial class f_TaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TenDN = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_QuyenHan = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.rad_Admin = new System.Windows.Forms.RadioButton();
            this.rad_User = new System.Windows.Forms.RadioButton();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.nhanVienTableAdapter = new GUI.QLTVDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(209, 305);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 60;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(209, 327);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 58;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(653, 204);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 57;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(455, 204);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 40);
            this.btn_Sua.TabIndex = 56;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(257, 204);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 55;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(205, 115);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(274, 27);
            this.tb_MatKhau.TabIndex = 52;
            // 
            // tb_TenDN
            // 
            this.tb_TenDN.Location = new System.Drawing.Point(205, 66);
            this.tb_TenDN.Name = "tb_TenDN";
            this.tb_TenDN.Size = new System.Drawing.Size(274, 27);
            this.tb_TenDN.TabIndex = 51;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(80, 118);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(77, 20);
            this.lbl_MatKhau.TabIndex = 49;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Location = new System.Drawing.Point(79, 69);
            this.lbl_TenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(119, 20);
            this.lbl_TenDN.TabIndex = 48;
            this.lbl_TenDN.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(209, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 74);
            this.panel1.TabIndex = 59;
            // 
            // lbl_QuyenHan
            // 
            this.lbl_QuyenHan.AutoSize = true;
            this.lbl_QuyenHan.Location = new System.Drawing.Point(571, 69);
            this.lbl_QuyenHan.Name = "lbl_QuyenHan";
            this.lbl_QuyenHan.Size = new System.Drawing.Size(89, 20);
            this.lbl_QuyenHan.TabIndex = 61;
            this.lbl_QuyenHan.Text = "Quyền hạn";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(571, 122);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(108, 20);
            this.lbl_MaNV.TabIndex = 62;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // rad_Admin
            // 
            this.rad_Admin.AutoSize = true;
            this.rad_Admin.Location = new System.Drawing.Point(715, 69);
            this.rad_Admin.Name = "rad_Admin";
            this.rad_Admin.Size = new System.Drawing.Size(77, 24);
            this.rad_Admin.TabIndex = 63;
            this.rad_Admin.TabStop = true;
            this.rad_Admin.Text = "Admin";
            this.rad_Admin.UseVisualStyleBackColor = true;
            // 
            // rad_User
            // 
            this.rad_User.AutoSize = true;
            this.rad_User.Location = new System.Drawing.Point(835, 69);
            this.rad_User.Name = "rad_User";
            this.rad_User.Size = new System.Drawing.Size(66, 24);
            this.rad_User.TabIndex = 64;
            this.rad_User.TabStop = true;
            this.rad_User.Text = "User";
            this.rad_User.UseVisualStyleBackColor = true;
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.nhanVienBindingSource;
            this.cbb_MaNV.DisplayMember = "sMaNV";
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(715, 115);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(186, 28);
            this.cbb_MaNV.TabIndex = 65;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(12, 360);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.RowHeadersWidth = 51;
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(976, 190);
            this.dgv_TaiKhoan.TabIndex = 66;
            this.dgv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellClick);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // f_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgv_TaiKhoan);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.rad_User);
            this.Controls.Add(this.rad_Admin);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lbl_QuyenHan);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenDN);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.f_TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TenDN;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_QuyenHan;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.RadioButton rad_Admin;
        private System.Windows.Forms.RadioButton rad_User;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLTVDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}