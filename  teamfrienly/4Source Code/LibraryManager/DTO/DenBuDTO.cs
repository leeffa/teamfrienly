using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DenBuDTO
    {
        #region Attributes

        private int sothutu;
        private int mamuonsach;
        private int sotien;

        #endregion Attributes
        #region Properties
        public int Sothutu
        {
            get { return sothutu; }
            set { sothutu = value; }
        }
        public int Mamuonsach
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
            mamuonsach = 0;
            sotien = 0;
        }


    }
}

