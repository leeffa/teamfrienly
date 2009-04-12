using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class TacGiaDao
    {
        // Inserting
        public bool Insert_TacGia(TacGiaDto tacgiadto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
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
        public  bool Update_TacGia(TacGiaDto tacgiadto)
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
        public  bool Delete_TacGia(TacGiaDto tacgiadto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ten",tacgiadto.Ma ));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_TacGia", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        
    
    }
}
