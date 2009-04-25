using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using DAO;
namespace Presentation
{
    public partial class frmTraCuuThe : Form
    {
        public frmTraCuuThe()
        {
            InitializeComponent();
        }
        List<SqlParameter> sqlParams =new List<SqlParameter>();
        public string BuildQuery()
        {
            string strDKMa = "1=1";
            string strDKLoaiThe = "1=1";
            string strDKNgayCap = "1=1";
            string strDKNgayHetHan = "1=1";
            string strDKNgaySinh = "1=1";
            string strDKTen = "1=1";
            if (textBox_Ma.Text != "")
            {
                strDKMa = "Ma=@MaThe";
                sqlParams.Add(new SqlParameter("@MaThe", textBox_Ma.Text));
            }
            if (textBox_Ten.Text != "")
            {
                strDKTen = "TenDocGia=@Ten";
                sqlParams.Add(new SqlParameter("@Ten", textBox_Ten.Text));
            }
            if (checkBox_loaithe.Checked == true)
            {
                int index = comboBox_loaithe.SelectedIndex;
                LoaiTheDTO lt = (LoaiTheDTO)comboBox_loaithe.Items[index];
                strDKLoaiThe ="LoaiThe=@LoaiThe";
                sqlParams.Add(new SqlParameter ("@LoaiThe",lt.Ma));
            }
            if (checkBox_ngaycap.Checked == true)
            {
                strDKNgayCap = "NgayCap between @ngaycaptu and @ngaycapden";
                sqlParams.Add(new SqlParameter("@ngaycaptu", dateTimePicker_captu.Value));
                sqlParams.Add(new SqlParameter("@ngaycapden", dateTimePicker_capden.Value));

            }
            if (checkBox_ngayhethan.Checked == true)
            {
                strDKNgayHetHan = "NgayHetHan between @nghhtu and @nghhden";
                sqlParams.Add(new SqlParameter("@nghhtu", dateTimePicker_hettu.Value));
                sqlParams.Add(new SqlParameter("@nghhden", dateTimePicker_hetden.Value));
            }
            if (checkBox_ngaysinh.Checked == true)
            {
                strDKNgaySinh = "NgaySinh between @sinhtu and @sinhden";
                sqlParams.Add(new SqlParameter("@sinhtu", dateTimePicker_sinhtu.Value));
                sqlParams.Add(new SqlParameter("@sinhden", dateTimePicker_sinhden.Value));
            }
            string strDkWhere = " where ";
            strDkWhere += strDKMa;
            strDkWhere += " and " + strDKLoaiThe;
            strDkWhere += " and " + strDKNgayCap;
            strDkWhere += " and " + strDKNgayHetHan;
            strDkWhere += " and " + strDKNgaySinh;
            strDkWhere += " and " + strDKTen;
            string strsql = "select * from The ";
            strsql += strDkWhere;

            return strsql;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlParams = new List<SqlParameter>();
            string chuoi = BuildQuery();
          
             DataTable dt    = SqlDataAccessHelper.ExecuteQueryText(chuoi, sqlParams);
            foreach (DataRow dr in dt.Rows)
            {
                string Maloai =(string)dr["LoaiThe"];
                LoaiTheDTO lt = LoaiTheBUS.SelectLoaiTheByID(Maloai);
                dr["LoaiThe"] = lt.TenLoai;
            }
            dataGridView1.DataSource = dt;
        }

        private void frmTraCuuThe_Load(object sender, EventArgs e)
        {
            comboBox_loaithe.DataSource = LoaiTheBUS.SelectLoaiTheAll();
            comboBox_loaithe.DisplayMember = "Ten";
            comboBox_loaithe.ValueMember = "Ma";
            //-----------ẩn các control
            comboBox_loaithe.Enabled = false;
            dateTimePicker_capden.Enabled = false;
            dateTimePicker_captu.Enabled = false;
            dateTimePicker_hetden.Enabled = false;
            dateTimePicker_hettu.Enabled = false;
            dateTimePicker_sinhden.Enabled = false;
            dateTimePicker_sinhtu.Enabled = false;
            
            //-------------end------------
        }

        private void textBox_Ma_Click(object sender, EventArgs e)
        {
            textBox_Ma.Text = "";
        }

        private void checkBox_loaithe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_loaithe.Checked == true)
                comboBox_loaithe.Enabled = true;
            else
                comboBox_loaithe.Enabled = false;
        }

        private void checkBox_ngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ngaysinh.Checked == true)
            {
                dateTimePicker_sinhtu.Enabled = true;
                dateTimePicker_sinhden.Enabled = true;
            }
            else
            {
                dateTimePicker_sinhtu.Enabled =false;
                dateTimePicker_sinhden.Enabled = false;
            }
           
        }

        private void checkBox_ngaycap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ngaycap.Checked == true)
            {
                dateTimePicker_captu.Enabled = true;
                dateTimePicker_capden.Enabled = true;
            }
            else
            {
                dateTimePicker_captu.Enabled = false;
                dateTimePicker_capden.Enabled = false;
            }
        }

        private void checkBox_ngayhethan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ngayhethan.Checked == true)
            {
                dateTimePicker_hetden.Enabled = true;
                dateTimePicker_hettu.Enabled = true;
            }
            else
            {
                dateTimePicker_hetden.Enabled = false;
                dateTimePicker_hettu.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

       

       
    }
}