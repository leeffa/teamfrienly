using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NgonNguDto
    {
        #region Attribute
        private string ma;
        private string ten;
 #endregion
#region Properties
        public string Ma
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
            ma = "";
            ten = "";
 
        }
#endregion
    }
}
