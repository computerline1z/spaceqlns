namespace E5_QLNV
{
    partial class QuanTriCongViec
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
            this.tenduan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbduan = new System.Windows.Forms.ComboBox();
            this.txtcongviec = new System.Windows.Forms.TextBox();
            this.txttilehoanthanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenduan
            // 
            this.tenduan.HeaderText = "Tên Công Việc";
            this.tenduan.Name = "tenduan";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tình Trạng";
            this.Column1.Name = "Column1";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(474, 377);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 24;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenduan,
            this.Column1});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(178, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 151);
            this.dataGridView1.TabIndex = 23;
            // 
            // cbduan
            // 
            this.cbduan.FormattingEnabled = true;
            this.cbduan.Location = new System.Drawing.Point(302, 76);
            this.cbduan.Name = "cbduan";
            this.cbduan.Size = new System.Drawing.Size(121, 21);
            this.cbduan.TabIndex = 22;
            // 
            // txtcongviec
            // 
            this.txtcongviec.Location = new System.Drawing.Point(302, 116);
            this.txtcongviec.Name = "txtcongviec";
            this.txtcongviec.Size = new System.Drawing.Size(100, 20);
            this.txtcongviec.TabIndex = 21;
            // 
            // txttilehoanthanh
            // 
            this.txttilehoanthanh.Location = new System.Drawing.Point(302, 161);
            this.txttilehoanthanh.Name = "txttilehoanthanh";
            this.txttilehoanthanh.Size = new System.Drawing.Size(100, 20);
            this.txttilehoanthanh.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tỉ Lệ Hoàn Thành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "CHIA NHỎ CÔNG VIỆC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Công Việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dự Án";
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(327, 377);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 25;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(205, 377);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 25;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(89, 377);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 25;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // QuanTriCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbduan);
            this.Controls.Add(this.txtcongviec);
            this.Controls.Add(this.txttilehoanthanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanTriCongViec";
            this.Text = "QuanTriCongViec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tenduan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbduan;
        private System.Windows.Forms.TextBox txtcongviec;
        private System.Windows.Forms.TextBox txttilehoanthanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
    }
}