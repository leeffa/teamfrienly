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
        private int loaiSach;
        private string tacGia;
        private int gia;
        private string ngonNgu;
        private string nhaXB;
       // private DateTime namXuatBan;

        
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
        public int LoaiSach
        {
            get { return loaiSach; }
            set { loaiSach = value; }
        }
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public string NgonNgu
        {
            get { return ngonNgu; }
            set { ngonNgu = value; }
        }
       

        public string NhaXB
        {
            get { return nhaXB; }
            set { nhaXB = value; }
        }
       
       
        
        #endregion Properties

        private int maSach;
        private string tenSach;
        private int loaiSach;
        private string tacGia;
        private int gia;
        private string ngonNgu;
        private string nhaXB;
        public SachDTO()
        {
            maSach = 0;
            tenSach = "";
            loaiSach = 0;
            tacGia = "";
            gia = 0;
            ngonNgu = "";
            nhaXB = "";
            
        }
    } 
}
