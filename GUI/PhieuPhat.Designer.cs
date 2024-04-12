namespace GUI
{
    partial class f_PhieuPhat
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
            this.tb_MaPhieuPhat = new System.Windows.Forms.TextBox();
            this.cbb_MaPhieuTra = new System.Windows.Forms.ComboBox();
            this.phieuTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new GUI.QLTVDataSet();
            this.lbl_TienPhat = new System.Windows.Forms.Label();
            this.lbl_MaPhieuTra = new System.Windows.Forms.Label();
            this.lbl_MaPhieuPhat = new System.Windows.Forms.Label();
            this.tb_TienPhat = new System.Windows.Forms.TextBox();
            this.grb_NoiDung = new System.Windows.Forms.GroupBox();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.dgv_PhieuPhat = new System.Windows.Forms.DataGridView();
            this.phieuTraTableAdapter = new GUI.QLTVDataSetTableAdapters.PhieuTraTableAdapter();
            this.pn_ThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            this.grb_NoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(217, 435);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 47;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(217, 457);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 45;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // pn_ThemSuaXoa
            // 
            this.pn_ThemSuaXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Xoa);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Sua);
            this.pn_ThemSuaXoa.Controls.Add(this.btn_Them);
            this.pn_ThemSuaXoa.Location = new System.Drawing.Point(217, 302);
            this.pn_ThemSuaXoa.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ThemSuaXoa.Name = "pn_ThemSuaXoa";
            this.pn_ThemSuaXoa.Size = new System.Drawing.Size(585, 97);
            this.pn_ThemSuaXoa.TabIndex = 43;
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
            // tb_MaPhieuPhat
            // 
            this.tb_MaPhieuPhat.Location = new System.Drawing.Point(186, 51);
            this.tb_MaPhieuPhat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MaPhieuPhat.Name = "tb_MaPhieuPhat";
            this.tb_MaPhieuPhat.Size = new System.Drawing.Size(281, 27);
            this.tb_MaPhieuPhat.TabIndex = 42;
            // 
            // cbb_MaPhieuTra
            // 
            this.cbb_MaPhieuTra.DataSource = this.phieuTraBindingSource;
            this.cbb_MaPhieuTra.DisplayMember = "sMaPhieuTra";
            this.cbb_MaPhieuTra.FormattingEnabled = true;
            this.cbb_MaPhieuTra.Location = new System.Drawing.Point(186, 110);
            this.cbb_MaPhieuTra.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaPhieuTra.Name = "cbb_MaPhieuTra";
            this.cbb_MaPhieuTra.Size = new System.Drawing.Size(281, 28);
            this.cbb_MaPhieuTra.TabIndex = 37;
            // 
            // phieuTraBindingSource
            // 
            this.phieuTraBindingSource.DataMember = "PhieuTra";
            this.phieuTraBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_TienPhat
            // 
            this.lbl_TienPhat.AutoSize = true;
            this.lbl_TienPhat.Location = new System.Drawing.Point(56, 173);
            this.lbl_TienPhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TienPhat.Name = "lbl_TienPhat";
            this.lbl_TienPhat.Size = new System.Drawing.Size(78, 20);
            this.lbl_TienPhat.TabIndex = 33;
            this.lbl_TienPhat.Text = "Tiền phạt";
            // 
            // lbl_MaPhieuTra
            // 
            this.lbl_MaPhieuTra.AutoSize = true;
            this.lbl_MaPhieuTra.Location = new System.Drawing.Point(56, 113);
            this.lbl_MaPhieuTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhieuTra.Name = "lbl_MaPhieuTra";
            this.lbl_MaPhieuTra.Size = new System.Drawing.Size(102, 20);
            this.lbl_MaPhieuTra.TabIndex = 32;
            this.lbl_MaPhieuTra.Text = "Mã phiếu trả";
            // 
            // lbl_MaPhieuPhat
            // 
            this.lbl_MaPhieuPhat.AutoSize = true;
            this.lbl_MaPhieuPhat.Location = new System.Drawing.Point(56, 55);
            this.lbl_MaPhieuPhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaPhieuPhat.Name = "lbl_MaPhieuPhat";
            this.lbl_MaPhieuPhat.Size = new System.Drawing.Size(114, 20);
            this.lbl_MaPhieuPhat.TabIndex = 31;
            this.lbl_MaPhieuPhat.Text = "Mã phiếu phạt";
            // 
            // tb_TienPhat
            // 
            this.tb_TienPhat.Location = new System.Drawing.Point(186, 170);
            this.tb_TienPhat.Name = "tb_TienPhat";
            this.tb_TienPhat.Size = new System.Drawing.Size(281, 27);
            this.tb_TienPhat.TabIndex = 49;
            // 
            // grb_NoiDung
            // 
            this.grb_NoiDung.Controls.Add(this.tb_NoiDung);
            this.grb_NoiDung.Location = new System.Drawing.Point(556, 35);
            this.grb_NoiDung.Name = "grb_NoiDung";
            this.grb_NoiDung.Size = new System.Drawing.Size(358, 82);
            this.grb_NoiDung.TabIndex = 50;
            this.grb_NoiDung.TabStop = false;
            this.grb_NoiDung.Text = "Nội dung";
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(0, 26);
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(358, 27);
            this.tb_NoiDung.TabIndex = 0;
            // 
            // dgv_PhieuPhat
            // 
            this.dgv_PhieuPhat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuPhat.Location = new System.Drawing.Point(12, 490);
            this.dgv_PhieuPhat.Name = "dgv_PhieuPhat";
            this.dgv_PhieuPhat.RowHeadersWidth = 51;
            this.dgv_PhieuPhat.RowTemplate.Height = 24;
            this.dgv_PhieuPhat.Size = new System.Drawing.Size(989, 185);
            this.dgv_PhieuPhat.TabIndex = 51;
            this.dgv_PhieuPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuPhat_CellClick);
            // 
            // phieuTraTableAdapter
            // 
            this.phieuTraTableAdapter.ClearBeforeFill = true;
            // 
            // f_PhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 683);
            this.Controls.Add(this.dgv_PhieuPhat);
            this.Controls.Add(this.grb_NoiDung);
            this.Controls.Add(this.tb_TienPhat);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.pn_ThemSuaXoa);
            this.Controls.Add(this.tb_MaPhieuPhat);
            this.Controls.Add(this.cbb_MaPhieuTra);
            this.Controls.Add(this.lbl_TienPhat);
            this.Controls.Add(this.lbl_MaPhieuTra);
            this.Controls.Add(this.lbl_MaPhieuPhat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_PhieuPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu phạt";
            this.Load += new System.EventHandler(this.f_PhieuPhat_Load);
            this.pn_ThemSuaXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            this.grb_NoiDung.ResumeLayout(false);
            this.grb_NoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuPhat)).EndInit();
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
        private System.Windows.Forms.TextBox tb_MaPhieuPhat;
        private System.Windows.Forms.ComboBox cbb_MaPhieuTra;
        private System.Windows.Forms.Label lbl_TienPhat;
        private System.Windows.Forms.Label lbl_MaPhieuTra;
        private System.Windows.Forms.Label lbl_MaPhieuPhat;
        private System.Windows.Forms.TextBox tb_TienPhat;
        private System.Windows.Forms.GroupBox grb_NoiDung;
        private System.Windows.Forms.DataGridView dgv_PhieuPhat;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource phieuTraBindingSource;
        private QLTVDataSetTableAdapters.PhieuTraTableAdapter phieuTraTableAdapter;
    }
}