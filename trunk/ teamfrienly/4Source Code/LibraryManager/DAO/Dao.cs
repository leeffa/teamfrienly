using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
namespace DAO
{
    public class Dao
    {
        public static DataTable LayDS_SachMuon_byDocGiaID(String ID)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable dt = new DataTable();
            try
            {
                sqlParams.Add(new SqlParameter("@MaThe", ID));
                dt = SqlDataAccessHelper.ExecuteQuery("spLayDS_SachMuon_ByDocGiaID", sqlParams);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static DataTable LayDS_SachDangMuon_byDocGiaID(String ID)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            DataTable dt = new DataTable();
            try
            {
                sqlParams.Add(new SqlParameter("@MaThe", ID));
                dt = SqlDataAccessHelper.ExecuteQuery("spLay_SachDangMuon_byDocGiaID", sqlParams);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static bool ConnectedToServer(String strConn)
        {
            try
            {
                if (strConn == "")
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("ConnectionString.xml");
                    XmlElement root = doc.DocumentElement;
                    strConn= root.InnerText;                    
                }
                SqlConnection connect = new SqlConnection(strConn);
                connect.Open();
                connect.Close();
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }

    }

}
