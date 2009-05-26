using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Khoi_DTO
    {
        #region Attributes

        private string maKhoi;
        private string tenKhoi;
        
        #endregion Attributes

        #region Properties
       
        public string MaKhoi
        {
            get {return maKhoi  ;}
            set {maKhoi = value  ; }
        }
        public string TenKhoi
        {
            get {return tenKhoi  ;}
            set {tenKhoi = value  ; }
        }
        
        #endregion Properties

        public Khoi_DTO()
        {
            maKhoi  = "";
            tenKhoi  = "";
            
        }
    }
}
