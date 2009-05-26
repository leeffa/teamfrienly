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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
       

        private void FrmReport_Load(object sender, EventArgs e)
        {
            //reportToPrint.SetDataSource(DataTableForReport );
            ReportSubject _report = new ReportSubject ();
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
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in _report.Database.Tables)
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
            //FrmData frm_Data = new FrmData();
           
            string _subj = ((FrmData)Owner )._IdSubject ;
            string _semester = ((FrmData)Owner)._IdSemester ;
            _report.SetParameterValue("MaHocKyPara", _semester);
            _report .SetParameterValue ("MaMonPara",_subj );
            crystalReportSubject.ReportSource = _report;
            
        }



      
    }
}