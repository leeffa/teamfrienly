using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TheDTO
    {
        #region Attributes
        private string ma;
        private string loaithe;
        private DateTime ngaycap;
        private DateTime ngayhethan;
        private string ten;
        private DateTime ngaysinh;
        #endregion Attributes
        #region Properties
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string LoaiThe
        {
            get { return loaithe; }
            set { loaithe = value; }
        }
        public DateTime NgayCap
        {
            get { return ngaycap; }
            set { ngaycap = value; }
        }
        public DateTime NgayHetHan
        {
            get { return ngayhethan; }
            set { ngayhethan = value; }
        }
        public string TenDocGia
        {
            get { return ten; }
            set { ten = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        #endregion Properties
       
        public TheDTO()
        {
            ma = "";
            loaithe = "";
            ngaycap = new DateTime(1, 1, 1);
            ngayhethan = new DateTime(1, 1, 1);
            ten = "";
            ngaysinh = new DateTime(1, 1, 1);

        }
      

    }
}
