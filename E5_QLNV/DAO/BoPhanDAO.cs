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
        public static List<BoPhanDTO> LoadAll()
        {
            List<BoPhanDTO> list = new List<BoPhanDTO>();
            string sql = "select * from BOPHAN";
            try
            {
                CDataAdapter c = new CDataAdapter();
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    BoPhanDTO bp = new BoPhanDTO();
                    bp.MaBoPhan = int.Parse(dr["MaBoPhan"].ToString());
                    bp.BoPhan = dr["BoPhan"].ToString();
                    list.Add(bp);
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
