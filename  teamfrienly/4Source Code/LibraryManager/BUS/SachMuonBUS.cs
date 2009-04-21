using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class SachMuonBUS
    {
        public static bool InsertSachMuon(SachMuonDTO emp)
        {
            if (SachMuonDAO.CheckSachMuonByID(emp.MaMuonSach))
            {
                return false;
            }
            return SachMuonDAO.InsertSachMuon(emp);
        }
        //Updating
        public static bool UpdateSachMuon(SachMuonDTO emp)
        {
            if (SachMuonDAO.CheckSachMuonByID(emp.MaMuonSach))
            {
                return SachMuonDAO.UpdateSachMuon(emp);
            }
            return false;

        }
        // Deleting
        public static bool DeleteSachMuonByID(int ma)
        {
            if (SachMuonDAO.CheckSachMuonByID(ma))
            {
                return SachMuonDAO.DeleteSachMuonByID(ma);
            }
            return false;
        }
        public static List<SachMuonDTO> SelectSachMuonAll()
        {
            return SachMuonDAO.SelectSachMuonAll();
        }
        public static SachMuonDTO SelectSachMuonByID(int ma)
        {
            return SachMuonDAO.SelectSachMuonByID(ma);
        }

        public static bool  CheckedSachMuonByID(int ma)
        {
            return SachMuonDAO.CheckSachMuonByID (ma);
        }
      
    }
}
