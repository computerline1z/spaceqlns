namespace E5_qlnv
{
    partial class BangCap
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
            this.lbmaso = new System.Windows.Forms.Label();
            this.lbbangcap = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.txtbangcap = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoatrang = new System.Windows.Forms.Button();
            this.dtgvbangcap = new System.Windows.Forms.DataGridView();
            this.gvmaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvbangcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangcap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẰNG CẤP";
            // 
            // lbmaso
            // 
            this.lbmaso.AutoSize = true;
            this.lbmaso.Location = new System.Drawing.Point(47, 56);
            this.lbmaso.Name = "lbmaso";
            this.lbmaso.Size = new System.Drawing.Size(38, 13);
            this.lbmaso.TabIndex = 1;
            this.lbmaso.Text = "Mã Số";
            // 
            // lbbangcap
            // 
            this.lbbangcap.AutoSize = true;
            this.lbbangcap.Location = new System.Drawing.Point(357, 56);
            this.lbbangcap.Name = "lbbangcap";
            this.lbbangcap.Size = new System.Drawing.Size(54, 13);
            this.lbbangcap.TabIndex = 2;
            this.lbbangcap.Text = "Bằng Cấp";
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(139, 56);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(100, 20);
            this.txtmaso.TabIndex = 3;
            // 
            // txtbangcap
            // 
            this.txtbangcap.Location = new System.Drawing.Point(447, 55);
            this.txtbangcap.Name = "txtbangcap";
            this.txtbangcap.Size = new System.Drawing.Size(100, 20);
            this.txtbangcap.TabIndex = 4;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(29, 300);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(163, 300);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(291, 299);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoatrang
            // 
            this.btxoatrang.Location = new System.Drawing.Point(433, 299);
            this.btxoatrang.Name = "btxoatrang";
            this.btxoatrang.Size = new System.Drawing.Size(75, 23);
            this.btxoatrang.TabIndex = 8;
            this.btxoatrang.Text = "Xóa Trắng";
            this.btxoatrang.UseVisualStyleBackColor = true;
            // 
            // dtgvbangcap
            // 
            this.dtgvbangcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbangcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvmaso,
            this.gvbangcap});
            this.dtgvbangcap.Location = new System.Drawing.Point(134, 115);
            this.dtgvbangcap.Name = "dtgvbangcap";
            this.dtgvbangcap.Size = new System.Drawing.Size(258, 150);
            this.dtgvbangcap.TabIndex = 9;
            // 
            // gvmaso
            // 
            this.gvmaso.HeaderText = "Mã Số";
            this.gvmaso.Name = "gvmaso";
            // 
            // gvbangcap
            // 
            this.gvbangcap.HeaderText = "Bằng Cấp";
            this.gvbangcap.Name = "gvbangcap";
            // 
            // BangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 351);
            this.Controls.Add(this.dtgvbangcap);
            this.Controls.Add(this.btxoatrang);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtbangcap);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.lbbangcap);
            this.Controls.Add(this.lbmaso);
            this.Controls.Add(this.label1);
            this.Name = "BangCap";
            this.Text = "BangCap";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmaso;
        private System.Windows.Forms.Label lbbangcap;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.TextBox txtbangcap;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoatrang;
        private System.Windows.Forms.DataGridView dtgvbangcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvmaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvbangcap;
    }
}