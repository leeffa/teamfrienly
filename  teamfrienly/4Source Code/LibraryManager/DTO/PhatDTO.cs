using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhatDTO
    {
        
        #region Attributes
        private int sothutu;
        private int maMuonSach;
        private int songay;
        private int thanhtien;
        #endregion Attributes
        #region Properties
        public int Sothutu
        {
            get { return sothutu; }
            set { Sothutu = value; }
        }
        public int MaMuonSach
        {
            get { return maMuonSach; }
            set { maMuonSach = value; }
        }
        public int Songay
        {
            get { return songay; }
            set { songay = value; }
        }
        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        #endregion Properties
        public PhatDTO()
        {
            sothutu = 0;
            MaMuonSach = 0;
            songay = 0;
            thanhtien = 0;
        }
    }
}
