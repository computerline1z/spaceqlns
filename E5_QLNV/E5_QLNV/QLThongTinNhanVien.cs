using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;


namespace E5_QLNV
{
    public partial class QLThongTinNhanVien : Form
    {
        public QLThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.dgvDanhSach.DataSource = NhanVienBUS.LoadAll();
        }

    }
}