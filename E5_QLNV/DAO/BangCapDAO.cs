using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using DTO;
namespace DAO
{
    public class BangCapDAO
    {
        public static DataTable LayBangCap()
        {
            string sql = "select * from BangCap ";
            CDataAdapter c = new CDataAdapter();
            DataTable tb = c.ExecuteQuery(sql);            
            return tb;
        }
    }
}
