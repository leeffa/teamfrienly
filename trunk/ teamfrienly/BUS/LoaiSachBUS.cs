using System;
using System.Collections.Generic;
using System.Text;

using DAO;
using DTO;
namespace BUS
{
    public class LoaiSachBUS
    {
        // Inserting
        public static bool InsertLoaiSach(LoaiSachDTO emp)
        {
            bool result = false;
            try
            {
                result = LoaiSachDAO.InsertLoaiSach(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdateLoaiSach(LoaiSachDTO emp)
        {
            bool result = false;
            try
            {
                result = LoaiSachDAO.UpdateLoaiSach(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeleteLoaiSachByID(String ma)
        {
            bool result = false;
            try
            {
                result = LoaiSachDAO.DeleteLoaiSachByID(ma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<LoaiSachDTO> SelectLoaiSachAll()
        {
            List<LoaiSachDTO> list = new List<LoaiSachDTO>();
            try
            {
                list = LoaiSachDAO.SelectLoaiSachAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
