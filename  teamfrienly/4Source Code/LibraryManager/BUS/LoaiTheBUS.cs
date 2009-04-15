using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    class LoaiTheBUS
    {
        public static bool InsertLoaiThe(LoaiTheDTO emp)
        {
            if (LoaiTheDAO.CheckLoaiTheByID(emp.Ma))
            {
                return false;
            }
            return LoaiTheDAO.InsertLoaiThe(emp);
        }
        //Updating
        public static bool UpdateLoaiThe(LoaiTheDTO emp)
        {
            if (LoaiTheDAO.CheckLoaiTheByID(emp.Ma))
            {
                return LoaiTheDAO.UpdateLoaiThe(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteLoaiTheByID(String ma)
        {
            if (LoaiTheDAO.CheckLoaiTheByID(ma))
            {
                return LoaiTheDAO.DeleteLoaiTheByID(ma);
            }
            return false;
        }
        public static List<LoaiTheDTO> SelectLoaiTheAll()
        {
            return LoaiTheDAO.SelectLoaiTheAll();
        }
        public static LoaiTheDTO SelectLoaiTheByID(string ma)
        {
            return LoaiTheDAO.SelectLoaiTheByID(ma);
        }
    }
}
