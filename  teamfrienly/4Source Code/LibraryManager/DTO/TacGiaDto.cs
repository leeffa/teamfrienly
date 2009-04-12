using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TacGiaDto
    {
#region Attribute
        private int ma;
        private string ten;
        private DateTime ngaysinh;
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
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
#endregion
#region method
        public TacGiaDto()
        {
            ma = 0;
            ten = "";
            ngaysinh = new DateTime(1 , 1 , 1);

        }
#endregion
    }
}
