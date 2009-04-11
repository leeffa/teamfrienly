using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiTheDTO
    {
        #region Attributes
       private  string ma;
       private  string tenloai;
        #endregion Attributes
        #region Properties
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string TenLoai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
        #endregion Properties
        public LoaiTheDTO()
        {
            ma = "";
            tenloai = "";
        }
    }
}
