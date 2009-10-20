using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class ChucVuBUS
    {
        public static DataTable LayChucVu()
        {
            return ChucVuDAO.LayChucVu();
        }
    }
}
