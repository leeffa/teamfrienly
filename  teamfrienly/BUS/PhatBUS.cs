using System;
using System.Collections.Generic;
using System.Text;

using DAO;
using DTO;
namespace BUS
{
    public class PhatBUS
    {
        public static bool InsertPhat(PhatDTO emp)
        {
            bool result = false;
            try
            {
                result = PhatDAO.InsertPhat(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdatePhat(PhatDTO emp)
        {
            bool result = false;
            try
            {
                result = PhatDAO.UpdatePhat(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeletePhatByID(int sothutu)
        {
            bool result = false;
            try
            {
                result = PhatDAO.DeletePhatByID(sothutu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<PhatDTO> SelectPhatAll()
        {
            List<PhatDTO> list = new List<PhatDTO>();
            try
            {
                list = PhatDAO.SelectPhatAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
