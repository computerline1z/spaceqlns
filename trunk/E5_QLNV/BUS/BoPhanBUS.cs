using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BoPhanBUS
    {
        public static DataTable LayBoPhan()
        {                            
                return BoPhanDAO .LayBoPhan ();
        }
    }
}
