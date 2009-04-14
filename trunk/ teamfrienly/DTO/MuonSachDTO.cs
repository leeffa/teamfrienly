using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Serializable]
    class MuonSachDTO
    {
        #region Attributes

        private int maMuonSach;
        private int maSach;
        private int maThe;
        private DateTime ngayMuon;
        private DateTime ngayHenTra;
        private DateTime ngayTra;
        
        
        

        #endregion Attributes
        #region Properties
        public int MaMuonSach
        {
            get { return maMuonSach; }
            set { maMuonSach = value; }
        }

        public int MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public int MaThe
        {
            get { return maThe; }
            set { maThe = value; }
        }

       

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateTime NgayHenTra
        {
            get { return ngayHenTra; }
            set { ngayHenTra = value; }
        }
        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }

        #endregion Properties

        public MuonSachDTO()
        {
            maMuonSach = 0;
            maSach = 0;
            maThe=0;
            
            ngayMuon = new DateTime(1950, 1, 1);
            ngayHenTra = new DateTime(1950,1,1);
            ngayTra = new DateTime(1950, 1, 1);
          
        }
    }
}
