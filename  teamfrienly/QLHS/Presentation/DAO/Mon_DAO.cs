using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class Mon_DAO
    {
        //insert Subject
        public static bool InSert_Mon(Mon_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", hs.MaMon));
                sqlParams.Add(new SqlParameter("@TenMon", hs.TenMon));


                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInSert_Mon", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //updating
        public static bool Update_Mon(Mon_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", hs.MaMon));
                sqlParams.Add(new SqlParameter("@TenMon", hs.TenMon));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Mon", sqlParams);
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
        public static bool Delete_IDMon(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdMon", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //return List<HocSinh_DTO> send DataGridView
        public static List<Mon_DTO> SelectMonAll()
        {
            List<Mon_DTO> list = new List<Mon_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMonAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Mon_DTO s = new Mon_DTO();

                    s.MaMon = dr["MaMon"].ToString();
                    s.TenMon = dr["TenMon"].ToString();

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        //count amount Subjects
        public static int CountMonAll()
        {
            int count = 0;
            List<Mon_DTO> list = new List<Mon_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMonAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Mon_DTO s = new Mon_DTO();

                    s.MaMon = dr["MaMon"].ToString();
                    s.TenMon = dr["TenMon"].ToString();
                    count++;
                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        //Return 1 record MuonSachDTO use Search
        public static Mon_DTO SelectMon_ID(string ma)
        {
            Mon_DTO s = new Mon_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMon_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaMon = dr["MaMon"].ToString();
                s.TenMon = dr["TenMon"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check Id Type_Mark
        public static bool CheckMonByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMon_ID", sqlParams);
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
