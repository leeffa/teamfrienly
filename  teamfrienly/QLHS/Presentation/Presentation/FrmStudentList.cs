using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
namespace Presentation
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {

            this.comClass .ValueMember = "MaLop";
            this.comClass.DisplayMember = "TenLop";
            this.comClass.DataSource = Lop_BUS.SelectClassAll();
        }
        private string _strMakeCircle(double _double)
        {
            string _changeStr = Convert.ToString(_double);
            string _c0 = _changeStr[0].ToString();
            int strlen = _changeStr.Length;
            if (strlen == 1)
            {
                return _c0;
            }
            string _c1 = _changeStr[1].ToString();

            string ch = _c0 + _c1;
            //  int strlen = _changeStr.Length ;
            if (strlen <= 4)
            {
                return _changeStr;
            }
            else
            {
                int _c2 = Convert.ToInt16(_changeStr[3].ToString());
                int _c3 = Convert.ToInt16(_changeStr[4].ToString());
                if (_c3 >= 5)
                {
                    _c3 = _c3 + 1;
                }
                ch = ch + Convert.ToString(_c3);
                return ch;
            }


        }
        //se tra ve dtbhk cua 1 hs ung voi 1 hk
        private double _DTBHK(string maHS,string maHK)
        {
            double dtb = 0;
            List<Diem_DTO> list = new List<Diem_DTO>();
            list = Diem_BUS.SelectDiemBy2ID(maHS ,maHK );
            ThamSo_DTO ts = new ThamSo_DTO();
            ts = ThamSo_BUS.SelectThamSoByID("1");
            if (list == null)
            {
                return dtb;
            }
            for (int i = 0; i < list.Count; i++)
            {
                
                dtb += list[i].DTBHK;
            }
            dtb = double.Parse ( _strMakeCircle(dtb / list.Count));
            return dtb;
        }
        private void comClass_SelectedIndexChanged (object sender, EventArgs e)
        {
            int count =1;
            Lop_DTO _class = new Lop_DTO();
            List<ListStudent_DTO> list = new List<ListStudent_DTO>();
            _class = (Lop_DTO )comClass .Items[comClass .SelectedIndex];
            List<Diem_DTO> list_mark = new List<Diem_DTO>();
            list_mark = Diem_BUS.SelectDiemAll();
            for (int i = 0; i < list_mark.Count; i++ )
            {
                bool flag = false; 
                for (int j = 0; j < list.Count; j++)
                {
                    if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                    {
                        flag = true;
                    }
                }
                HocSinh_DTO hs = new HocSinh_DTO ();
                hs = HocSinh_BUS .SelectStudentByID(list_mark[i].MaHocSinh );
                if (hs.MaLop == _class.MaLop && flag ==false)
                {
                    
                    ListStudent_DTO a = new ListStudent_DTO ();
                    double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh,"HK_001");
                    double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh,"HK_002");
                    a.MaHocSinh = hs.MaHocSinh;
                    a.STT = count;
                    a.TenHocSinh = hs.TenHocSinh;
                    a.TenLop = _class.TenLop;
                    a.TBHK1 = dtbhk1;
                    a.TBHK2 = dtbhk2;
                    list.Add(a);
                    count++;
                }
                flag = false;
            }
           dataGridListStudent.DataSource = list;
        }

        private void butGetAll_Click(object sender, EventArgs e)
        {
            int count = 1;
            Lop_DTO _class = new Lop_DTO();
            List<ListStudent_DTO> list = new List<ListStudent_DTO>();
            //get Class
            List<Lop_DTO> lst_Class = new List<Lop_DTO>();
            lst_Class = Lop_BUS.SelectClassAll();
            //get mark
            List<Diem_DTO> list_mark = new List<Diem_DTO>();
            list_mark = Diem_BUS.SelectDiemAll();

            for (int t = 0; t < lst_Class.Count; t++)
            {
                for (int i = 0; i < list_mark.Count; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                        {
                            flag = true;
                        }
                    }
                    HocSinh_DTO hs = new HocSinh_DTO();
                    hs = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);
                    if (hs.MaLop == lst_Class[t].MaLop && flag == false)
                    {

                        ListStudent_DTO a = new ListStudent_DTO();
                        double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                        double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                        a.MaHocSinh = hs.MaHocSinh;
                        a.STT = count;
                        a.TenHocSinh = hs.TenHocSinh;
                        a.TenLop = lst_Class[t].TenLop;
                        a.TBHK1 = dtbhk1;
                        a.TBHK2 = dtbhk2;
                        list.Add(a);
                        count++;
                    }
                    flag = false;

                }//end mark
            }//end Class
            dataGridListStudent.DataSource = list;
        }//end private
    }
}