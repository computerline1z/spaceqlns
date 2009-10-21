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
        public static int Delete(int MaNV)
        {
            return NhanVienDAO.DeleteNhanVien(MaNV);
        }
        public static int Update(NhanVienDTO nv)
        {
            return NhanVienDAO.UpdateNhanVien(nv);
        }
    }
}
