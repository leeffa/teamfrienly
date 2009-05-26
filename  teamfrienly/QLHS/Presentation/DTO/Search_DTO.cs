using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Search_DTO
    {
         #region Attributes
 
           
        private int sTT;
        private string maHocSinh;
        private string tenHocSinh;
        private string tenLop;
        private DateTime  ngaySinh;
        private double  dBHK1;
        private double dBHK2;
        
        #endregion Attributes

        #region Properties
        public string MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }
         public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
        public string TenHocSinh
        {
            get { return tenHocSinh; }
            set { tenHocSinh = value; }
        }
       
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public DateTime  NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public double DBHK1
        {
            get { return dBHK1; }
            set { dBHK1 = value; }
        }
        public double DBHK2
        {
            get { return dBHK2; }
            set { dBHK2 = value; }
        }
        
        #endregion Properties

        public Search_DTO()
        {
            sTT = 0;
            tenHocSinh = "";
            tenLop = "";
            ngaySinh =new  DateTime(1,1,1);
            dBHK1 = 0;
            dBHK2 = 0;

        }
    }
}
