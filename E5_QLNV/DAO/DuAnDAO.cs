using System;
using System.Collections.Generic;
using System.Text;

using DTO;
namespace DAO
{
    public class DuAnDAO
    {
        public static bool ThemDuAN(DuAnDTO dan)
        {

            bool kq = false;
            string sql = "insert into DuAn values(" + dan.MaDuAn.ToString() + ",N" + dan.TenDuAn + "," + dan.TenKhachHang;
            sql += ",N" + dan.Gia.ToString() + "," + dan.NgayBatDau.ToString () + "," +dan.NgayKetThuc.ToString() + "," dan.NgayGiaoSanPham.ToString() + ")";
           CDataAdapter c = new CDataAdapter();
            int n = c.ExecuteNonQuery(sql);
            
            if (n != 0)
                kq = true;
            return kq;
        }
    }
}
