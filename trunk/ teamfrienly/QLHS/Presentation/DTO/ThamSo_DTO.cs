using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThamSo_DTO
    {
        #region Attributes

        private string maThamSo;
        private int tuoiToiThieu;
        private int tuoiToiDa;
        private int soLuongMon;
        private int siSoToiDa;
        private int soLopToiDa;
        private int diemTB;
       

        #endregion Attributes

        #region Properties
         
        public string MaThamSo
        {
            get {return  maThamSo;}   
            set { maThamSo = value; }
       }
        public int TuoiToiThieu
        {
            get { return tuoiToiThieu; }
            set { tuoiToiThieu = value; }
        }
        public int TuoiToiDa
        {
            get {return  tuoiToiDa;}   
            set { tuoiToiDa = value; }
        }
        public int SiSoToiDa
        {
            get { return siSoToiDa; }
            set { siSoToiDa = value; }
        }
        public int SoLuongMon
        {
            get { return soLuongMon; }
            set { soLuongMon = value; }
        }
        public int DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
        public int SoLopToiDa
        {
            get {return  soLopToiDa;}   
            set { soLopToiDa = value; }
        }
       
        
       
        
        #endregion Properties

        public ThamSo_DTO()
        {
            maThamSo = "";
            tuoiToiThieu = 0;
            tuoiToiDa =0;

            siSoToiDa = 0;
            soLuongMon = 0;
            diemTB = 0;
            soLopToiDa = 0;
            
            
        }
    }
}
