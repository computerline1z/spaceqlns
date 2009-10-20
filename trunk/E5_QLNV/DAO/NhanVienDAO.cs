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
            string sql = "insert into NhanVien values("+nv.MaNV.ToString ()+",N'"+nv.HoTenNV +"',"+nv.GioiTinh +","+nv.NgaySinh .ToString ();
            sql += ",N'" + nv.DiaChi + "'," + nv.MaBanngCap.ToString() + "," + nv.MaChucVu.ToString() + "," + nv.MaQuocTich.ToString() + ",";
            sql += nv.MaBoPhan.ToString ()+","+nv.NgayBatDauLamViec.ToString ()+")";
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
                    nv.MaBanngCap = int.Parse(dr["MaBangCap"].ToString());
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

    }
}
