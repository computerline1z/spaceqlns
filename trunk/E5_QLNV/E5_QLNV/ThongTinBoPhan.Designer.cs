namespace E5_qlnv
{
    partial class Thong_Tin_Bo_Phan
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
            this.lbtenbophan = new System.Windows.Forms.Label();
            this.cbbophan = new System.Windows.Forms.ComboBox();
            this.dtgvbophan = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbophan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbophan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(209, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BỘ PHẬN";
            // 
            // lbtenbophan
            // 
            this.lbtenbophan.AutoSize = true;
            this.lbtenbophan.Location = new System.Drawing.Point(116, 71);
            this.lbtenbophan.Name = "lbtenbophan";
            this.lbtenbophan.Size = new System.Drawing.Size(70, 13);
            this.lbtenbophan.TabIndex = 1;
            this.lbtenbophan.Text = "Tên Bộ Phận";
            // 
            // cbbophan
            // 
            this.cbbophan.FormattingEnabled = true;
            this.cbbophan.Location = new System.Drawing.Point(234, 71);
            this.cbbophan.Name = "cbbophan";
            this.cbbophan.Size = new System.Drawing.Size(107, 21);
            this.cbbophan.TabIndex = 2;
            // 
            // dtgvbophan
            // 
            this.dtgvbophan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbophan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Tbophan});
            this.dtgvbophan.Location = new System.Drawing.Point(107, 131);
            this.dtgvbophan.Name = "dtgvbophan";
            this.dtgvbophan.Size = new System.Drawing.Size(260, 139);
            this.dtgvbophan.TabIndex = 3;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // Tbophan
            // 
            this.Tbophan.HeaderText = "Tên Bộ Phận";
            this.Tbophan.Name = "Tbophan";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(34, 305);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 4;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(149, 305);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(292, 305);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(452, 305);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // Thong_Tin_Bo_Phan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 356);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtgvbophan);
            this.Controls.Add(this.cbbophan);
            this.Controls.Add(this.lbtenbophan);
            this.Controls.Add(this.label1);
            this.Name = "Thong_Tin_Bo_Phan";
            this.Text = "Thong_Tin_Bo_Phan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbophan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtenbophan;
        private System.Windows.Forms.ComboBox cbbophan;
        private System.Windows.Forms.DataGridView dtgvbophan;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tbophan;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthoat;
    }
}