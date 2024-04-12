namespace GUI
{
    partial class f_NhanVien
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
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_DT = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.tb_TenNV = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_DienThoai = new System.Windows.Forms.TextBox();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.chucVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new GUI.QLTVDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuTableAdapter = new GUI.QLTVDataSetTableAdapters.ChucVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(48, 57);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(108, 20);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(48, 106);
            this.lbl_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(113, 20);
            this.lbl_TenNhanVien.TabIndex = 1;
            this.lbl_TenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(557, 57);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lbl_GioiTinh.TabIndex = 2;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(48, 155);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_DT
            // 
            this.lbl_DT.AutoSize = true;
            this.lbl_DT.Location = new System.Drawing.Point(48, 204);
            this.lbl_DT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DT.Name = "lbl_DT";
            this.lbl_DT.Size = new System.Drawing.Size(84, 20);
            this.lbl_DT.TabIndex = 4;
            this.lbl_DT.Text = "Điện thoại";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(557, 106);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(83, 20);
            this.lbl_NgaySinh.TabIndex = 5;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Location = new System.Drawing.Point(558, 155);
            this.lbl_ChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(70, 20);
            this.lbl_ChucVu.TabIndex = 6;
            this.lbl_ChucVu.Text = "Chức vụ";
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(173, 54);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(274, 27);
            this.tb_MaNV.TabIndex = 7;
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.Location = new System.Drawing.Point(173, 103);
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.Size = new System.Drawing.Size(274, 27);
            this.tb_TenNV.TabIndex = 8;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(173, 152);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(274, 27);
            this.tb_DiaChi.TabIndex = 9;
            // 
            // tb_DienThoai
            // 
            this.tb_DienThoai.Location = new System.Drawing.Point(173, 201);
            this.tb_DienThoai.Name = "tb_DienThoai";
            this.tb_DienThoai.Size = new System.Drawing.Size(274, 27);
            this.tb_DienThoai.TabIndex = 10;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(685, 55);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(65, 24);
            this.rad_Nam.TabIndex = 11;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(822, 55);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(51, 24);
            this.rad_Nu.TabIndex = 12;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(652, 103);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(274, 27);
            this.dateTime_NgaySinh.TabIndex = 13;
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.DataSource = this.chucVuBindingSource1;
            this.cbb_ChucVu.DisplayMember = "sMaChucVu";
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(652, 152);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(274, 28);
            this.cbb_ChucVu.TabIndex = 14;
            // 
            // chucVuBindingSource1
            // 
            this.chucVuBindingSource1.DataMember = "ChucVu";
            this.chucVuBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(12, 452);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(989, 238);
            this.dgv_NhanVien.TabIndex = 15;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(256, 273);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(454, 273);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 40);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(652, 273);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(208, 419);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 20;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(208, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 74);
            this.panel1.TabIndex = 23;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(208, 397);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 24;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLTVDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // nhanVienBindingSource2
            // 
            this.nhanVienBindingSource2.DataMember = "NhanVien";
            this.nhanVienBindingSource2.DataSource = this.qLTVDataSet;
            // 
            // nhanVienBindingSource3
            // 
            this.nhanVienBindingSource3.DataMember = "NhanVien";
            this.nhanVienBindingSource3.DataSource = this.qLTVDataSet;
            // 
            // nhanVienBindingSource4
            // 
            this.nhanVienBindingSource4.DataMember = "NhanVien";
            this.nhanVienBindingSource4.DataSource = this.qLTVDataSet;
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
            // f_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 690);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.cbb_ChucVu);
            this.Controls.Add(this.dateTime_NgaySinh);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.tb_DienThoai);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_TenNV);
            this.Controls.Add(this.tb_MaNV);
            this.Controls.Add(this.lbl_ChucVu);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_DT);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_TenNhanVien);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.f_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_DT;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.TextBox tb_TenNV;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_DienThoai;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TimKiem;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLTVDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource3;
        private System.Windows.Forms.BindingSource nhanVienBindingSource4;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private QLTVDataSetTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.BindingSource chucVuBindingSource1;
    }
}