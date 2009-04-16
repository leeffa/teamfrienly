using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiSachDAO
    {

        // Inserting
        public static bool InsertLoaiSach(LoaiSachDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
                sqlParams.Add(new SqlParameter("@Ten", emp.Ten));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertLoaiSach", sqlParams);
                if (n == 1)
                    result = true;
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
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
                sqlParams.Add(new SqlParameter("@Ten", emp.Ten));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdateLoaiSach", sqlParams);
                if (n == 1)
                    result = true;
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
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeleteLoaiSachByID", sqlParams);
                if (n == 1)
                    result = true;
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
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiSachAll");
                foreach (DataRow dr in dt.Rows)
                {
                    LoaiSachDTO emp = new LoaiSachDTO();
                    emp.Ma = dr["Ma"].ToString();
                    emp.Ten = dr["Ten"].ToString();

                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static LoaiSachDTO SelectLoaiSach_Ma(string ma)
        {
            LoaiSachDTO db = new LoaiSachDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaLoaiSach", sqlParams);
                DataRow dr = dt.Rows[0];
                db.Ma = dr["Ma"].ToString();
                db.Ten =dr["Ten"].ToString();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return db;
        }

        public static bool CheckLoaiSachByMa(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaLoaiSach", sqlParams);
                if (dt.Rows.Count == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
