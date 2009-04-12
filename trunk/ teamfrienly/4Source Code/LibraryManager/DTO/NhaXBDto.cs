using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhaXBDto
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
        public NhaXBDto()
        {
            ma = 0;
            ten = "";
 
        }
#endregion
    }
}
