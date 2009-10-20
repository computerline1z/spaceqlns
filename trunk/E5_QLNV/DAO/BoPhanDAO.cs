using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAO
{
    public class BoPhanDAO
    {
        public static DataTable LayBoPhan()
        {
            string sql = "select * from BoPhan ";
            CDataAdapter c = new CDataAdapter();
            DataTable tb = c.ExecuteQuery(sql);
            return tb;
        }
    }
}
