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
        public static bool InsertPhat(PhatDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Masachmuon));
                sqlParams.Add(new SqlParameter("@SoNgay", emp.Songay));
                sqlParams.Add(new SqlParameter("@ThanhTien", emp.Thanhtien));

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
        public static bool UpdatePhat(PhatDTO emp)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@SoThuTu", emp.Sothutu));
                sqlParams.Add(new SqlParameter("@MaMuonSach", emp.Masachmuon));
                sqlParams.Add(new SqlParameter("@SoNgay", emp.Songay));
                sqlParams.Add(new SqlParameter("@ThanhTien", emp.Thanhtien));
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
        public static bool DeletePhatByID(int sothutu)
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
        public static List<PhatDTO> SelectPhatAll()
        {
            List<PhatDTO> list = new List<PhatDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectTheAll");
                foreach (DataRow dr in dt.Rows)
                {
                    PhatDTO emp = new PhatDTO();
                    emp.Sothutu = (int)dr["STT"];
                    emp.Masachmuon = dr["MaSachMuon"].ToString();
                    emp.Songay = (int)dr["SoNgay"];
                    emp.Thanhtien = (int)dr["ThanhTien"];
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
