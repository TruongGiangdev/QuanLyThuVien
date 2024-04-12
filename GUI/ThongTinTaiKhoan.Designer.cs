namespace GUI
{
    partial class f_ThongTinTaiKhoan
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
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_DT = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.tb_TenNV = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_DT = new System.Windows.Forms.TextBox();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_ChinhSuaTT = new System.Windows.Forms.Button();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.tb_LayTenDN = new System.Windows.Forms.TextBox();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuTableAdapter = new GUI.QLTVDataSetTableAdapters.ChucVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(137, 120);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(108, 20);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Location = new System.Drawing.Point(137, 175);
            this.lbl_TenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(113, 20);
            this.lbl_TenNV.TabIndex = 1;
            this.lbl_TenNV.Text = "Tên nhân viên";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(137, 230);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lbl_GioiTinh.TabIndex = 2;
            this.lbl_GioiTinh.Text = "Giới tính ";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(137, 285);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_DT
            // 
            this.lbl_DT.AutoSize = true;
            this.lbl_DT.Location = new System.Drawing.Point(136, 340);
            this.lbl_DT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DT.Name = "lbl_DT";
            this.lbl_DT.Size = new System.Drawing.Size(84, 20);
            this.lbl_DT.TabIndex = 4;
            this.lbl_DT.Text = "Điện thoại";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(137, 395);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(83, 20);
            this.lbl_NgaySinh.TabIndex = 5;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(265, 117);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(276, 27);
            this.tb_MaNV.TabIndex = 6;
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.Location = new System.Drawing.Point(265, 172);
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.Size = new System.Drawing.Size(276, 27);
            this.tb_TenNV.TabIndex = 7;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(265, 282);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(276, 27);
            this.tb_DiaChi.TabIndex = 8;
            // 
            // tb_DT
            // 
            this.tb_DT.Location = new System.Drawing.Point(265, 337);
            this.tb_DT.Name = "tb_DT";
            this.tb_DT.Size = new System.Drawing.Size(276, 27);
            this.tb_DT.TabIndex = 9;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(265, 230);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(65, 24);
            this.rad_Nam.TabIndex = 10;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(416, 230);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(51, 24);
            this.rad_Nu.TabIndex = 11;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(265, 390);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(276, 27);
            this.dateTime_NgaySinh.TabIndex = 12;
            // 
            // btn_ChinhSuaTT
            // 
            this.btn_ChinhSuaTT.Location = new System.Drawing.Point(234, 526);
            this.btn_ChinhSuaTT.Name = "btn_ChinhSuaTT";
            this.btn_ChinhSuaTT.Size = new System.Drawing.Size(220, 53);
            this.btn_ChinhSuaTT.TabIndex = 13;
            this.btn_ChinhSuaTT.Text = "Chỉnh sửa thông tin";
            this.btn_ChinhSuaTT.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaTT.Click += new System.EventHandler(this.btn_ChinhSuaTT_Click);
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Location = new System.Drawing.Point(136, 68);
            this.lbl_TenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(119, 20);
            this.lbl_TenDN.TabIndex = 14;
            this.lbl_TenDN.Text = "Tên đăng nhập";
            // 
            // tb_LayTenDN
            // 
            this.tb_LayTenDN.Location = new System.Drawing.Point(265, 65);
            this.tb_LayTenDN.Name = "tb_LayTenDN";
            this.tb_LayTenDN.Size = new System.Drawing.Size(276, 27);
            this.tb_LayTenDN.TabIndex = 15;
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Location = new System.Drawing.Point(137, 453);
            this.lbl_ChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(70, 20);
            this.lbl_ChucVu.TabIndex = 16;
            this.lbl_ChucVu.Text = "Chức vụ";
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.DataSource = this.chucVuBindingSource;
            this.cbb_ChucVu.DisplayMember = "sMaChucVu";
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(265, 450);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(276, 28);
            this.cbb_ChucVu.TabIndex = 17;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.qLTVDataSet;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // f_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 647);
            this.Controls.Add(this.cbb_ChucVu);
            this.Controls.Add(this.lbl_ChucVu);
            this.Controls.Add(this.tb_LayTenDN);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.btn_ChinhSuaTT);
            this.Controls.Add(this.dateTime_NgaySinh);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.tb_DT);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_TenNV);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_DT);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.lbl_MaNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_ThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.f_ThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_DT;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.TextBox tb_TenNV;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_DT;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.Button btn_ChinhSuaTT;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.TextBox tb_LayTenDN;
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private QLTVDataSetTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
    }
}