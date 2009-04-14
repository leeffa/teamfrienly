using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class DenBuBUS
    {
        // Inserting
        public static bool InsertDenBu(DenBuDTO emp)
        {
            
            try
            {               
                bool resulf = DenBuDAO.InsertDenBu(emp);
                return resulf;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static bool UpdateDenBu(DenBuDTO emp)
        {
           
            try
            {
                bool resulf = DenBuDAO.UpdateDenBu(emp);
                return resulf;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool DeleteDenBuByID(int sothutu)
        {
      
            try
            {
                bool resulf = DenBuDAO.DeleteDenBuByID(sothutu);
                return resulf;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<DenBuDTO> SelectDenBuAll()
        {
            List<DenBuDTO> list = new List<DenBuDTO>();
            try
            {
                list = DenBuDAO.SelectDenBuAll();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
