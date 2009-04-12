using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhaXBDao
    {
        // Inserting
        public  bool Insert_NhaXB(NhaXBDto nhaxbdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
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
        public  bool Update_NhaXB(NhaXBDto nhaxbdto)
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
        public  bool Delete_NhaXB(NhaXBDto nhaxbdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", nhaxbdto.Ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_NhaXB", sqlParams);
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
