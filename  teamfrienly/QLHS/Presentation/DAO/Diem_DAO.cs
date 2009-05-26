using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class Diem_DAO
    {
        //insert stype mark
        public static bool InSert_Diem(Diem_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", hs.MaHocSinh));
                sqlParams.Add(new SqlParameter("@MaMon", hs.MaMon));
                sqlParams.Add(new SqlParameter("@MaHocKy", hs.MaHocKy));

                sqlParams.Add(new SqlParameter("@Diem15p", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@Diem1t", hs.Diem1t));
                sqlParams.Add(new SqlParameter("@DiemCuoiKy", hs.DiemCuoiKy));
                sqlParams.Add(new SqlParameter("@DTBHK", hs.DTBHK));


                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInSert_Diem", sqlParams);
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
        public static bool Update_Diem(Diem_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", hs.MaHocSinh));
                sqlParams.Add(new SqlParameter("@MaMon", hs.MaMon));
                sqlParams.Add(new SqlParameter("@MaHocKy", hs.MaHocKy));

                sqlParams.Add(new SqlParameter("@Diem15p", hs.Diem15p));
                sqlParams.Add(new SqlParameter("@Diem1t", hs.Diem1t));
                sqlParams.Add(new SqlParameter("@DiemCuoiKy", hs.DiemCuoiKy));
                sqlParams.Add(new SqlParameter("@DTBHK", hs.DTBHK));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Diem", sqlParams);
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
        public static bool Delete_IDDiem(String ma1,String ma2,String ma3)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma1));
                sqlParams.Add(new SqlParameter("@MaMon", ma2));
                sqlParams.Add(new SqlParameter("@MaHocKy", ma3));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdDiem", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        // Deleting all Same ID'Student
        public static bool Delete_IDStudent(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma));
                
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdStudent", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        // Deleting all Same ID'Subject
        public static bool Delete_IDSubject(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", ma));

                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdSubject", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //return List<Diem_DTO> send DataGridView
        public static List<Diem_DTO> SelectDiemAll()
        {
            List<Diem_DTO> list = new List<Diem_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiemAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Diem_DTO s = new Diem_DTO();

                    s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.MaMon = dr["MaMon"].ToString();
                    s.MaHocKy = dr["MaHocKy"].ToString();


                    s.Diem15p = double.Parse(dr["Diem15p"].ToString());
                    s.Diem1t = double.Parse(dr["Diem1t"].ToString());
                    s.DiemCuoiKy = double.Parse(dr["DiemCuoiKy"].ToString());
                    s.DTBHK = double.Parse(dr["DTBHK"].ToString());

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        //Return 1 record Diem_DTO use Search
        public static Diem_DTO SelectDiem_ID(string ma1, string ma2, string ma3)
        {
            Diem_DTO s = new Diem_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma1));
                sqlParams.Add(new SqlParameter("@MaMon", ma2));
                sqlParams.Add(new SqlParameter("@MaHocKy", ma3));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaHocSinh = dr["MaHocSinh"].ToString();
                s.MaMon = dr["MaMon"].ToString();
                s.MaHocKy = dr["MaHocKy"].ToString();


                s.Diem15p = double.Parse(dr["Diem15p"].ToString());
                s.Diem1t = double.Parse(dr["Diem1t"].ToString());
                s.DiemCuoiKy = double.Parse(dr["DiemCuoiKy"].ToString());
                s.DTBHK = double.Parse(dr["DTBHK"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check Id mark
        public static bool CheckDiemByID(string maHS, string maMon, string maHocKy)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", maHS));
                sqlParams.Add(new SqlParameter("@MaMon", maMon));
                sqlParams.Add(new SqlParameter("@MaHocKy", maHocKy));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_ID", sqlParams);
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
        //Return 1 record Diem_DTO use Search
        public static List< Diem_DTO> SelectDiem_IDStudent(string ma)
        {
            List<Diem_DTO> list = new List<Diem_DTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams .Add (new SqlParameter ("@MaHocSinh",ma));
               
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_IDStudent", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    Diem_DTO s = new Diem_DTO();

                    s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.MaMon = dr["MaMon"].ToString();
                    s.MaHocKy = dr["MaHocKy"].ToString();


                    s.Diem15p = double.Parse(dr["Diem15p"].ToString());
                    s.Diem1t = double.Parse(dr["Diem1t"].ToString());
                    s.DiemCuoiKy = double.Parse(dr["DiemCuoiKy"].ToString());
                    s.DTBHK = double.Parse(dr["DTBHK"].ToString());

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        //check Id student of mark 
        public static bool CheckDiemBy_IDStudent(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_IDStudent", sqlParams);
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
        //check Id subject of mark 
        public static bool CheckDiemBy_IDSubject(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaMon", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_IDSubject", sqlParams);
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
        public static List<Diem_DTO> SelectDiem_2ID(string maHS,string maHK)
        {
            List<Diem_DTO> list = new List<Diem_DTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", maHS));
                sqlParams.Add(new SqlParameter("@MaHocKy", maHK));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_2ID", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    Diem_DTO s = new Diem_DTO();

                    s.MaHocSinh = dr["MaHocSinh"].ToString();
                    s.MaMon = dr["MaMon"].ToString();
                    s.MaHocKy = dr["MaHocKy"].ToString();


                    s.Diem15p = double.Parse(dr["Diem15p"].ToString());
                    s.Diem1t = double.Parse(dr["Diem1t"].ToString());
                    s.DiemCuoiKy = double.Parse(dr["DiemCuoiKy"].ToString());
                    s.DTBHK = double.Parse(dr["DTBHK"].ToString());

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static bool CheckDiemBy_2ID(string maHS,string maHK)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaHocSinh", maHS));
                sqlParams.Add(new SqlParameter("@MaHocKy", maHK));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectDiem_2ID", sqlParams);
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
    
    }

}
