using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;
namespace Presentation
{
    public partial class frmTraCuuSach : Form
    {
        public frmTraCuuSach()
        {
            InitializeComponent();
        }
        List<SqlParameter> sqlParams = new List<SqlParameter>();
        public string BuildQuery()
        {
           
           // sqlParams.Add(new SqlParameter("@MaMuonSach", temp.MaMuonSach));
            string strDKMa = "1=1";
            string strDKTen = "1=1";
            string strDKLoaiSach = "1=1";
            string strDKTacGia = "1=1";
            string strDKGia = "1=1";
            string StrDKNgonNgu = "1=1";
            string strDKNhaXB = "1=1";
            if (textBox_Ma.Text != "")
            {
                strDKMa = "Ma=@Ma";
                sqlParams.Add(new SqlParameter("@Ma", textBox_Ma.Text));
            }
            if (textBox_Ten.Text != "")
            {
                strDKTen = "Ten=@Ten";
                sqlParams.Add(new SqlParameter("@Ten", textBox_Ten.Text));
            }
            if (checkBox_loaisach.Checked == true)
            {
                int index = comboBox_Loaisach.SelectedIndex;
                if (index != -1)
                {
                    strDKLoaiSach = "LoaiSach=@LoaiSach";
                    LoaiSachDTO ls=(LoaiSachDTO)comboBox_Loaisach.Items[index];
                    sqlParams.Add(new SqlParameter("@LoaiSach", ls.Ma));
                }
            }
            if (checkBox_ngonngu.Checked == true)
            {
                int index = comboBox_ngonngu.SelectedIndex;
                if (index != -1)
                {
                    StrDKNgonNgu = "NgonNgu=@MaNgonNgu";
                    NgonNguDto nn = (NgonNguDto)comboBox_ngonngu.Items[index];
                    sqlParams.Add(new SqlParameter("@MaNgonNgu",nn.Ma));
                }
            }
            if (checkBox_tacgia.Checked == true)
            {
                int index = comboBox_tacgia.SelectedIndex;
                if (index != -1)
                {
                    strDKTacGia = "TacGia=@MaTacGia";
                    TacGiaDto tg = (TacGiaDto)comboBox_tacgia.Items[index];
                    sqlParams.Add(new SqlParameter("@MaTacGia",tg.Ma));
                }
            }
            if (checkBox_nhaxb.Checked == true)
            {
                int index = comboBox_nhaxb.SelectedIndex;
                if (index != -1)
                {
                    strDKNhaXB = "NhaXB=@MaNXB";
                    NhaXBDto nxb = (NhaXBDto)comboBox_nhaxb.Items[index];
                    sqlParams.Add(new SqlParameter("@MaNXB", nxb.Ma));

                }
            }
            if (checkBox_giatu.Checked == true)
            {
                strDKGia="Gia between @gia1 and @gia2";
                sqlParams.Add(new SqlParameter("@gia1",Convert.ToInt32( textBox_giatu.Text)));
                 sqlParams.Add(new SqlParameter("@gia2",Convert.ToInt32( textBox_giaden.Text)));
            }
            string strDKWhere = " Where ";
            strDKWhere += strDKMa;
            strDKWhere += " and " + strDKTen;
            strDKWhere += " and " + strDKLoaiSach;
            strDKWhere += " and " + strDKTacGia;
            strDKWhere += " and " + StrDKNgonNgu;
            strDKWhere += " and " + strDKNhaXB;
            strDKWhere += " and " + strDKGia;
            string strsql = "select *from Sach ";
            strsql += strDKWhere;
            return strsql;


           
        }

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            comboBox_Loaisach.DataSource = LoaiSachBUS.SelectLoaiSachAll();
            comboBox_Loaisach.DisplayMember = "Ten";
            comboBox_Loaisach.ValueMember = "Ma";
            //-----------------
            comboBox_ngonngu.DataSource = NgonNguBus.SelectNgonNguAll();
            comboBox_ngonngu.DisplayMember = "Ten";
            comboBox_ngonngu.ValueMember = "Ma";
            //---------------
            comboBox_nhaxb.DataSource = NhaXBBus.SelectNhaXBAll();
            comboBox_nhaxb.DisplayMember = "Ten";
            comboBox_nhaxb.ValueMember = "Ma";
            //------------------
            comboBox_tacgia.DataSource = TacGiaBus.SelectTacGiaAll();
            comboBox_tacgia.DisplayMember = "Ten";
            comboBox_tacgia.ValueMember = "Ma";
            //disable cac control
            comboBox_Loaisach.Enabled = false;
            comboBox_ngonngu.Enabled = false;
            comboBox_nhaxb.Enabled = false;
            comboBox_tacgia.Enabled = false;
            textBox_giaden.Enabled = false;
            textBox_giaden.Text = "0";
            textBox_giatu.Text = "0";
            textBox_giatu.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlParams = new List<SqlParameter>();
           string Strsql= BuildQuery();
           DataTable dt = SqlDataAccessHelper.ExecuteQueryText(Strsql,sqlParams);
           dataGridView1.DataSource = dt;
        }

        private void checkBox_loaisach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_loaisach.Checked == true)
                comboBox_Loaisach.Enabled = true;
            else
                comboBox_Loaisach.Enabled = false;
        }

        private void checkBox_ngonngu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ngonngu.Checked == true)
                comboBox_ngonngu.Enabled = true;
            else
                comboBox_ngonngu.Enabled = false;
        }

        private void checkBox_tacgia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tacgia.Checked == true)
                comboBox_tacgia.Enabled = true;
            else
                comboBox_tacgia.Enabled = false;
        }

        private void checkBox_nhaxb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nhaxb.Checked == true)
                comboBox_nhaxb.Enabled = true;
            else
                comboBox_nhaxb.Enabled = false;
        }

        private void checkBox_giatu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_giatu.Checked == true)
            {
                textBox_giatu.Enabled = true;
                textBox_giaden.Enabled = true;
            }
            else
            {
                textBox_giatu.Enabled = false;
                textBox_giaden.Enabled = false;
            }
        }

        private void textBox_giatu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox_giaden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_giatu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}