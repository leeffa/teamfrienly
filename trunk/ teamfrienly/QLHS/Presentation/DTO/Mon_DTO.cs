using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Mon_DTO
    {
        #region Attributes

        private string maMon;
        private string tenMon;
        
        #endregion Attributes

        #region Properties
         
        public string MaMon
        {
            get {return  maMon;}   
            set { maMon = value; }
        }
        public string TenMon
        {
            get {return  tenMon;}   
            set { tenMon = value; }
        }
        
        #endregion Properties

        public Mon_DTO()
        {
            maMon = "";
            tenMon = "";
            
        }
    }
}
