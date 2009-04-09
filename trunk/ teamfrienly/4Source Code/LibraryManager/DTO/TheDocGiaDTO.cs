using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TheDocGiaDTO
    {
        #region Attributes

        private int maThe;
        private int maLoaiDocGia;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;
        private string email;
        private DateTime ngayLapThe;
        private DateTime ngayHetHan;

        #endregion Attributes

        #region Properties

        public int MaThe
        {
            get { return maThe; }
            set { maThe = value; }
        }
        public int MaLoaiDocGia
        {
            get { return maLoaiDocGia; }
            set { maLoaiDocGia = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

         public DateTime NgayLapThe
        {
            get { return ngayLapThe; }
            set { ngayLapThe = value; }
        }
         public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }
        #endregion Properties
        public TheDocGiaDTO()
        {
            maThe = 0;
            maLoaiDocGia = 0;
            hoTen = "";
            ngaySinh = new DateTime(1,1,1);
            email = "";
            diaChi = "";
            ngayLapThe = new DateTime(1,1,1);
            ngayHetHan = new DateTime(1, 1, 1);
        }
    }
}
