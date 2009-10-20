using System;
using System.Collections.Generic;
using System.Text;

namespace E5_QLNV
{
    class NhanVienDTO
    {
        #region Attribute

        private int _MaNV;        
        private String _HoTenNV;        
        private int _GioiTinh;       
        private DateTime _NgaySinh;       
        private string _DiaChi;       
        private int _MaBanngCap;        
        private int _MaChucVu;        
        private int _MaQuocTich;       
        private int _MaBoPhan;
        
        #endregion
        #region Property
        protected int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        protected String HoTenNV
        {
            get { return _HoTenNV; }
            set { _HoTenNV = value; }
        }
        protected int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        protected DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        protected string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        protected int MaBanngCap
        {
            get { return _MaBanngCap; }
            set { _MaBanngCap = value; }
        }
        protected int MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        protected int MaQuocTich
        {
            get { return _MaQuocTich; }
            set { _MaQuocTich = value; }
        }
        protected int MaBoPhan
        {
            get { return _MaBoPhan; }
            set { _MaBoPhan = value; }
        }  
        #endregion
    }
}
