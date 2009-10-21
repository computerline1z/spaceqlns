using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E5_QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TiepNhanNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiepNhanNhanVien frm = new TiepNhanNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLThongTinNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLThongTinNhanVien frm = new QLThongTinNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TiepNhanDuAn_Click(object sender, EventArgs e)
        {
            TiepNhanDuAn frm = new TiepNhanDuAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QuanLyDangNhap_Click(object sender, EventArgs e)
        {
            QLNV frm = new QLNV();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}