using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiSachBUS
    {
        // Inserting
        public static bool InsertLoaiSach(LoaiSachDTO emp)
        {
            if (LoaiSachDAO.CheckLoaiSachByMa(emp.Ma))
            {
                return false;
            }
            return LoaiSachDAO.InsertLoaiSach(emp);
        }

        public static bool UpdateLoaiSach(LoaiSachDTO ms)
        {
            if (LoaiSachDAO.CheckLoaiSachByMa(ms.Ma))
            {
                return LoaiSachDAO.UpdateLoaiSach (ms);
            }
            return false;
        }
        public static bool DeleteLoaiSachByID(String ma)
        {
            if (LoaiSachDAO.CheckLoaiSachByMa(ma))
            {
                return LoaiSachDAO.DeleteLoaiSachByID (ma);
            }
            return false;
        }
        public static List<LoaiSachDTO> SelectLoaiSachAll()
        {
            return LoaiSachDAO.SelectLoaiSachAll ();
        }
        public static LoaiSachDTO SelectLoaiSachByMa(string ma)
        {
           // if (LoaiSachDAO.CheckLoaiSachByMa(ma))
           // {
           //     return null;
           // }
            return LoaiSachDAO.SelectLoaiSach_Ma (ma);
        }
    }
}
