using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class SachBUS
    {
        // Inserting
        public static bool InsertSach(SachDTO s)
        {
            if (SachDAO.CheckSachByMa(s.Ma))
            {
                return false;
            }
            return SachDAO.Insert_Sach (s);
        }
        //Updating
        public static bool UpdateSach(SachDTO s)
        {
            if (SachDAO.CheckSachByMa (s.Ma ))
            {
                return SachDAO.Update_Sach  (s);
            }
            return false;

        }
        // Deleting
        public static bool DeleteSachByMa(string maS)
        {
            if (SachDAO.CheckSachByMa(maS))
            {
                return SachDAO.Delete_Sach_Ma (maS);
            }
            return false;
        }
        // Retrieving

        public static List<SachDTO> SelectSachAll()
        {
            return SachDAO.SelectMuonSachAll ();
        }
        public static SachDTO SelectSachByMa(string  maS)
        {
            if (!SachDAO.CheckSachByMa(maS))
            {
                return null;
            }
            return SachDAO.SelectSach_Ma (maS);
        }

        public static List<SachDTO> SelectSachByLoaiSach(string maS)
        {
            if (SachDAO.CheckSachByLoaiSach(maS))
            {
                return SachDAO.SelectSachByLoaiSach(maS);
            }
            
            return null;
        }
       
        public static String KiemTraSach(String maSach)
        {
            return SachDAO.KiemTraSach(maSach);
        }

        public static bool CheckMaSach(String maSach)
        {
            return SachDAO.CheckSachByMa(maSach);
        }
    }
}
