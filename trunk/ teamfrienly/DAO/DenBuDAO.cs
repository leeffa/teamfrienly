using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DenBuDAO
    {
        // Inserting
        public static bool InsertDenBu(DenBuDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Mamuonsach));
                sqlParams.Add(new SqlParameter("@SoTien", emp.Sotien));
                
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
        public static bool UpdateDenBu(DenBuDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Mamuonsach));
                sqlParams.Add(new SqlParameter("@SoTien", emp.Sotien));
               
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
        public static bool DeleteDenBuByID(int sothutu)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", sothutu));
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
        public static List<DenBuDTO> SelectDenBuAll()
        {
            List<DenBuDTO> list = new List<DenBuDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheAll");
                foreach (DataRow dr in dt.Rows)
                {
                    DenBuDTO emp = new DenBuDTO();
                    emp.Sothutu = (int)dr["STT"];
                    emp.Mamuonsach = dr["MaMuonSach"].ToString();
                    emp.Sotien = (int)dr["SoTien"];                    
                    list.Add(emp);
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
