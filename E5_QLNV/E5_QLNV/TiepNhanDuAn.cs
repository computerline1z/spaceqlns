using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace moncongcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bttiepnhan_Click(object sender, EventArgs e)
        {
                  
            string sql = "";
            
            sql = "Insert into Du_An(MaDuAn,KhachHang,Gia,NgayBatDau,NgayketThuc,NgayGiaosp) Values (";
            sql += this.txtma.Text + "," + this.txtkhachhang.Text + "," +this.txtgia.Text + "," + this.txtbdau.Text + "," + this.txtkthuc.Text + "," +this.txtngaygiao.Text + ")";
            KetNoi.StringExecuteNonQuery(sql);
         
            lbthongbao.Text = "Đã Tiếp Nhận";
        }

        private void Bthuy_Click(object sender, EventArgs e)
        {
            txtbdau.Text = "";
            txtgia.Text = "";
            txtkhachhang.Text = "";
            txtma.Text = "";
            txtngaygiao.Text = "";
            txtkthuc.Text = "";

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}