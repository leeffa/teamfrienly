using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HocSinh_BUS
    {
        // Inserting
        public static bool Insert_Student(HocSinh_DTO  s)
        {
            if (HocSinh_DAO.CheckStudentByMa (s.MaHocSinh ))
            {
                return false;
            }
            return HocSinh_DAO.InSert_Student (s);
        }
        //Updating
        public static bool Update_Student(HocSinh_DTO s)
        {
            if (HocSinh_DAO.CheckStudentByMa(s.MaHocSinh ))
            {
                return HocSinh_DAO.Update_Student(s);
            }
            return false;

        }
        // Deleting
        public static bool Delete_StudentByID(string maS)
        {
            if (HocSinh_DAO.CheckStudentByMa(maS))
            {
                return HocSinh_DAO.Delete_IDHocSinh(maS);
            }
            return false;
        }
        public static List<HocSinh_DTO> SelectStudentAll()
        {
            return HocSinh_DAO.SelectStudenAll ();
        }
        public static HocSinh_DTO SelectStudentByID(string maS)
        {
            if (!HocSinh_DAO.CheckStudentByMa(maS))
            {
                return null;
            }
            return HocSinh_DAO.SelectStudent_ID(maS);
        }
        public static bool CheckStudent_ByID(String ma)
        {
            return HocSinh_DAO .CheckStudentByMa(ma);
        }
        //get all student but don't get ID student
        public static List<HocSinh_DTO> SelectStudentChoose(string malop)
        {
            return HocSinh_DAO.SelectStudentChoose(malop);
        }
        public static int CountStudentSame(string malop)
        {
            return HocSinh_DAO.CountStudentSameClass(malop);
        }
        public static List<HocSinh_DTO> SelectStudentByName(string name)
        {
            return HocSinh_DAO.SelectStudentByName(name);
        }
    }
}
