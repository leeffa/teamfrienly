using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAO
{
    public class TacGiaDao
    {
        // Inserting
        public static bool Insert_TacGia(TacGiaDto tacgiadto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", tacgiadto.Ma));
                sqlParams.Add(new SqlParameter("@Ten", tacgiadto.Ten));
                sqlParams.Add(new SqlParameter("@NgaySinh", tacgiadto.NgaySinh));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_TacGia", sqlParams);
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
        public static bool Update_TacGia(TacGiaDto tacgiadto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ten", tacgiadto.Ten));
                sqlParams.Add(new SqlParameter("@NgaySinh", tacgiadto.NgaySinh));
                 // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_TacGia", sqlParams);
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
        public  static bool Delete_TacGiaByID(string tacgiadto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ten",tacgiadto ));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_TacGiaByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<TacGiaDto> SelectTacGiaAll()
        {
            List<TacGiaDto> list = new List<TacGiaDto>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTacgiaAll");
                foreach (DataRow dr in dt.Rows)
                {
                    TacGiaDto temp = new TacGiaDto();
                    temp.Ma = dr["Ma"].ToString();
                    temp.Ten = dr["Ten"].ToString();
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
        public static bool CheckTacGiaByID(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTacGiaByID", sqlParams);
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
        public static TacGiaDto SelectTacGiaByID(String employeeID)
        {
            TacGiaDto temp = new TacGiaDto();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", employeeID));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTacGiaByID", sqlParams);
                if (dt.Rows.Count==0)
                {
                    return temp;
                }
                DataRow dr = dt.Rows[0];
                temp.Ma = dr["Ma"].ToString();
                temp.Ten = dr["Ten"].ToString();
                if (dr["NgaySinh"].ToString()!="")
                {
                    temp.NgaySinh = (DateTime)dr["NgaySinh"];
                }
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return temp;
        }

        
    
    }
}
