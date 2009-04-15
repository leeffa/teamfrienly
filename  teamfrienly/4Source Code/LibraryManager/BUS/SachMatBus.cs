using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class SachMatBus
    {
        public static bool Insert_SachMat(SachMatDto sachmatdto)
        {
            if (SachMatDao.CheckSachMatByID(sachmatdto.Ma))
            {
                return false;
            }
            return SachMatDao.Insert_SachMat(sachmatdto);


        }
        public static bool UpdateSachMat(SachMatDto emp)
        {
            if (SachMatDao.CheckSachMatByID(emp.Ma))
            {
                return SachMatDao.Update_SachMat(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteSachMatByID(string ma)
        {
            if (SachMatDao.CheckSachMatByID(ma))
            {
                return SachMatDao.Delete_SachMatByID(ma);
            }
            return false;
        }
        public static List<SachMatDto> SelectSachMatAll()
        {
            return SachMatDao.SelectSachMatAll();
        }
        public static SachMatDto SelectSachMatByID(string Ma)
        {
            return SachMatDao.SelectSachMatByID(Ma);
        }
    }
}
