using System;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using DTO;

namespace DAO
{
    public class BangCapDAO
    {
        /*public static DataTable LayBangCap()
        {
            string sql = "select* from BangCap ";
            CDataAdapter c = new CDataAdapter();
            DataTable tb = c.ExecuteQuery(sql);            
            return tb;
        }*/
        public static List<BangCapDTO> LoadAll()
        {
            List<BangCapDTO> list = new List<BangCapDTO>();
            string sql = "select * from BANGCAP";
            try
            {
                CDataAdapter c = new CDataAdapter();
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    BangCapDTO bc = new BangCapDTO();
                    bc.MaBangCap = int.Parse(dr["MaBangCap"].ToString());
                    bc.BangCap = dr["BangCap"].ToString();
                    list.Add(bc);
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
