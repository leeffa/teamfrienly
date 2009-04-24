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

        private void muonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmMuonSach"))
                {
                    form.Close();
                }
            }
            frmMuonSach frm = new frmMuonSach();
            frm.MdiParent = this;
            frm.TypeAction = "MuonSach";
            frm.Show();
        }

      private void traSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmMuonSach"))
                {
                    form.Close();
                }
            }
            frmMuonSach frm = new frmMuonSach();
            frm.MdiParent = this;
            frm.TypeAction = "TraSach";
            frm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuSach frm= new frmTraCuuSach();
            frm.Show();

        }


        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmSach"))
                    form.Close();
            }
            frmSach frm = new frmSach();
            frm.MdiParent = this;

            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmTraCuuThe"))
                    form.Close();
            }
            frmTraCuuThe frm = new frmTraCuuThe();
            frm.MdiParent = this;

            frm.Show();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("TheForm"))
                    form.Close();
            }
            TheForm frm = new TheForm();
            frm.MdiParent = this;

            frm.Show();
        }

     
    }
}