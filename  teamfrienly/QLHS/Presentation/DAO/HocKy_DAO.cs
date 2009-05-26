using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HocKy_DAO
    {
        //insert Subject
        public static bool InSert_HocKy(HocKy_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocKy", hs.MaHocKy));
                sqlParams.Add(new SqlParameter("@TenHocKy", hs.TenHocKy));


                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInSert_HocKy", sqlParams);
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
        public static bool Update_HocKy(HocKy_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocKy", hs.MaHocKy));
                sqlParams.Add(new SqlParameter("@TenHocKy", hs.TenHocKy));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_HocKy", sqlParams);
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
        public static bool Delete_IDHocKy(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocKy", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdHocKy", sqlParams);
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
        public static List<HocKy_DTO> SelectHocKyAll()
        {
            List<HocKy_DTO> list = new List<HocKy_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectHocKyAll");
                foreach (DataRow dr in dt.Rows)
                {
                    HocKy_DTO s = new HocKy_DTO();

                    s.MaHocKy = dr["MaHocKy"].ToString();
                    s.TenHocKy = dr["TenHocKy"].ToString();

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        //Return 1 record MuonSachDTO use Search
        public static HocKy_DTO SelectHocKy_ID(string ma)
        {
            HocKy_DTO s = new HocKy_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocKy", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectHocKy_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaHocKy = dr["MaHocKy"].ToString();
                s.TenHocKy = dr["TenHocKy"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check Id Type_Mark
        public static bool CheckHocKyByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocKy", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectHocKy_ID", sqlParams);
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
