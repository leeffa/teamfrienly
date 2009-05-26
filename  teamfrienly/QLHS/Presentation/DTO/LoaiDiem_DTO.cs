using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiDiem_DTO
    {
         #region Attributes

        private string maLoaiDiem;
        private int diem15p ;
        private int diem1t;
        private int diemCuoiKy;
        
        #endregion Attributes

        #region Properties
        public string MaLoaiDiem
        {
            get {return  maLoaiDiem;}   
            set { maLoaiDiem = value ; }
        }

        public int Diem15p
        {
            get {return diem15p ;}
            set { diem15p = value ; }
        }

        public int Diem1t
        {
            get { return diem1t; }
            set { diem1t = value; }
        }

         public int DiemCuoiKy
        {
            get {return diemCuoiKy ;}
            set { diemCuoiKy = value ; }
        }
        
       
        #endregion Properties

        public LoaiDiem_DTO()
        {
            maLoaiDiem = "";
            diem15p = 0;  
            diem1t  = 0;
            diemCuoiKy  = 0;
        }
    }
}
