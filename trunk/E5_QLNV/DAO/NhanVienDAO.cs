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

        public static DataTable LoadDanhSach()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            string sql = " select * from NhanVien";
            CDataAdapter c = new CDataAdapter();
            dt = c.ExecuteQuery(sql);
            return dt;
        }

    }
}
