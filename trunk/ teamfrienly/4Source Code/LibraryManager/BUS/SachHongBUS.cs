using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
   public class SachHongBUS
    {
        public static bool Insert_SachHong(SachHongDTO SachHongDTO)
        {
            if (SachHongDAO.CheckSachHongByID(SachHongDTO.MaSach))
            {
                return false;
            }
            return SachHongDAO.Insert_SachHong(SachHongDTO);


        }
        public static bool UpdateSachHong(SachHongDTO emp)
        {
            if (SachHongDAO.CheckSachHongByID(emp.MaSach))
            {
                return SachHongDAO.Update_SachHong(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteSachHongByID(string ma)
        {
            if (SachHongDAO.CheckSachHongByID(ma))
            {
                return SachHongDAO.Delete_SachHongByID(ma);
            }
            return false;
        }
        public static List<SachHongDTO> SelectSachHongAll()
        {
            return SachHongDAO.SelectSachHongAll();
        }
       public static SachHongDTO SelectSachHongByID(string Ma)
       {
           return SachHongDAO.SelectSachHongByID(Ma);
       }
    }
}
