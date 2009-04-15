using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
  public  class TheDAO
    {
        // Inserting
        public static bool InsertThe(TheDTO  emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
                sqlParams.Add(new SqlParameter("@LoaiThe", emp.LoaiThe));
                sqlParams.Add(new SqlParameter("@NgayCap", emp.NgayCap));
                sqlParams.Add(new SqlParameter("@NgayHetHan", emp.NgayHetHan));
                sqlParams.Add(new SqlParameter("@TenDocGia", emp.TenDocGia));
                sqlParams.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
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
      public static bool UpdateThe(TheDTO emp)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", emp.Ma));
              sqlParams.Add(new SqlParameter("@LoaiThe", emp.LoaiThe));
              sqlParams.Add(new SqlParameter("@NgayCap", emp.NgayCap));
              sqlParams.Add(new SqlParameter("@NgayHetHan", emp.NgayHetHan));
              sqlParams.Add(new SqlParameter("@TenDocGia", emp.TenDocGia));
              sqlParams.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
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
      public static bool DeleteTheByID(String ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", ma));
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
      public static List<TheDTO> SelectTheAll()
      {
          List<TheDTO> list = new List<TheDTO>();
          try
          {
              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheAll");
              foreach (DataRow dr in dt.Rows)
              {
                  TheDTO emp = new TheDTO();
                  emp.Ma = dr["Ma"].ToString();
                  emp.LoaiThe = dr["LoaiThe"].ToString();
                  emp.NgayCap =(DateTime) dr["NgayCap"];
                  emp.NgayHetHan = (DateTime)dr["NgayHetHan"];
                  emp.TenDocGia= dr["TenDocGia"].ToString();
                  emp.NgaySinh = (DateTime)dr["NgaySinh"];
                  list.Add(emp);
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return list;
      }
      public static bool CheckTheByID(String ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", ma));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheByID", sqlParams);
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