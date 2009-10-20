using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
   public class ChucVuDAO
    {
       public static DataTable LayChucVu()
       {
           string sql = "select * from ChucVu ";
           CDataAdapter c = new CDataAdapter();
           DataTable tb = c.ExecuteQuery(sql);
           return tb;
       }
    }
}
