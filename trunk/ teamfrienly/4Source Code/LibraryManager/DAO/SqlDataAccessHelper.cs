using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace DAO
{
    public class SqlDataAccessHelper
    {       
        #region ConnectionString
        protected static String connectionString;
        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString("ConnectionString.xml");
            }
        }
        public static String ReadConnectionString(String file)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement root = doc.DocumentElement;
                String connectionString = root.InnerText;
                return connectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        #region ExecuteQuery
        public static DataTable ExecuteQuery(String spName, List<SqlParameter> sqlParams)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connect = new SqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static DataTable ExecuteQuery(String spName)
        {
            return ExecuteQuery(spName, null);
        }
        #endregion
        #region ExecuteNoneQuery
        public static int ExecuteNoneQuery(String spName, List<SqlParameter> sqlParams)
        {
            int n;
            try
            {
                SqlConnection connect = new SqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    n = command.ExecuteNonQuery();
                    
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }
        public static int ExecuteNoneQuery(String spName)
        {
            return ExecuteNoneQuery(spName, null);
        }
        #endregion

        #region ExecuteScalar
        public static int ExecuteScalar(String spName, List<SqlParameter> sqlParams)
        {
            int n=0;
            try
            {
                SqlConnection connect = new SqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    object temp=command.ExecuteScalar();
                    if (temp .ToString()!="")
                        n = (int)temp;


                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }
        public static int ExecuteScalar(String spName)
        {
            return ExecuteScalar(spName, null);
        }
        #endregion

    }
}
