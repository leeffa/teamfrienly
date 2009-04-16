using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    [Serializable]
    public class MuonSachDTO
    {
        #region Attributes

        private int maMuonSach;
        private string maSach;
        private string maThe;
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

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string MaThe
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
            maSach = "0";
            maThe="0";
            
            ngayMuon = new DateTime(1950, 1, 1);
            ngayHenTra = new DateTime(1950,1,1);
            ngayTra = new DateTime(1950, 1, 1);
          
        }
    }
}
