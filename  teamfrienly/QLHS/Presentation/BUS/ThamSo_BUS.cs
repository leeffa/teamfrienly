using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThamSo_BUS
    {
        // Inserting
        public static bool Insert_ThamSo(ThamSo_DTO s)
        {
            //if (ThamSo_DAO.CheckThamSoByID(s.MaThamSo))
            //{
               // return false;
            //}
            return ThamSo_DAO.InSert_ThamSo(s);
        }
        //Updating
        public static bool Update_ThamSo(ThamSo_DTO s)
        {
            if (ThamSo_DAO.CheckThamSoByID(s.MaThamSo))
           {
                return ThamSo_DAO.Update_ThamSo(s);
            }
            return false;

        }
        public static ThamSo_DTO SelectThamSoByID(string maS)
        {
            if (!ThamSo_DAO.CheckThamSoByID(maS))
            {
                return null;
            }
            return ThamSo_DAO.SelectThamSo_ID(maS);
        }
       
    }
}
