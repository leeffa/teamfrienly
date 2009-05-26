using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class HocKy_DTO
    {
        #region Attributes

        private string maHocKy;
        private string tenHocKy;
        
        
        #endregion Attributes

        #region Properties
         
        public string  MaHocKy
        {
            get {return maHocKy ;}   
            set { maHocKy = value; }
        }
        public string TenHocKy
        {
            get {return  tenHocKy;}   
            set {tenHocKy  = value; }
        }
        
        #endregion Properties

        public HocKy_DTO()
        {
            maHocKy = "";
            tenHocKy = "";
            
        }
    }
}
