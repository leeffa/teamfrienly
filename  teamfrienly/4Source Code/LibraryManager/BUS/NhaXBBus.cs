using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class NhaXBBus
    {
        public static bool Insert_NhaXB(NhaXBDto NhaXBDto)
        {
            if (NhaXBDao.CheckNhaXBByID(NhaXBDto.Ma))
            {
                return false;
            }
            return NhaXBDao.Insert_NhaXB(NhaXBDto);


        }
        public static bool Update_NhaXB(NhaXBDto emp)
        {
            if (NhaXBDao.CheckNhaXBByID(emp.Ma))
            {
                return NhaXBDao.Update_NhaXB(emp);
            }
            return false;

        }
        // Deleting
        public static bool Delete_NhaXBByID(string ma)
        {
            if (NhaXBDao.CheckNhaXBByID(ma))
            {
                return NhaXBDao.Delete_NhaXBByID(ma);
            }
            return false;
        }
        public static List<NhaXBDto> SelectNhaXBAll()
        {
            return NhaXBDao.SelectNhaXBAll();
        }
        public static NhaXBDto SelectNhaXBByID(string ma)
        {
            return NhaXBDao.SelectNhaXBByID(ma);
        }

    }
}
