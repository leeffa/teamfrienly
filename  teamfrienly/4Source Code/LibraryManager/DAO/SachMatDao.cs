using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class SachMatDao
    {
        // Inserting
        public  bool Insert_SachMat(SachMatDto sachmatdtodto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSach", sachmatdtodto.Ma));
                 // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_SachMat", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //Updating --> tao thay khong ton tai nhu cau update sach mat 
        public  bool Update_SachMat(SachMatDto sachmatdtodto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", sachmatdtodto.Ma));
                //sqlParams.Add(new SqlParameter("@NgaySinh", sachmatdtodto.NgaySinh));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_SachMat", sqlParams);
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
        public  bool Delete_SachMat(SachMatDto sachmatdtodto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", sachmatdtodto.Ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_SachMat", sqlParams);
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
