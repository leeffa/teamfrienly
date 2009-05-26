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
    public partial class FrmStudentMark : Form
    {
        public FrmStudentMark()
        {
            InitializeComponent();
        }
        private void ShowMaster()
        {
            dataGridStudentMark.AutoGenerateColumns = false;
            dataGridStudentMark.DataSource = Diem_BUS.SelectDiemAll();
        }
        private void FrmStudentMark_Load(object sender, EventArgs e)
        {
            dataGridStudentMark.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudentMark.AllowUserToResizeRows = false;
            dataGridStudentMark.AllowUserToDeleteRows = false;
            dataGridStudentMark.AllowUserToAddRows = false;
           
            //semester
            this.comSemester .ValueMember = "MaHocKy";
            this.comSemester.DisplayMember = "TenHocKy";
            this.comSemester.DataSource = HocKy_BUS.SelectHocKyAll ();
            //mass
            this.comMass.ValueMember = "MaKhoi";
            this.comMass.DisplayMember = "TenKhoi";
            this.comMass.DataSource = Khoi_BUS.SelectKhoiAll();
            //process choose to load suitable class
            Khoi_DTO mass = new Khoi_DTO();
            int iMass = comMass.SelectedIndex;
            mass = (Khoi_DTO)comMass.Items[iMass];
            string maMass = mass.MaKhoi;

            this.comClass.ValueMember = "MaLop";
            this.comClass.DisplayMember = "TenLop";
            this.comClass.DataSource = Lop_BUS.SelectClassSuitble(maMass);
            //subjects
            this.comSubject.ValueMember = "MaMon";
            this.comSubject.DisplayMember = "TenMon";
            this.comSubject.DataSource = Mon_BUS.SelectMonAll();

            dataGridStudentMark.DataSource = Choose_Mark();

        }
        private List<Out_Mark> Choose_Mark()
        {
            List<Diem_DTO> list = new List<Diem_DTO>();
            List<Out_Mark> list_Mark = new List<Out_Mark>();
            list = Diem_BUS.SelectDiemAll();
            int count = 1;
            for (int i = 0; i < list.Count; i++)
            {
                //get 
                HocSinh_DTO student = new HocSinh_DTO();
                Lop_DTO _class = new Lop_DTO ();
                _class =(Lop_DTO )comClass .Items [comClass .SelectedIndex ];
                student = HocSinh_BUS.SelectStudentByID(list[i].MaHocSinh);

                if (student.MaLop ==_class .MaLop  )
                {
                    Out_Mark out_mark = new Out_Mark();

                    student = HocSinh_BUS.SelectStudentByID(list[i].MaHocSinh);
                    out_mark.STT = count;
                    out_mark.HoTen = student.TenHocSinh;
                    out_mark.Diem15p = list[i].Diem15p;
                    out_mark.Diem1t = list[i].Diem1t;
                    out_mark.DiemCuoiKy = list[i].DiemCuoiKy;
                    out_mark.DTBHK  = double.Parse(_strMakeCircle(list[i].DTBHK));

                    HocKy_DTO semester = new HocKy_DTO();
                    semester = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
                    out_mark.HocKy = semester.TenHocKy;
                    list_Mark.Add(out_mark);
                    count++;
                }
                
            }
            return list_Mark;
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comMass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Khoi_DTO mass = new Khoi_DTO();
            int iMass = comMass.SelectedIndex;
            mass = (Khoi_DTO)comMass.Items[iMass];
            string maMass = mass.MaKhoi;

            this.comClass.ValueMember = "MaLop";
            this.comClass.DisplayMember = "TenLop";
            this.comClass.DataSource = Lop_BUS.SelectClassSuitble(maMass);
        }

        private void butCheckID_Click(object sender, EventArgs e)
        {
            HocSinh_DTO student = new HocSinh_DTO();
            //get ID Class from comClass
            Lop_DTO _class = new Lop_DTO ();
            _class =(Lop_DTO ) comClass .Items [comClass .SelectedIndex ];
            if(txtIDStudent.Text =="")
            {
                MessageBox.Show("ID Student hasn't choose !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool rs_check = HocSinh_BUS.CheckStudent_ByID(txtIDStudent.Text);
            if (rs_check == true)
            {
                student = HocSinh_BUS.SelectStudentByID(txtIDStudent.Text);
                if (student.MaLop == _class .MaLop)
                {
                    txtName.Text = student.TenHocSinh;
                }
                else
                {
                    MessageBox.Show("ID Student hasn't existed in class !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("ID Student hasn't existed in any class !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void text15_KeyPress(object sender, KeyPressEventArgs e)
        {

            int s = 0;
            string ch = "";

            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar) && Convert.ToString(e.KeyChar) != ".")
            {
                e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                MessageBox.Show("You must fill number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            string str = text15 .Text;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "." && s <= 1)
                {
                    s++;
                }
                if (s > 1)
                {
                    text15.Text = ch;
                    s = 0;
                    e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                    MessageBox.Show("Only 1 dot!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ch = str[i].ToString();
            }
           
            
           
        }
        
        private void txt1t_KeyPress(object sender, KeyPressEventArgs e)
        {

            int a = 0;
            string ch = "";
           
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar)&& Convert.ToString (e.KeyChar)!= ".")
            {
                e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                MessageBox.Show("You must fill number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            string str = txt1t.Text;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "." && a <= 1)
                {
                    a++;
                }
                if(a > 1 )
                {
                    txt1t.Text = ch;
                    a = 0;
                    e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                    MessageBox.Show("Only 1 dot!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ch = str[i].ToString();
            }
           
            
        }

        private void txtCuoiKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = 0;
            string ch = "";

            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar) && Convert.ToString(e.KeyChar) != ".")
            {
                e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                MessageBox.Show("You must fill number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            string str = txtCuoiKy.Text;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "." && a <= 1)
                {
                    a++;
                }
                if (a > 1)
                {
                    txtCuoiKy.Text = ch;
                    a = 0;
                    e.Handled = true;// viec dien ki tu da duoc quan ly ko cho danh ki tu vao
                    MessageBox.Show("Only 1 dot!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ch = str[i].ToString();
            }
           
            
        }

        private void butSaveMark_Click(object sender, EventArgs e)
        {
            if (text15.Text == "")
            {
                MessageBox.Show("15' mark isn't fill  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt1t.Text == "")
            {
                MessageBox.Show("1t mark isn't fill  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCuoiKy.Text == "")
            {
                MessageBox.Show(" Semester end mark isn't fill  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double diem15 = double.Parse(text15.Text);
            double diem1t = double.Parse(txt1t.Text);
            double diemck = double.Parse(txtCuoiKy.Text);
            if (diem15 > 10 || diem15 < 0)
            {
                MessageBox.Show("15' mark must in [0,10]  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (diem1t > 10 || diem1t < 0)
            {
                MessageBox.Show("1t mark must in [0,10]  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (diemck > 10 || diemck < 0)
            {
                MessageBox.Show("semester end mark must in [0,10]  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HocKy_DTO hk = new HocKy_DTO();
            hk = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
            Mon_DTO subject = new Mon_DTO();
            subject = (Mon_DTO)comSubject.Items[comSubject.SelectedIndex];

            Diem_DTO mark = new Diem_DTO();
            mark.MaHocKy = hk.MaHocKy;
            mark.MaMon = subject.MaMon;
            mark.MaHocSinh = txtIDStudent.Text;
            mark.Diem15p = double.Parse(text15.Text);
            mark.Diem1t = double.Parse(txt1t.Text);
            mark.DiemCuoiKy = double.Parse(txtCuoiKy.Text);
            mark.DTBHK = double .Parse ( _strMakeCircle(mark_Average(double.Parse(text15.Text), double.Parse(txt1t.Text), double.Parse(txtCuoiKy.Text))));
            bool rs_insert = Diem_BUS.Insert_Diem(mark);
            if (rs_insert == true)
            {
                txtTBHK.Text = Convert.ToString(mark.DTBHK);
                MessageBox.Show("Input to finish Mark!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridStudentMark.DataSource = Choose_Mark();
                return;
            }
            else
            {
                MessageBox.Show("Id has been same with different ID ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                 //  ShowMaster();
                return;
            }
        }
        public double mark_Average(double a, double b, double c)
        {
            double tb = (a + b * 2) / 3;
            double d = (tb * 2 + c) / 3;
            return d;
        }

        private void comClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridStudentMark.DataSource = Choose_Mark();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDStudent.Text == "")
            {
                MessageBox.Show("You must input student ID to update!","Warning",MessageBoxButtons .OK ,MessageBoxIcon.Warning );
                return;
            }
            if (txt1t.Text == "")
            {
                MessageBox.Show("You must input 1t mark ID to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (text15.Text == "")
            {
                MessageBox.Show("You must input 15' mark ID to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //average
            txtTBHK.Text = Convert.ToString(mark_Average(double.Parse(text15.Text), double.Parse(txt1t.Text), double.Parse(txtCuoiKy.Text)));
       
            HocKy_DTO hk = new HocKy_DTO();
            hk = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
            Mon_DTO subject = new Mon_DTO();
            subject = (Mon_DTO)comSubject.Items[comSubject.SelectedIndex];
            Diem_DTO _mark_Update = new Diem_DTO();
            _mark_Update.MaHocSinh = txtIDStudent.Text;
            _mark_Update.MaHocKy = hk.MaHocKy ;
            _mark_Update.MaMon = subject .MaMon ;
            _mark_Update.Diem15p = double.Parse(text15.Text);
            _mark_Update.Diem1t = double.Parse(txt1t.Text);
            _mark_Update.DiemCuoiKy = double.Parse(txtCuoiKy.Text);
            _mark_Update.DTBHK =double.Parse (_strMakeCircle(double.Parse (txtTBHK.Text)));
            bool _update = Diem_BUS.Update_Diem(_mark_Update);
            if (_update == true)
            {
                txtTBHK.Text = Convert.ToString (  _mark_Update.DTBHK);
                dataGridStudentMark.DataSource = Choose_Mark();
                MessageBox.Show("Update Id' Student = " + txtIDStudent.Text + " finished!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Update Id' Student = " + txtIDStudent.Text + " fail Id dont't exist in mark table!", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dataGridStudentMark_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridStudentMark.CurrentRow != null)
            {
                //this.txtName.Text = this.dataGridStudentMark.CurrentRow.Cells["HoTen"].Value.ToString();
               // this.text15.Text = this.dataGridStudentMark.CurrentRow.Cells["Diem15p"].Value.ToString();
              //  this.txt1t.Text = this.dataGridStudentMark.CurrentRow.Cells["Diem1t"].Value.ToString();
               // this.txtCuoiKy.Text = this.dataGridStudentMark.CurrentRow.Cells["DiemCuoiKy"].Value.ToString();
               // this.comGioiTinh.Text = this.dataGridViewStudent.CurrentRow.Cells["GioiTinh"].Value.ToString();
                
            }
        }

        private void butCheckUpdate_Click(object sender, EventArgs e)
        {
            Diem_DTO _mark = new Diem_DTO();
            Mon_DTO _subject = new Mon_DTO ();
            _subject = (Mon_DTO)comSubject.Items[comSubject.SelectedIndex];
            HocKy_DTO _semester = new HocKy_DTO ();
            _semester = (HocKy_DTO )comSemester.Items[comSemester.SelectedIndex ];
            if (txtIDStudent.Text == "")
            {
                MessageBox.Show("ID Student hasn't choose !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mark.MaHocSinh = txtIDStudent.Text;
            _mark.MaHocKy = _semester.MaHocKy ;
            _mark .MaMon =_subject.MaMon ;

            Diem_DTO _mark_Result = new Diem_DTO();
           _mark_Result = Diem_BUS.SelectDiemByID(_mark.MaHocSinh, _mark.MaMon, _mark.MaHocKy);
           if (_mark_Result == null)
           {
               MessageBox.Show("Id's student is yet input mark!","Error",MessageBoxButtons .OK ,MessageBoxIcon.Error );
               return;
           }
           if (_mark_Result.MaHocKy != "")
           {
               HocSinh_DTO st = new HocSinh_DTO ();
               st = HocSinh_BUS .SelectStudentByID (_mark_Result.MaHocSinh );
               txtName.Text = st.TenHocSinh;
               text15.Text = Convert.ToString(_mark_Result.Diem15p);
              
              
               txt1t.Text = Convert.ToString(_mark_Result.Diem1t);
               txtCuoiKy.Text = Convert.ToString(_mark_Result.DiemCuoiKy);
               txtTBHK.Text = _strMakeCircle(_mark_Result.DTBHK);
               //string abc = _strMakeCircle(_mark_Result.DTBHK);
               //MessageBox.Show(abc);
           }
           else
           {
               MessageBox.Show("ID Student have yet inputed mark in this semester or subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
           }
        }
        private string _strMakeCircle(double _double)
        {
            string _changeStr = Convert.ToString( _double);
            string _c0 = _changeStr[0].ToString();
            int strlen = _changeStr.Length;
            if (strlen == 1)
            {
                return _c0;
            }
            string _c1 = _changeStr[1].ToString();
            
            string ch = _c0 +_c1;
          //  int strlen = _changeStr.Length ;
            if(strlen <=3)
            {
                return _changeStr;
            }
            else
            {
               int _c2 =Convert .ToInt16 (_changeStr[3].ToString());
               int _c3 = Convert.ToInt16(_changeStr[4].ToString());
               if (_c3 >= 5)
               {
                   _c3 = _c3 + 1 ;
               }
               ch = ch + Convert .ToString (_c3);
               return ch;
            }
            
            
        }

        private void butReresh_Click(object sender, EventArgs e)
        {
            text15.Text = "";
            txt1t.Text = "";
            txtCuoiKy.Text = "";
            txtTBHK.Text = "";
            txtName.Text = "";
        }


    }
}