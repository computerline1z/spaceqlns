namespace E5_QLNV
{
    partial class PhanDoanDuAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbduan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laphandoan = new System.Windows.Forms.Label();
            this.btdongy = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.txtmaphandoan = new System.Windows.Forms.TextBox();
            this.txttenphandoan = new System.Windows.Forms.TextBox();
            this.cbduan = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN ĐOẠN DỰ ÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbduan);
            this.groupBox1.Controls.Add(this.txttenphandoan);
            this.groupBox1.Controls.Add(this.txtmaphandoan);
            this.groupBox1.Controls.Add(this.lbduan);
            this.groupBox1.Controls.Add(this.laphandoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(61, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHÂN CÔNG";
            // 
            // lbduan
            // 
            this.lbduan.AutoSize = true;
            this.lbduan.Location = new System.Drawing.Point(6, 38);
            this.lbduan.Name = "lbduan";
            this.lbduan.Size = new System.Drawing.Size(37, 13);
            this.lbduan.TabIndex = 0;
            this.lbduan.Text = "Dự Án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phân Đoạn";
            // 
            // laphandoan
            // 
            this.laphandoan.AutoSize = true;
            this.laphandoan.Location = new System.Drawing.Point(29, 104);
            this.laphandoan.Name = "laphandoan";
            this.laphandoan.Size = new System.Drawing.Size(61, 13);
            this.laphandoan.TabIndex = 0;
            this.laphandoan.Text = "Phân Đoạn";
            // 
            // btdongy
            // 
            this.btdongy.Location = new System.Drawing.Point(117, 331);
            this.btdongy.Name = "btdongy";
            this.btdongy.Size = new System.Drawing.Size(75, 23);
            this.btdongy.TabIndex = 2;
            this.btdongy.Text = "Đồng Ý";
            this.btdongy.UseVisualStyleBackColor = true;
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(342, 331);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 3;
            this.bthuy.Text = "Hủy Bỏ";
            this.bthuy.UseVisualStyleBackColor = true;
            // 
            // txtmaphandoan
            // 
            this.txtmaphandoan.Location = new System.Drawing.Point(376, 38);
            this.txtmaphandoan.Name = "txtmaphandoan";
            this.txtmaphandoan.Size = new System.Drawing.Size(100, 20);
            this.txtmaphandoan.TabIndex = 1;
            // 
            // txttenphandoan
            // 
            this.txttenphandoan.Location = new System.Drawing.Point(159, 104);
            this.txttenphandoan.Name = "txttenphandoan";
            this.txttenphandoan.Size = new System.Drawing.Size(100, 20);
            this.txttenphandoan.TabIndex = 1;
            // 
            // cbduan
            // 
            this.cbduan.FormattingEnabled = true;
            this.cbduan.Location = new System.Drawing.Point(56, 35);
            this.cbduan.Name = "cbduan";
            this.cbduan.Size = new System.Drawing.Size(121, 21);
            this.cbduan.TabIndex = 2;
            // 
            // PhanDoanDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 462);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btdongy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PhanDoanDuAn";
            this.Text = "PhanDoanDuAn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbduan;
        private System.Windows.Forms.Label laphandoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdongy;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.ComboBox cbduan;
        private System.Windows.Forms.TextBox txttenphandoan;
        private System.Windows.Forms.TextBox txtmaphandoan;
    }
}