using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TacGiaDto
    {
#region Attribute
        private string ma;
        private string ten;
        private DateTime ngaysinh;
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
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
#endregion
#region method
        public TacGiaDto()
        {
            ma = "";
            ten = "";
            ngaysinh = new DateTime();

        }
#endregion
    }
}
