using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SachDAO
    {
        // Inserting
        public static bool Insert_Sach(SachDTO s)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", s.Ma ));
                sqlParams.Add(new SqlParameter("@Ten", s.Ten ));
                sqlParams.Add(new SqlParameter("@LoaiSach", s.LoaiSach));
                sqlParams.Add(new SqlParameter("@TacGia", s.TacGia));
                sqlParams.Add(new SqlParameter("@Gia", s.Gia));
                sqlParams.Add(new SqlParameter("@NgonNgu", s.NgonNgu));
                sqlParams.Add(new SqlParameter("@NhaXB", s.NhaXB));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_Sach", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        //Updating
        public static bool Update_Sach(SachDTO s)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", s.Ma));
                sqlParams.Add(new SqlParameter("@Ten", s.Ten));
                sqlParams.Add(new SqlParameter("@LoaiSach", s.LoaiSach));
                sqlParams.Add(new SqlParameter("@TacGia", s.TacGia));
                sqlParams.Add(new SqlParameter("@Gia", s.Gia));
                sqlParams.Add(new SqlParameter("@NgonNgu", s.NgonNgu));
                sqlParams.Add(new SqlParameter("@NhaXB", s.NhaXB));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Sach", sqlParams);
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
        public static bool Delete_Sach_Ma(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_Sach_Ma", sqlParams);
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
        public static List<SachDTO> SelectMuonSachAll()
        {
            List<SachDTO> list = new List<SachDTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachAll");
                foreach (DataRow dr in dt.Rows)
                {
                    SachDTO s = new SachDTO();
                    s.Ma = dr["Ma"].ToString();
                    s.Ten  = dr["Ten"].ToString();
                    s.LoaiSach =dr["LoaiSach"].ToString();
                    s.TacGia = dr["TacGia"].ToString();
                    s.Gia = int.Parse(dr["Gia"].ToString());
                    s.NgonNgu = dr["NgonNgu"].ToString();
                    s.NhaXB = dr["NhaXB"].ToString();
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
        public static SachDTO SelectSach_Ma(string ma)
        {
            SachDTO s = new SachDTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaSach", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.Ma = dr["Ma"].ToString();
                s.Ten = dr["Ten"].ToString();
                s.LoaiSach = dr["LoaiSach"].ToString();
                s.TacGia = dr["TacGia"].ToString();
                s.Gia = int.Parse(dr["Gia"].ToString());
                s.NgonNgu = dr["NgonNgu"].ToString();
                s.NhaXB = dr["NhaXB"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }

        public static List < SachDTO> SelectSachByLoaiSach(string loaiSach)
        {
            List<SachDTO> list = new List<SachDTO>();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@LoaiSach", loaiSach));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectSachByLoaiSach", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    SachDTO s = new SachDTO();
                   
                    s.Ma = dr["Ma"].ToString();
                    s.Ten = dr["Ten"].ToString();
                    s.LoaiSach = dr["LoaiSach"].ToString();
                    s.TacGia = dr["TacGia"].ToString();
                    s.Gia = int.Parse(dr["Gia"].ToString());
                    s.NgonNgu = dr["NgonNgu"].ToString();
                    s.NhaXB = dr["NhaXB"].ToString();
                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

      
        public static bool CheckSachByMa(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@Ma", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectMaSach", sqlParams);
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

        public static bool CheckSachByLoaiSach(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@LoaiSach", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectCheckLoaiSach", sqlParams);
                if (dt.Rows.Count >= 1)
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
        public static String KiemTraSach(String maSach)
        {
            String kx = "";
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("MaSach",maSach));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spIs_SachMuon", sqlParams);
                if (dt.Rows.Count != 0)
                {
                    kx += "Sách này đang được mượn.\n";
                    return kx;
                }

                sqlParams.Clear();
                sqlParams.Add(new SqlParameter("MaSach", maSach));
                dt = SqlDataAccessHelper.ExecuteQuery("spIs_Sachmat", sqlParams);
                if (dt.Rows.Count != 0)
                {
                    kx += "Sách này đã bị mất.";
                    return kx;
                }
                sqlParams.Clear();
                sqlParams.Add(new SqlParameter("MaSach", maSach));
                dt = SqlDataAccessHelper.ExecuteQuery("spIs_SachHong", sqlParams);
                if (dt.Rows.Count != 0)
                {
                    kx += "Sách này đã bị hỏng.";
                    return kx;
                }




            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return kx;
        }
    }
}
