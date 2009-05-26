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
    public partial class FrmClass : Form
    {
        public FrmClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {

            txtSoLopHienTai.Enabled = false;
            this.comKhoi.ValueMember = "MaKhoi";
            this.comKhoi.DisplayMember = "TenKhoi";
            this.comKhoi.DataSource = Khoi_BUS.SelectKhoiAll();
            this.txtSoLopHienTai.Text = Convert.ToString(Lop_BUS .CountClassAll ());
        }

        private void comKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comClass.Enabled = true;
            Lop_DTO _class = new Lop_DTO ();
            Khoi_DTO _mass = new Khoi_DTO();
            _mass = (Khoi_DTO )comKhoi .Items [comKhoi .SelectedIndex ];

            this.comClass.ValueMember = "MaLop";
            this.comClass.DisplayMember = "TenLop";
            this.comClass.DataSource = Lop_BUS.SelectClassSuitble(_mass.MaKhoi);
            
        }

       

        private void comClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Lop_DTO _class = new Lop_DTO();
            _class = (Lop_DTO)comClass.Items[comClass.SelectedIndex];

            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;

            txtMaLop.Text = _class.MaLop;
            txtTenLop.Text = _class.TenLop;
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Lop_DTO _class = new Lop_DTO();
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("You don't fill ID's Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("You don't fill name Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Khoi_DTO _mass = new Khoi_DTO ();
            _mass =(Khoi_DTO ) comKhoi .Items [comKhoi .SelectedIndex ];
            _class.MaLop = txtMaLop.Text;
            _class.TenLop = txtTenLop.Text;
            _class.SiSo = 0;
            _class .MaKhoi = _mass .MaKhoi ;
            bool rs_checkName = Lop_BUS.CheckClassp_ByName(_class.TenLop);
            if (rs_checkName == true)
            {
                MessageBox.Show("Class name have exited, You must change name Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool check_SoluongLop = Check_AmountClass_Now();
            if (check_SoluongLop == false)
            {
                MessageBox.Show("You can't insert class that over stipulation of my school! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool rs_Insert = Lop_BUS.Insert_Class(_class );
            if (rs_Insert == true)
            {
                txtSoLopHienTai.Text =Convert .ToString ( Lop_BUS.CountClassAll() + 1);
                MessageBox.Show("Insert Class :!" + _class.TenLop + " finished!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Insert fail beacase have same ID Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            Lop_DTO _class = new Lop_DTO();
            if (txtMaLop .Text =="")
            {
                MessageBox.Show("You don't fill ID's Class that update fail!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("You don't fill name Class that update fail!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Khoi_DTO _mass = new Khoi_DTO();
            _mass = (Khoi_DTO)comKhoi.Items[comKhoi.SelectedIndex];
            _class = Lop_BUS.SelectClassByID(txtMaLop.Text  );
            
            bool check = Lop_BUS.CheckClassp_ByID(txtMaLop.Text);
            if (check == false)
            {
                MessageBox.Show("Update fail beacase haven't same ID Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _class.MaLop = txtMaLop.Text;
            _class.TenLop = txtTenLop.Text;
            bool rs_UpdateClass = Lop_BUS.Update_Class(_class);
            if (rs_UpdateClass == true)
            {
                MessageBox.Show("Update Class :!" + _class.TenLop + " finished", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Update fail beacase haven't same ID Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private bool Check_AmountClass_Now()
        {
           // Lop_DTO _class = new Lop_DTO();
            ThamSo_DTO paremeter = new ThamSo_DTO();
            paremeter = ThamSo_BUS.SelectThamSoByID("1");
            int amountClass = paremeter.SoLopToiDa;
            int solop_phienco = Lop_BUS.CountClassAll();
            if (solop_phienco >= 9)
            {
                // MessageBox.Show("You can't insert class that over stipulation of my school! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
                return true;
        }

        private void butCheckAdd_Click(object sender, EventArgs e)
        {
            Lop_DTO _class = new Lop_DTO();
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("You don't fill ID's Class that update fail!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool check_SoluongLop = Check_AmountClass_Now();
            if (check_SoluongLop == false)
            {
                MessageBox.Show("You can't insert class that over stipulation of my school! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            _class.MaLop = txtMaLop.Text;
            bool rs_check = Lop_BUS.CheckClassp_ByID(_class.MaLop);

            if (rs_check == true)
            {
                MessageBox.Show("ID's Class exits. You must change ID" + "\r\n" + "Note don't same name class that have exited", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                MessageBox.Show("This Id's Class is OK. You can insert! ","Ok",MessageBoxButtons .OK ,MessageBoxIcon.Information);
                return;
            }

        }
    }
}