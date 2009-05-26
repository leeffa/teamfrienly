using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Khoi_DAO
    {
        //insert student
        public static bool InSert_Khoi(Khoi_DTO  hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", hs.MaKhoi ));
                sqlParams.Add(new SqlParameter("@TenKhoi", hs.TenKhoi ));
                

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_Khoi", sqlParams);
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
        public static bool Update_Khoi(Khoi_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", hs.MaKhoi));
                sqlParams.Add(new SqlParameter("@TenKhoi", hs.TenKhoi));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Khoi", sqlParams);
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
        public static bool Delete_IDKhoi(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdMaKhoi", sqlParams);
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
        public static List<Khoi_DTO > SelectKhoiAll()
        {
            List<Khoi_DTO> list = new List<Khoi_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectKhoiAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Khoi_DTO s = new Khoi_DTO();

                    s.MaKhoi = dr["MaKhoi"].ToString();
                    s.TenKhoi = dr["TenKhoi"].ToString();
                   
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
        public static Khoi_DTO  SelectKhoi_ID(string ma)
        {
            Khoi_DTO s = new Khoi_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectKhoi_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaKhoi = dr["MaKhoi"].ToString();
                s.TenKhoi = dr["TenKhoi"].ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check Id Student
        public static bool CheckKhoiByMa(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectKhoi_ID", sqlParams);
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
