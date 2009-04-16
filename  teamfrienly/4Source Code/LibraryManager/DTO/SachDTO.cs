using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    //[Serializable]
    public class SachDTO
    {
        #region Attributes

        private string ma;
        private string ten;
        private string loaiSach;
        private string tacGia;
        private int gia;
        private string ngonNgu;
        private string nhaXB;
       // private DateTime namXuatBan;

        
        #endregion Attributes
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
        public string LoaiSach
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

        
        public SachDTO()
        {
            ma = "";
            ten = "";
            loaiSach = "";
            tacGia = "";
            gia = 0;
            ngonNgu = "";
            nhaXB = "";
            
        }
    } 
}
