using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiDiem_DAO
    {
        //insert stype mark
        public static bool InSert_LoaiDiem(LoaiDiem_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoaiDiem", hs.MaLoaiDiem));
                sqlParams.Add(new SqlParameter("@Diem15p", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@Diem1t", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@DiemCuoiKy", hs.DiemCuoiKy));


                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInSert_LoaiDiem", sqlParams);
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
        public static bool Update_LoaiDiem(LoaiDiem_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoaiDiem", hs.MaLoaiDiem));
                sqlParams.Add(new SqlParameter("@Diem15p", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@Diem1t", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@DiemCuoiKy", hs.DiemCuoiKy));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_LoaiDiem", sqlParams);
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
        public static bool Delete_IDLoaiDiem(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoaiDiem", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdLoaiDiem", sqlParams);
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
        public static List<LoaiDiem_DTO> SelectLoaiDiemAll()
        {
            List<LoaiDiem_DTO> list = new List<LoaiDiem_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiDiemAll");
                foreach (DataRow dr in dt.Rows)
                {
                    LoaiDiem_DTO s = new LoaiDiem_DTO();

                    s.MaLoaiDiem = dr["MaLoaiDiem"].ToString();
                    s.Diem15p = int.Parse (dr["Diem15p"].ToString());
                    s.Diem1t = int.Parse(dr["Diem1t"].ToString());
                    s.DiemCuoiKy = int.Parse(dr["DiemCuoiKy"].ToString());

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
        public static LoaiDiem_DTO SelectLoaiDiem_ID(string ma)
        {
            LoaiDiem_DTO s = new LoaiDiem_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoaiDiem", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiDiem_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaLoaiDiem = dr["MaLoaiDiem"].ToString();
                s.Diem15p = int.Parse(dr["Diem15p"].ToString());
                s.Diem1t = int.Parse(dr["Diem1t"].ToString());
                s.DiemCuoiKy = int.Parse(dr["DiemCuoiKy"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
         //check Id Type_Mark
        public static bool CheckLoaiDiemByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoaiDiem", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectLoaiDiem_ID", sqlParams);
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
