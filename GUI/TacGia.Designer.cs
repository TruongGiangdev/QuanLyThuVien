namespace GUI
{
    partial class f_TacGia
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
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            this.tb_MaTacGia = new System.Windows.Forms.TextBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_TenTacGia = new System.Windows.Forms.Label();
            this.lbl_MaTacGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_TacGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(220, 298);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(77, 20);
            this.lbl_TimKiem.TabIndex = 47;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(220, 320);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(274, 27);
            this.tb_TimKiem.TabIndex = 44;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(664, 182);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(466, 182);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 40);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(268, 182);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(765, 51);
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
            this.rad_Nam.Location = new System.Drawing.Point(664, 51);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(65, 24);
            this.rad_Nam.TabIndex = 36;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Location = new System.Drawing.Point(185, 99);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(274, 27);
            this.tb_TenTacGia.TabIndex = 33;
            // 
            // tb_MaTacGia
            // 
            this.tb_MaTacGia.Location = new System.Drawing.Point(185, 50);
            this.tb_MaTacGia.Name = "tb_MaTacGia";
            this.tb_MaTacGia.Size = new System.Drawing.Size(274, 27);
            this.tb_MaTacGia.TabIndex = 32;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(569, 53);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lbl_GioiTinh.TabIndex = 27;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_TenTacGia
            // 
            this.lbl_TenTacGia.AutoSize = true;
            this.lbl_TenTacGia.Location = new System.Drawing.Point(60, 102);
            this.lbl_TenTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenTacGia.Name = "lbl_TenTacGia";
            this.lbl_TenTacGia.Size = new System.Drawing.Size(113, 20);
            this.lbl_TenTacGia.TabIndex = 26;
            this.lbl_TenTacGia.Text = "Tên nhân viên";
            // 
            // lbl_MaTacGia
            // 
            this.lbl_MaTacGia.AutoSize = true;
            this.lbl_MaTacGia.Location = new System.Drawing.Point(60, 53);
            this.lbl_MaTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaTacGia.Name = "lbl_MaTacGia";
            this.lbl_MaTacGia.Size = new System.Drawing.Size(87, 20);
            this.lbl_MaTacGia.TabIndex = 25;
            this.lbl_MaTacGia.Text = "Mã tác giả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(220, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 74);
            this.panel1.TabIndex = 46;
            // 
            // dgv_TacGia
            // 
            this.dgv_TacGia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TacGia.Location = new System.Drawing.Point(12, 353);
            this.dgv_TacGia.Name = "dgv_TacGia";
            this.dgv_TacGia.RowHeadersWidth = 51;
            this.dgv_TacGia.RowTemplate.Height = 24;
            this.dgv_TacGia.Size = new System.Drawing.Size(976, 197);
            this.dgv_TacGia.TabIndex = 48;
            this.dgv_TacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TacGia_CellClick);
            // 
            // f_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgv_TacGia);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.tb_TenTacGia);
            this.Controls.Add(this.tb_MaTacGia);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_TenTacGia);
            this.Controls.Add(this.lbl_MaTacGia);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_TacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.f_TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.TextBox tb_MaTacGia;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_TenTacGia;
        private System.Windows.Forms.Label lbl_MaTacGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_TacGia;
    }
}