using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class PhatBUS
    {
        // Inserting
        public static bool InsertPhat(PhatDTO temp)
        {
            return PhatDAO.InsertPhat(temp);
            
        }
        public static bool UpdatePhat(PhatDTO temp)
        {
            return PhatDAO.UpdatePhat(temp);
        }
        
        public static bool DeletePhatByID(int sothutu)
        {
            return PhatDAO.DeletePhatByID(sothutu);
        }
        public static List<PhatDTO> SelectPhatAll()
        {
            return PhatDAO.SelectPhatAll();
        }
        public static bool CheckPhatByID(int stt)
        {
            return PhatDAO.CheckPhatByID(stt);
        }
        public static PhatDTO SelectPhatByID(int STT)
        {
            return PhatDAO.SelectPhatByID(STT);
        }

    }

}

