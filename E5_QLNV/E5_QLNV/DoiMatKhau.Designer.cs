namespace E5_QLNV
{
    partial class DoiMatKhau
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassmoinua = new System.Windows.Forms.TextBox();
            this.txtpassmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.btthaydoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(249, 126);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(249, 78);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // txtpassmoinua
            // 
            this.txtpassmoinua.Location = new System.Drawing.Point(249, 219);
            this.txtpassmoinua.Name = "txtpassmoinua";
            this.txtpassmoinua.Size = new System.Drawing.Size(100, 20);
            this.txtpassmoinua.TabIndex = 12;
            // 
            // txtpassmoi
            // 
            this.txtpassmoi.Location = new System.Drawing.Point(249, 169);
            this.txtpassmoi.Name = "txtpassmoi";
            this.txtpassmoi.Size = new System.Drawing.Size(100, 20);
            this.txtpassmoi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Pass Again";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Pass";
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(305, 270);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 14;
            this.bthuy.Text = "Cancel";
            this.bthuy.UseVisualStyleBackColor = true;
            // 
            // btthaydoi
            // 
            this.btthaydoi.Location = new System.Drawing.Point(80, 270);
            this.btthaydoi.Name = "btthaydoi";
            this.btthaydoi.Size = new System.Drawing.Size(75, 23);
            this.btthaydoi.TabIndex = 13;
            this.btthaydoi.Text = "Change";
            this.btthaydoi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(139, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "THAY ĐỔI MẬT KHẤU";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btthaydoi);
            this.Controls.Add(this.txtpassmoinua);
            this.Controls.Add(this.txtpassmoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassmoinua;
        private System.Windows.Forms.TextBox txtpassmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btthaydoi;
        private System.Windows.Forms.Label label5;
    }
}