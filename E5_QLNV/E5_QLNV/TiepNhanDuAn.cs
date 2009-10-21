using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace E5_QLNV
{
    public partial class TiepNhanDuAn : Form
    {
        public TiepNhanDuAn()
        {
            InitializeComponent();
        }

        private void bttiepnhan_Click(object sender, EventArgs e)
        {
            DuAnDTO dan =new DuAnDTO ();
            //dan.MaDuAn =this.txtma.Text ();
            dan.TenDuAn =this.txttensp.Text. ToString ();
            dan.TenKhachHang = this.txtkhachhang.Text.ToString();
            dan.Gia=float.Parse (this.txtgia.Text.ToString ());
            dan.NgayBatDau=DateTime.Parse (this.txtbdau.Text.ToString ());
            dan.NgayKetThuc=DateTime.Parse (this.txtkthuc.Text.ToString  ());
            dan.NgayGiaoSanPham = DateTime.Parse (this.txtngaygiao.Text .ToString ());
            
            if (DuAnBUS.ThemDuAn (dan) == true)
            {
                this.lblbao.Text = "Tiếp nhận thành công!";
            }
        }

        private void Bthuy_Click(object sender, EventArgs e)
        {
            this.txtbdau.Text = "";
            this.txtgia.Text = "";
            this.txtkhachhang.Text = "";
            this.txtkthuc.Text = "";
            this.txtngaygiao.Text = "";
            this.txttensp.Text = "";
            this.lblbao.Text = "";
        }
    }
}