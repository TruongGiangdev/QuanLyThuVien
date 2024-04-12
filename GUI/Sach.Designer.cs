namespace GUI
{
    partial class f_Sach
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
            this.cbb_MaLoai = new System.Windows.Forms.ComboBox();
            this.theLoaiSachBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.dateTime_NXB = new System.Windows.Forms.DateTimePicker();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.tb_TenSach = new System.Windows.Forms.TextBox();
            this.tb_MaSach = new System.Windows.Forms.TextBox();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.lbl_MaTacGia = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_NamXB = new System.Windows.Forms.Label();
            this.cbb_MaTacGia = new System.Windows.Forms.ComboBox();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_MaNXB = new System.Windows.Forms.ComboBox();
            this.nhaXuatBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.theLoaiSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiSachTableAdapter = new GUI.QLTVDataSetTableAdapters.TheLoaiSachTableAdapter();
            this.theLoaiSachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter = new GUI.QLTVDataSetTableAdapters.TacGiaTableAdapter();
            this.nhaXuatBanTableAdapter = new GUI.QLTVDataSetTableAdapters.NhaXuatBanTableAdapter();
            this.lbl_DSTG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(201, 466);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 47;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(201, 488);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 44;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(645, 382);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(447, 382);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 40);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(249, 382);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_MaLoai
            // 
            this.cbb_MaLoai.DataSource = this.theLoaiSachBindingSource2;
            this.cbb_MaLoai.DisplayMember = "sMaTheLoai";
            this.cbb_MaLoai.FormattingEnabled = true;
            this.cbb_MaLoai.Location = new System.Drawing.Point(674, 102);
            this.cbb_MaLoai.Name = "cbb_MaLoai";
            this.cbb_MaLoai.Size = new System.Drawing.Size(274, 28);
            this.cbb_MaLoai.TabIndex = 39;
            // 
            // theLoaiSachBindingSource2
            // 
            this.theLoaiSachBindingSource2.DataMember = "TheLoaiSach";
            this.theLoaiSachBindingSource2.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTime_NXB
            // 
            this.dateTime_NXB.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NXB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NXB.Location = new System.Drawing.Point(674, 54);
            this.dateTime_NXB.Name = "dateTime_NXB";
            this.dateTime_NXB.Size = new System.Drawing.Size(274, 27);
            this.dateTime_NXB.TabIndex = 38;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(171, 152);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(274, 27);
            this.tb_Gia.TabIndex = 35;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(171, 198);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(274, 27);
            this.tb_SoLuong.TabIndex = 34;
            // 
            // tb_TenSach
            // 
            this.tb_TenSach.Location = new System.Drawing.Point(171, 103);
            this.tb_TenSach.Name = "tb_TenSach";
            this.tb_TenSach.Size = new System.Drawing.Size(274, 27);
            this.tb_TenSach.TabIndex = 33;
            // 
            // tb_MaSach
            // 
            this.tb_MaSach.Location = new System.Drawing.Point(171, 54);
            this.tb_MaSach.Name = "tb_MaSach";
            this.tb_MaSach.Size = new System.Drawing.Size(274, 27);
            this.tb_MaSach.TabIndex = 32;
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Location = new System.Drawing.Point(531, 158);
            this.lbl_MaNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(132, 20);
            this.lbl_MaNXB.TabIndex = 31;
            this.lbl_MaNXB.Text = "Mã nhà xuất bản";
            // 
            // lbl_MaTacGia
            // 
            this.lbl_MaTacGia.AutoSize = true;
            this.lbl_MaTacGia.Location = new System.Drawing.Point(531, 204);
            this.lbl_MaTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaTacGia.Name = "lbl_MaTacGia";
            this.lbl_MaTacGia.Size = new System.Drawing.Size(98, 20);
            this.lbl_MaTacGia.TabIndex = 30;
            this.lbl_MaTacGia.Text = "Mã tác giả *";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.Location = new System.Drawing.Point(75, 155);
            this.lbl_Gia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(35, 20);
            this.lbl_Gia.TabIndex = 29;
            this.lbl_Gia.Text = "Giá";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(75, 201);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 20);
            this.lbl_SoLuong.TabIndex = 28;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Location = new System.Drawing.Point(531, 105);
            this.lbl_MaLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(63, 20);
            this.lbl_MaLoai.TabIndex = 27;
            this.lbl_MaLoai.Text = "Mã loại";
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Location = new System.Drawing.Point(75, 106);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(78, 20);
            this.lbl_TenSach.TabIndex = 26;
            this.lbl_TenSach.Text = "Tên sách";
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(75, 57);
            this.lbl_MaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(73, 20);
            this.lbl_MaSach.TabIndex = 25;
            this.lbl_MaSach.Text = "Mã sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(201, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 74);
            this.panel1.TabIndex = 46;
            // 
            // lbl_NamXB
            // 
            this.lbl_NamXB.AutoSize = true;
            this.lbl_NamXB.Location = new System.Drawing.Point(531, 57);
            this.lbl_NamXB.Name = "lbl_NamXB";
            this.lbl_NamXB.Size = new System.Drawing.Size(112, 20);
            this.lbl_NamXB.TabIndex = 48;
            this.lbl_NamXB.Text = "Năm xuất bản";
            // 
            // cbb_MaTacGia
            // 
            this.cbb_MaTacGia.DataSource = this.tacGiaBindingSource;
            this.cbb_MaTacGia.DisplayMember = "sMaTacGia";
            this.cbb_MaTacGia.FormattingEnabled = true;
            this.cbb_MaTacGia.Location = new System.Drawing.Point(674, 201);
            this.cbb_MaTacGia.Name = "cbb_MaTacGia";
            this.cbb_MaTacGia.Size = new System.Drawing.Size(274, 28);
            this.cbb_MaTacGia.TabIndex = 49;
            this.cbb_MaTacGia.SelectedIndexChanged += new System.EventHandler(this.cbb_MaTacGia_SelectedIndexChanged);
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.qLTVDataSet;
            // 
            // cbb_MaNXB
            // 
            this.cbb_MaNXB.DataSource = this.nhaXuatBanBindingSource;
            this.cbb_MaNXB.DisplayMember = "sMaNXB";
            this.cbb_MaNXB.FormattingEnabled = true;
            this.cbb_MaNXB.Location = new System.Drawing.Point(674, 155);
            this.cbb_MaNXB.Name = "cbb_MaNXB";
            this.cbb_MaNXB.Size = new System.Drawing.Size(274, 28);
            this.cbb_MaNXB.TabIndex = 50;
            // 
            // nhaXuatBanBindingSource
            // 
            this.nhaXuatBanBindingSource.DataMember = "NhaXuatBan";
            this.nhaXuatBanBindingSource.DataSource = this.qLTVDataSet;
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(12, 522);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.RowTemplate.Height = 24;
            this.dgv_Sach.Size = new System.Drawing.Size(989, 226);
            this.dgv_Sach.TabIndex = 51;
            this.dgv_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellClick);
            // 
            // theLoaiSachBindingSource
            // 
            this.theLoaiSachBindingSource.DataMember = "TheLoaiSach";
            this.theLoaiSachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // theLoaiSachTableAdapter
            // 
            this.theLoaiSachTableAdapter.ClearBeforeFill = true;
            // 
            // theLoaiSachBindingSource1
            // 
            this.theLoaiSachBindingSource1.DataMember = "TheLoaiSach";
            this.theLoaiSachBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // nhaXuatBanTableAdapter
            // 
            this.nhaXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_DSTG
            // 
            this.lbl_DSTG.BackColor = System.Drawing.Color.White;
            this.lbl_DSTG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DSTG.Location = new System.Drawing.Point(535, 255);
            this.lbl_DSTG.Name = "lbl_DSTG";
            this.lbl_DSTG.Size = new System.Drawing.Size(413, 92);
            this.lbl_DSTG.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "* Có thể chọn nhiều lựa chọn";
            // 
            // f_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DSTG);
            this.Controls.Add(this.dgv_Sach);
            this.Controls.Add(this.cbb_MaNXB);
            this.Controls.Add(this.cbb_MaTacGia);
            this.Controls.Add(this.lbl_NamXB);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cbb_MaLoai);
            this.Controls.Add(this.dateTime_NXB);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.tb_SoLuong);
            this.Controls.Add(this.tb_TenSach);
            this.Controls.Add(this.tb_MaSach);
            this.Controls.Add(this.lbl_MaNXB);
            this.Controls.Add(this.lbl_MaTacGia);
            this.Controls.Add(this.lbl_Gia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_MaLoai);
            this.Controls.Add(this.lbl_TenSach);
            this.Controls.Add(this.lbl_MaSach);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.f_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiSachBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbb_MaLoai;
        private System.Windows.Forms.DateTimePicker dateTime_NXB;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.TextBox tb_TenSach;
        private System.Windows.Forms.TextBox tb_MaSach;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.Label lbl_MaTacGia;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_NamXB;
        private System.Windows.Forms.ComboBox cbb_MaTacGia;
        private System.Windows.Forms.ComboBox cbb_MaNXB;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource theLoaiSachBindingSource;
        private QLTVDataSetTableAdapters.TheLoaiSachTableAdapter theLoaiSachTableAdapter;
        private System.Windows.Forms.BindingSource theLoaiSachBindingSource1;
        private System.Windows.Forms.BindingSource theLoaiSachBindingSource2;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private QLTVDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private System.Windows.Forms.BindingSource nhaXuatBanBindingSource;
        private QLTVDataSetTableAdapters.NhaXuatBanTableAdapter nhaXuatBanTableAdapter;
        private System.Windows.Forms.Label lbl_DSTG;
        private System.Windows.Forms.Label label1;
    }
}