/*

 * Author: Tran Thi Phu (0842110)
 * Date: 10/20/09 
 * Workfile: QLThongTinNhanVien.cs 

 */

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

        private void SetFormat()
        {
            this.txtMaNV.Enabled = false;
            //this.txtHoten.Enabled = false;
            //this.txtDiaChi.Enabled = false;
            //this.dtpNgaySinh.Enabled = false;
            //this.dtpNgayBatDauLamViec.Enabled = false;
            //this.cbBangCap.Enabled = false;
            //this.cbBoPhan.Enabled = false;
            //this.cbChucVu.Enabled = false;
            //this.cbGioiTinh.Enabled = false;
            //this.cbQuocTich.Enabled = false;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.SetFormat();
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
                this.txtDiaChi.Text = this.dgvDanhSach.CurrentRow.Cells["DiaChi"].Value.ToString();
                this.dtpNgayBatDauLamViec.Text = this.dgvDanhSach.CurrentRow.Cells["NgayBatDauLamViec"].Value.ToString();
                this.cbGioiTinh.SelectedIndex = int.Parse(this.dgvDanhSach.CurrentRow.Cells["GioiTinh"].Value.ToString());
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
            this.txtDiaChi.Text = "";
            this.dtpNgayBatDauLamViec.Text = "";
            this.cbGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TiepNhanNhanVien frm = new TiepNhanNhanVien();
            frm.Show();
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = int.Parse(this.txtMaNV.Text);
            nv.HoTenNV = this.txtHoten.Text;
            nv.NgaySinh = Convert.ToDateTime(this.dtpNgaySinh.Text);
            nv.DiaChi = this.txtDiaChi.Text;
            nv.NgayBatDauLamViec = Convert.ToDateTime(this.dtpNgayBatDauLamViec.Text);
            nv.GioiTinh = this.cbGioiTinh.SelectedIndex;
            nv.MaBangCap = int.Parse(this.cbBangCap.SelectedValue.ToString());
            nv.MaBoPhan = int.Parse(this.cbBoPhan.SelectedValue.ToString());
            nv.MaChucVu = int.Parse(this.cbChucVu.SelectedValue.ToString());
            nv.MaQuocTich = int.Parse(this.cbQuocTich.SelectedValue.ToString());
            NhanVienBUS.Update(nv);
            this.dgvDanhSach.DataSource = NhanVienBUS.LoadAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaNV.Text != "")
            {
                DialogResult dl = MessageBox.Show("ban co muon xoa nhan vien " + this.txtHoten.Text + " ko ?", "thong bao,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    NhanVienBUS.Delete(int.Parse(this.txtMaNV.Text));
                }
            }
            this.dgvDanhSach.DataSource = NhanVienBUS.LoadAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("ban co muon thoat ko ?", "thong bao,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}