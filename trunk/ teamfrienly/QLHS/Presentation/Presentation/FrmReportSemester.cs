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
    public partial class FrmReportSemester : Form
    {
        public FrmReportSemester()
        {
            InitializeComponent();
        }

        

        private void FrmReportSemester_Load(object sender, EventArgs e)
        {
            this.comSemester.ValueMember = "MaHocKy";
            this.comSemester.DisplayMember = "TenHocKy";
            this.comSemester.DataSource = HocKy_BUS.SelectHocKyAll();
        }

        private void comSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportSemester _reportSemester = new ReportSemester();
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = null;
            string connectiostring = DAO.SqlDataAccessHelper.ConnectionString;
            int i = 12;
            int serlen = 1;
            string serstring = "";
            while (connectiostring[i] != ';')//gap dau ; thi ngung ko lay nua
            {
                serstring = connectiostring.Substring(12, serlen);
                i++;
                serlen++;
            }
            int j = i + 17;
            int k = j;
            int dbnamelen = 1;
            string dbnamestring = "";
            while (connectiostring[k] != ';')
            {
                dbnamestring = connectiostring.Substring(j, dbnamelen);
                k++;
                dbnamelen++;
            }
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in _reportSemester.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = serstring;
                //tliCurrent.ConnectionInfo.ServerName=
                //tliCurrent.ConnectionInfo.UserID = "sa";
                //tliCurrent.ConnectionInfo.Password = "311967556";
                tliCurrent.ConnectionInfo.IntegratedSecurity = true;
                tliCurrent.ConnectionInfo.DatabaseName = dbnamestring;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            HocKy_DTO _semester = new HocKy_DTO();
            _semester = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
            _reportSemester.SetParameterValue("MaHocKyPara", _semester.MaHocKy );
            crystalReportSemeter.ReportSource = _reportSemester;
        }
    }
}