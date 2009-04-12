using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class TacGiaBus
    {
        public   bool Insert_TacGia(TacGiaDto tacgiadto)    
        {
            TacGiaDao tacgiadao = new TacGiaDao();
            return tacgiadao.Insert_TacGia(tacgiadto);
            

        }
        public   bool Update_TacGia(TacGiaDto tacgiadto)
        {
            TacGiaDao tacgiadao = new TacGiaDao();
            return tacgiadao.Update_TacGia(tacgiadto);

        }
        public   bool Delete_TacGia(TacGiaDto tacgiadto)
        {
            TacGiaDao tacgiadao = new TacGiaDao();
            return tacgiadao.Delete_TacGia(tacgiadto);

        }
    }
}
