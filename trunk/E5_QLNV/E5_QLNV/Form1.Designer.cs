namespace E5_QLNV
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TiepNhanNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLThongTinNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiepNhanDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TiepNhanNhanVienToolStripMenuItem,
            this.QLThongTinNhanVienToolStripMenuItem,
            this.TiepNhanDuAn,
            this.QuanLyDangNhap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TiepNhanNhanVienToolStripMenuItem
            // 
            this.TiepNhanNhanVienToolStripMenuItem.Name = "TiepNhanNhanVienToolStripMenuItem";
            this.TiepNhanNhanVienToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.TiepNhanNhanVienToolStripMenuItem.Text = "Tiếp Nhận Nhân Viên";
            this.TiepNhanNhanVienToolStripMenuItem.Click += new System.EventHandler(this.TiepNhanNhanVienToolStripMenuItem_Click);
            // 
            // QLThongTinNhanVienToolStripMenuItem
            // 
            this.QLThongTinNhanVienToolStripMenuItem.Name = "QLThongTinNhanVienToolStripMenuItem";
            this.QLThongTinNhanVienToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.QLThongTinNhanVienToolStripMenuItem.Text = "QL Thông Tin Nhân Viên";
            this.QLThongTinNhanVienToolStripMenuItem.Click += new System.EventHandler(this.QLThongTinNhanVienToolStripMenuItem_Click);
            // 
            // TiepNhanDuAn
            // 
            this.TiepNhanDuAn.Name = "TiepNhanDuAn";
            this.TiepNhanDuAn.Size = new System.Drawing.Size(110, 20);
            this.TiepNhanDuAn.Text = "Tiếp Nhận Dự Án";
            this.TiepNhanDuAn.Click += new System.EventHandler(this.TiepNhanDuAn_Click);
            // 
            // QuanLyDangNhap
            // 
            this.QuanLyDangNhap.Name = "QuanLyDangNhap";
            this.QuanLyDangNhap.Size = new System.Drawing.Size(126, 20);
            this.QuanLyDangNhap.Text = "Quản Lý Đăng Nhập";
            this.QuanLyDangNhap.Click += new System.EventHandler(this.QuanLyDangNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 264);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TiepNhanNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLThongTinNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TiepNhanDuAn;
        private System.Windows.Forms.ToolStripMenuItem QuanLyDangNhap;
    }
}

