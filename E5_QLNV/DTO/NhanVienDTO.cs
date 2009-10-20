using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO
{
    public class NhanVienDTO
    {
        #region Attribute
        protected int _MaNV;
        protected String _HoTenNV;
        protected int _GioiTinh;
        protected DateTime _NgaySinh;
        protected string _DiaChi;
        protected int _MaBanngCap;
        protected int _MaChucVu;
        protected int _MaQuocTich;
        protected int _MaBoPhan;
        protected  DateTime _NgayBatDauLamViec;

        

        #endregion
        #region Property
        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public String HoTenNV
        {
            get { return _HoTenNV; }
            set { _HoTenNV = value; }
        }
        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public int MaBanngCap
        {
            get { return _MaBanngCap; }
            set { _MaBanngCap = value; }
        }
        public int MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        public int MaQuocTich
        {
            get { return _MaQuocTich; }
            set { _MaQuocTich = value; }
        }
        public int MaBoPhan
        {
            get { return _MaBoPhan; }
            set { _MaBoPhan = value; }
        }
        public DateTime NgayBatDauLamViec
        {
            get { return _NgayBatDauLamViec; }
            set { _NgayBatDauLamViec = value; }
        }
        #endregion
    }
}
