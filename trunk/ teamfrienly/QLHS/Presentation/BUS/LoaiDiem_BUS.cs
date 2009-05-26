using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiDiem_BUS
    {
        // Inserting
        public static bool Insert_LoaiDiem(LoaiDiem_DTO s)
        {
            if (LoaiDiem_DAO.CheckLoaiDiemByID(s.MaLoaiDiem))
            {
                return false;
            }
            return LoaiDiem_DAO.InSert_LoaiDiem(s);
        }
        //Updating
        public static bool Update_LoaiDiem(LoaiDiem_DTO s)
        {
            if (LoaiDiem_DAO.CheckLoaiDiemByID(s.MaLoaiDiem))
            {
                return LoaiDiem_DAO.Update_LoaiDiem(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_LoaiDiemByID(string maL)
        {
            if (LoaiDiem_DAO.CheckLoaiDiemByID(maL))
            {
                return LoaiDiem_DAO.Delete_IDLoaiDiem(maL);
            }
            return false;
        }

        public static List<LoaiDiem_DTO> SelectLoaiDiemAll()
        {
            return LoaiDiem_DAO.SelectLoaiDiemAll();
        }
        public static LoaiDiem_DTO SelectLoaiDiemByID(string maS)
        {
            if (!LoaiDiem_DAO.CheckLoaiDiemByID(maS))
            {
                return null;
            }
            return LoaiDiem_DAO.SelectLoaiDiem_ID(maS);
        }

    }
}
