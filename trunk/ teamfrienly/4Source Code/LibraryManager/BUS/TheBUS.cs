using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class TheBUS
    {
        public static bool InsertThe(TheDTO emp)
        {
            if (TheDAO.CheckTheByID(emp.Ma))
            {
                return false;
            }
            return TheDAO.InsertThe(emp);
        }
        //Updating
        public static bool UpdateThe(TheDTO emp)
        {
            if (TheDAO.CheckTheByID(emp.Ma))
            {
                return TheDAO.UpdateThe(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteTheByID(String ma)
        {
            if (TheDAO.CheckTheByID(ma))
            {
                return TheDAO.DeleteTheByID(ma);
            }
            return false;
        }
        public static List<TheDTO> SelectTheAll()
        {
            return TheDAO.SelectTheAll();
        }
        public static TheDTO SelectTheByID(String employeeID)
        {
            return TheDAO.SelectTheByID(employeeID);
        }
        public static List<TheDTO> SelectTheByLoaiThe(String maloaithe)
        {
            return TheDAO.SelectTheByLoaiThe(maloaithe);
        }
 
    }
}
