namespace GUI
{
    partial class f_PhieuMuon
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
            this.lbl_MaPhieuMuon = new System.Windows.Forms.Label();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.cbb_MaDocGia = new System.Windows.Forms.ComboBox();
            this.docGiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.docGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_MaSach = new System.Windows.Forms.ComboBox();
            this.sachBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTime_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dateTime_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.tb_MaPhieuMuon = new System.Windows.Forms.TextBox();
            this.pn_ThemSuaXoa = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.docGiaTableAdapter = new GUI.QLTVDataSetTableAdapters.DocGiaTableAdapter();
            this.nhanVienTableAdapter = new GUI.QLTVDataSetTableAdapters.NhanVienTableAdapter();
            this.sachTableAdapter = new GUI.QLTVDataSetTableAdapters.SachTableAdapter();
            this.lbl_DSSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.pn_ThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaPhieuMuon
            // 
            this.lbl_MaPhieuMuon.AutoSize = true;
            this.lbl_MaPhieuMuon.Location = new System.Drawing.Point(50, 57);
            this.lbl_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhieuMuon.Name = "lbl_MaPhieuMuon";
            this.lbl_MaPhieuMuon.Size = new System.Drawing.Size(123, 20);
            this.lbl_MaPhieuMuon.TabIndex = 0;
            this.lbl_MaPhieuMuon.Text = "Mã phiếu mượn";
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Location = new System.Drawing.Point(50, 115);
            this.lbl_MaDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(91, 20);
            this.lbl_MaDG.TabIndex = 1;
            this.lbl_MaDG.Text = "Mã độc giả";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(50, 175);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(108, 20);
            this.lbl_MaNV.TabIndex = 2;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(50, 237);
            this.lbl_MaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(84, 20);
            this.lbl_MaSach.TabIndex = 3;
            this.lbl_MaSach.Text = "Mã sách *";
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.Location = new System.Drawing.Point(591, 56);
            this.lbl_NgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(93, 20);
            this.lbl_NgayMuon.TabIndex = 4;
            this.lbl_NgayMuon.Text = "Ngày mượn";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.Location = new System.Drawing.Point(591, 120);
            this.lbl_NgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(72, 20);
            this.lbl_NgayTra.TabIndex = 5;
            this.lbl_NgayTra.Text = "Ngày trả";
            // 
            // cbb_MaDocGia
            // 
            this.cbb_MaDocGia.DataSource = this.docGiaBindingSource2;
            this.cbb_MaDocGia.DisplayMember = "sMaDocGia";
            this.cbb_MaDocGia.FormattingEnabled = true;
            this.cbb_MaDocGia.Location = new System.Drawing.Point(180, 112);
            this.cbb_MaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaDocGia.Name = "cbb_MaDocGia";
            this.cbb_MaDocGia.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaDocGia.TabIndex = 7;
            // 
            // docGiaBindingSource2
            // 
            this.docGiaBindingSource2.DataMember = "DocGia";
            this.docGiaBindingSource2.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docGiaBindingSource1
            // 
            this.docGiaBindingSource1.DataMember = "DocGia";
            this.docGiaBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.qLTVDataSet;
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.nhanVienBindingSource2;
            this.cbb_MaNV.DisplayMember = "sMaNV";
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(180, 172);
            this.cbb_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaNV.TabIndex = 8;
            // 
            // nhanVienBindingSource2
            // 
            this.nhanVienBindingSource2.DataMember = "NhanVien";
            this.nhanVienBindingSource2.DataSource = this.qLTVDataSet;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLTVDataSet;
            // 
            // cbb_MaSach
            // 
            this.cbb_MaSach.DataSource = this.sachBindingSource2;
            this.cbb_MaSach.DisplayMember = "sMaSach";
            this.cbb_MaSach.FormattingEnabled = true;
            this.cbb_MaSach.Location = new System.Drawing.Point(180, 233);
            this.cbb_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaSach.Name = "cbb_MaSach";
            this.cbb_MaSach.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaSach.TabIndex = 9;
            this.cbb_MaSach.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSach_SelectedIndexChanged);
            // 
            // sachBindingSource2
            // 
            this.sachBindingSource2.DataMember = "Sach";
            this.sachBindingSource2.DataSource = this.qLTVDataSet;
            // 
            // sachBindingSource1
            // 
            this.sachBindingSource1.DataMember = "Sach";
            this.sachBindingSource1.DataSource = this.qLTVDataSet;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // dateTime_NgayMuon
            // 
            this.dateTime_NgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgayMuon.Location = new System.Drawing.Point(693, 52);
            this.dateTime_NgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime_NgayMuon.Name = "dateTime_NgayMuon";
            this.dateTime_NgayMuon.Size = new System.Drawing.Size(249, 27);
            this.dateTime_NgayMuon.TabIndex = 10;
            // 
            // dateTime_NgayTra
            // 
            this.dateTime_NgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgayTra.Location = new System.Drawing.Point(693, 116);
            this.dateTime_NgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime_NgayTra.Name = "dateTime_NgayTra";
            this.dateTime_NgayTra.Size = new System.Drawing.Size(249, 27);
            this.dateTime_NgayTra.TabIndex = 11;
            // 
            // tb_MaPhieuMuon
            // 
            this.tb_MaPhieuMuon.Location = new System.Drawing.Point(180, 53);
            this.tb_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaPhieuMuon.Name = "tb_MaPhieuMuon";
            this.tb_MaPhieuMuon.Size = new System.Drawing.Size(281, 27);
            this.tb_MaPhieuMuon.TabIndex = 12;
            // 
            // pn_ThemSuaXoa
            // 
            this.pn_ThemSuaXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Xoa);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Sua);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Them);
            this.pn_ThemSuaXoa.Location = new System.Drawing.Point(211, 304);
            this.pn_ThemSuaXoa.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ThemSuaXoa.Name = "pn_ThemSuaXoa";
            this.pn_ThemSuaXoa.Size = new System.Drawing.Size(585, 97);
            this.pn_ThemSuaXoa.TabIndex = 13;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(424, 31);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 41);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(241, 31);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(109, 41);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(61, 31);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(109, 41);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(211, 437);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 28;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(211, 459);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 26;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(12, 492);
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.RowHeadersWidth = 51;
            this.dgv_PhieuMuon.RowTemplate.Height = 24;
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(989, 186);
            this.dgv_PhieuMuon.TabIndex = 29;
            this.dgv_PhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuMuon_CellClick);
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_DSSach
            // 
            this.lbl_DSSach.BackColor = System.Drawing.Color.White;
            this.lbl_DSSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DSSach.Location = new System.Drawing.Point(595, 172);
            this.lbl_DSSach.Name = "lbl_DSSach";
            this.lbl_DSSach.Size = new System.Drawing.Size(347, 89);
            this.lbl_DSSach.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "* Có thể chọn nhiều lựa chọn";
            // 
            // f_PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DSSach);
            this.Controls.Add(this.dgv_PhieuMuon);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.pn_ThemSuaXoa);
            this.Controls.Add(this.tb_MaPhieuMuon);
            this.Controls.Add(this.dateTime_NgayTra);
            this.Controls.Add(this.dateTime_NgayMuon);
            this.Controls.Add(this.cbb_MaSach);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.cbb_MaDocGia);
            this.Controls.Add(this.lbl_NgayTra);
            this.Controls.Add(this.lbl_NgayMuon);
            this.Controls.Add(this.lbl_MaSach);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lbl_MaDG);
            this.Controls.Add(this.lbl_MaPhieuMuon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_PhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu mượn";
            this.Load += new System.EventHandler(this.f_PhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.pn_ThemSuaXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaPhieuMuon;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.ComboBox cbb_MaDocGia;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.ComboBox cbb_MaSach;
        private System.Windows.Forms.DateTimePicker dateTime_NgayMuon;
        private System.Windows.Forms.DateTimePicker dateTime_NgayTra;
        private System.Windows.Forms.TextBox tb_MaPhieuMuon;
        private System.Windows.Forms.Panel pn_ThemSuaXoa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private QLTVDataSetTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLTVDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLTVDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource docGiaBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.BindingSource sachBindingSource1;
        private System.Windows.Forms.BindingSource docGiaBindingSource2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private System.Windows.Forms.BindingSource sachBindingSource2;
        private System.Windows.Forms.Label lbl_DSSach;
        private System.Windows.Forms.Label label1;
    }
}