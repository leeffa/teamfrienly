using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Out_Mark
    {
        #region Attributes

        private int sTT;
        private string hoTen;
        private double diem15p;
        private double diem1t;
        private double diemCuoiKy;
        private double dTBHK;
        private string hocKy;

        #endregion Attributes

        #region Properties
         
        public int  STT
        {
            get {return  sTT;}   
            set { sTT = value; }
        }
        public string HoTen
        {
            get {return hoTen ;}   
            set { hoTen = value; }
        }
        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }


        public double DTBHK
        {
            get {return dTBHK ;}   
            set { dTBHK = value; }
        }
        public double Diem15p
        {
            get { return diem15p; }
            set { diem15p = value; }
        }
        public double Diem1t
        {
            get { return diem1t; }
            set { diem1t = value; }
        }
        public double DiemCuoiKy
        {
            get { return diemCuoiKy; }
            set { diemCuoiKy = value; }
        }
        #endregion Properties

        public Out_Mark()
        {
            sTT  = 0;
            hoTen = "";
            diem15p  = 0;
            diem1t = 0;
            diemCuoiKy  = 0;
            dTBHK = 0;
            hocKy = "";
           
        }
    }
}
