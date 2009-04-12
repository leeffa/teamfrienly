using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NgonNguDto
    {
        #region Attribute
        private int ma;
        private string ten;
 #endregion
#region Properties
        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
 #endregion
#region method
        public NgonNguDto()
        {
            ma = 0;
            ten = "";
 
        }
#endregion
    }
}
