using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Lop_DTO
    {
        #region Attributes

        private string  maLop;
        private string tenLop;
        private string  maKhoi;
        private int siSo;
        
        #endregion Attributes

        #region Properties
        public string MaLop
        {
            get {return  maLop;}   
            set { maLop = value ; }
        }
        public string TenLop
        {
            get { return  tenLop;}
            set {  tenLop = value; }
        }
        public string MaKhoi
        {
            get { return maKhoi;}
            set { maKhoi = value ; }
        }
        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }
        #endregion Properties

        public Lop_DTO()
        {
            maLop = "";
            tenLop = "";
            maKhoi = "";
            siSo = 0;
            
        }
    }
}
