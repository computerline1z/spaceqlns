using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
//using DAO;

namespace E5_QLNV
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            
            ThanhVienDTO tv = new ThanhVienDTO();
            String user = txtUser.Text.ToString();
            String pass = txtPass.Text.ToString();
            tv.MaUser = user;
            tv.Password = pass;
            bool check = ThanhVienBUS.CheckLogin(tv);
            if (check == true)
            {
                           
                MessageBox.Show("Login successful!");
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close();  
            }
            else
            {
                MessageBox.Show("Login fail!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            String msg = "User : admin , Pass : admin";
            MessageBox.Show(msg);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }

    }
}