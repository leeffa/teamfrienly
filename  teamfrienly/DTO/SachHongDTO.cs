using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SachHongDTO
    {
        #region Attributes
        private string masachhong;
        private string masach;
        #endregion Attributes
        #region Properties
        public string Masachhong
        {
            get { return masachhong; }
            set { masachhong = value; }
        }
        public string Masach
        {
            get { return masach; }
            set { masach = value; }
        }
        #endregion Properties
        public SachHongDTO()
        {
            masachhong = "";
            masach = "";
        }
    }
}
