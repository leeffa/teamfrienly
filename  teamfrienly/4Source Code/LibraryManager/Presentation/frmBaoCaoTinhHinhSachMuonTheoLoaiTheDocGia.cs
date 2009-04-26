using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmBaoCaoTinhHinhSachMuonTheoLoaiTheDocGia : Form
    {
        public frmBaoCaoTinhHinhSachMuonTheoLoaiTheDocGia()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rptTinhHinhMuonSachTheoLoaiTheDocGia rpt = new rptTinhHinhMuonSachTheoLoaiTheDocGia();
            //CrystalReport1 rpt = new CrystalReport1();
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = null;
            //xu ly chuoi ConectionString de lay ra servername va databasename
            string connectiostring = DAO.SqlDataAccessHelper.ConnectionString;
            //bat dau lay tu vi tri 12;
            int i = 12;
            int serlen = 1;
            string serstring = "";
            while (connectiostring[i] != ';')//gap dau ; thi ngung ko lay nua
            {
                serstring = connectiostring.Substring(12, serlen);
                i++;
                serlen++;
            }
            //lay ten database
            //bat dau tu vi tri i+17
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
            //c
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rpt.Database.Tables)
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
            cptvBaoCaoTinhHinhMuonSachTheoLoaiTheDocGia.ReportSource = rpt;
        }
    }
}