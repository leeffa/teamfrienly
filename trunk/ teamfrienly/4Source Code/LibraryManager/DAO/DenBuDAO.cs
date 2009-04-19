using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

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
                emp.Sothutu = SqlDataAccessHelper.ExecuteScalar("spLatSTT_DenBu") + 1;
                sqlParams.Add(new SqlParameter("@STT", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Mamuonsach));
                sqlParams.Add(new SqlParameter("@SoTien", emp.Sotien));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertDenBu", sqlParams);
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
                sqlParams.Add(new SqlParameter("@STT", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Mamuonsach));
                sqlParams.Add(new SqlParameter("@SoTien", emp.Sotien));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdateDenBu", sqlParams);
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
                sqlParams.Add(new SqlParameter("@STT", sothutu));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeleteDenBuByID", sqlParams);
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
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDenBuAll");
                foreach (DataRow dr in dt.Rows)
                {
                    DenBuDTO emp = new DenBuDTO();
                    emp.Sothutu = int.Parse(dr["STT"].ToString());
                    emp.Mamuonsach = int.Parse(dr["MaMuonSach"].ToString());
                    emp.Sotien = int.Parse(dr["SoTien"].ToString());
                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public static DenBuDTO SelectDenBu_Ma(int ma)
        {
            DenBuDTO db = new DenBuDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaDenBu", sqlParams);
                DataRow dr = dt.Rows[0];
                db.Sothutu = int.Parse (dr["STT"].ToString());
                db.Mamuonsach = int.Parse (dr["MaMuonSach"].ToString());
                db.Sotien = int.Parse (dr["SoTien"].ToString());
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return db;
        }

        public static bool CheckDenBuBySTT(int stt)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@STT", stt));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSTTDenBu", sqlParams);
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
