using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmStudent"))
                    form.Close();
            }
            frmStudent frm= new frmStudent ();
            frm.MdiParent = this;

            frm.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmSubjects"))
                    form.Close();
            }
            FrmSubjects frm = new FrmSubjects();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thayĐổiQuiĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmStipulation"))
                    form.Close();
            }
            FrmStipulation frm = new FrmStipulation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmClass"))
                    form.Close();
            }
            FrmClass frm = new FrmClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void laToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmListClass"))
                    form.Close();
            }
            FrmListClass frm = new FrmListClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmStudentMark"))
                    form.Close();
            }
            FrmStudentMark frm = new FrmStudentMark();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;

            //this.Controls.Add(frm);
            
            
            frm.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmStudentList"))
                    form.Close();
            }
            FrmStudentList frm = new FrmStudentList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void traCứuHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmStudentSearch"))
                    form.Close();
            }
            FrmStudentSearch frm = new FrmStudentSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmReport"))
                    form.Close();
            }
            FrmData frm = new FrmData();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmReportSemester"))
                    form.Close();
            }
            FrmReportSemester frm = new FrmReportSemester();
            frm.MdiParent = this;
            frm.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmAuthor"))
                    form.Close();
            }
            FrmAuthor frm = new FrmAuthor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}