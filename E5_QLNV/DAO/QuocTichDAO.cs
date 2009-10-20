using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
   public class QuocTichDAO
    {
       /*public static DataTable LayQuocTich()
       {
           string sql = "select * from QuocTich ";
           CDataAdapter c = new CDataAdapter();
           DataTable tb = c.ExecuteQuery(sql);
           return tb;
       }
       */
       public static List<QuocTichDTO> LoadAll()
       {
           List<QuocTichDTO> list = new List<QuocTichDTO>();
           string sql = "select * from QUOCTICH";
           try
           {
               CDataAdapter c = new CDataAdapter();
               DataTable dt = new DataTable();
               dt = c.ExecuteQuery(sql);
               foreach (DataRow dr in dt.Rows)
               {
                   QuocTichDTO cv = new QuocTichDTO();
                   cv.MaQuocTich = int.Parse(dr["MaQuocTich"].ToString());
                   cv.QuocTich = dr["QuocTich"].ToString();
                   list.Add(cv);
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
