namespace E5_qlnv
{
    partial class LoaiHopDong
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
            this.lbtenhopdong = new System.Windows.Forms.Label();
            this.cbloaihopdong = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.Sửa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.dtgvloaihopdong = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lhdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaihopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI HỢP ĐỒNG";
            // 
            // lbtenhopdong
            // 
            this.lbtenhopdong.AutoSize = true;
            this.lbtenhopdong.Location = new System.Drawing.Point(72, 69);
            this.lbtenhopdong.Name = "lbtenhopdong";
            this.lbtenhopdong.Size = new System.Drawing.Size(78, 13);
            this.lbtenhopdong.TabIndex = 1;
            this.lbtenhopdong.Text = "Tên Hợp Đồng";
            // 
            // cbloaihopdong
            // 
            this.cbloaihopdong.FormattingEnabled = true;
            this.cbloaihopdong.Location = new System.Drawing.Point(178, 69);
            this.cbloaihopdong.Name = "cbloaihopdong";
            this.cbloaihopdong.Size = new System.Drawing.Size(121, 21);
            this.cbloaihopdong.TabIndex = 2;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(422, 290);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(292, 290);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 11;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            this.Sửa.Location = new System.Drawing.Point(172, 290);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(75, 23);
            this.Sửa.TabIndex = 10;
            this.Sửa.Text = "Xóa";
            this.Sửa.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(46, 291);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 9;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // dtgvloaihopdong
            // 
            this.dtgvloaihopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvloaihopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.lhdong});
            this.dtgvloaihopdong.Location = new System.Drawing.Point(147, 120);
            this.dtgvloaihopdong.Name = "dtgvloaihopdong";
            this.dtgvloaihopdong.Size = new System.Drawing.Size(277, 141);
            this.dtgvloaihopdong.TabIndex = 13;
            this.dtgvloaihopdong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // lhdong
            // 
            this.lhdong.HeaderText = "Loại Hợp Đồng";
            this.lhdong.Name = "lhdong";
            // 
            // LoaiHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Controls.Add(this.dtgvloaihopdong);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbloaihopdong);
            this.Controls.Add(this.lbtenhopdong);
            this.Controls.Add(this.label1);
            this.Name = "LoaiHopDong";
            this.Text = "LoaiHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaihopdong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtenhopdong;
        private System.Windows.Forms.ComboBox cbloaihopdong;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button Sửa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dtgvloaihopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lhdong;
    }
}