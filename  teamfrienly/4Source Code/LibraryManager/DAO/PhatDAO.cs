using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class PhatDAO
    {
        // Inserting
        public static bool InsertPhat(PhatDTO temp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                //Lay STT
                temp.Sothutu= SqlDataAccessHelper.ExecuteScalar("spLaySTT_Phat") + 1;
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", temp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", temp.MaMuonSach));
                sqlParams.Add(new SqlParameter("@SoNgay", temp.Songay));
                sqlParams.Add(new SqlParameter("@ThanhTien", temp.Thanhtien));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsertPhat", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdatePhat(PhatDTO temp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", temp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", temp.MaMuonSach));
                sqlParams.Add(new SqlParameter("@SoNgay", temp.Songay));
                sqlParams.Add(new SqlParameter("@ThanhTien", temp.Thanhtien));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdatePhat", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeletePhatByID(int sothutu)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", sothutu));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDeletePhatByID", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static List<PhatDTO> SelectPhatAll()
        {
            List<PhatDTO> list = new List<PhatDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectPhatAll");
                foreach (DataRow dr in dt.Rows)
                {
                    PhatDTO temp = new PhatDTO();
                    temp.Sothutu = (int)dr["STT"];
                    temp.MaMuonSach = (int)dr["MaSachMuon"];
                    temp.Songay = (int)dr["SoNgay"];
                    temp.Thanhtien = (int)dr["ThanhTien"];
                    list.Add(temp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static bool CheckPhatByID(int stt)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@STT", stt));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectPhatByID", sqlParams);
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
        public static PhatDTO SelectPhatByID(int STT)
        {
            PhatDTO temp = new PhatDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@STT", STT));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectPhatByID", sqlParams);
                if (dt.Rows.Count == 0)
                    return temp;
                DataRow dr = dt.Rows[0];
                temp.Sothutu = (int)dr["STT"];
                temp.MaMuonSach = (int)dr["MaMuonSach"];
                temp.Songay = (int)dr["SoNgay"];
                temp.Thanhtien = (int)dr["ThanhTien"];


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return temp;
        }
    }
}
