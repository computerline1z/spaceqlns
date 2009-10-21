using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        
        public static bool ThemNhanVien(NhanVienDTO nv)
        {       
            
            bool kq = false;
            string sql = "insert into NhanVien(HoTenNV, GioiTinh, NgaySinh, DiaChi,MaBangCap, MaChucVu, MaQuocTich, MaBoPhan, NgayBatDauLamViec) values(N'" + nv.HoTenNV + "'," + nv.GioiTinh + ",'" + nv.NgaySinh.ToShortDateString();
            sql += "',N'" + nv.DiaChi + "'," + nv.MaBangCap.ToString() + "," + nv.MaChucVu.ToString() + "," + nv.MaQuocTich.ToString() + ",";
            sql += nv.MaBoPhan.ToString ()+",'"+nv.NgayBatDauLamViec.ToShortDateString ()+"')";
            CDataAdapter c=new CDataAdapter ();
            int n =c.ExecuteNonQuery(sql);
            if (n !=0)
                kq = true;
            return kq;
        }

        

        public static List<NhanVienDTO> LoadALl()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string sql = "select * from NHANVIEN";
            try
            {
                CDataAdapter c = new CDataAdapter();
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNV = int.Parse(dr["MaNV"].ToString());
                    nv.HoTenNV = dr["HoTenNV"].ToString();
                    nv.GioiTinh = int.Parse(dr["GioiTinh"].ToString());
                    nv.NgaySinh = Convert.ToDateTime(dr["NgaySinh"].ToString()); ;
                    nv.DiaChi = dr["DiaChi"].ToString();
                    nv.NgayBatDauLamViec = Convert.ToDateTime(dr["NgayBatDauLamViec"].ToString());
                    nv.MaBangCap = int.Parse(dr["MaBangCap"].ToString());
                    nv.MaBoPhan = int.Parse(dr["MaBoPhan"].ToString());
                    nv.MaChucVu = int.Parse(dr["MaChucVu"].ToString());
                    nv.MaQuocTich = int.Parse(dr["MaQuocTich"].ToString());
                    list.Add(nv);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static int UpdateNhanVien(NhanVienDTO nv)
        {
            int result = 0;
            string sql = "Update NHANVIEN set HoTenNV = '" + nv.HoTenNV + "', NgaySinh = '" + nv.NgaySinh.ToString() + "', NgayBatDauLamViec = '" + nv.NgayBatDauLamViec.ToString() + "', DiaChi = '" + nv.DiaChi +
                "', GioiTinh = '" + nv.GioiTinh.ToString() + "', MaBangCap = '" + nv.MaBangCap.ToString() + "', MaQuocTich = '" + nv.MaQuocTich.ToString() +
                "', MaBoPhan = '" + nv.MaBoPhan.ToString() + "', MaChucVu = '" + nv.MaChucVu.ToString() + "' where MaNV = " + nv.MaNV.ToString();
            CDataAdapter c = new CDataAdapter();
            result = c.ExecuteNonQuery(sql);
            return result;
        }

        public static int DeleteNhanVien(int MaNV)
        {
            int result = 0;
            string sql = "delete from NHANVIEN where MaNV = " + MaNV;
            CDataAdapter c = new CDataAdapter();
            result = c.ExecuteNonQuery(sql);
            return result;
        }
    }
}
