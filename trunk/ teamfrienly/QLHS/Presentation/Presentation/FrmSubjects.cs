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
    public partial class FrmSubjects : Form
    {
        public FrmSubjects()
        {
            InitializeComponent();
        }
        public void ShowMaster()
        {
            this.dataGridSubject.AutoGenerateColumns = false;
            this.dataGridSubject.DataSource = Mon_BUS.SelectMonAll();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaMon.Text  = "";
            txtTenMon.Text = "";
        }

        private void FrmSubjects_Load(object sender, EventArgs e)
        {
            txtQuiDinh.Enabled = false;
            this.dataGridSubject.AllowUserToAddRows = false;
            this.dataGridSubject.AllowUserToDeleteRows = false;
            this.dataGridSubject.AllowUserToResizeColumns = false;
            this.dataGridSubject.AutoGenerateColumns = false;
            this.dataGridSubject.AutoSize  = false;
            //this.dataGridSubject.
            this.txtQuiDinh.Text = "9";
            this.ShowMaster();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Mon_DTO subject = new Mon_DTO();
            subject.MaMon = txtMaMon.Text;
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("You don't fill ID'Subject!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            subject.TenMon = txtTenMon.Text;
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("You don't fill subject name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Mon_BUS.CountMonAll() >= 9)
            {
                MessageBox.Show("Subjects have been over stipulation !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool rs = Mon_BUS.Insert_Mon(subject);
            if(rs == true)
            {
                MessageBox.Show("Insert subject :"+subject .TenMon +" "+"finished!","Information",MessageBoxButtons .OK ,MessageBoxIcon.Information  );
                this.ShowMaster();
                return;
            }
            else
            {
                MessageBox.Show("Subjects haven't finished beacause Id have existed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }


        }

        private void dataGridSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridSubject.CurrentRow != null)
            {
                this.txtMaMon.Text = this.dataGridSubject.CurrentRow.Cells["MaMon"].Value.ToString ();
                this.txtTenMon.Text = this.dataGridSubject.CurrentRow.Cells["TenMon"].Value .ToString();

            }
        }

        private void butCheckIDSubject_Click(object sender, EventArgs e)
        {
            Mon_DTO subject = new Mon_DTO();
            subject.MaMon = txtMaMon.Text;
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("ID'Subjects dont't fill !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool rs = Mon_BUS.CheckMon_ByID(subject.MaMon);
            if (rs == true)
            {

                MessageBox.Show("ID'Subjects exited !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                subject = Mon_BUS.SelectMonByID(subject.MaMon);
                this.txtTenMon.Text = subject.TenMon;
                return;
            }
            else
            {

                MessageBox.Show("ID'Subjects not exits !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Mon_DTO subject = new Mon_DTO();
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("ID'Subjects not fill !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("ID'Subjects not fill !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            subject.MaMon = txtMaMon.Text;
            subject.TenMon = txtTenMon.Text;
           // subject = Mon_BUS.SelectMonByID(subject.MaMon);
            bool rs = Mon_BUS.Update_Mon(subject);
            if (rs == true)
            {
                MessageBox.Show("Update finished !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowMaster();
                return;
            }
            else
            {
                MessageBox.Show("Error beacause Id'Subject dont't exits on database !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonDeleteSubjects_Click(object sender, EventArgs e)
        {
            Mon_DTO subject = new Mon_DTO();
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Error beacause not choose ID's Subject !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            subject.MaMon = txtMaMon.Text;
            Diem_DTO mark = new Diem_DTO();
            DialogResult rsDialog = MessageBox.Show("Do you delete Id of !" + subject.MaMon +" ?", "Question?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rsDialog == DialogResult .OK )
            {
                bool rs = Diem_BUS.CheckDiem_ByIDSubject(subject.MaMon);
                if (rs == true)
                {
                    bool rs_mark = Diem_BUS.Delete_DiemByIDSubject(subject.MaMon);
                    {
                        MessageBox.Show(" Delete subject in table Mark finish  !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ShowMaster();
                    }
                }

                bool delete_subject = Mon_BUS.Delete_MonByID(subject.MaMon);
                if (delete_subject == true)
                {
                    MessageBox.Show("Delete Id !" + subject.MaMon + " finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowMaster();
                    return;
                }
                else
                {
                    MessageBox.Show("Error in delete Id !" + subject.MaMon, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("You have cancel delete" , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
            
    }
}
