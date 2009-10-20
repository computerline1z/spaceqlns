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

        private void LoadAll()
        {
            this.cbBangCap.DataSource = BangCapBUS.LoadAll();
            this.cbBoPhan.DataSource = BoPhanBUS.LoadAll();
            this.cbChucVu.DataSource = ChucVuBUS.LoadAll();
            this.cbQuocTich.DataSource = QuocTichBUS.LoadAll();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.LoadAll();
            this.dgvDanhSach.DataSource = NhanVienBUS.LoadAll();
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvDanhSach.Rows.Count > 0)
            {
                this.txtMaNV.Text = this.dgvDanhSach.CurrentRow.Cells["MaNV"].Value.ToString();
                this.txtHoten.Text = this.dgvDanhSach.CurrentRow.Cells["HoTenNV"].Value.ToString();
                this.dtpNgaySinh.Text = this.dgvDanhSach.CurrentRow.Cells["NgaySinh"].Value.ToString();
            }
            else
            {
                this.SetNullValue();
            }
        }

        private void SetNullValue()
        {
            this.txtMaNV.Text = "";
            this.txtHoten.Text = "";
            this.dtpNgaySinh.Text = "";
        }

    }
}