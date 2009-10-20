using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAO
{
    class NhanVienDAO
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
    }
}
