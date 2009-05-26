using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class Khoi_BUS
    {
        // Inserting
        public static bool Insert_Khoi(Khoi_DTO  s)
        {
            if (Khoi_DAO.CheckKhoiByMa (s.MaKhoi ))
            {
                return false;
            }
            return Khoi_DAO.InSert_Khoi (s);
        }
        //Updating
        public static bool Update_Khoi(Khoi_DTO s)
        {
            if (Khoi_DAO.CheckKhoiByMa(s.MaKhoi))
            {
                return Khoi_DAO.Update_Khoi(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_KhoiByID(string maK)
        {
            if (Khoi_DAO.CheckKhoiByMa(maK))
            {
                return Khoi_DAO.Delete_IDKhoi (maK);
            }
            return false;
        }
        public static List<Khoi_DTO > SelectKhoiAll()
        {
            return Khoi_DAO.SelectKhoiAll();
        }
        public static Khoi_DTO SelectKhoiByID(string maS)
        {
            if (!Khoi_DAO.CheckKhoiByMa (maS))
            {
                return null;
            }
            return Khoi_DAO.SelectKhoi_ID (maS);
        }
        public static bool CheckKhoi_ByID(String ma)
        {
            return Khoi_DAO.CheckKhoiByMa (ma);
        }
    }
}
