using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.ThemNhanVien(nv);
        }

        public static List<NhanVienDTO> LoadAll()
        {
            return NhanVienDAO.LoadALl();
        }
    }
}
