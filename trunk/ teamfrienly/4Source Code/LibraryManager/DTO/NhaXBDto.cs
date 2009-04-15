using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhaXBDto
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
        public NhaXBDto()
        {
            ma = "";
            ten = "";
 
        }
#endregion
    }
}
