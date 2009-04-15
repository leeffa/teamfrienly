using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
  public   class SachMuonDAO
    {
         public static bool InsertSachMuon(SachMuonDTO  emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.MaMuonSach));
                
                
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertSachMuon", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
      public static bool UpdateSachMuon(SachMuonDTO emp)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@MaMuonSach", emp.MaMuonSach));
              
             
              // Call Store Procedure
              int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdateSachMuon", sqlParams);
              if (n == 1)
                  result = true;
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return result;
      }
      public static bool DeleteSachMuonByID(int ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@MaMuonSach", ma));
              // Call Store Procedure
              int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeleteSachMuonByID", sqlParams);
              if (n == 1)
                  result = true;
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return result;
      }
      public static List<SachMuonDTO> SelectSachMuonAll()
      {
          List<SachMuonDTO> list = new List<SachMuonDTO>();
          try
          {
              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMuonAll");
              foreach (DataRow dr in dt.Rows)
              {
                  SachMuonDTO emp = new SachMuonDTO();
                  emp.MaMuonSach = (int)dr["MaMuonSach"];
                  
                 
                  list.Add(emp);
              }
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return list;
      }
      public static bool CheckSachMuonByID(int ma)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@MaMuonSach", ma));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMuonByID", sqlParams);
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
      public static SachMuonDTO SelectSachMuonByID(int employeeID)
      {
          SachMuonDTO emp = new SachMuonDTO();
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@MaMuonSach", employeeID));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMuonByID", sqlParams);
              DataRow dr = dt.Rows[0];
              emp.MaMuonSach =(int) dr["MaMuonSach"];
             

          }
          catch (Exception ex)
          {
              throw ex;
          }
          return emp;
      }

    }

    
}
