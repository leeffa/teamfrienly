using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAO
{
    public class NgonNguDao
    {
        // Inserting
        public static bool Insert_NgonNgu(NgonNguDto ngonngudto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ngonngudto.Ma));
                sqlParams.Add(new SqlParameter("@Ten", ngonngudto.Ten));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_NgonNgu", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //Updating
        public static bool Update_NgonNgu(NgonNguDto ngonngudto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ten", ngonngudto.Ten));
                sqlParams.Add(new SqlParameter("@Ma", ngonngudto.Ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_NgonNgu", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        // Deleting
        public static bool Delete_NgonNguByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_NgonNguByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<NgonNguDto> SelectNgonNguAll()
        {
            List<NgonNguDto> list = new List<NgonNguDto>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNgonNguAll");
                foreach (DataRow dr in dt.Rows)
                {
                    NgonNguDto emp = new NgonNguDto();
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
        public static bool CheckNgonNguByID(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNgonNguByID", sqlParams);
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
        public static NgonNguDto SelectNgonNguByID(string ma)
        {
            NgonNguDto emp = new NgonNguDto();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNgonNguByID", sqlParams);
                DataRow dr = dt.Rows[0];
                emp.Ma = dr["Ma"].ToString();
                emp.Ten = dr["Ten"].ToString();



            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emp;
        }
    }
}
