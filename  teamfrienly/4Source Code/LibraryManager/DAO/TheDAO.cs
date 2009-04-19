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
        public static bool InsertThe(TheDTO  temp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", temp.Ma));
                sqlParams.Add(new SqlParameter("@LoaiThe", temp.LoaiThe));
                sqlParams.Add(new SqlParameter("@NgayCap", temp.NgayCap));
                sqlParams.Add(new SqlParameter("@NgayHetHan", temp.NgayHetHan));
                sqlParams.Add(new SqlParameter("@TenDocGia", temp.TenDocGia));
                sqlParams.Add(new SqlParameter("@NgaySinh", temp.NgaySinh));
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
      public static bool UpdateThe(TheDTO temp)
      {
          bool result = false;
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", temp.Ma));
              sqlParams.Add(new SqlParameter("@LoaiThe", temp.LoaiThe));
              sqlParams.Add(new SqlParameter("@NgayCap", temp.NgayCap));
              sqlParams.Add(new SqlParameter("@NgayHetHan", temp.NgayHetHan));
              sqlParams.Add(new SqlParameter("@TenDocGia", temp.TenDocGia));
              sqlParams.Add(new SqlParameter("@NgaySinh", temp.NgaySinh));
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
                  TheDTO temp = new TheDTO();
                  temp.Ma = dr["Ma"].ToString();
                  temp.LoaiThe = dr["LoaiThe"].ToString();
                  temp.NgayCap =(DateTime) dr["NgayCap"];
                  temp.NgayHetHan = (DateTime)dr["NgayHetHan"];
                  temp.TenDocGia= dr["TenDocGia"].ToString();
                  temp.NgaySinh = (DateTime)dr["NgaySinh"];
                  list.Add(temp);
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
      public static TheDTO SelectTheByID(String ID)
      {
         TheDTO temp = new TheDTO();
          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", ID));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheByID", sqlParams);
              if (dt.Rows.Count == 0)
                  return temp;
              DataRow dr = dt.Rows[0];
              temp.Ma= dr["Ma"].ToString().Trim();
              temp.LoaiThe = dr["LoaiThe"].ToString().Trim();
              temp.NgayCap = (DateTime) dr["NgayCap"];
              temp.NgayHetHan = (DateTime)dr["NgayHetHan"];
              temp.TenDocGia = dr["TenDocGia"].ToString().Trim();
              if (dr["NgaySinh"].ToString()!="")
                  temp.NgaySinh = (DateTime)dr["NgaySinh"];
          }
          catch (Exception ex)
          {
              throw ex;
          }
          return temp;
      }
      public static bool KiemTraThe(String maThe)
      {
          try
          {
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", maThe));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheByID", sqlParams);
              if (dt.Rows.Count == 0)
                  return false;
              DataRow dr = dt.Rows[0];
              if (DateTime.Compare((DateTime)dr["NgayHetHan"], DateTime.Now) < 0)
                  return false;
              else
                  return true;             
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

      public static List<TheDTO> SelectTheByLoaiThe(String maloaithe)
      {
          List<TheDTO> list = new List<TheDTO>();

          try
          {
              // Create List Sql Parameter
              List<SqlParameter> sqlParams = new List<SqlParameter>();
              sqlParams.Add(new SqlParameter("@Ma", maloaithe));

              DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheByLoaiThe", sqlParams);
              foreach (DataRow dr in dt.Rows)
              {
                  TheDTO the = new TheDTO();

                  the.Ma = dr["Ma"].ToString();
                  the.LoaiThe = dr["LoaiThe"].ToString();
                  the.NgayCap = (DateTime)dr["NgayCap"];
                  the.NgayHetHan = (DateTime)dr["NgayHetHan"];
                  the.TenDocGia = dr["TenDocGia"].ToString();
                  if (dr["NgaySinh"].ToString()!="")
                  {
                      the.NgaySinh = (DateTime)dr["NgaySinh"];
                  }                  
                  list.Add(the);
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

