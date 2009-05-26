using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ReportSubject_DTO
    {
         #region Attributes
 
           
        private int sTT;
        
        private string tenLop;
        private int  siSo;
        private int   sLDat;
        private string  tyLe;
        
        #endregion Attributes

        #region Properties
         public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
         public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }
        
        public int SLDat
        {
            get { return sLDat; }
            set { sLDat = value; }
        }
       

        public string TyLe
        {
            get { return tyLe; }
            set { tyLe = value; }
        }
        
        #endregion Properties

        public ReportSubject_DTO()
        {
            sTT = 0; 
            tenLop = "";
            siSo = 0;
            sLDat = 0;
            tyLe = "";
           
        }
    }
}
