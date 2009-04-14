using System;
using System.Collections.Generic;
using System.Text;

using DAO;
using DTO;
namespace BUS
{
    public class SachHongBUS
    {
        // Inserting
        public static bool InsertSachHong(SachHongDTO emp)
        {
           
            try
            {
                bool result = SachHongDAO.InsertSachHong(emp);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static bool UpdateSachHong(SachHongDTO emp)
        {
            
            try
            {
                bool result = SachHongDAO.UpdateSachHong(emp);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static bool DeleteSachHongByID(string masachhong)
        {
            
            try
            {
                bool result = SachHongDAO.DeleteSachHongByID(masachhong);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static List<SachHongDTO> SelectSachHongAll()
        {
            List<SachHongDTO> list = new List<SachHongDTO>();
            try
            {
                list = SachHongDAO.SelectSachHongAll();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
