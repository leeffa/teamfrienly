using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ListStudent_DTO
    {
         #region Attributes

       private int sTT;
        private string maHocSinh;
        private string tenHocSinh;
        private string tenLop;
        private double  tBHK1;
        private double tBHK2;
        
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
        public double TBHK1
        {
            get { return tBHK1; }
            set { tBHK1 = value; }
        }
        public double TBHK2
        {
            get { return tBHK2; }
            set { tBHK2 = value; }
        }
        
        #endregion Properties

        public ListStudent_DTO()
        {
            sTT = 0;
            tenHocSinh = "";
            tenLop = "";
            tBHK1 = 0;
            tBHK2 = 0;

        }
    }
}
