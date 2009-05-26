using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HocKy_BUS
    {
        //insert Semester
        public static bool Insert_HocKy(HocKy_DTO s)
        {
            if (HocKy_DAO.CheckHocKyByID(s.MaHocKy))
            {
                return false;
            }
            return HocKy_DAO.InSert_HocKy(s);
        }
        //Updating
        public static bool Update_HocKy(HocKy_DTO s)
        {
            if (HocKy_DAO.CheckHocKyByID(s.MaHocKy))
            {
                return HocKy_DAO.Update_HocKy(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_HocKyByID(string maK)
        {
            if (HocKy_DAO.CheckHocKyByID(maK))
            {
                return HocKy_DAO.Delete_IDHocKy(maK);
            }
            return false;
        }
        public static List<HocKy_DTO> SelectHocKyAll()
        {
            return HocKy_DAO.SelectHocKyAll();
        }
        public static HocKy_DTO SelectHocKyByID(string maS)
        {
            if (!HocKy_DAO.CheckHocKyByID(maS))
            {
                return null;
            }
            return HocKy_DAO.SelectHocKy_ID(maS);
        }
        public static bool CheckHocKy_ByID(String ma)
        {
            return HocKy_DAO.CheckHocKyByID(ma);
        }

    }
}
