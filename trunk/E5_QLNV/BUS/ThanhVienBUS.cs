using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ThanhVienBUS
    { 

        public static bool CheckLogin(ThanhVienDTO tv)
        {
            return ThanhVienDAO.CheckLogin(tv);
        }
    }
}
