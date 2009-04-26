using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Presentation
{
    public partial class frmThemNhaXB : Form
    {
        public frmThemNhaXB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            NhaXBDto nxb = new NhaXBDto();
            nxb.Ma = textBox_Ma.Text;
            nxb.Ten = textBox_Ten.Text;
            if (textBox_Ma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà xuất bản","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error  );
               
                frm.Show();
                this.Close();
                return;
            }
            if (textBox_Ten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error );

                frm.Show();
                this.Close();
                return;
            }
            if (NhaXBBus.Insert_NhaXB(nxb) == false)
            {
                MessageBox.Show("Nhà XB đã có trong csdl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                frm.Show();
                this.Close();
                return;
            }

            MessageBox.Show("Successful Add", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information );
           
           frm.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}