using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiSachDTO
    {
         #region Attributes      
        private string ma;
        private string ten;
        #endregion Attributes
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
        #endregion Properties
        public LoaiSachDTO()
        {
            
            ma = " ";
            ten = "";
        }
    }
}
