using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAO
{
   public class QuocTichDAO
    {
       public static DataTable LayQuocTich()
       {
           string sql = "select * from QuocTich ";
           CDataAdapter c = new CDataAdapter();
           DataTable tb = c.ExecuteQuery(sql);
           return tb;
       }
    }
}
