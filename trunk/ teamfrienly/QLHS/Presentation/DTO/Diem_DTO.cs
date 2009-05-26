using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Diem_DTO
    {
        #region Attributes

        private string maHocSinh;
        private string maHocKy;
        private string maMon;

        private double diem15p;
        private double diem1t;
        private double diemCuoiKy;
        private double dTBHK;

        #endregion Attributes

        #region Properties
         
        public string  MaHocSinh
        {
            get {return  maHocSinh;}   
            set { maHocSinh = value; }
        }
        public string MaHocKy
        {
            get {return maHocKy ;}   
            set { maHocKy = value; }
        }
        public string MaMon
        {
            get {return maMon ;}   
            set { maMon = value; }
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

        public Diem_DTO()
        {
            maHocSinh = "";
            maHocKy = "";
            maMon = "";

            diem15p  = 0;
            diem1t = 0;
            diemCuoiKy  = 0;
            dTBHK = 0;
           
        }
    }
}
