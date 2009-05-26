using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Student_DTO
    {
         #region Attributes

       
        private string tenHocSinh;
        private string gioiTinh;
        private string  ngaySinh;
        private string diaChi;
        private int sTT;
        #endregion Attributes

        #region Properties
       
        
        public string TenHocSinh
        {
            get { return tenHocSinh; }
            set { tenHocSinh = value; }
        }
        public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        
        #endregion Properties

        public Student_DTO()
        {
            
            tenHocSinh = "";
            ngaySinh = "";
            diaChi = "";
            sTT = 0;
            gioiTinh = "";
            

        }
    }
}
