using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class ThamSo_DAO
    {
        //insert student
        public static bool InSert_ThamSo(ThamSo_DTO hs)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaThamSo", hs.MaThamSo));
                sqlParams.Add(new SqlParameter("@TuoiToiThieu", hs.TuoiToiThieu));
                sqlParams.Add(new SqlParameter("@TuoiToiDa", hs.TuoiToiDa));
                sqlParams.Add(new SqlParameter("@SoLuongMon", hs.SoLuongMon));
                sqlParams.Add(new SqlParameter("@SiSoToiDa", hs.SiSoToiDa));
                sqlParams.Add(new SqlParameter("@DiemTB", hs.DiemTB));
                sqlParams.Add(new SqlParameter("@SoLopToiDa", hs.SoLopToiDa));


                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spInsert_ThamSo", sqlParams);
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
        public static bool Update_ThamSo(ThamSo_DTO hs)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
               sqlParams.Add(new SqlParameter("@MaThamSo", hs.MaThamSo));
                sqlParams.Add(new SqlParameter("@TuoiToiThieu", hs.TuoiToiThieu));
                sqlParams.Add(new SqlParameter("@TuoiToiDa", hs.TuoiToiDa));
                sqlParams.Add(new SqlParameter("@SoLuongMon", hs.SoLuongMon));
                sqlParams.Add(new SqlParameter("@SiSoToiDa", hs.SiSoToiDa));
                sqlParams.Add(new SqlParameter("@DiemTB", hs.DiemTB));
                sqlParams.Add(new SqlParameter("@SoLopToiDa", hs.SoLopToiDa));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("spUpdate_ThamSo", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //check Id ThamSo
        public static bool CheckThamSoByID(string ma)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaThamSo", ma));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectThamSo_ID", sqlParams);
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
        //Select ID ThamSo
        public static ThamSo_DTO SelectThamSo_ID(string ma)
        {
            ThamSo_DTO s = new ThamSo_DTO();
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaThamSo", ma));
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectThamSo_ID", sqlParams);
                if (dt.Rows.Count == 0)
                    return s;
                DataRow dr = dt.Rows[0];
                s.MaThamSo = dr["MaThamSo"].ToString();

                s.TuoiToiThieu = int.Parse(dr["TuoiToiThieu"].ToString());
                s.TuoiToiDa = int.Parse(dr["TuoiToiDa"].ToString());

                s.SoLuongMon = int.Parse(dr["SoLuongMon"].ToString());
                s.SiSoToiDa = int.Parse(dr["SiSoToiDa"].ToString());

                s.DiemTB = int.Parse(dr["DiemTB"].ToString());
                s.SoLopToiDa = int.Parse(dr["SoLopToiDa"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }

    /*   public static ThamSo_DTO SelectThamSoAll()
        {
            ThamSo_DTO s = new ThamSo_DTO();
            try
            {
                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spSelectThamSoAll");
                foreach (DataRow dr in dt.Rows)
                {
                    

                    s.MaThamSo =     dr["MaThamSo"].ToString();
                    s.TuoiToiThieu = int.Parse (dr["TuoiToiThieu"].ToString());
                    s.TuoiToiDa =  int.Parse (dr["TuoiToiDa"].ToString());
                    s.SoLuongMon = int.Parse (dr["SoLuongMon"].ToString());
                    s.SiSoToiDa = int.Parse ( dr["SiSoToiDa"].ToString());
                    s.DiemTB =    int.Parse ( dr["DiemTB"].ToString());
                    s.SoLopToiDa = int.Parse(dr["SoLopToiDa"].ToString());
                    //list.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return s;
        }
     */
    }
}
