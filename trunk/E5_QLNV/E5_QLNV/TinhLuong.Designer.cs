namespace E5_QLNV
{
    partial class TinhLuong
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
            this.lbma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtbophan = new System.Windows.Forms.TextBox();
            this.lbvitri = new System.Windows.Forms.Label();
            this.lbluong = new System.Windows.Forms.Label();
            this.blbophan = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.bttinh = new System.Windows.Forms.Button();
            this.btin = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.gbthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Location = new System.Drawing.Point(173, 58);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(75, 13);
            this.lbma.TabIndex = 0;
            this.lbma.Text = "Mã Nhân Viên";
            this.lbma.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(281, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÍNH LƯƠNG";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(284, 58);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 1;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Controls.Add(this.txtvitri);
            this.gbthongtin.Controls.Add(this.txthoten);
            this.gbthongtin.Controls.Add(this.txtluong);
            this.gbthongtin.Controls.Add(this.txtbophan);
            this.gbthongtin.Controls.Add(this.lbvitri);
            this.gbthongtin.Controls.Add(this.lbluong);
            this.gbthongtin.Controls.Add(this.blbophan);
            this.gbthongtin.Controls.Add(this.lbhoten);
            this.gbthongtin.ForeColor = System.Drawing.Color.Red;
            this.gbthongtin.Location = new System.Drawing.Point(130, 124);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(476, 138);
            this.gbthongtin.TabIndex = 2;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txtvitri
            // 
            this.txtvitri.Enabled = false;
            this.txtvitri.Location = new System.Drawing.Point(354, 40);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(100, 20);
            this.txtvitri.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(104, 40);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 20);
            this.txthoten.TabIndex = 1;
            // 
            // txtluong
            // 
            this.txtluong.Enabled = false;
            this.txtluong.Location = new System.Drawing.Point(354, 105);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 20);
            this.txtluong.TabIndex = 1;
            // 
            // txtbophan
            // 
            this.txtbophan.Enabled = false;
            this.txtbophan.Location = new System.Drawing.Point(104, 101);
            this.txtbophan.Name = "txtbophan";
            this.txtbophan.Size = new System.Drawing.Size(100, 20);
            this.txtbophan.TabIndex = 1;
            // 
            // lbvitri
            // 
            this.lbvitri.AutoSize = true;
            this.lbvitri.ForeColor = System.Drawing.Color.Black;
            this.lbvitri.Location = new System.Drawing.Point(284, 47);
            this.lbvitri.Name = "lbvitri";
            this.lbvitri.Size = new System.Drawing.Size(33, 13);
            this.lbvitri.TabIndex = 0;
            this.lbvitri.Text = "Vị Trí";
            // 
            // lbluong
            // 
            this.lbluong.AutoSize = true;
            this.lbluong.ForeColor = System.Drawing.Color.Black;
            this.lbluong.Location = new System.Drawing.Point(284, 108);
            this.lbluong.Name = "lbluong";
            this.lbluong.Size = new System.Drawing.Size(37, 13);
            this.lbluong.TabIndex = 0;
            this.lbluong.Text = "Lương";
            // 
            // blbophan
            // 
            this.blbophan.AutoSize = true;
            this.blbophan.ForeColor = System.Drawing.Color.Black;
            this.blbophan.Location = new System.Drawing.Point(33, 104);
            this.blbophan.Name = "blbophan";
            this.blbophan.Size = new System.Drawing.Size(51, 13);
            this.blbophan.TabIndex = 0;
            this.blbophan.Text = "Bộ  Phận";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.ForeColor = System.Drawing.Color.Black;
            this.lbhoten.Location = new System.Drawing.Point(33, 40);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(43, 13);
            this.lbhoten.TabIndex = 0;
            this.lbhoten.Text = "Họ Tên";
            // 
            // bttinh
            // 
            this.bttinh.Location = new System.Drawing.Point(234, 296);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(75, 23);
            this.bttinh.TabIndex = 3;
            this.bttinh.Text = "Tính Lương";
            this.bttinh.UseVisualStyleBackColor = true;
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(402, 295);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(75, 23);
            this.btin.TabIndex = 4;
            this.btin.Text = "In Bảng Lương";
            this.btin.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(588, 294);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 380);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.bttinh);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbma);
            this.Name = "TinhLuong";
            this.Text = "TinhLuong";
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtbophan;
        private System.Windows.Forms.Label lbvitri;
        private System.Windows.Forms.Label lbluong;
        private System.Windows.Forms.Label blbophan;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.Button btin;
        private System.Windows.Forms.Button btthoat;
    }
}