using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class Diem_BUS
    {
        // Inserting
        public static bool Insert_Diem(Diem_DTO s)
        {
            if (Diem_DAO.CheckDiemByID(s.MaHocSinh,s.MaMon,s.MaHocKy ))
            {
                return false;
            }
            return Diem_DAO.InSert_Diem(s);
        }
        //Updating
        public static bool Update_Diem(Diem_DTO s)
        {
            if (Diem_DAO.CheckDiemByID(s.MaHocSinh, s.MaMon, s.MaHocKy))
            {
                return Diem_DAO.Update_Diem(s);
            }
            return false;

        }

        // Deleting
        public static bool Delete_DiemByID(string ma1,string ma2,string ma3)
        {
            if (Diem_DAO.CheckDiemByID(ma1, ma2, ma3))
            {
                return Diem_DAO.Delete_IDDiem(ma1,ma2,ma3);
            }
            return false;
        }
        // Deleting same ID'Student
        public static bool Delete_DiemByIDStudent(string ma)
        {
            if (Diem_DAO.CheckDiemBy_IDStudent(ma))
            {
                return Diem_DAO.Delete_IDStudent(ma);
            }
            return false;
        }

        // Deleting same ID'Student
        public static bool Delete_DiemByIDSubject(string ma)
        {
            if (Diem_DAO.CheckDiemBy_IDSubject(ma))
            {
                return Diem_DAO.Delete_IDSubject(ma);
            }
            return false;
        }
        public static List<Diem_DTO> SelectDiemAll()
        {
            return Diem_DAO.SelectDiemAll();
        }
        public static Diem_DTO SelectDiemByID(string maHS, string maMon, string maHocKy)
        {
            if (!Diem_DAO.CheckDiemByID(maHS, maMon, maHocKy))
            {
                return null;
            }
            return Diem_DAO.SelectDiem_ID(maHS, maMon, maHocKy);
        }

        public static List<Diem_DTO> SelectDiemByIDStudent(string ma)
        {
           if (!Diem_DAO.CheckDiemBy_IDStudent(ma))
           {
                return null;
            }
            return Diem_DAO.SelectDiem_IDStudent (ma);
        }
        public static bool CheckDiem_ByIDStudent(String ma)
        {
            return Diem_DAO.CheckDiemBy_IDStudent(ma);
        }
        public static bool CheckDiem_ByIDSubject(String ma)
        {
            return Diem_DAO.CheckDiemBy_IDSubject(ma);
        }

        public static List<Diem_DTO> SelectDiemBy2ID(string maHS,string maHK)
        {
            if (!Diem_DAO.CheckDiemBy_2ID(maHS,maHK))
            {
                return null;
            }
            return Diem_DAO.SelectDiem_2ID(maHS, maHK);
        }
    }
}
