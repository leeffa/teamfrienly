using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SachMatDto
    {
        #region Attribute
        private string ma;
        private int stt;
 #endregion
#region Properties
        public string Ma
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
        public SachMatDto()
        {
            ma = "";
            stt = 0; ;
 
        }
#endregion
    }
}
