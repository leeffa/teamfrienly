using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;


namespace BUS
{
    public class NgonNguBus
    {
        public static bool Insert_NgonNgu(NgonNguDto NgonNguDto)
        {
            if (NgonNguDao.CheckNgonNguByID(NgonNguDto.Ma))
            {
                return false;
            }
            return NgonNguDao.Insert_NgonNgu(NgonNguDto);


        }
        public static bool UpdateNgonNgu(NgonNguDto emp)
        {
            if (NgonNguDao.CheckNgonNguByID(emp.Ma))
            {
                return NgonNguDao.Update_NgonNgu(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteNgonNguByID(string ma)
        {
            if (NgonNguDao.CheckNgonNguByID(ma))
            {
                return NgonNguDao.Delete_NgonNguByID(ma);
            }
            return false;
        }
        public static List<NgonNguDto> SelectNgonNguAll()
        {
            return NgonNguDao.SelectNgonNguAll();
        }
        public static NgonNguDto SelectNgonNguByID(string ma)
        { 
            return NgonNguDao.SelectNgonNguByID(ma);
        }
    }
}
