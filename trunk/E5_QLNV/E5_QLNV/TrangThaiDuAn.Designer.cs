namespace E5_QLNV
{
    partial class TrangThaiDuAn
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
            this.cbmaduan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenduan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbduan = new System.Windows.Forms.Label();
            this.lbtile = new System.Windows.Forms.Label();
            this.txtduan = new System.Windows.Forms.TextBox();
            this.txttile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmaduan
            // 
            this.cbmaduan.FormattingEnabled = true;
            this.cbmaduan.Location = new System.Drawing.Point(241, 69);
            this.cbmaduan.Name = "cbmaduan";
            this.cbmaduan.Size = new System.Drawing.Size(100, 21);
            this.cbmaduan.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenduan,
            this.Column1});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(187, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 151);
            this.dataGridView1.TabIndex = 5;
            // 
            // tenduan
            // 
            this.tenduan.HeaderText = "Tên Dự Án";
            this.tenduan.Name = "tenduan";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nhân Sự";
            this.Column1.Name = "Column1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Dự Án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRẠNG THÁI CÔNG VIỆC";
            // 
            // lbduan
            // 
            this.lbduan.AutoSize = true;
            this.lbduan.Location = new System.Drawing.Point(58, 101);
            this.lbduan.Name = "lbduan";
            this.lbduan.Size = new System.Drawing.Size(37, 13);
            this.lbduan.TabIndex = 3;
            this.lbduan.Text = "Dự Án";
            // 
            // lbtile
            // 
            this.lbtile.AutoSize = true;
            this.lbtile.Location = new System.Drawing.Point(58, 135);
            this.lbtile.Name = "lbtile";
            this.lbtile.Size = new System.Drawing.Size(94, 13);
            this.lbtile.TabIndex = 3;
            this.lbtile.Text = "Tỉ Lệ Hoàn Thành";
            // 
            // txtduan
            // 
            this.txtduan.Location = new System.Drawing.Point(241, 98);
            this.txtduan.Name = "txtduan";
            this.txtduan.Size = new System.Drawing.Size(100, 20);
            this.txtduan.TabIndex = 7;
            // 
            // txttile
            // 
            this.txttile.Location = new System.Drawing.Point(241, 135);
            this.txttile.Name = "txttile";
            this.txttile.Size = new System.Drawing.Size(100, 20);
            this.txttile.TabIndex = 7;
            // 
            // TrangThaiCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 496);
            this.Controls.Add(this.txttile);
            this.Controls.Add(this.txtduan);
            this.Controls.Add(this.cbmaduan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbtile);
            this.Controls.Add(this.lbduan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrangThaiCongViec";
            this.Text = "TrangThaiCongViec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmaduan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenduan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbduan;
        private System.Windows.Forms.Label lbtile;
        private System.Windows.Forms.TextBox txtduan;
        private System.Windows.Forms.TextBox txttile;
    }
}