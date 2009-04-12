using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class SachMatBus
    {
        public bool Insert_SachMat(SachMatDto sachmatdto)
        {
            SachMatDao sachmatdao = new SachMatDao();
            return sachmatdao.Insert_SachMat(sachmatdto);


        }
        public bool Update_SachMat(SachMatDto sachmatdto)
        {
            SachMatDao sachmatdao = new SachMatDao();
            return sachmatdao.Update_SachMat(sachmatdto);

        }
        public bool Delete_SachMat(SachMatDto sachmatdto)
        {
            SachMatDao sachmatdao = new SachMatDao();
            return sachmatdao.Delete_SachMat(sachmatdto);

        }
    }
}
