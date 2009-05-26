using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class HocSinh_DTO
    {
        #region Attributes

        private string maHocSinh;
        private string tenHocSinh;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string email;
        private string maLop;

        #endregion Attributes

        #region Properties
        public string MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenHocSinh
        {
            get { return tenHocSinh; }
            set { tenHocSinh = value; }
        }
        public DateTime NgaySinh
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
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion Properties

        public HocSinh_DTO()
        {
            maHocSinh = "";
            tenHocSinh = "";
            ngaySinh = new DateTime(1, 1, 1);
            diaChi = "";
            email = "";
            gioiTinh = "";
            maLop = "";

        }
    }
}
