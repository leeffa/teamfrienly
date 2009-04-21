using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class MuonSachBUS
    {
        // Inserting
        public static bool InsertMaMuonSach(ref MuonSachDTO  ms)
        {
//             if (MuonSachDAO .CheckMuonSachByMa (ms.MaMuonSach ))
//             {
//                 return false;
//             }
            return MuonSachDAO.Insert_MuonSach(ref ms);
        }
        //Updating
        public static bool UpdateMuonSach(MuonSachDTO  ms)
        {
            if (MuonSachDAO .CheckMuonSachByMa (ms.MaMuonSach ))
            {
                return MuonSachDAO.Update_MuonSach (ms);
            }
            return false;

        }
        // Deleting
        public static bool DeleteMuonSachByMa(int maMS)
        {
            if (MuonSachDAO.CheckMuonSachByMa (maMS))
            {
                return MuonSachDAO.Delete_MuonSach_Ma (maMS );
            }
            return false;
        }
        // Retrieving
        
        public static List<MuonSachDTO > SelectMuonSachAll()
        {
            return MuonSachDAO .SelectMuonSachAll ();
        }
        public static MuonSachDTO  SelectMuonSachByMa(int maMS)
        {
            if (MuonSachDAO .CheckMuonSachByMa(maMS ))
            {
                return null;
            }
            return MuonSachDAO.SelectMuonSach_Ma (maMS );
        }
        public static MuonSachDTO LayPhieuMuonSach_byMaSach(String maSach)
        {
            return MuonSachDAO.LayPhieuMuonSach_byMaSach(maSach);
        }

        public static MuonSachDTO SelectedMuonSach_byMaSach(String maSach)
        {
            return MuonSachDAO.SelectMuonSach_MaSach(maSach);
           
        }

    }
}
