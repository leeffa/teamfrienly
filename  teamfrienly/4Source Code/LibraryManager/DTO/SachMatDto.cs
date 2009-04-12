using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SachMatDto
    {
        #region Attribute
        private int ma;
        private int stt;
 #endregion
#region Properties
        public int Ma
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
            ma = 0;
            stt = 0; ;
 
        }
#endregion
    }
}
