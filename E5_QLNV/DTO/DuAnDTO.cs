using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class DuAnDTO
    {

        #region Attribute
        protected int _MaDuAn;
        protected string _TenDuAn;
        protected string _TenKhachHang;
        protected float _Gia;
        protected DateTime _NgayBatDau;
        protected DateTime _NgayKetThuc; 
        protected DateTime _NgayGiaoSanPham;
       
        #endregion
        #region Property
        public int MaDuAn
        {
            get { return _MaDuAn; }
            set { _MaDuAn = value; }
        }
        public string TenDuAn
        {
            get { return _TenDuAn; }
            set { _TenDuAn = value; }
        }
        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set {  _TenKhachHang = value; }
        }
        public float  Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        public DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        public DateTime NgayGiaoSanPham
        {
            get { return _NgayGiaoSanPham; }
            set { _NgayGiaoSanPham = value; }
        }
      
        #endregion
    }
}
