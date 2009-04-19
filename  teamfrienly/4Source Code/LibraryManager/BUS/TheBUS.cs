using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class TheBUS
    {
        public static bool InsertThe(TheDTO temp)
        {
            if (TheDAO.CheckTheByID(temp.Ma))
            {
                return false;
            }
            return TheDAO.InsertThe(temp);
        }
        //Updating
        public static bool UpdateThe(TheDTO temp)
        {
              if (TheDAO.CheckTheByID(temp.Ma))
            {
                 return TheDAO.UpdateThe(temp);
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
        public static TheDTO SelectTheByID(String ID)
        {
            return TheDAO.SelectTheByID(ID);
        }
        public static bool KiemTraThe(String maThe)        
        {
            return TheDAO.KiemTraThe(maThe);
        }
        public static List<TheDTO> SelectTheByLoaiThe(String maloaithe)
        {
            return TheDAO.SelectTheByLoaiThe(maloaithe);
        }
    }
}
