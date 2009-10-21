using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class ThanhVienDAO
    {

        public static bool CheckLogin( ThanhVienDTO tv)
        {
            bool kq = false;
            string sql = "select * from ThanhVien";
            CDataAdapter c = new CDataAdapter();
            DataTable dt = new DataTable();
            dt = c.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ThanhVienDTO tvcheck = new ThanhVienDTO();
                tvcheck.MaUser = dr["MaUser"].ToString();
                tvcheck.Password = dr["Password"].ToString();
                if (tv.MaUser == tvcheck.MaUser && tv.Password == tvcheck.Password)
                    kq = true;  
            }

            return kq;
        }
    }
}
