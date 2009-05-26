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
    public partial class FrmListClass : Form
    {
        public FrmListClass()
        {
            InitializeComponent();
        }

        private void FrmListClass_Load(object sender, EventArgs e)
        {
            
            dataGridListClass .ReadOnly = true;
            dataGridListClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridListClass.AutoGenerateColumns = false;
            dataGridListClass.AutoSize = false;
            dataGridListClass.AllowUserToResizeRows = false;
            dataGridListClass.AllowUserToDeleteRows = false;
            // dataGridListClass.AutoSizeColumnsMode.= false;
            //dataGridListClass.AutoSizeRowsMode  = false;
            txtAmount.Enabled = false;
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
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comMass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //process choose to load suitable class
            Khoi_DTO mass = new Khoi_DTO();
            int iMass = comMass.SelectedIndex;
            mass = (Khoi_DTO)comMass.Items[iMass];
            string maMass = mass.MaKhoi;

            this.comClass.ValueMember = "MaLop";
            this.comClass.DisplayMember = "TenLop";
            this.comClass.DataSource = Lop_BUS.SelectClassSuitble(maMass);
        }
        int count = 0;
        private void butGetList_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmStudent"))
                    form.Close();
            }
            frmStudent frm = new frmStudent();
           // frm.MdiParent = this;

            frm.Show();
        }
        private string _changeBirthday(DateTime daytime)
        {
            string str = Convert.ToString(daytime.Day) + "/" + Convert.ToString(daytime.Month) + "/" + Convert.ToString(daytime.Year);
            return str;
        }
        private void comClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lop_DTO _class = (Lop_DTO)comClass.Items[comClass.SelectedIndex];
            count = HocSinh_BUS.CountStudentSame(_class.MaLop);
            txtAmount.Text = Convert.ToString(count);
            List<HocSinh_DTO> list = HocSinh_BUS.SelectStudentChoose(_class.MaLop);
            DataGridViewRow row = new DataGridViewRow();
            List<Student_DTO> listsd = new List<Student_DTO>();
            for (int i = 0; i < count; i++)
            {
                Student_DTO st = new Student_DTO();
                st.TenHocSinh = list[i].TenHocSinh;
                st.GioiTinh = list[i].GioiTinh;
                st.DiaChi = list[i].DiaChi;
                string a = _changeBirthday(list[i].NgaySinh);
                st.NgaySinh = a;
                st.STT = i + 1;
                listsd.Add(st);
            }
            dataGridListClass.DataSource = listsd;

           // dataGridListClass_BackgroundColorChanged(sender, e);

        }

        private void dataGridListClass_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridListClass.Rows.Count; i++)
            {
                if (i % 2 == 1)
                {
                    dataGridListClass.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    
                }
                else
                {
                    dataGridListClass.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue  ;

                }
            }
        }

      
    }
}