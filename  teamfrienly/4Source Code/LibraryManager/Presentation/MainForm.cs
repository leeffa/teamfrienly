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
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("frmTraCuuSach"))
                    form.Close();
            }
            frmTraCuuSach frm = new frmTraCuuSach();
            frm.MdiParent = this;

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

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("TacGia"))
                    form.Close();
            }
            TacGia frm = new TacGia();
            frm.MdiParent = this;

            frm.Show();
        }

        private void theoLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTinhHinhMuonSachTheoLoaiSach frm = new frmBaoCaoTinhHinhMuonSachTheoLoaiSach();
            frm.Show();
        }

        private void theoLoạiThẻĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTinhHinhSachMuonTheoLoaiTheDocGia frm = new frmBaoCaoTinhHinhSachMuonTheoLoaiTheDocGia();
            frm.Show();
        }

        private void hỏngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTinhHinhSachHong frm = new frmBaoCaoTinhHinhSachHong();
            frm.Show();
        }

        private void mấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTinhHinhSachMat frm = new frmBaoCaoTinhHinhSachMat();
            frm.Show();
        }




     
    }
}