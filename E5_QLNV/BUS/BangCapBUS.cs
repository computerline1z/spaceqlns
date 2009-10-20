using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    class BangCapBUS
    {
        public static void LayBoPhan()
        {
            return BoPhanDAO.LayBoPhan();
        }
    }
}
