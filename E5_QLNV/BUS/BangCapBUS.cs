using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
   public class BangCapBUS
    {
        /*public static DataTable LayBangCap()
        {
            return BangCapDAO .LayBangCap ();
        }*/
       public static List<BangCapDTO> LoadAll()
       {
           return BangCapDAO.LoadAll();
       }
       
    }
}
