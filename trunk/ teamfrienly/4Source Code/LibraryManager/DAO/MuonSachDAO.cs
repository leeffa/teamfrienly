using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class MuonSachDAO
    {
        // Inserting
        public static bool Insert_MuonSach(ref MuonSachDTO ms)
        {
            bool result = false;
            try
            {
               // Create List Sql Parameter
                ms.MaMuonSach = SqlDataAccessHelper.ExecuteScalar("spLayMaMuonSach")+1;
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", ms.MaMuonSach));
                sqlParams.Add(new SqlParameter("@MaSach", ms.MaSach));
                sqlParams.Add(new SqlParameter("@MaThe", ms.MaThe));
                sqlParams.Add(new SqlParameter("@NgayHenTra", ms.NgayHenTra));
                sqlParams.Add(new SqlParameter("@NgayMuon", ms.NgayMuon));
                sqlParams.Add(new SqlParameter("@NgayTra", ms.NgayTra));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_MuonSach", sqlParams);
                if (n == 1)
                {
                    result = true;

                    SachMuonDTO smDto = new SachMuonDTO();
                    smDto.MaMuonSach = ms.MaMuonSach;
                    SachMuonDAO.InsertSachMuon(smDto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        //Updating
        public static bool Update_MuonSach(MuonSachDTO  ms)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", ms.MaMuonSach));
                sqlParams.Add(new SqlParameter("@MaSach", ms.MaSach));
                sqlParams.Add(new SqlParameter("@MaThe", ms.MaThe));
                sqlParams.Add(new SqlParameter("@NgayHenTra", ms.NgayHenTra));
                sqlParams.Add(new SqlParameter("@NgayMuon", ms.NgayMuon));
                sqlParams.Add(new SqlParameter("@NgayTra", ms.NgayTra));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_MuonSach", sqlParams);
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
        public static bool Delete_MuonSach_Ma(int ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_MuonSach_Ma", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //return List<MuonSachDTO> send DataGridView
        public static List<MuonSachDTO> SelectMuonSachAll()
        {
            List<MuonSachDTO> list = new List<MuonSachDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMuonSachAll");
                foreach (DataRow dr in dt.Rows)
                {
                    MuonSachDTO ms = new MuonSachDTO();
                    ms.MaMuonSach  = int.Parse (dr["MaMuonSach"].ToString());
                    ms.MaSach = dr["MaSach"].ToString();
                    ms.MaThe = dr["MaThe"].ToString();
                    ms.NgayHenTra =DateTime.Parse(dr["NgayHenTra"].ToString());
                    ms.NgayMuon = DateTime.Parse(dr["NgayMuon"].ToString());
                    ms.NgayTra = DateTime.Parse(dr["NgayTra"].ToString());
                    

                    list.Add(ms);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        //Return 1 record MuonSachDTO use Search
        public static MuonSachDTO  SelectMuonSach_Ma(int ma)
        {
            MuonSachDTO ms = new MuonSachDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaMuonSach", sqlParams);
                DataRow dr = dt.Rows[0];
                ms.MaMuonSach  = int.Parse (dr["MaMuonSach"].ToString());
                ms.MaSach = dr["MaSach"].ToString();
                ms.MaThe = dr["MaThe"].ToString();
                ms.NgayHenTra = DateTime.Parse(dr["NgayHenTra"].ToString());
                ms.NgayMuon = DateTime.Parse(dr["NgayMuon"].ToString());
                ms.NgayTra = DateTime.Parse(dr["NgayTra"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ms;
        }

        public static bool CheckMuonSachByMa(int maMuonSach)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMuonSach", maMuonSach));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaMuonSach", sqlParams);
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
        public static MuonSachDTO  LayPhieuMuonSach_byMaSach(String maSach)
        {
            MuonSachDTO ms = new MuonSachDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaSach", maSach));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spLayMuonSach_byMaSach", sqlParams);
                DataRow dr = dt.Rows[0];
                ms.MaMuonSach = int.Parse(dr["MaMuonSach"].ToString());
                ms.MaSach = dr["MaSach"].ToString();
                ms.MaThe = dr["MaThe"].ToString();
                ms.NgayHenTra = DateTime.Parse(dr["NgayHenTra"].ToString());
                ms.NgayMuon = DateTime.Parse(dr["NgayMuon"].ToString());
                ms.NgayTra = DateTime.Parse(dr["NgayTra"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ms;
        }
    }
}
