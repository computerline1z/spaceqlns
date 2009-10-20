using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
   public class ChucVuDAO
    {
       /*public static DataTable LayChucVu()
       {
           string sql = "select * from ChucVu ";
           CDataAdapter c = new CDataAdapter();
           DataTable tb = c.ExecuteQuery(sql);
           return tb;
       }*/

       public static List<ChucVuDTO> LoadAll()
       {
           List<ChucVuDTO> list = new List<ChucVuDTO>();
           string sql = "select * from CHUCVU";
           try
           {
               CDataAdapter c = new CDataAdapter();
               DataTable dt = new DataTable();
               dt = c.ExecuteQuery(sql);
               foreach (DataRow dr in dt.Rows)
               {
                   ChucVuDTO cv = new ChucVuDTO();
                   cv.MaChucVu = int.Parse(dr["MaChucVu"].ToString());
                   cv.ChucVu = dr["ChucVu"].ToString();
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
