using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Lop_DAO
    {
        // insert Class
        public static bool InSert_Class(Lop_DTO  hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", hs.MaLop));
                sqlParams.Add(new SqlParameter("@TenLop", hs.TenLop));
                sqlParams.Add(new SqlParameter("@MaKhoi", hs.MaKhoi));
                sqlParams.Add(new SqlParameter("@SiSo", hs.SiSo));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInSert_Class", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //update Class
        public static bool Update_Class(Lop_DTO  hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", hs.MaLop));
                sqlParams.Add(new SqlParameter("@TenLop", hs.TenLop));
                sqlParams.Add(new SqlParameter("@MaKhoi", hs.MaKhoi));
                sqlParams.Add(new SqlParameter("@SiSo", hs.SiSo));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_Class", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //delete Classs
        public static bool Delete_IDClass(String ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", ma));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spDelete_IdClass", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        //return come datagridview
        public static List<Lop_DTO > SelectLopAll()
        {
            List<Lop_DTO> list = new List<Lop_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClassAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Lop_DTO s = new Lop_DTO();

                    s.MaLop = dr["MaLop"].ToString();
                    s.TenLop = dr["TenLop"].ToString();
                    s.MaKhoi = dr["MaKhoi"].ToString();
                    s.SiSo = int.Parse (dr["SiSo"].ToString());

                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

         public static List<Lop_DTO> SelectLopSuitalbe(string makhoi)
        {
           // bool result = false;
            List<Lop_DTO> list = new List<Lop_DTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaKhoi", makhoi));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClassToKhoi", sqlParams);
                //DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClassToKhoi");
                foreach (DataRow dr in dt.Rows)
                {
                    Lop_DTO s = new Lop_DTO();

                    s.MaLop = dr["MaLop"].ToString();
                    s.TenLop = dr["TenLop"].ToString();
                    s.MaKhoi = dr["MaKhoi"].ToString();
                    s.SiSo = int.Parse(dr["SiSo"].ToString());

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
        public static Lop_DTO  SelectLop_ID(string ma)
        {
            Lop_DTO s = new Lop_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClass_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaLop = dr["MaLop"].ToString();
                s.TenLop = dr["TenLop"].ToString();
                s.MaKhoi = dr["MaKhoi"].ToString();
                s.SiSo = int.Parse (dr["SiSo"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //Return 1 record MuonSachDTO use Search
        public static Lop_DTO SelectLop_TenClass(string ma)
        {
            Lop_DTO s = new Lop_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@TenLop", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClass_Name", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaLop = dr["MaLop"].ToString();
                s.TenLop = dr["TenLop"].ToString();
                s.MaKhoi = dr["MaKhoi"].ToString();
                s.SiSo = int.Parse(dr["SiSo"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
        //check name Class
        public static bool CheckClassByName(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@TenLop", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClass_Name", sqlParams);
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
        //check Id Student
        public static bool CheckClassByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLop", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClass_ID", sqlParams);
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
        public static int CountLopAll()
        {
            int count = 0;
            List<Lop_DTO> list = new List<Lop_DTO>();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectClassAll");
                foreach (DataRow dr in dt.Rows)
                {
                    Lop_DTO s = new Lop_DTO();

                    s.MaLop = dr["MaLop"].ToString();
                    s.TenLop = dr["TenLop"].ToString();
                    s.MaKhoi = dr["MaKhoi"].ToString();
                    s.SiSo = int.Parse(dr["SiSo"].ToString());
                    count++;
                    list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return count;
        }

       
    }
}
