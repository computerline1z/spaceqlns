using System;
using System.Collections.Generic;
using System.Text;

using DTO;
namespace DAO
{
    public class DuAnDAO
    {
        public static bool ThemDuAn(DuAnDTO dan)
        {

            bool kq = false;
            string sql = "insert into DuAn values(N'"   + dan.TenDuAn + "','" ;
            sql +=  dan.NgayBatDau.ToString () + "','" + dan.NgayKetThuc.ToString() + "','" + dan.NgayGiaoSanPham.ToString();
            sql+="',N'"+dan.TenKhachHang +"',"+dan .Gia .ToString ()+")";            
           CDataAdapter c = new CDataAdapter();
            int n = c.ExecuteNonQuery(sql);
            
            if (n != 0)
                kq = true;
            return kq;
        }
    }
    
}
