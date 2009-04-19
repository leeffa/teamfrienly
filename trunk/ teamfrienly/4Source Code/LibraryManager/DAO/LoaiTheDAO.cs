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
        public static bool InsertLoaiThe(LoaiTheDTO  temp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", temp.Ma));
                sqlParams.Add(new SqlParameter("@TenLoai", temp.TenLoai));
                
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
      public static bool UpdateLoaiThe(LoaiTheDTO temp)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", temp.Ma));
              sqlParams.Add(new SqlParameter("@TenLoai", temp.TenLoai));
             
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
              // Create List Sql Parameter

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiTheAll");
              foreach (DataRow dr in dt.Rows)
              {
                  LoaiTheDTO temp = new LoaiTheDTO();
                  temp.Ma = dr["Ma"].ToString().Trim();
                  temp.TenLoai = dr["TenLoai"].ToString().Trim();
                 
                  list.Add(temp);
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
           LoaiTheDTO temp = new LoaiTheDTO();
           try
           {
               // Create List Sql Parameter
               List<SqlParameter> sqlParams = new List<SqlParameter>();
               sqlParams.Add(new SqlParameter("@Ma", ma));

               DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiTheByID", sqlParams);
               if (dt.Rows.Count == 0)
                   return temp;

               DataRow dr = dt.Rows[0];
               temp.Ma = dr["Ma"].ToString().Trim();
               temp.TenLoai = dr["TenLoai"].ToString().Trim();

           }
           catch (Exception ex)
           {
               throw ex;
           }
           return temp;
       }

    }

}
