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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        Lop_DTO _classSiSo_First = new Lop_DTO();
        public void ShowMaster()
        {
            this.dataGridViewStudent.AutoGenerateColumns = false;
          //List <HocSinh_DTO >.=HocSinh_BUS.SelectStudentAll()
            this.dataGridViewStudent.DataSource = HocSinh_BUS.SelectStudentAll();
        }
        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            
             comGioiTinh.SelectedIndex = 0;
          

             //load comKhoi
             textSiSoLop.Enabled = false;
             this.comKhoi.ValueMember = "MaKhoi";
             this.comKhoi.DisplayMember = "TenKhoi";
             this.comKhoi.DataSource = Khoi_BUS.SelectKhoiAll();
             //process choose to load suitable class
             Khoi_DTO mass = new Khoi_DTO();
             int iMass = comKhoi.SelectedIndex;
             mass = (Khoi_DTO)comKhoi.Items[iMass];
             string maMass = mass.MaKhoi ;
             
             this.comboBoxLop.ValueMember = "MaLop";
             this.comboBoxLop.DisplayMember = "TenLop";
             this.comboBoxLop.DataSource = Lop_BUS.SelectClassSuitble(maMass);
            //load amount Student's Class 
            Lop_DTO lop = new Lop_DTO ();
            int index = comboBoxLop.SelectedIndex;
            lop = (Lop_DTO)comboBoxLop.Items[index];
            
            this.textSiSoLop.Text = Convert.ToString(lop.SiSo);
             this.ShowMaster();
             _classSiSo_First = (Lop_DTO)comboBoxLop.Items[comboBoxLop.SelectedIndex];
             Lop_DTO lop_dto = new Lop_DTO();
             HocSinh_DTO hs = new HocSinh_DTO();
             lop_dto = (Lop_DTO)comboBoxLop.Items[comboBoxLop .SelectedIndex ];

             hs.MaLop = lop_dto.MaLop;
             int count_student = HocSinh_BUS.CountStudentSame(hs.MaLop);
             textSiSoLop.Text = Convert.ToString(count_student++);
        }

        private void butReresh_Click(object sender, EventArgs e)
        {
            //textMaHS.Text = "";
            textHoTen.Text = "";
            textDiaChi.Text = "";
            textEmail.Text = "";
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            HocSinh_DTO hs = new HocSinh_DTO();

            hs.MaHocSinh = textMaHS.Text;
            if (textMaHS.Text =="")
            {
            MessageBox.Show("Bạn chưa nhập mã HS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            hs.TenHocSinh = textHoTen.Text;
            if (textHoTen.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập ten HS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hs.DiaChi = textDiaChi.Text;
            if (textDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập DC HS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            hs.Email = textEmail.Text;
            hs.NgaySinh = dateTimeNgaySinh.Value;
            int year_sinh = hs.NgaySinh.Year;
            int year = DateTime.Now.Year;
            if (year - year_sinh > 20)
            {

                MessageBox.Show("Học Sinh quá tuổi qui định!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (year - year_sinh < 15)
            {
                MessageBox.Show("Học Sinh dưới tuổi qui định!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hs.GioiTinh = this.comGioiTinh.Text;
           // hs.MaLop = comboBoxLop.Text;
            Lop_DTO lop_dto = new Lop_DTO();
            //get local TenLop
            int indexLop = comboBoxLop.SelectedIndex;
            lop_dto = (Lop_DTO)comboBoxLop.Items[indexLop];
           
            hs.MaLop = lop_dto.MaLop;
            int count_student = HocSinh_BUS.CountStudentSame(hs.MaLop);
           // lop_dto.SiSo++;
            if (count_student >= 40)
            {
                MessageBox.Show("Amount Student in Class is enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = HocSinh_BUS.Insert_Student(hs);
            if (result == true)
            {
                
                bool result_Class = Lop_BUS.Update_Class(lop_dto);
                MessageBox.Show("Insert Studen have finish!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSiSoLop.Text = Convert .ToString ( count_student++);
                this.ShowMaster();
                
            }
            else 
            {
                MessageBox.Show("Fail!  ID Student has been exits \r\n Check Ma ,Please!", "Warning Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.frmStudent_Load(sender, e);
            
            comboBoxLop.Text = hs.MaLop;
            Lop_DTO _c = new Lop_DTO();
            _c = (Lop_DTO)comboBoxLop.Items[comboBoxLop.SelectedIndex];
            comKhoi.Text = _c.MaKhoi;
        }
        private string add_ID(string maHS)
        {
            int ghep = 0;
            int c5 = int.Parse(maHS[5].ToString());

            // ghep += c5;

            int c6 = int.Parse(maHS[6].ToString());
            int c4 =int.Parse ( maHS[4].ToString());
            if (c4 == 0)
            {
                ghep = c6 + c5 * 10 +  1;
                string a = "0" + Convert.ToString(ghep);
                return a ;
            }
            ghep = c6 + c5 * 10 + c4 * 100 + 1;
           
            return Convert.ToString (ghep);
        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            HocSinh_DTO hs = new HocSinh_DTO();
            if (textMaHS.Text == "")
            {
                MessageBox.Show("ID Student hasn't choose !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //hs.MaHocSinh = this.textMaHS.Text;
            bool check = HocSinh_BUS.CheckStudent_ByID(this.textMaHS.Text);
            if (check == false)
            {
                MessageBox.Show("ID Student has not been exits!", "Check Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                HocSinh_DTO hocsinh = new HocSinh_DTO();
                hocsinh = HocSinh_BUS.SelectStudentByID (textMaHS.Text );
                MessageBox.Show("ID has been exits!", "Check Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textHoTen.Text = hocsinh.TenHocSinh;
                textDiaChi.Text = hocsinh.DiaChi;
                textEmail.Text = hocsinh.Email;
                comGioiTinh.Text = hocsinh.GioiTinh;
                //load Class and Mass

                Lop_DTO _class = new Lop_DTO();
                _class = (Lop_DTO ) comboBoxLop.Items[comboBoxLop.SelectedIndex]; 
                comboBoxLop.Text = _class .TenLop ;
               
                //end Class
                //load amount Student's Class 
                Lop_DTO lop = new Lop_DTO();
                int index = comboBoxLop.SelectedIndex;
                lop = (Lop_DTO)comboBoxLop.Items[index];
                this.textSiSoLop.Text = Convert.ToString(lop.SiSo);
                //end
                dateTimeNgaySinh.Value = hocsinh.NgaySinh;
            }
        }

        private void dataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewStudent.CurrentRow != null)
            {
                this .textMaHS .Text = this.dataGridViewStudent  .CurrentRow.Cells ["MaHocSinh"].Value .ToString ();
                this.textHoTen.Text = this.dataGridViewStudent.CurrentRow.Cells["TenHocSinh"].Value.ToString();
                this.textDiaChi.Text = this.dataGridViewStudent.CurrentRow.Cells["DiaChi"].Value.ToString();
                this.textEmail.Text = this.dataGridViewStudent.CurrentRow.Cells["Email"].Value.ToString();
                this.comGioiTinh.Text = this.dataGridViewStudent.CurrentRow.Cells["GioiTinh"].Value.ToString();
                string maClass = this.dataGridViewStudent.CurrentRow.Cells["MaLop"].Value.ToString(); ;
                Lop_DTO lop_dto = new Lop_DTO();
                lop_dto = Lop_BUS.SelectClassByID(maClass);


                this.comboBoxLop.Text = lop_dto.TenLop;
                _classSiSo_First = lop_dto;
               // MessageBox.Show(_classSiSo_First.MaLop);
                this.dateTimeNgaySinh.Text = this.dataGridViewStudent.CurrentRow.Cells["NgaySinh"].Value.ToString();
                //load amount Student's Class 
                Lop_DTO lop = new Lop_DTO();
                string name_class = comboBoxLop.Text;
                lop = Lop_BUS.SelectClassByName(name_class);

                //check again load ID mass
                Khoi_DTO _mass = new Khoi_DTO();
                _mass = (Khoi_DTO)comKhoi.Items[comKhoi.SelectedIndex];
                if (lop.MaKhoi != _mass.MaKhoi)
                {
                    //again load Id Mass
                  //  _mass. = lop.MaKhoi;
                    Khoi_DTO _massChange = new Khoi_DTO();
                    _massChange = Khoi_BUS.SelectKhoiByID(lop.MaKhoi);
                    comKhoi.Text = _massChange.TenKhoi;
                    comKhoi_SelectedIndexChanged(sender, e);

                }

               
            }
            List<HocSinh_DTO> hs = new List<HocSinh_DTO>();
            hs = HocSinh_BUS.SelectStudentAll();

            textMaHS.Text = "MHS_" + add_ID(hs[hs.Count - 1].MaHocSinh );
            textHoTen.Text = "";
            textDiaChi.Text = "";
            textEmail.Text = "";
        }

        private void comKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
           // frmStudent_Load(sender, e);
            //process choose to load suitable class
            Khoi_DTO mass = new Khoi_DTO();
            int iMass = comKhoi.SelectedIndex;
            mass = (Khoi_DTO)comKhoi.Items[iMass];
            string maMass = mass.MaKhoi;

            this.comboBoxLop.ValueMember = "MaLop";
            this.comboBoxLop.DisplayMember = "TenLop";
            this.comboBoxLop.DataSource = Lop_BUS.SelectClassSuitble(maMass);
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load amount Student's Class 
            Lop_DTO lop = new Lop_DTO();
            int index = comboBoxLop.SelectedIndex;
            lop = (Lop_DTO)comboBoxLop.Items[index];
            //check again load ID mass
            Khoi_DTO _mass = new Khoi_DTO();
            _mass = (Khoi_DTO)comKhoi.Items[comKhoi.SelectedIndex];
            if (lop.MaKhoi != _mass.MaKhoi)
            {
                //again load Id Mass
                comKhoi.Text = lop.MaKhoi;
                

            }

            this.textSiSoLop.Text = Convert.ToString(lop.SiSo);
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            HocSinh_DTO st= new HocSinh_DTO();
            //string _maLop_to_siso = _classSiSo_First.MaLop;
            st.MaHocSinh = textMaHS.Text;
            if (textMaHS.Text != "")
            {
                
                if (textHoTen.Text == "")
                {
                    MessageBox.Show("you don't fill name student to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                st.TenHocSinh = textHoTen.Text;
             
                if (textDiaChi.Text == "")
                {
                    MessageBox.Show("you don't fill adress student to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                st.DiaChi = textDiaChi.Text;
                st.NgaySinh = dateTimeNgaySinh.Value;
                int year = st.NgaySinh.Year;
                if (DateTime.Now.Year - year > 20)
                {
                    MessageBox.Show("Student is very old to study!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DateTime.Now.Year - year < 15)
                {
                    MessageBox.Show("Student is under age stipulation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                st.Email = textEmail.Text;
                Lop_DTO  _class = new Lop_DTO ();
                _class =(Lop_DTO )comboBoxLop .Items [comboBoxLop .SelectedIndex ];
                st.MaLop = _class.MaLop;
                st.GioiTinh = comGioiTinh.Text;
                bool result = HocSinh_BUS.Update_Student(st);
                if (result == true)
                {
                    if (_classSiSo_First.MaLop  != st.MaLop)
                    {
                       // Lop_DTO _class_updateAmount = new Lop_DTO();
                        //_class_updateAmount = (Lop_DTO)comboBoxLop.Items[comboBoxLop.SelectedIndex];
                      //  _class.SiSo++;
                        bool updateAmount = Lop_BUS.Update_Class(_class);
                       // _classSiSo_First.SiSo--;
                        bool updateAmount_Class_First = Lop_BUS.Update_Class(_classSiSo_First);
                        comboBoxLop_SelectedIndexChanged(sender, e);
                        _classSiSo_First = _class;

                    }
                    MessageBox.Show("Successful update this Student!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ShowMaster();
                    frmStudent_Load(sender,e);

                }
                else
                {
                    MessageBox.Show("Fail!\r\nCheck ID Student beacause Student ID not exits to update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("You don't choose ID Student to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            HocSinh_DTO st = new HocSinh_DTO();
            st.MaHocSinh = textMaHS.Text;
            st = HocSinh_BUS.SelectStudentByID(st.MaHocSinh);
            Lop_DTO lop_SS = new Lop_DTO();
            lop_SS.MaLop = st.MaLop;
            lop_SS = Lop_BUS.SelectClassByID(lop_SS.MaLop);
            if (textMaHS.Text == "")
            {
                MessageBox.Show("You don't choose ID Student!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Diem_DTO mark = new Diem_DTO();
            bool result_Mark = Diem_BUS.CheckDiem_ByIDStudent(textMaHS.Text);
            if (result_Mark == true)
            {
                bool rs = Diem_BUS.Delete_DiemByIDStudent(st.MaHocSinh);
                if (rs == true)
                {
                    MessageBox.Show("Delete finish Diem");
                }
            }
            DialogResult rs1 = MessageBox.Show("Do you want to delete this ID'Student?" + st.MaHocSinh + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // DialogResult dr = MessageBox.Show("Do you want to delete EmployeeID " + employeeID + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs1 == DialogResult.Yes)
            {
                bool kq = HocSinh_BUS.Delete_StudentByID(st.MaHocSinh );
                if (kq == true)
                {
                    //Lop_DTO lop_SS = new Lop_DTO();
                   // lop_SS = Lop_BUS.SelectClassByID(st.MaLop);
                    MessageBox.Show("Delete  Successful Student!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lop_SS.SiSo--;
                    Lop_BUS.Update_Class(lop_SS );
                    this.ShowMaster();
                    frmStudent_Load(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Fail in delete!");
                    return;
                }
            }

        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewStudent.CurrentRow != null)
            {
                this.textMaHS.Text = this.dataGridViewStudent.CurrentRow.Cells["MaHocSinh"].Value.ToString();
                this.textHoTen.Text = this.dataGridViewStudent.CurrentRow.Cells["TenHocSinh"].Value.ToString();
                this.textDiaChi.Text = this.dataGridViewStudent.CurrentRow.Cells["DiaChi"].Value.ToString();
                this.textEmail.Text = this.dataGridViewStudent.CurrentRow.Cells["Email"].Value.ToString();
                this.comGioiTinh.Text = this.dataGridViewStudent.CurrentRow.Cells["GioiTinh"].Value.ToString();
                string maClass = this.dataGridViewStudent.CurrentRow.Cells["MaLop"].Value.ToString(); ;
                Lop_DTO lop_dto = new Lop_DTO();
                lop_dto = Lop_BUS.SelectClassByID(maClass);


                this.comboBoxLop.Text = lop_dto.TenLop;
                _classSiSo_First = lop_dto;
                // MessageBox.Show(_classSiSo_First.MaLop);
                this.dateTimeNgaySinh.Text = this.dataGridViewStudent.CurrentRow.Cells["NgaySinh"].Value.ToString();
                //load amount Student's Class 
                Lop_DTO lop = new Lop_DTO();
                string name_class = comboBoxLop.Text;
                lop = Lop_BUS.SelectClassByName(name_class);

                //check again load ID mass
                Khoi_DTO _mass = new Khoi_DTO();
                _mass = (Khoi_DTO)comKhoi.Items[comKhoi.SelectedIndex];
                if (lop.MaKhoi != _mass.MaKhoi)
                {
                    //again load Id Mass
                    //  _mass. = lop.MaKhoi;
                    Khoi_DTO _massChange = new Khoi_DTO();
                    _massChange = Khoi_BUS.SelectKhoiByID(lop.MaKhoi);
                    comKhoi.Text = _massChange.TenKhoi;
                    comKhoi_SelectedIndexChanged(sender, e);

                }


            }
        }

        
    }
}