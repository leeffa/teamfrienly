using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HocSinh_DAO
    {
       //insert student
        public static bool InSert_Student(HocSinh_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", hs.MaHocSinh));
                sqlParams.Add(new SqlParameter("@TenHocSinh", hs.TenHocSinh));
                sqlParams.Add(new SqlParameter("@GioiTinh", hs.GioiTinh ));
                sqlParams.Add(new SqlParameter("@NgaySinh", hs.NgaySinh ));
                sqlParams.Add(new SqlParameter("@DiaChi", hs.DiaChi ));
                sqlParams.Add(new SqlParameter("@Email", hs.Email ));
                sqlParams.Add(new SqlParameter("@MaLop", hs.MaLop));
               
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_Student", sqlParams);
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
        public static bool Update_Student(HocSinh_DTO   hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", hs.MaHocSinh));
                sqlParams.Add(new SqlParameter("@TenHocSinh", hs.TenHocSinh));
                sqlParams.Add(new SqlParameter("@GioiTinh", hs.GioiTinh));
                sqlParams.Add(new SqlParameter("@NgaySinh", hs.NgaySinh));
                sqlParams.Add(new SqlParameter("@DiaChi", hs.DiaChi));
                sqlParams.Add(new SqlParameter("@Email", hs.Email));
                sqlParams.Add(new SqlParameter("@MaLop", hs.MaLop));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Student", sqlParams);
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
        public static bool Delete_IDHocSinh(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdMaHS", sqlParams);
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
        public static List<HocSinh_DTO > SelectStudenAll()
        {
            List<HocSinh_DTO> list = new List<HocSinh_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudentAll");
                foreach (DataRow dr in dt.Rows)
                {
                    HocSinh_DTO s = new HocSinh_DTO();

                    s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.TenHocSinh = dr["TenHocSinh"].ToString();
                    s.GioiTinh = dr["GioiTinh"].ToString();
                    s.NgaySinh =DateTime .Parse ( dr["NgaySinh"].ToString());
                    s.DiaChi = dr["DiaChi"].ToString();
                    s.Email = dr["Email"].ToString();
                    s.MaLop = dr["MaLop"].ToString();
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
        public static HocSinh_DTO  SelectStudent_ID(string ma)
        {
            HocSinh_DTO s = new HocSinh_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudent_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaHocSinh = dr["MaHocSinh"].ToString();
                s.TenHocSinh = dr["TenHocSinh"].ToString();
                s.GioiTinh = dr["GioiTinh"].ToString();
                s.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                s.DiaChi = dr["DiaChi"].ToString();
                s.Email = dr["Email"].ToString();
                s.MaLop = dr["MaLop"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check Id Student
        public static bool CheckStudentByMa(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudent_ID", sqlParams);
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
        //get list student but don't get Id
        public static List<HocSinh_DTO> SelectStudentChoose(string malop)
        {
            List<HocSinh_DTO> list = new List<HocSinh_DTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", malop));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudentChoose", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    HocSinh_DTO s = new HocSinh_DTO();

                   // s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.TenHocSinh = dr["TenHocSinh"].ToString();
                    s.GioiTinh = dr["GioiTinh"].ToString();
                    s.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                    s.DiaChi = dr["DiaChi"].ToString();
                   // s.Email = dr["Email"].ToString();
                  //  s.MaLop = dr["MaLop"].ToString();
                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        // return amount student in a class
        public static int CountStudentSameClass(string malop)
        {
            //List<HocSinh_DTO> list = new List<HocSinh_DTO>();
            int count = 0;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", malop));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudentChoose", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    HocSinh_DTO s = new HocSinh_DTO();

                    // s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.TenHocSinh = dr["TenHocSinh"].ToString();
                   // s.GioiTinh = dr["GioiTinh"].ToString();
                    //s.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                   // s.DiaChi = dr["DiaChi"].ToString();
                    // s.Email = dr["Email"].ToString();
                    //  s.MaLop = dr["MaLop"].ToString();
                   // list.Add(s);
                    count++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }
        public static List<HocSinh_DTO> SelectStudentByName(string name)
        {
            List<HocSinh_DTO> list = new List<HocSinh_DTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@TenHocSinh", name));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectStudentByName", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    HocSinh_DTO s = new HocSinh_DTO();

                     s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.TenHocSinh = dr["TenHocSinh"].ToString();
                    s.GioiTinh = dr["GioiTinh"].ToString();
                    s.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                    s.DiaChi = dr["DiaChi"].ToString();
                     s.Email = dr["Email"].ToString();
                      s.MaLop = dr["MaLop"].ToString();
                    list.Add(s);
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
