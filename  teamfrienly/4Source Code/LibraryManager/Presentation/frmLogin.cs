using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

using BUS;
namespace Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String connectString = "";
            connectString += "Data Source=";
            connectString += txtServerName.Text;
            if (Bus.ConnectedToServer(connectString+";Integrated Security=True;User Instance=True"))
            {
                if (!Bus.ConnectedToServer(connectString + ";Initial Catalog=QLTV_teamfriendly;Integrated Security=True;"))
                {
                    MessageBox.Show("Không tồn tại cơ sở dữ liệu.\n Chương trình xe tạo mới cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("sqlcmd.exe", "-E -S " + txtServerName.Text + " -i database\\CreateDB.sql").WaitForExit();
                    Process.Start("sqlcmd.exe", "-E -S " + txtServerName.Text + " -i database\\CreateTable.sql").WaitForExit();
                    Process.Start("sqlcmd.exe", "-E -S " + txtServerName.Text + " -i database\\CreateSP.sql").WaitForExit();
                    Process.Start("sqlcmd.exe", "-E -S " + txtServerName.Text + " -i database\\insertDB.sql").WaitForExit();
                }

            }  
            else
            {
                MessageBox.Show("Kết nối thất bại.\n Hãy nhập lại tên server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((MainForm)Owner).IsConnected = false;
                return;
            }

            connectString += ";Initial Catalog=QLTV_teamfriendly;Integrated Security=True;";
            if (Bus.ConnectedToServer(connectString))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                root.InnerText = connectString;
                doc.Save("ConnectionString.xml");
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((MainForm)Owner).IsConnected = true;
                Close();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((MainForm)Owner).IsConnected = false;
            }

        }
    }
}