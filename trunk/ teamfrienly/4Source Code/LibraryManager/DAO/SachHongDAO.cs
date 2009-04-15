using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
   public class SachHongDAO
    {
        public static bool  Insert_SachHong(SachHongDTO SachHongDTOdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSach", SachHongDTOdto));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_SachHong", sqlParams);
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
        public static bool Update_SachHong(SachHongDTO SachHongDTOdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", SachHongDTOdto.MaSach));
                //sqlParams.Add(new SqlParameter("@NgaySinh", SachHongDTOdto.NgaySinh));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_SachHong", sqlParams);
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
        public static bool Delete_SachHongByID(string SachHongDTOdto)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", SachHongDTOdto));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_SachHongByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<SachHongDTO> SelectSachHongAll()
        {
            List<SachHongDTO> list = new List<SachHongDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachHongAll");
                foreach (DataRow dr in dt.Rows)
                {
                    SachHongDTO emp = new SachHongDTO();
                    emp.MaSach = dr["MaSach"].ToString();
                    emp.STT = (int)dr["STT"];

                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static bool CheckSachHongByID(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSach", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachHongByID", sqlParams);
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
       public static SachHongDTO SelectSachHongByID(string employeeID)
       {
           SachHongDTO emp = new SachHongDTO();
           try
           {
               // Create List Sql Parameter
               List<SqlParameter> sqlParams = new List<SqlParameter>();
               sqlParams.Add(new SqlParameter("@MaSach", employeeID));

               DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachHongByID", sqlParams);
               DataRow dr = dt.Rows[0];
               emp.MaSach = dr["MaSach"].ToString();
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
