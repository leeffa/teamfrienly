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
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 //           frmSach frm = new frmSach();
            TacGiaDto nxb = new TacGiaDto();
            nxb.Ma = textBox_Ma.Text;
            nxb.Ten = textBox_Ten.Text;
            nxb.NgaySinh = dateTimePicker1.Value;
            if (textBox_Ma.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã tác giả","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error );

//                frm.Show();
//                this.Close();
                return;
            }
            if (textBox_Ten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error );

//                frm.Show();
//               this.Close();
                return;
            }
            if (TacGiaBus.Insert_TacGia(nxb) == false)
            {
                MessageBox.Show("Tac gia đã có trong csdl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

 //               frm.Show();
 //               this.Close();
                return;
            }

            MessageBox.Show("Add Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

  //          frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}