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
    public partial class FrmStipulation : Form
    {
        public FrmStipulation()
        {
            InitializeComponent();
        }
        private void ShowMaster()
        {
            this.dataGridStipulate.AutoGenerateColumns = false;
            this.dataGridStipulate.DataSource = ThamSo_BUS.SelectThamSoByID("1");
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStipulation_Load(object sender, EventArgs e)
        {
            this.comClassName.ValueMember = "MaLop";
            this.comClassName.DisplayMember = "TenLop";
            this.comClassName.DataSource = Lop_BUS.SelectClassAll ();

            this.comSubjectName.ValueMember = "MaMon";
            this.comSubjectName.DisplayMember = "TenMon";
            this.comSubjectName.DataSource = Mon_BUS.SelectMonAll ();

            this.ShowMaster();
        }

        private void dataGridStipulate_SelectionChanged(object sender, EventArgs e)
        {
            this.txtAgeMin.Text =        this.dataGridStipulate.CurrentRow.Cells["TuoiToiThieu"].Value.ToString();
            this.txtAgeMax.Text =        this.dataGridStipulate.CurrentRow.Cells["TuoiToiDa"].Value.ToString();
            this.txtAmountMax.Text =     this.dataGridStipulate.CurrentRow.Cells["SiSoToiDa"].Value.ToString();
            this.txtAmountSubject.Text = this.dataGridStipulate.CurrentRow.Cells["SoLuongMon"].Value.ToString();
           
            
           
            this.txtBaseMark.Text = this.dataGridStipulate.CurrentRow.Cells["DiemTB"].Value.ToString();
            this.txtAmountClass.Text = this.dataGridStipulate.CurrentRow.Cells["SoLopToiDa"].Value.ToString();

        }

        private void buttonUpdateStipulation_Click(object sender, EventArgs e)
        {
            if (txtAgeMin.Text == "")
            {
                MessageBox.Show("You don't fill age min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAgeMax.Text == "")
            {
                MessageBox.Show("You don't fill age max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAmountClass.Text == "")
            {
                MessageBox.Show("You don't fill amount stipulate class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAmountClass.Text == "")
            {
                MessageBox.Show("You don't fill amount subjects ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBaseMark.Text == "")
            {
                MessageBox.Show("You don't fill base mark ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAmountMax.Text == "")
            {
                MessageBox.Show("You don't fill amount student in class ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ThamSo_DTO thamso = new ThamSo_DTO();
            thamso.MaThamSo = "1";
            thamso.TuoiToiThieu =int.Parse ( txtAgeMin.Text);
            thamso.TuoiToiDa =int.Parse (  txtAgeMax.Text);
            thamso.SiSoToiDa = int.Parse ( txtAmountMax.Text);
            thamso.SoLuongMon = int.Parse ( txtAmountSubject.Text);
            thamso.DiemTB = int.Parse ( txtBaseMark.Text);
            thamso.SoLopToiDa = int.Parse(txtAmountClass.Text);
            bool result = ThamSo_BUS.Update_ThamSo (thamso);
            if (result == true)
            {
                MessageBox.Show("You have update finished!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowMaster();
                return;
            }
            else
            {
                MessageBox.Show("Update fail ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void butReresh_Click(object sender, EventArgs e)
        {
            txtAgeMin.Text = "";
            txtAgeMax.Text = "";
            txtAmountMax.Text = "";
            txtAmountSubject.Text = "";
            txtBaseMark.Text = "";
            txtAmountClass.Text = "";
        }

        private void butRepairSubject_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmSubjects"))
                    form.Close();
            }
            FrmSubjects frm = new FrmSubjects();
           // frm.MdiParent = this;
           // frm.;
            frm.Show();
        }

        private void butRepairClass_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmClass"))
                    form.Close();
            }
            FrmClass frm = new FrmClass();
            frm.Show();
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}