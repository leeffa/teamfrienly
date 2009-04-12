using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class NhaXBBus
    {
        public bool Insert_NhaXB(NhaXBDto nhaxbdto)
        {
            NhaXBDao nhaxbdao = new NhaXBDao();
            return nhaxbdao.Insert_NhaXB(nhaxbdto);


        }
        public bool Update_NhaXB(NhaXBDto nhaxbdto)
        {
            NhaXBDao nhaxbdao = new NhaXBDao();
            return nhaxbdao.Update_NhaXB(nhaxbdto);

        }
        public bool Delete_NhaXB(NhaXBDto nhaxbdto)
        {
            NhaXBDao nhaxbdao = new NhaXBDao();
            return nhaxbdao.Delete_NhaXB(nhaxbdto);

        }
    }
}
