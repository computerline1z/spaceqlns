namespace E5_qlnv
{
    partial class ViTri_ChucVu
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
            this.lbchucvu = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.bluser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.Sửa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.vt_chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VỊ TRÍ_CHỨC VỤ";
            // 
            // lbchucvu
            // 
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Location = new System.Drawing.Point(40, 57);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(70, 13);
            this.lbchucvu.TabIndex = 1;
            this.lbchucvu.Text = "Tên Chức Vụ";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(194, 99);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(30, 13);
            this.lbpass.TabIndex = 2;
            this.lbpass.Text = "Pass";
            // 
            // bluser
            // 
            this.bluser.AutoSize = true;
            this.bluser.Location = new System.Drawing.Point(302, 57);
            this.bluser.Name = "bluser";
            this.bluser.Size = new System.Drawing.Size(29, 13);
            this.bluser.TabIndex = 3;
            this.bluser.Text = "User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vt_chucvu,
            this.user,
            this.pass});
            this.dataGridView1.Location = new System.Drawing.Point(131, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(43, 303);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 5;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            this.Sửa.Location = new System.Drawing.Point(169, 302);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(75, 23);
            this.Sửa.TabIndex = 6;
            this.Sửa.Text = "Xóa";
            this.Sửa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(289, 302);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(419, 302);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 8;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // vt_chucvu
            // 
            this.vt_chucvu.HeaderText = "Vị Trí,Chức Vụ";
            this.vt_chucvu.Name = "vt_chucvu";
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            // 
            // pass
            // 
            this.pass.HeaderText = "Pass";
            this.pass.Name = "pass";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(131, 49);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(100, 20);
            this.txtchucvu.TabIndex = 9;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(377, 54);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 10;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(267, 99);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 11;
            // 
            // ViTri_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 357);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.Sửa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bluser);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbchucvu);
            this.Controls.Add(this.label1);
            this.Name = "ViTri_ChucVu";
            this.Text = "ViTri_ChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label bluser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button Sửa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn vt_chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
    }
}