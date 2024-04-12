namespace GUI
{
    partial class f_DocGia
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
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dateTime_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.tb_DienThoai = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_TenDocGia = new System.Windows.Forms.TextBox();
            this.tb_MaDocGia = new System.Windows.Forms.TextBox();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_DT = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_TenDocGia = new System.Windows.Forms.Label();
            this.lbl_MaDocGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DocGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(217, 400);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 47;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(217, 422);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 44;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(661, 276);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(463, 276);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 40);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(265, 276);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dateTime_NgaySinh
            // 
            this.dateTime_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTime_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgaySinh.Location = new System.Drawing.Point(661, 106);
            this.dateTime_NgaySinh.Name = "dateTime_NgaySinh";
            this.dateTime_NgaySinh.Size = new System.Drawing.Size(274, 27);
            this.dateTime_NgaySinh.TabIndex = 38;
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(831, 58);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(51, 24);
            this.rad_Nu.TabIndex = 37;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(694, 58);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(65, 24);
            this.rad_Nam.TabIndex = 36;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // tb_DienThoai
            // 
            this.tb_DienThoai.Location = new System.Drawing.Point(182, 204);
            this.tb_DienThoai.Name = "tb_DienThoai";
            this.tb_DienThoai.Size = new System.Drawing.Size(274, 27);
            this.tb_DienThoai.TabIndex = 35;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(182, 155);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(274, 27);
            this.tb_DiaChi.TabIndex = 34;
            // 
            // tb_TenDocGia
            // 
            this.tb_TenDocGia.Location = new System.Drawing.Point(182, 106);
            this.tb_TenDocGia.Name = "tb_TenDocGia";
            this.tb_TenDocGia.Size = new System.Drawing.Size(274, 27);
            this.tb_TenDocGia.TabIndex = 33;
            // 
            // tb_MaDocGia
            // 
            this.tb_MaDocGia.Location = new System.Drawing.Point(182, 57);
            this.tb_MaDocGia.Name = "tb_MaDocGia";
            this.tb_MaDocGia.Size = new System.Drawing.Size(274, 27);
            this.tb_MaDocGia.TabIndex = 32;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(566, 109);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(83, 20);
            this.lbl_NgaySinh.TabIndex = 30;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_DT
            // 
            this.lbl_DT.AutoSize = true;
            this.lbl_DT.Location = new System.Drawing.Point(57, 207);
            this.lbl_DT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DT.Name = "lbl_DT";
            this.lbl_DT.Size = new System.Drawing.Size(84, 20);
            this.lbl_DT.TabIndex = 29;
            this.lbl_DT.Text = "Điện thoại";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(57, 158);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.lbl_DiaChi.TabIndex = 28;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(566, 60);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lbl_GioiTinh.TabIndex = 27;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_TenDocGia
            // 
            this.lbl_TenDocGia.AutoSize = true;
            this.lbl_TenDocGia.Location = new System.Drawing.Point(57, 109);
            this.lbl_TenDocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDocGia.Name = "lbl_TenDocGia";
            this.lbl_TenDocGia.Size = new System.Drawing.Size(96, 20);
            this.lbl_TenDocGia.TabIndex = 26;
            this.lbl_TenDocGia.Text = "Tên độc giả";
            // 
            // lbl_MaDocGia
            // 
            this.lbl_MaDocGia.AutoSize = true;
            this.lbl_MaDocGia.Location = new System.Drawing.Point(57, 60);
            this.lbl_MaDocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaDocGia.Name = "lbl_MaDocGia";
            this.lbl_MaDocGia.Size = new System.Drawing.Size(91, 20);
            this.lbl_MaDocGia.TabIndex = 25;
            this.lbl_MaDocGia.Text = "Mã độc giả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(217, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 74);
            this.panel1.TabIndex = 46;
            // 
            // dgv_DocGia
            // 
            this.dgv_DocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocGia.Location = new System.Drawing.Point(12, 455);
            this.dgv_DocGia.Name = "dgv_DocGia";
            this.dgv_DocGia.RowHeadersWidth = 51;
            this.dgv_DocGia.RowTemplate.Height = 24;
            this.dgv_DocGia.Size = new System.Drawing.Size(989, 223);
            this.dgv_DocGia.TabIndex = 48;
            this.dgv_DocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DocGia_CellClick);
            // 
            // f_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 690);
            this.Controls.Add(this.dgv_DocGia);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dateTime_NgaySinh);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.tb_DienThoai);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_TenDocGia);
            this.Controls.Add(this.tb_MaDocGia);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_DT);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_TenDocGia);
            this.Controls.Add(this.lbl_MaDocGia);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.f_DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker dateTime_NgaySinh;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox tb_DienThoai;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_TenDocGia;
        private System.Windows.Forms.TextBox tb_MaDocGia;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_DT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_TenDocGia;
        private System.Windows.Forms.Label lbl_MaDocGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DocGia;
    }
}