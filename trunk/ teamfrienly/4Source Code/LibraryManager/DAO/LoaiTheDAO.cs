using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
   public  class LoaiTheDAO
    {
        public static bool InsertLoaiThe(LoaiTheDTO  emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
                sqlParams.Add(new SqlParameter("@TenLoai", emp.TenLoai));
                
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertLoaiThe", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
      public static bool UpdateLoaiThe(LoaiTheDTO emp)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
              sqlParams.Add(new SqlParameter("@TenLoai", emp.TenLoai));
             
              // Call Store Procedure
              int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdateLoaiThe", sqlParams);
              if (n == 1)
                  result = true;
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return result;
      }
      public static bool DeleteLoaiTheByID(String ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", ma));
              // Call Store Procedure
              int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeleteLoaiTheByID", sqlParams);
              if (n == 1)
                  result = true;
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return result;
      }
      public static List<LoaiTheDTO> SelectLoaiTheAll()
      {
          List<LoaiTheDTO> list = new List<LoaiTheDTO>();
          try
          {
              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiTheAll");
              foreach (DataRow dr in dt.Rows)
              {
                  LoaiTheDTO emp = new LoaiTheDTO();
                  emp.Ma = dr["Ma"].ToString();
                  emp.TenLoai = dr["TenLoai"].ToString();
                 
                  list.Add(emp);
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return list;
      }
      public static bool CheckLoaiTheByID(String ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", ma));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiTheByID", sqlParams);
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
       public static LoaiTheDTO SelectLoaiTheByID(string ma)
       {
           LoaiTheDTO emp = new LoaiTheDTO();
           try
           {
               // Create List Sql Parameter
               List<SqlParameter> sqlParams = new List<SqlParameter>();
               sqlParams.Add(new SqlParameter("@Ma", ma));

               DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiTheByID", sqlParams);
               DataRow dr = dt.Rows[0];
               emp.Ma = dr["Ma"].ToString();
               emp.TenLoai = dr["TenLoai"].ToString();



           }
           catch (Exception ex)
           {
               throw ex;
           }
           return emp;
       }

    }

}
