using System;
using System.Collections.Generic;
using System.Text;

using DAO;
using DTO;

namespace BUS
{
    public class DuAnBUS
    {


        public static bool ThemDuAn(DuAnDTO dan)
        {
            return DuAnDAO.ThemDuAn (dan);
        }

        
    }
   
}
