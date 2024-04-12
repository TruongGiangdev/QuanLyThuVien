namespace GUI
{
    partial class PicMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicMenu));
            this.picThuVien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // picThuVien
            // 
            this.picThuVien.Image = ((System.Drawing.Image)(resources.GetObject("picThuVien.Image")));
            this.picThuVien.Location = new System.Drawing.Point(1, 0);
            this.picThuVien.Name = "picThuVien";
            this.picThuVien.Size = new System.Drawing.Size(1024, 673);
            this.picThuVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThuVien.TabIndex = 0;
            this.picThuVien.TabStop = false;
            // 
            // PicMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 671);
            this.Controls.Add(this.picThuVien);
            this.Name = "PicMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.picThuVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThuVien;
    }
}