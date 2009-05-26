using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class Lop_BUS
    {
        // Inserting
        public static bool Insert_Class(Lop_DTO s)
        {
            if (Lop_DAO.CheckClassByID(s.MaLop))
            {
                return false;
            }
            return Lop_DAO.InSert_Class(s);
        }
        //Updating
        public static bool Update_Class(Lop_DTO s)
        {
            if (Lop_DAO.CheckClassByID(s.MaLop))
            {
                return Lop_DAO.Update_Class(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_ClassByID(string maL)
        {
            if (Lop_DAO.CheckClassByID(maL))
            {
                return Lop_DAO.Delete_IDClass(maL);
            }
            return false;
        }
        public static List<Lop_DTO> SelectClassAll()
        {
            return Lop_DAO.SelectLopAll ();
        }
        public static List<Lop_DTO> SelectClassSuitble(string maKhoi)
        {
            return Lop_DAO.SelectLopSuitalbe (maKhoi);
        }
        public static Lop_DTO SelectClassByID(string maS)
        {
            if (!Lop_DAO.CheckClassByID(maS))
            {
                return null;
            }
            return Lop_DAO.SelectLop_ID(maS);
        }
        public static Lop_DTO SelectClassByName(string maS)
        {
            if (!Lop_DAO.CheckClassByName(maS))
            {
                return null;
            }
            return Lop_DAO.SelectLop_TenClass(maS);
        }

        public static bool CheckClassp_ByID(String ma)
        {
            return Lop_DAO.CheckClassByID(ma);
        }
        public static bool CheckClassp_ByName(String name)
        {
            return Lop_DAO.CheckClassByName(name);
        }

        public static int CountClassAll()
        {
            return Lop_DAO.CountLopAll();
        }
    }
}
