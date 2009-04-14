using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class SachHongDAO
    {
        // Inserting
        public static bool InsertSachHong(SachHongDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSachHong", emp.Masachhong));
                sqlParams.Add(new SqlParameter("@MaSach", emp.Masach));                

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertThe", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdateSachHong(SachHongDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSachHong", emp.Masachhong));
                sqlParams.Add(new SqlParameter("@MaSach", emp.Masach));        
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdateThe", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeleteSachHongByID(string masachhong)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSachHong", masachhong));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeleteTheByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<SachHongDTO> SelectSachHongAll()
        {
            List<SachHongDTO> list = new List<SachHongDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheAll");
                foreach (DataRow dr in dt.Rows)
                {
                    SachHongDTO emp = new SachHongDTO();
                    emp.Masachhong = dr["MaSachHong"].ToString();
                    emp.Masach = dr["MaSach"].ToString();                    
                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
