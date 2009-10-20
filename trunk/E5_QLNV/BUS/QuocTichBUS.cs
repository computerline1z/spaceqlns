using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class QuocTichBUS
    {
        /*public static DataTable LayQuocTich()
        {
            return QuocTichDAO.LayQuocTich();
        }*/
        public static List<QuocTichDTO>LoadAll()
        {
            return QuocTichDAO.LoadAll();
        }
       
    }
}
