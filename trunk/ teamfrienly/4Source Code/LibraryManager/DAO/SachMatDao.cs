using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class SachMatDao
    {
        // Inserting
        public static  bool Insert_SachMat(SachMatDto sachmatdtodto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@STT", sachmatdtodto.STT));
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
        public static bool Update_SachMat(SachMatDto sachmatdtodto)
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
        public static bool Delete_SachMatByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));
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
        public static List<SachMatDto> SelectSachMatAll()
        {
            List<SachMatDto> list = new List<SachMatDto>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMatAll");
                foreach (DataRow dr in dt.Rows)
                {
                    SachMatDto emp = new SachMatDto();
                    emp.Ma = dr["Ma"].ToString();
                    emp.STT =(int) dr["STT"];
                   
                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static bool CheckSachMatByID(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMatByID", sqlParams);
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
        public static SachMatDto SelectSachMatByID(string employeeID)
        {
            SachMatDto emp = new SachMatDto();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSach", employeeID));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachMatByID", sqlParams);
                DataRow dr = dt.Rows[0];
                emp.Ma = dr["MaSach"].ToString();
                emp.STT = (int)dr["STT"];

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emp;
        }
    }
}
