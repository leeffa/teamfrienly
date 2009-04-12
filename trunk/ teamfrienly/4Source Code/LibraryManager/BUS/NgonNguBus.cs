using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;


namespace BUS
{
    public class NgonNguBus
    {
        public   bool Insert_NgonNgu(NgonNguDto ngonngudto)
        {
            NgonNguDao ngonngudao = new NgonNguDao();
            return ngonngudao.Insert_NgonNgu(ngonngudto);

        }
        public   bool Update_NgonNgu(NgonNguDto ngonngudto)
        {
            NgonNguDao ngonngudao = new NgonNguDao();
            return ngonngudao.Update_NgonNgu(ngonngudto);

        }
        public   bool Delete_NgonNgu(NgonNguDto ngonngudto)
        {
            NgonNguDao ngonngudao = new NgonNguDao();
            return ngonngudao.Delete_NgonNgu(ngonngudto);

        }
    }
}
