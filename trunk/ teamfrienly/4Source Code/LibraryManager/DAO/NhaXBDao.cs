using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAO
{
    public class NhaXBDao
    {
        // Inserting
        public static  bool Insert_NhaXB(NhaXBDto nhaxbdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", nhaxbdto.Ma));
                sqlParams.Add(new SqlParameter("@Ten", nhaxbdto.Ten));

                 // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_NhaXB", sqlParams);
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
        public static  bool Update_NhaXB(NhaXBDto nhaxbdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ten", nhaxbdto.Ten));
                sqlParams.Add(new SqlParameter("@Ma", nhaxbdto.Ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_NhaXB", sqlParams);
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
        public static bool Delete_NhaXBByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_NhaXBByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<NhaXBDto> SelectNhaXBAll()
        {
            List<NhaXBDto> list = new List<NhaXBDto>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNhaXBAll");
                foreach (DataRow dr in dt.Rows)
                {
                    NhaXBDto emp = new NhaXBDto();
                    emp.Ma = dr["Ma"].ToString();
                    emp.Ten = dr["STT"].ToString();

                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static bool CheckNhaXBByID(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNhaXBByID", sqlParams);
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
        public static NhaXBDto SelectNhaXBByID(string ma)
        {
            NhaXBDto emp = new NhaXBDto();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectNhaXBByID", sqlParams);
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
