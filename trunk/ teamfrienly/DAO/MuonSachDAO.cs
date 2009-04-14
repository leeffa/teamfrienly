using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class MuonSachDAO
    {
        // Inserting
        public static bool Insert_MuonSach(MuonSachDAO muonsach)
        {
            bool result = false;
            try
            {
                // Create List Sql Parameter
                List<SqlParameter> sqlParams = new List<SqlParameter>();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
