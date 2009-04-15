using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class SachHongDTO
    {
        
    
        #region Attribute
        private string ma;
        private int stt;
 #endregion
#region Properties
        public string MaSach
        {
            get { return ma; }
            set { ma = value; }
        }
        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }
 #endregion
#region method
        public SachHongDTO()
        {
            ma = "";
            stt = 0; ;
 
        }
#endregion
    }
}
