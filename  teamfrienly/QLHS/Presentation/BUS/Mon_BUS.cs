using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class Mon_BUS
    {
        // Inserting
        public static bool Insert_Mon(Mon_DTO s)
        {
            if (Mon_DAO.CheckMonByID(s.MaMon))
            {
                return false;
            }
            return Mon_DAO.InSert_Mon(s);
        }
        //Updating
        public static bool Update_Mon(Mon_DTO s)
        {
            if (Mon_DAO.CheckMonByID(s.MaMon))
            {
                return Mon_DAO.Update_Mon(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_MonByID(string maK)
        {
            if (Mon_DAO.CheckMonByID(maK))
            {
                return Mon_DAO.Delete_IDMon(maK);
            }
            return false;
        }
        public static List<Mon_DTO> SelectMonAll()
        {
            return Mon_DAO.SelectMonAll();
        }
        //count amount
        public static int CountMonAll()
        {
            return Mon_DAO.CountMonAll ();
        }
        public static Mon_DTO SelectMonByID(string maS)
        {
            if (!Mon_DAO.CheckMonByID(maS))
            {
                return null;
            }
            return Mon_DAO.SelectMon_ID(maS);
        }
        public static bool CheckMon_ByID(String ma)
        {
            return Mon_DAO.CheckMonByID(ma);
        }
    }
}
