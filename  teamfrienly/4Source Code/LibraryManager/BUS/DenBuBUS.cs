using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DenBuBUS
    {
        // Inserting
        public static bool InsertDenBu(DenBuDTO emp)
        {

            if (DenBuDAO.CheckDenBuBySTT(emp.Mamuonsach ))
            {
                return false;
            }
            return DenBuDAO.InsertDenBu (emp);

        }
        public static bool UpdateDenBu(DenBuDTO emp)
        {

            if (DenBuDAO.CheckDenBuBySTT(emp.Mamuonsach))
            {
                return DenBuDAO.UpdateDenBu(emp);
            }
            return false;
        }
        public static bool DeleteDenBuByID(int ma)
        {

            if (DenBuDAO.CheckDenBuBySTT(ma))
            {
                return DenBuDAO.DeleteDenBuByID (ma);
            }
            return false;

        }
        public static List<DenBuDTO> SelectDenBuAll()
        {
            return DenBuDAO.SelectDenBuAll ();
        }

        public static DenBuDTO SelectDenBuByMa(int maSachMuon)
        {
            if (DenBuDAO.CheckDenBuBySTT(maSachMuon))
            {
                return null;
            }
            return DenBuDAO.SelectDenBu_Ma (maSachMuon);
        }

        public static bool SelectDenBuByMaMuonSach(int maSachMuon)
        {
            
            return DenBuDAO.CheckDenBuByMaMuonSach (maSachMuon);
           // return DenBuDAO.CheckDenBuByMaMuonSach(maSachMuon);
        }

       
    }
}
