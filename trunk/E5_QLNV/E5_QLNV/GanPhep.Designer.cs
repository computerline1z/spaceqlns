namespace E5_QLNV
{
    partial class GanPhep
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
            this.btsongay = new System.Windows.Forms.Label();
            this.txtsongay = new System.Windows.Forms.TextBox();
            this.btganghep = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÁN PHÉP";
            // 
            // btsongay
            // 
            this.btsongay.AutoSize = true;
            this.btsongay.Location = new System.Drawing.Point(3, 64);
            this.btsongay.Name = "btsongay";
            this.btsongay.Size = new System.Drawing.Size(101, 13);
            this.btsongay.TabIndex = 1;
            this.btsongay.Text = "Số Ngày Phép Năm";
            // 
            // txtsongay
            // 
            this.txtsongay.Location = new System.Drawing.Point(120, 61);
            this.txtsongay.Name = "txtsongay";
            this.txtsongay.Size = new System.Drawing.Size(100, 20);
            this.txtsongay.TabIndex = 2;
            // 
            // btganghep
            // 
            this.btganghep.Location = new System.Drawing.Point(39, 165);
            this.btganghep.Name = "btganghep";
            this.btganghep.Size = new System.Drawing.Size(75, 23);
            this.btganghep.TabIndex = 3;
            this.btganghep.Text = "Gán Phép";
            this.btganghep.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(165, 165);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // GanPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btganghep);
            this.Controls.Add(this.txtsongay);
            this.Controls.Add(this.btsongay);
            this.Controls.Add(this.label1);
            this.Name = "GanPhep";
            this.Text = "GanPhep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btsongay;
        private System.Windows.Forms.TextBox txtsongay;
        private System.Windows.Forms.Button btganghep;
        private System.Windows.Forms.Button btthoat;
    }
}