namespace GUI
{
    partial class f_PhieuTra
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
            this.pn_ThemSuaXoa = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tb_MaPhieuTra = new System.Windows.Forms.TextBox();
            this.dateTime_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbb_MaDG = new System.Windows.Forms.ComboBox();
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_MaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.lbl_DocGia = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_MaPhieuMuon = new System.Windows.Forms.Label();
            this.lbl_MaPhieuTra = new System.Windows.Forms.Label();
            this.dgv_PhieuTra = new System.Windows.Forms.DataGridView();
            this.cbb_MaSach = new System.Windows.Forms.ComboBox();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.phieuMuonTableAdapter = new GUI.QLTVDataSetTableAdapters.PhieuMuonTableAdapter();
            this.nhanVienTableAdapter = new GUI.QLTVDataSetTableAdapters.NhanVienTableAdapter();
            this.docGiaTableAdapter = new GUI.QLTVDataSetTableAdapters.DocGiaTableAdapter();
            this.sachTableAdapter = new GUI.QLTVDataSetTableAdapters.SachTableAdapter();
            this.lbl_DSSach = new System.Windows.Forms.Label();
            this.lbl_TinhTrangSach = new System.Windows.Forms.Label();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.tinhTrangSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhTrangSachTableAdapter = new GUI.QLTVDataSetTableAdapters.TinhTrangSachTableAdapter();
            this.pn_ThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangSachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(214, 494);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 45;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(214, 516);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 43;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // pn_ThemSuaXoa
            // 
            this.pn_ThemSuaXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Xoa);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Sua);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Them);
            this.pn_ThemSuaXoa.Location = new System.Drawing.Point(214, 361);
            this.pn_ThemSuaXoa.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ThemSuaXoa.Name = "pn_ThemSuaXoa";
            this.pn_ThemSuaXoa.Size = new System.Drawing.Size(596, 97);
            this.pn_ThemSuaXoa.TabIndex = 41;
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
            // tb_MaPhieuTra
            // 
            this.tb_MaPhieuTra.Location = new System.Drawing.Point(187, 48);
            this.tb_MaPhieuTra.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaPhieuTra.Name = "tb_MaPhieuTra";
            this.tb_MaPhieuTra.Size = new System.Drawing.Size(281, 27);
            this.tb_MaPhieuTra.TabIndex = 40;
            // 
            // dateTime_NgayTra
            // 
            this.dateTime_NgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgayTra.Location = new System.Drawing.Point(700, 52);
            this.dateTime_NgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime_NgayTra.Name = "dateTime_NgayTra";
            this.dateTime_NgayTra.Size = new System.Drawing.Size(249, 27);
            this.dateTime_NgayTra.TabIndex = 39;
            // 
            // cbb_MaDG
            // 
            this.cbb_MaDG.DataSource = this.docGiaBindingSource;
            this.cbb_MaDG.DisplayMember = "sMaDocGia";
            this.cbb_MaDG.FormattingEnabled = true;
            this.cbb_MaDG.Location = new System.Drawing.Point(187, 228);
            this.cbb_MaDG.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaDG.Name = "cbb_MaDG";
            this.cbb_MaDG.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaDG.TabIndex = 37;
            // 
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.DataSource = this.nhanVienBindingSource;
            this.cbb_MaNV.DisplayMember = "sMaNV";
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(187, 167);
            this.cbb_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaNV.TabIndex = 36;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLTVDataSet;
            // 
            // cbb_MaPhieuMuon
            // 
            this.cbb_MaPhieuMuon.DataSource = this.phieuMuonBindingSource;
            this.cbb_MaPhieuMuon.DisplayMember = "sMaPhieuMuon";
            this.cbb_MaPhieuMuon.FormattingEnabled = true;
            this.cbb_MaPhieuMuon.Location = new System.Drawing.Point(187, 107);
            this.cbb_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaPhieuMuon.Name = "cbb_MaPhieuMuon";
            this.cbb_MaPhieuMuon.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaPhieuMuon.TabIndex = 35;
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource.DataSource = this.qLTVDataSet;
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.Location = new System.Drawing.Point(598, 56);
            this.lbl_NgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(72, 20);
            this.lbl_NgayTra.TabIndex = 34;
            this.lbl_NgayTra.Text = "Ngày trả";
            // 
            // lbl_DocGia
            // 
            this.lbl_DocGia.AutoSize = true;
            this.lbl_DocGia.Location = new System.Drawing.Point(57, 232);
            this.lbl_DocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DocGia.Name = "lbl_DocGia";
            this.lbl_DocGia.Size = new System.Drawing.Size(91, 20);
            this.lbl_DocGia.TabIndex = 32;
            this.lbl_DocGia.Text = "Mã độc giả";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(57, 170);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(108, 20);
            this.lbl_MaNV.TabIndex = 31;
            this.lbl_MaNV.Text = "Mã nhân viên";
            // 
            // lbl_MaPhieuMuon
            // 
            this.lbl_MaPhieuMuon.AutoSize = true;
            this.lbl_MaPhieuMuon.Location = new System.Drawing.Point(57, 110);
            this.lbl_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhieuMuon.Name = "lbl_MaPhieuMuon";
            this.lbl_MaPhieuMuon.Size = new System.Drawing.Size(123, 20);
            this.lbl_MaPhieuMuon.TabIndex = 30;
            this.lbl_MaPhieuMuon.Text = "Mã phiếu mượn";
            // 
            // lbl_MaPhieuTra
            // 
            this.lbl_MaPhieuTra.AutoSize = true;
            this.lbl_MaPhieuTra.Location = new System.Drawing.Point(57, 52);
            this.lbl_MaPhieuTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhieuTra.Name = "lbl_MaPhieuTra";
            this.lbl_MaPhieuTra.Size = new System.Drawing.Size(102, 20);
            this.lbl_MaPhieuTra.TabIndex = 29;
            this.lbl_MaPhieuTra.Text = "Mã phiếu trả";
            // 
            // dgv_PhieuTra
            // 
            this.dgv_PhieuTra.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuTra.Location = new System.Drawing.Point(12, 549);
            this.dgv_PhieuTra.Name = "dgv_PhieuTra";
            this.dgv_PhieuTra.RowHeadersWidth = 51;
            this.dgv_PhieuTra.RowTemplate.Height = 24;
            this.dgv_PhieuTra.Size = new System.Drawing.Size(989, 191);
            this.dgv_PhieuTra.TabIndex = 46;
            this.dgv_PhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuTra_CellClick);
            // 
            // cbb_MaSach
            // 
            this.cbb_MaSach.DataSource = this.sachBindingSource;
            this.cbb_MaSach.DisplayMember = "sMaSach";
            this.cbb_MaSach.FormattingEnabled = true;
            this.cbb_MaSach.Location = new System.Drawing.Point(700, 167);
            this.cbb_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaSach.Name = "cbb_MaSach";
            this.cbb_MaSach.Size = new System.Drawing.Size(249, 28);
            this.cbb_MaSach.TabIndex = 48;
            this.cbb_MaSach.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSach_SelectedIndexChanged);
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(590, 170);
            this.lbl_MaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(73, 20);
            this.lbl_MaSach.TabIndex = 47;
            this.lbl_MaSach.Text = "Mã sách";
            // 
            // phieuMuonTableAdapter
            // 
            this.phieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_DSSach
            // 
            this.lbl_DSSach.BackColor = System.Drawing.Color.White;
            this.lbl_DSSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DSSach.Location = new System.Drawing.Point(594, 208);
            this.lbl_DSSach.Name = "lbl_DSSach";
            this.lbl_DSSach.Size = new System.Drawing.Size(355, 88);
            this.lbl_DSSach.TabIndex = 49;
            // 
            // lbl_TinhTrangSach
            // 
            this.lbl_TinhTrangSach.AutoSize = true;
            this.lbl_TinhTrangSach.Location = new System.Drawing.Point(560, 110);
            this.lbl_TinhTrangSach.Name = "lbl_TinhTrangSach";
            this.lbl_TinhTrangSach.Size = new System.Drawing.Size(125, 20);
            this.lbl_TinhTrangSach.TabIndex = 50;
            this.lbl_TinhTrangSach.Text = "Tình trạng sách";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DataSource = this.tinhTrangSachBindingSource;
            this.cbb_TinhTrang.DisplayMember = "sMaTinhTrang";
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(700, 107);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(249, 28);
            this.cbb_TinhTrang.TabIndex = 51;
            // 
            // tinhTrangSachBindingSource
            // 
            this.tinhTrangSachBindingSource.DataMember = "TinhTrangSach";
            this.tinhTrangSachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // tinhTrangSachTableAdapter
            // 
            this.tinhTrangSachTableAdapter.ClearBeforeFill = true;
            // 
            // f_PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 752);
            this.Controls.Add(this.cbb_TinhTrang);
            this.Controls.Add(this.lbl_TinhTrangSach);
            this.Controls.Add(this.lbl_DSSach);
            this.Controls.Add(this.cbb_MaSach);
            this.Controls.Add(this.lbl_MaSach);
            this.Controls.Add(this.dgv_PhieuTra);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.pn_ThemSuaXoa);
            this.Controls.Add(this.tb_MaPhieuTra);
            this.Controls.Add(this.dateTime_NgayTra);
            this.Controls.Add(this.cbb_MaDG);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.cbb_MaPhieuMuon);
            this.Controls.Add(this.lbl_NgayTra);
            this.Controls.Add(this.lbl_DocGia);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lbl_MaPhieuMuon);
            this.Controls.Add(this.lbl_MaPhieuTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_PhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu trả";
            this.Load += new System.EventHandler(this.f_PhieuTra_Load);
            this.pn_ThemSuaXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangSachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Panel pn_ThemSuaXoa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tb_MaPhieuTra;
        private System.Windows.Forms.DateTimePicker dateTime_NgayTra;
        private System.Windows.Forms.ComboBox cbb_MaDG;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.ComboBox cbb_MaPhieuMuon;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.Label lbl_DocGia;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_MaPhieuMuon;
        private System.Windows.Forms.Label lbl_MaPhieuTra;
        private System.Windows.Forms.DataGridView dgv_PhieuTra;
        private System.Windows.Forms.ComboBox cbb_MaSach;
        private System.Windows.Forms.Label lbl_MaSach;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource;
        private QLTVDataSetTableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLTVDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private QLTVDataSetTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLTVDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.Label lbl_DSSach;
        private System.Windows.Forms.Label lbl_TinhTrangSach;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.BindingSource tinhTrangSachBindingSource;
        private QLTVDataSetTableAdapters.TinhTrangSachTableAdapter tinhTrangSachTableAdapter;
    }
}