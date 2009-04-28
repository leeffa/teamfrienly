using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class Bus
    {
      public static DataTable LayDS_SachMuon_byDocGiaID(String ID)
      {
          return Dao.LayDS_SachMuon_byDocGiaID(ID);
      }
        public static DataTable LayDS_SachDangMuon_byDocGiaID(String ID)
      {
          return Dao.LayDS_SachDangMuon_byDocGiaID(ID);
      }
        public static bool ConnectedToServer(String strConn)
        {
            return Dao.ConnectedToServer(strConn);
        }
    }
}
