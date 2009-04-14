using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DenBuDTO
    {
        #region Attributes
        private int sothutu;
        private string mamuonsach;
        private int sotien;
        #endregion Attributes
        #region Properties
        public int Sothutu
        {
            get {return sothutu;}
            set { sothutu = value; }
        }
        public string Mamuonsach
        {
            get { return mamuonsach; }
            set { mamuonsach = value; }
        }
        public int Sotien
        {
            get { return sotien; }
            set { sotien = value; }
        }
        #endregion Properties
        public DenBuDTO()
        {
            sothutu = 0;
            mamuonsach = " ";
            sotien = 0;
        }


    }
}
