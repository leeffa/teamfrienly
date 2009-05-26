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
    public partial class FrmStudentSearch : Form
    {
        public FrmStudentSearch()
        {
            InitializeComponent();
        }

        private void FrmStudentSearch_Load(object sender, EventArgs e)
        {
            checkMark.Checked = false;
            checkSearchBirthday.Checked = false;
            checkNameClass.Checked = false;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkNameClass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNameClass.Checked)
            {
                comClass.Enabled = true;
                this.comClass.ValueMember = "MaLop";
                this.comClass.DisplayMember = "TenLop";
                this.comClass.DataSource = Lop_BUS.SelectClassAll();
                comClass_SelectedIndexChanged(sender, e);


            }
            else
            {
                comClass.Enabled = false;
                List<Lop_DTO> ls = new List<Lop_DTO>();
                this.comClass.DataSource = ls;

            }
        }
        private void checkSearchBirthday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSearchBirthday.Checked)
            {
                dateTimeStart.Enabled = true;
                dateTimeEnd.Enabled = true;
            }
            else
            {
                dateTimeStart.Enabled = false;
                dateTimeEnd.Enabled = false;
            }
        }

        private void checkDTB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMark.Checked)
            {
                numericStart.Enabled = true;
                numericEnd.Enabled = true;
            }
            else
            {
                numericStart.Enabled = false;
                numericEnd.Enabled = false;
            }
        }
        //Search Class
        //se tra ve dtbhk cua 1 hs ung voi 1 hk
        private double _DTBHK(string maHS, string maHK)
        {
            double dtb = 0;
            List<Diem_DTO> list = new List<Diem_DTO>();
            list = Diem_BUS.SelectDiemBy2ID(maHS, maHK);
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
            dtb = double.Parse(_strMakeCircle(dtb / list.Count));
            return dtb;
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
        private void comClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (txtIDStudent.Text == ""  && txtName.Text == "" && checkSearchBirthday.Checked == false  && checkMark.Checked == false )
            {

                int count = 1;
                Lop_DTO _class = new Lop_DTO();
                List<Search_DTO> list = new List<Search_DTO>();
                _class = (Lop_DTO)comClass.Items[comClass.SelectedIndex];
                List<Diem_DTO> list_mark = new List<Diem_DTO>();
                list_mark = Diem_BUS.SelectDiemAll();
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
                    if (hs.MaLop == _class.MaLop && flag == false)
                    {

                        Search_DTO a = new Search_DTO();
                        double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                        double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                        a.STT = count;
                        a.MaHocSinh = hs.MaHocSinh;

                        a.TenHocSinh = hs.TenHocSinh;
                        a.NgaySinh = hs.NgaySinh;
                        a.TenLop = _class.TenLop;

                        a.DBHK1 = dtbhk1;
                        a.DBHK2 = dtbhk2;
                        list.Add(a);
                        count++;
                    }
                    flag = false;
                }
                dataGridResult.DataSource = list;
                return;
            }
            if (txtIDStudent.Text == "" && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == true)
            {
                double tb1 = double.Parse(numericStart.Value.ToString());
                double tb2 = double.Parse(numericEnd.Value.ToString());
                if (tb1 > tb2)
                {
                    double temp = 0;
                    temp = tb1;
                    tb1 = tb2;
                    tb2 = temp;
                }
                Lop_DTO _class = new Lop_DTO();
                _class =(Lop_DTO )comClass .Items [comClass .SelectedIndex ];
                DateTime dt1 = DateTime.Parse(dateTimeStart.Value.ToString());
                DateTime dt2 = DateTime.Parse(dateTimeEnd.Value.ToString());
                List<Search_DTO> list = SearchA_DTO(dt1,dt2,tb1,tb2);
                List<Search_DTO> _list = new List<Search_DTO>();
                int count = 1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].TenLop == _class.TenLop)
                    {
                        Search_DTO s = new Search_DTO();
                        s.STT = count;
                        s.MaHocSinh = list[i].MaHocSinh;
                        s.TenHocSinh = list[i].TenHocSinh;
                        s.NgaySinh = list[i].NgaySinh;
                        s.TenLop = _class.TenLop;
                        s.DBHK1 = list[i].DBHK1;
                        s.DBHK2 = list[i].DBHK2;
                        count++;
                        _list.Add(s);
                    }
                }
                dataGridResult.DataSource = _list;
                return;

            }
            if (txtIDStudent.Text == "" && txtName.Text != "" && checkSearchBirthday.Checked == true && checkMark.Checked == true)
            {
                double tb1 = double.Parse(numericStart.Value.ToString());
                double tb2 = double.Parse(numericEnd.Value.ToString());
                if (tb1 > tb2)
                {
                    double temp = 0;
                    temp = tb1;
                    tb1 = tb2;
                    tb2 = temp;
                }
                Lop_DTO _class = new Lop_DTO();
                _class = (Lop_DTO)comClass.Items[comClass.SelectedIndex];
                DateTime dt1 = DateTime.Parse(dateTimeStart.Value.ToString());
                DateTime dt2 = DateTime.Parse(dateTimeEnd.Value.ToString());
                List<Search_DTO> list = SearchA_DTO(dt1, dt2, tb1, tb2);
                List<Search_DTO> _list = new List<Search_DTO>();
                int count = 1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].TenLop == _class.TenLop)
                    {
                        Search_DTO s = new Search_DTO();
                        s.STT = 0;
                        s.MaHocSinh = list[i].MaHocSinh;
                        s.TenHocSinh = list[i].TenHocSinh;
                        s.NgaySinh = list[i].NgaySinh;
                        s.TenLop = _class.TenLop;
                        s.DBHK1 = list[i].DBHK1;
                        s.DBHK2 = list[i].DBHK2;
                        _list.Add(s);
                    }
                }
                List<Search_DTO> _Alist = new List<Search_DTO>();
                for (int i = 0; i < _list.Count; i++)
                {
                    if (txtName.Text == _list[i].TenHocSinh)
                    {
                        Search_DTO s = new Search_DTO();
                        s.STT = count;
                        s.MaHocSinh = list[i].MaHocSinh;
                        s.TenHocSinh = list[i].TenHocSinh;
                        s.NgaySinh = list[i].NgaySinh;
                        s.TenLop = _class.TenLop;
                        s.DBHK1 = list[i].DBHK1;
                        s.DBHK2 = list[i].DBHK2;
                        count++;
                        _Alist.Add(s);
                    }
                }
                dataGridResult.DataSource = _Alist;
                return;

            }
            /*
            if (txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == false)
            {

            }
            if (txtName.Text == "" && checkSearchBirthday.Checked == false  && checkMark.Checked == true )
            {

            }*/
            
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == false && checkMark.Checked == false)
            {
                MessageBox.Show("You have yet filled information to search!","Error",MessageBoxButtons .OK ,MessageBoxIcon.Error );
                return;
            }
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == false && checkMark.Checked == false)
            {
                int count = 1;
                List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                list_student = HocSinh_BUS.SelectStudentAll();

                List<Diem_DTO> list_mark = new List<Diem_DTO>();
                List<Search_DTO> list = new List<Search_DTO>();
                list_mark = Diem_BUS.SelectDiemAll();
                if (list_mark == null && list_student == null)
                {
                    MessageBox.Show("Database is yet input  any student ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (list_mark == null && list_student != null)
                {
                    for (int i = 0; i < list_student.Count; i++)
                    {
                        Search_DTO search = new Search_DTO();
                        HocSinh_DTO hs = new HocSinh_DTO();
                        hs = HocSinh_BUS.SelectStudentByID(list_student[i].MaHocSinh);
                        Lop_DTO _class = new Lop_DTO();
                        _class = Lop_BUS.SelectClassByID(hs.MaLop);
                        search.STT = i + 1;
                        search.MaHocSinh = hs.MaHocSinh;
                        search.TenHocSinh = hs.TenHocSinh;
                        search.TenLop = _class.TenLop;
                        search.DBHK1 = 0;
                        search.DBHK2 = 0;
                        list.Add(search);

                    }
                    dataGridResult.DataSource = list;
                    return;
                }
                for (int t = 0; t < list_student.Count; t++)
                {
                    bool a = false;
                    HocSinh_DTO hs_xet = new HocSinh_DTO();
                    hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                    for (int i = 0; i < list_mark.Count; i++)
                    {
                        //loai bo nhung id student da duyet
                        bool flag = false;
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                            {
                                flag = true;
                            }
                        }

                        HocSinh_DTO hs_mark = new HocSinh_DTO();
                        hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                        if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                        {
                            a = true;
                            Search_DTO s_hs = new Search_DTO();
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                            double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                            double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                            s_hs.STT = count;
                            s_hs.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs.NgaySinh = hs_xet.NgaySinh;
                            s_hs.TenLop = _class.TenLop;

                            s_hs.DBHK1 = dtbhk1;
                            s_hs.DBHK2 = dtbhk2;
                            list.Add(s_hs);
                            count++;
                        }


                    }
                    if (a == false)
                    {
                        Search_DTO s_hs2 = new Search_DTO();

                        Lop_DTO _class = new Lop_DTO();
                        _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                        s_hs2.STT = t + 1;
                        s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                        s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                        s_hs2.NgaySinh = hs_xet.NgaySinh;
                        s_hs2.TenLop = _class.MaLop;
                        s_hs2.DBHK1 = 0;
                        s_hs2.DBHK2 = 0;
                        list.Add(s_hs2);
                    }
                }
                dataGridResult.DataSource = list;
                return;


            }
            if (txtIDStudent.Text != "" )
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.MaHocSinh = txtIDStudent.Text;
                hs = HocSinh_BUS.SelectStudentByID(hs.MaHocSinh);

                List<Diem_DTO> list_mark = new List<Diem_DTO>();
                List<Search_DTO> list = new List<Search_DTO>();
                list_mark = Diem_BUS.SelectDiemByIDStudent(hs.MaHocSinh);
                Search_DTO s_hs = new Search_DTO();
                Lop_DTO _class = new Lop_DTO();
                _class = Lop_BUS.SelectClassByID(hs.MaLop);
                if (list_mark == null)
                {
                    s_hs.STT = 1;
                    s_hs.MaHocSinh = hs.MaHocSinh;
                    s_hs.TenHocSinh = hs.TenHocSinh;
                    s_hs.NgaySinh = hs.NgaySinh;
                    s_hs.TenLop = _class.MaLop;
                    s_hs.DBHK1 = 0;
                    s_hs.DBHK2 = 0;
                    list.Add(s_hs);
                    dataGridResult.DataSource = list;
                    return;
                }

                double dtbhk1 = _DTBHK(list_mark[0].MaHocSinh, "HK_001");
                double dtbhk2 = _DTBHK(list_mark[0].MaHocSinh, "HK_002");
                s_hs.STT = 1;
                s_hs.MaHocSinh = hs.MaHocSinh;
                s_hs.TenHocSinh = hs.TenHocSinh;
                s_hs.NgaySinh = hs.NgaySinh;
                s_hs.TenLop = _class.TenLop;

                s_hs.DBHK1 = dtbhk1;
                s_hs.DBHK2 = dtbhk2;
                list.Add(s_hs);
                dataGridResult.DataSource = list;
                return;


            }
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text != "" && checkSearchBirthday.Checked == false && checkMark.Checked == false)
            {
                int count = 1;
                //lay mark
                List<Diem_DTO> list_mark = new List<Diem_DTO>();
                list_mark = Diem_BUS.SelectDiemAll();

                //get lst hs
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.TenHocSinh = txtName.Text;
                List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                list_student = HocSinh_BUS.SelectStudentByName(hs.TenHocSinh);

                List<Search_DTO> list = new List<Search_DTO>();
                if (list_student == null)
                {
                    MessageBox.Show("Student name have found in database!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (list_mark == null && list_student != null)
                {
                    Search_DTO s_hs1 = new Search_DTO();
                    for (int t = 0; t < list_student.Count; t++)
                    {
                        // HocSinh_DTO hs1 = new HocSinh_DTO();
                        Lop_DTO _class1 = new Lop_DTO();
                        _class1 = Lop_BUS.SelectClassByID(list_student[t].MaLop);
                        s_hs1.STT = count;
                        s_hs1.MaHocSinh = list_student[t].MaHocSinh;
                        s_hs1.TenHocSinh = list_student[t].TenHocSinh;
                        s_hs1.NgaySinh = list_student[t].NgaySinh;
                        s_hs1.TenLop = _class1.MaLop;
                        s_hs1.DBHK1 = 0;
                        s_hs1.DBHK2 = 0;
                        list.Add(s_hs1);
                        count++;
                    }
                    dataGridResult.DataSource = list;
                    return;
                }
                if (list_mark == null && list_student == null)
                {
                    MessageBox.Show("Student name have found in database!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //start
                for (int t = 0; t < list_student.Count; t++)
                {
                    bool a = false;
                    HocSinh_DTO hs_xet = new HocSinh_DTO();
                    hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                    for (int i = 0; i < list_mark.Count; i++)
                    {
                        //loai bo nhung id student da duyet
                        bool flag = false;
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                            {
                                flag = true;
                            }
                        }

                        HocSinh_DTO hs_mark = new HocSinh_DTO();
                        hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                        if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                        {
                            a = true;
                            Search_DTO s_hs = new Search_DTO();
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                            double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                            double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                            s_hs.STT = count;
                            s_hs.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs.NgaySinh = hs_xet.NgaySinh;
                            s_hs.TenLop = _class.TenLop;

                            s_hs.DBHK1 = dtbhk1;
                            s_hs.DBHK2 = dtbhk2;
                            list.Add(s_hs);
                            count++;
                        }


                    }
                    if (a == false)
                    {
                        Search_DTO s_hs2 = new Search_DTO();

                        Lop_DTO _class = new Lop_DTO();
                        _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                        s_hs2.STT = t + 1;
                        s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                        s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                        s_hs2.NgaySinh = hs_xet.NgaySinh;
                        s_hs2.TenLop = _class.MaLop;
                        s_hs2.DBHK1 = 0;
                        s_hs2.DBHK2 = 0;
                        list.Add(s_hs2);
                    }


                }
                dataGridResult.DataSource = list;
                return;
            }
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == false && checkMark.Checked == true)
            {//
                double tb1 = double.Parse(numericStart.Value.ToString());
                double tb2 = double.Parse(numericEnd.Value.ToString());
                if (tb1 > tb2)
                {
                    double temp = 0;
                    temp = tb1;
                    tb1 = tb2;
                    tb2 = temp;
                }
                if (tb1 <= tb2)
                {
                    int count = 1;
                    List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                    list_student = HocSinh_BUS.SelectStudentAll();

                    List<Diem_DTO> list_mark = new List<Diem_DTO>();
                    List<Search_DTO> list = new List<Search_DTO>();
                    list_mark = Diem_BUS.SelectDiemAll();
                    if (list_mark == null && list_student == null)
                    {
                        MessageBox.Show("Database is yet input  any student ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    if (list_mark == null && list_student != null)
                    {
                        for (int i = 0; i < list_student.Count; i++)
                        {

                            Search_DTO search = new Search_DTO();
                            HocSinh_DTO hs = new HocSinh_DTO();
                            hs = HocSinh_BUS.SelectStudentByID(list_student[i].MaHocSinh);
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs.MaLop);
                            search.STT = i + 1;
                            search.MaHocSinh = hs.MaHocSinh;
                            search.TenHocSinh = hs.TenHocSinh;
                            search.NgaySinh = hs.NgaySinh;
                            search.TenLop = _class.TenLop;
                            search.DBHK1 = 0;
                            search.DBHK2 = 0;
                            bool flag = false;
                            if (tb1 <= search.DBHK1 && search.DBHK1 <= tb2)
                            {
                                flag = true;
                            }
                            if (tb1 <= search.DBHK2 && search.DBHK2 <= tb2)
                            {
                                flag = true;
                            }
                            if (flag == true)
                            {
                                list.Add(search);

                            }


                        }
                        dataGridResult.DataSource = list;
                        return;
                    }
                    for (int t = 0; t < list_student.Count; t++)
                    {
                        bool a = false;
                        HocSinh_DTO hs_xet = new HocSinh_DTO();
                        hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                        for (int i = 0; i < list_mark.Count; i++)
                        {
                            //loai bo nhung id student da duyet
                            bool flag = false;
                            for (int j = 0; j < list.Count; j++)
                            {
                                if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                                {
                                    flag = true;
                                }
                            }

                            HocSinh_DTO hs_mark = new HocSinh_DTO();
                            hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                            if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                            {
                                a = true;
                                Search_DTO s_hs = new Search_DTO();
                                Lop_DTO _class = new Lop_DTO();
                                _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                                double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                                double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                                s_hs.STT = count;
                                s_hs.MaHocSinh = hs_xet.MaHocSinh;
                                s_hs.TenHocSinh = hs_xet.TenHocSinh;
                                s_hs.NgaySinh = hs_xet.NgaySinh;
                                s_hs.TenLop = _class.TenLop;

                                s_hs.DBHK1 = dtbhk1;
                                s_hs.DBHK2 = dtbhk2;
                                bool _flag = false;
                                if (tb1 <= s_hs.DBHK1 && s_hs.DBHK1 <= tb2)
                                {
                                    _flag = true;
                                }
                                if (tb1 <= s_hs.DBHK2 && s_hs.DBHK2 <= tb2)
                                {
                                    _flag = true;
                                }
                                if (_flag == true)
                                {
                                    list.Add(s_hs);
                                    // _flag == false;
                                    count++;
                                }

                            }


                        }
                        if (a == false)
                        {
                            Search_DTO s_hs2 = new Search_DTO();

                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                            s_hs2.STT = t + 1;
                            s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs2.NgaySinh = hs_xet.NgaySinh;
                            s_hs2.TenLop = _class.MaLop;
                            s_hs2.DBHK1 = 0;
                            s_hs2.DBHK2 = 0;
                            bool _flag = false;
                            if (tb1 <= s_hs2.DBHK1 && s_hs2.DBHK1 <= tb2)
                            {
                                _flag = true;
                            }
                            if (tb1 <= s_hs2.DBHK2 && s_hs2.DBHK2 <= tb2)
                            {
                                _flag = true;
                            }
                            if (_flag == true)
                            {
                                list.Add(s_hs2);
                            }
                        }
                    }
                    dataGridResult.DataSource = list;
                    return;
                }


            }//end if mark
            //start birthday
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == false)
            {
                DateTime dt1 = DateTime.Parse(dateTimeStart.Value.ToString());
                DateTime dt2 = DateTime.Parse(dateTimeEnd.Value.ToString());
                if (dt1 > dt2)
                {
                    DateTime temp = new DateTime();
                    temp = dt1;
                    dt1 = dt2;
                    dt2 = temp;
                }
                if (dt1 <= dt2)
                {
                    int count = 1;
                    List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                    list_student = HocSinh_BUS.SelectStudentAll();

                    List<Diem_DTO> list_mark = new List<Diem_DTO>();
                    List<Search_DTO> list = new List<Search_DTO>();
                    list_mark = Diem_BUS.SelectDiemAll();
                    if (list_mark == null && list_student == null)
                    {
                        MessageBox.Show("Database is yet input  any student ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    if (list_mark == null && list_student != null)
                    {
                        for (int i = 0; i < list_student.Count; i++)
                        {

                            Search_DTO search = new Search_DTO();
                            HocSinh_DTO hs = new HocSinh_DTO();
                            hs = HocSinh_BUS.SelectStudentByID(list_student[i].MaHocSinh);
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs.MaLop);
                            search.STT = i + 1;
                            search.MaHocSinh = hs.MaHocSinh;
                            search.TenHocSinh = hs.TenHocSinh;
                            search.NgaySinh = hs.NgaySinh;
                            search.TenLop = _class.TenLop;
                            search.DBHK1 = 0;
                            search.DBHK2 = 0;
                            bool flag = false;
                            if (dt1 <= hs.NgaySinh && hs.NgaySinh <= dt2)
                            {
                                flag = true;
                            }

                            if (flag == true)
                            {
                                list.Add(search);

                            }


                        }
                        dataGridResult.DataSource = list;
                        return;
                    }
                    for (int t = 0; t < list_student.Count; t++)
                    {
                        bool a = false;
                        HocSinh_DTO hs_xet = new HocSinh_DTO();
                        hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                        for (int i = 0; i < list_mark.Count; i++)
                        {
                            //loai bo nhung id student da duyet
                            bool flag = false;
                            for (int j = 0; j < list.Count; j++)
                            {
                                if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                                {
                                    flag = true;
                                }
                            }

                            HocSinh_DTO hs_mark = new HocSinh_DTO();
                            hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                            if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                            {
                                a = true;
                                Search_DTO s_hs = new Search_DTO();
                                Lop_DTO _class = new Lop_DTO();
                                _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                                double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                                double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                                s_hs.STT = count;
                                s_hs.MaHocSinh = hs_xet.MaHocSinh;
                                s_hs.TenHocSinh = hs_xet.TenHocSinh;
                                s_hs.NgaySinh = hs_xet.NgaySinh;
                                s_hs.TenLop = _class.TenLop;

                                s_hs.DBHK1 = dtbhk1;
                                s_hs.DBHK2 = dtbhk2;
                                bool _flag = false;
                                if (dt1 <= s_hs.NgaySinh && s_hs.NgaySinh <= dt2)
                                {
                                    _flag = true;
                                }

                                if (_flag == true)
                                {
                                    list.Add(s_hs);
                                    // _flag == false;
                                    count++;
                                }

                            }


                        }
                        if (a == false)
                        {
                            Search_DTO s_hs2 = new Search_DTO();

                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                            s_hs2.STT = t + 1;
                            s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs2.NgaySinh = hs_xet.NgaySinh;
                            s_hs2.TenLop = _class.MaLop;
                            s_hs2.DBHK1 = 0;
                            s_hs2.DBHK2 = 0;
                            bool _flag = false;
                            if (dt1 <= s_hs2.NgaySinh && s_hs2.NgaySinh <= dt2)
                            {
                                _flag = true;
                            }
                            
                            if (_flag == true)
                            {
                                list.Add(s_hs2);
                            }
                        }
                    }
                    dataGridResult.DataSource = list;
                    return;
                }


            }//end if birthday
            //start birthday
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == false)
            {
                DateTime dt1 = DateTime.Parse(dateTimeStart.Value.ToString());
                DateTime dt2 = DateTime.Parse(dateTimeEnd.Value.ToString());
                if (dt1 > dt2)
                {
                    DateTime temp = new DateTime();
                    temp = dt1;
                    dt1 = dt2;
                    dt2 = temp;
                }
                if (dt1 <= dt2)
                {
                    int count = 1;
                    List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                    list_student = HocSinh_BUS.SelectStudentAll();

                    List<Diem_DTO> list_mark = new List<Diem_DTO>();
                    List<Search_DTO> list = new List<Search_DTO>();
                    list_mark = Diem_BUS.SelectDiemAll();
                    if (list_mark == null && list_student == null)
                    {
                        MessageBox.Show("Database is yet input  any student ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    if (list_mark == null && list_student != null)
                    {
                        for (int i = 0; i < list_student.Count; i++)
                        {

                            Search_DTO search = new Search_DTO();
                            HocSinh_DTO hs = new HocSinh_DTO();
                            hs = HocSinh_BUS.SelectStudentByID(list_student[i].MaHocSinh);
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs.MaLop);
                            search.STT = i + 1;
                            search.MaHocSinh = hs.MaHocSinh;
                            search.TenHocSinh = hs.TenHocSinh;
                            search.NgaySinh = hs.NgaySinh;
                            search.TenLop = _class.TenLop;
                            search.DBHK1 = 0;
                            search.DBHK2 = 0;
                            bool flag = false;
                            if (dt1 <= hs.NgaySinh && hs.NgaySinh <= dt2)
                            {
                                flag = true;
                            }

                            if (flag == true)
                            {
                                list.Add(search);

                            }


                        }
                        dataGridResult.DataSource = list;
                        return;
                    }
                    for (int t = 0; t < list_student.Count; t++)
                    {
                        bool a = false;
                        HocSinh_DTO hs_xet = new HocSinh_DTO();
                        hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                        for (int i = 0; i < list_mark.Count; i++)
                        {
                            //loai bo nhung id student da duyet
                            bool flag = false;
                            for (int j = 0; j < list.Count; j++)
                            {
                                if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                                {
                                    flag = true;
                                }
                            }

                            HocSinh_DTO hs_mark = new HocSinh_DTO();
                            hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                            if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                            {
                                a = true;
                                Search_DTO s_hs = new Search_DTO();
                                Lop_DTO _class = new Lop_DTO();
                                _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                                double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                                double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                                s_hs.STT = count;
                                s_hs.MaHocSinh = hs_xet.MaHocSinh;
                                s_hs.TenHocSinh = hs_xet.TenHocSinh;
                                s_hs.NgaySinh = hs_xet.NgaySinh;
                                s_hs.TenLop = _class.TenLop;

                                s_hs.DBHK1 = dtbhk1;
                                s_hs.DBHK2 = dtbhk2;
                                bool _flag = false;
                                if (dt1 <= s_hs.NgaySinh && s_hs.NgaySinh <= dt2)
                                {
                                    _flag = true;
                                }

                                if (_flag == true)
                                {
                                    list.Add(s_hs);
                                    // _flag == false;
                                    count++;
                                }

                            }


                        }
                        if (a == false)
                        {
                            Search_DTO s_hs2 = new Search_DTO();

                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                            s_hs2.STT = t + 1;
                            s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs2.NgaySinh = hs_xet.NgaySinh;
                            s_hs2.TenLop = _class.MaLop;
                            s_hs2.DBHK1 = 0;
                            s_hs2.DBHK2 = 0;
                            bool _flag = false;
                            if (dt1 <= s_hs2.NgaySinh && s_hs2.NgaySinh <= dt2)
                            {
                                _flag = true;
                            }
                            
                            if (_flag == true)
                            {
                                list.Add(s_hs2);
                            }
                        }
                    }
                    dataGridResult.DataSource = list;
                    return;
                }


            }//end if birthday
            //2 check: birthday and mark
            
            if (txtIDStudent.Text == "" && checkNameClass.Checked == false && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == true)
            {
                double tb1 = double.Parse(numericStart.Value.ToString());
                double tb2 = double.Parse(numericEnd.Value.ToString());
                if (tb1 > tb2)
                {
                    double temp = 0;
                    temp = tb1;
                    tb1 = tb2;
                    tb2 = temp;
                }
                DateTime dt1 = DateTime.Parse(dateTimeStart.Value.ToString());
                DateTime dt2 = DateTime.Parse(dateTimeEnd.Value.ToString());
                dataGridResult.DataSource  = SearchA_DTO(dt1,dt2,tb1,tb2);
             }//end 2:mark and birthday
             if (txtIDStudent.Text == "" && checkNameClass.Checked == true && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == true)
             {
               comClass_SelectedIndexChanged(sender,e);
             }
             if (txtIDStudent.Text == "" && checkNameClass.Checked == true && txtName.Text != "" && checkSearchBirthday.Checked == true && checkMark.Checked == true)
             {
                 comClass_SelectedIndexChanged(sender, e);
             }

             if (txtIDStudent.Text == "" && checkNameClass.Checked == true && txtName.Text == "" && checkSearchBirthday.Checked == false  && checkMark.Checked == true)
             {
                 comClass_SelectedIndexChanged(sender, e);
             }
             if (txtIDStudent.Text == "" && checkNameClass.Checked == true && txtName.Text == "" && checkSearchBirthday.Checked == true && checkMark.Checked == false )
             {
                 comClass_SelectedIndexChanged(sender, e);
             }



        }
        private List<Search_DTO> SearchA_DTO(DateTime dt1,DateTime dt2,Double tb1,Double tb2)
        {
            List<Search_DTO> list = new List<Search_DTO>();
                if (tb1 > tb2)
                {
                    double temp = 0;
                    temp = tb1;
                    tb1 = tb2;
                    tb2 = temp;
                }
                if (dt1 > dt2)
                {
                    DateTime temp = new DateTime();
                    temp = dt1;
                    dt1 = dt2;
                    dt2 = temp;
                }
                if (dt1 <= dt2)
                {
                    int count = 1;
                    List<HocSinh_DTO> list_student = new List<HocSinh_DTO>();
                    list_student = HocSinh_BUS.SelectStudentAll();

                    List<Diem_DTO> list_mark = new List<Diem_DTO>();
                    
                    list_mark = Diem_BUS.SelectDiemAll();
                    if (list_mark == null && list_student == null)
                    {
                        MessageBox.Show("Database is yet input  any student ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return list;
                    }
                    if (list_mark == null && list_student != null)
                    {
                        for (int i = 0; i < list_student.Count; i++)
                        {

                            Search_DTO search = new Search_DTO();
                            HocSinh_DTO hs = new HocSinh_DTO();
                            hs = HocSinh_BUS.SelectStudentByID(list_student[i].MaHocSinh);
                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs.MaLop);
                            search.STT = i + 1;
                            search.MaHocSinh = hs.MaHocSinh;
                            search.TenHocSinh = hs.TenHocSinh;
                            search.NgaySinh = hs.NgaySinh;
                            search.TenLop = _class.TenLop;
                            search.DBHK1 = 0;
                            search.DBHK2 = 0;
                            bool flag = false;
                            if (dt1 <= hs.NgaySinh && hs.NgaySinh <= dt2)
                            {
                                flag = true;
                            }
                            bool flag2 = false;
                            if (flag == true)
                            {
                                if (tb1 <= search.DBHK1 && search.DBHK1 <= tb2)
                                {
                                    flag2 = true;
                                }
                                if (tb1 <= search.DBHK2 && search.DBHK2 <= tb2)
                                {
                                    flag2 = true;
                                }
                                if (flag2 == true)
                                {
                                    list.Add(search);
                                }

                            }


                        }
                        //dataGridResult.DataSource = list;
                        return list;
                    }
                    for (int t = 0; t < list_student.Count; t++)
                    {
                        bool a = false;
                        HocSinh_DTO hs_xet = new HocSinh_DTO();
                        hs_xet = HocSinh_BUS.SelectStudentByID(list_student[t].MaHocSinh);

                        for (int i = 0; i < list_mark.Count; i++)
                        {
                            //loai bo nhung id student da duyet
                            bool flag = false;
                            for (int j = 0; j < list.Count; j++)
                            {
                                if (list_mark[i].MaHocSinh == list[j].MaHocSinh)
                                {
                                    flag = true;
                                }
                            }

                            HocSinh_DTO hs_mark = new HocSinh_DTO();
                            hs_mark = HocSinh_BUS.SelectStudentByID(list_mark[i].MaHocSinh);



                            if (flag == false && hs_xet.MaHocSinh == hs_mark.MaHocSinh)
                            {
                                a = true;
                                Search_DTO s_hs = new Search_DTO();
                                Lop_DTO _class = new Lop_DTO();
                                _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);
                                double dtbhk1 = _DTBHK(list_mark[i].MaHocSinh, "HK_001");
                                double dtbhk2 = _DTBHK(list_mark[i].MaHocSinh, "HK_002");
                                s_hs.STT = count;
                                s_hs.MaHocSinh = hs_xet.MaHocSinh;
                                s_hs.TenHocSinh = hs_xet.TenHocSinh;
                                s_hs.NgaySinh = hs_xet.NgaySinh;
                                s_hs.TenLop = _class.TenLop;

                                s_hs.DBHK1 = dtbhk1;
                                s_hs.DBHK2 = dtbhk2;
                                bool _flag = false;
                                if (dt1 <= s_hs.NgaySinh && s_hs.NgaySinh <= dt2)
                                {
                                    _flag = true;
                                }

                                if (_flag == true)
                                {
                                    bool flag3 = false;
                                    if (tb1 <= s_hs.DBHK1 && s_hs.DBHK1 <= tb2)
                                    {
                                        flag3 = true;
                                    }
                                    if (tb1 <= s_hs.DBHK2 && s_hs.DBHK2 <= tb2)
                                    {
                                        flag3 = true;
                                    }
                                    if (flag3 == true)
                                    {
                                        list.Add(s_hs);
                                        count++;
                                    }

                                    // _flag == false;

                                }

                            }


                        }
                        if (a == false)
                        {
                            Search_DTO s_hs2 = new Search_DTO();

                            Lop_DTO _class = new Lop_DTO();
                            _class = Lop_BUS.SelectClassByID(hs_xet.MaLop);

                            s_hs2.STT = t + 1;
                            s_hs2.MaHocSinh = hs_xet.MaHocSinh;
                            s_hs2.TenHocSinh = hs_xet.TenHocSinh;
                            s_hs2.NgaySinh = hs_xet.NgaySinh;
                            s_hs2.TenLop = _class.MaLop;
                            s_hs2.DBHK1 = 0;
                            s_hs2.DBHK2 = 0;
                            bool _flag = false;
                            if (dt1 <= s_hs2.NgaySinh && s_hs2.NgaySinh <= dt2)
                            {
                                _flag = true;
                            }

                            if (_flag == true)
                            {
                                bool flag3 = false;
                                if (tb1 <= s_hs2.DBHK1 && s_hs2.DBHK1 <= tb2)
                                {
                                    flag3 = true;
                                }
                                if (tb1 <= s_hs2.DBHK2 && s_hs2.DBHK2 <= tb2)
                                {
                                    flag3 = true;
                                }
                                if (flag3 == true)
                                {
                                    list.Add(s_hs2);

                                }

                            }
                        }
                    }//end for
                   // dataGridResult.DataSource = list;

                }//end if
                return list;
        }//end private Search_DTO
        //start 2 referent
        
    }
}