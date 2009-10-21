using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using BUS;
using DTO;

namespace E5_QLNV
{
    public partial class TiepNhanNhanVien : Form
    {
        public TiepNhanNhanVien()
        {
            InitializeComponent();            

        }
        
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            

 
        }

        private void btnreset_Click(object sender, EventArgs e)
        {            
            this.txtHoten.Text = "";
            this.txtDiaChi.Text = "";
            this.txtNgayBatDauLV.Text = "";
            this.txtNgaySinh.Text = "";
            this.lblThong.Text = "";
        }

        private void TiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.SelectedIndex = 0;
            cmbBangCap.DisplayMember = "BangCap";
            cmbBangCap.ValueMember = "MaBangCap";
            this.cmbBangCap.DataSource = BangCapBUS.LoadAll();

            cmbBoPhan.DisplayMember = "BoPhan";
            cmbBoPhan.ValueMember = "MaBoPhan";
            this.cmbBoPhan.DataSource = BoPhanBUS.LoadAll();

            cmbChucVu.DisplayMember = "ChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
            this.cmbChucVu.DataSource = ChucVuBUS.LoadAll();

            this.comboBox1 .DisplayMember = "QuocTich";
            this.comboBox1 .ValueMember = "MaQuocTich";
            this.comboBox1 .DataSource = QuocTichBUS.LoadAll();
            
            //int ma = NhanVienBUS.LayMaNVLonNhat();
            //ma = ma + 1;
            //this.txtMaNV.Text =ma.ToString ();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            //nv.MaNV = int.Parse(this.txtMaNV.Text.ToString());
            nv.HoTenNV = this.txtHoten.Text;
            nv.GioiTinh = this.cmbGioiTinh.SelectedIndex;
            nv.DiaChi = this.txtDiaChi.Text;
            nv.MaBanngCap = int.Parse(this.cmbBangCap.SelectedValue.ToString());
            nv.MaBoPhan = int.Parse(this.cmbBoPhan.SelectedValue.ToString());
            nv.MaChucVu = int.Parse(this.cmbChucVu.SelectedValue.ToString());
            nv.MaQuocTich = int.Parse(this.comboBox1.SelectedValue.ToString());
            nv.NgaySinh = DateTime.Parse(this.txtNgaySinh.Text.ToString());
            nv.NgayBatDauLamViec = DateTime.Parse(this.txtNgayBatDauLV.Text.ToString());
            if (NhanVienBUS.ThemNhanVien(nv) == true)
            {
                this.lblThong.Text = "Tiếp nhận thành công!";
            }

        }

        
    }
}