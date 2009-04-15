using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class TacGiaBus
    {
        public static bool Insert_TacGia(TacGiaDto TacGiaDto)
        {
            if (TacGiaDao.CheckTacGiaByID(TacGiaDto.Ma))
            {
                return false;
            }
            return TacGiaDao.Insert_TacGia(TacGiaDto);


        }
        public static bool UpdateTacGia(TacGiaDto emp)
        {
            if (TacGiaDao.CheckTacGiaByID(emp.Ma))
            {
                return TacGiaDao.Update_TacGia(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteTacGiatByID(string ma)
        {
            if (TacGiaDao.CheckTacGiaByID(ma))
            {
                return TacGiaDao.Delete_TacGiaByID(ma);
            }
            return false;
        }
        public static List<TacGiaDto> SelectTacGiaAll()
        {
            return TacGiaDao.SelectTacGiaAll();
        }
        public static TacGiaDto SelectTheByID(String ma)
        {
            return TacGiaDao.SelectTacGiaByID(ma);
        }
    }
}
