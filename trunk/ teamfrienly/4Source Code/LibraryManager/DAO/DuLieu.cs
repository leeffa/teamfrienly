using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DuLieu
    {
        String m_strConn;
        SqlConnection m_cnn;

        public DuLieu()
        {
            m_strConn = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\QLTV.mdf;Integrated Security=True;User Instance=True";
            m_cnn = new SqlConnection(m_strConn);
        }

        public String StrCn
        {
            get { return m_strConn; }
            set { m_strConn = value; }
        }
        public SqlConnection Cn
        {
            get { return m_cnn; }
            set { m_cnn = value; }
        }
        public void KetNoiCSDL()
        {
            try
            {
                Cn.Open();
            }
            catch
            {

            }
        }
        public void HuyKetNoiCSDL()
        {
            Cn.Close();
        }
        public DataTable Execute(String strSQL)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader ExecuteReader(String strSQL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, Cn);
                return cmd.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        public void ExcuteNonQuerty(String strSQL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, Cn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
        }

    }
}
