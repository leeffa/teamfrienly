using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class SachDTO
    {
        #region Attributes

        private int maSach;
        private string tenSach;
        private int maTheLoai;
        private string tacGia;
        private DateTime namXuatBan;
        private string nhaXuatBan;
        private int triGia;
        private DateTime ngayNhap;
        private Boolean tinhTrang;
        private string ngonNgu;
        
        #endregion Attributes
        #region Properties
        public int MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public int MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public DateTime NamXuatBan
        {
            get { return namXuatBan; }
            set { namXuatBan = value; }
        }
        public int TriGia 
        {
            get { return triGia; }
            set { triGia = value; }
        }
        
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public Boolean TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public string NgonNgu
        {
            get { return ngonNgu; }
            set { ngonNgu = value; }
        }
        #endregion Properties

        public SachDTO()
        {
            maSach = 0;
            tenSach = "";
            maTheLoai = 0;
            tacGia = "";
           

            namXuatBan = new DateTime(1950, 1, 1);
            triGia = 0;
            ngayNhap = new DateTime(1950, 1, 1);
            tinhTrang = false;
            ngonNgu = "";
        }
    } 
}
