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
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }
        public string _IdSubject;
        public string _IdSemester;
        private void FrmReport_Load(object sender, EventArgs e)
        {

            this.comSemester.ValueMember = "MaHocKy";
            this.comSemester.DisplayMember = "TenHocKy";
            this.comSemester.DataSource = HocKy_BUS.SelectHocKyAll();
            this.comSubject.ValueMember = "MaMon";
            this.comSubject.DisplayMember = "TenMon";
            this.comSubject.DataSource = Mon_BUS.SelectMonAll();

        }
        private List<ReportSubject_DTO> _Report()
        {
            Mon_DTO subject = new Mon_DTO();
            int a = comSubject.SelectedIndex;
            subject = (Mon_DTO)comSubject.Items[comSubject.SelectedIndex];
            HocKy_DTO semester = new HocKy_DTO();
            semester = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];

            List<HocSinh_DTO> list_Student = HocSinh_BUS.SelectStudentAll();

            //DataTable datatable = new DataTable();
            // datatable =(DataTable ) list_Student;
            List<Diem_DTO> list_mark = Diem_BUS.SelectDiemAll();
            Lop_DTO _class = new Lop_DTO();
            List<Lop_DTO> list_class = Lop_BUS.SelectClassAll();
            List<ReportSubject_DTO> list_report = new List<ReportSubject_DTO>();
            for (int i = 0; i < list_class.Count; i++)
            {
                ReportSubject_DTO _report = new ReportSubject_DTO();
                _report.STT = i + 1;
                _report.TenLop = list_class[i].TenLop;
                _report.SiSo = list_class[i].SiSo;
                int count = 0;
                for (int j = 0; j < list_Student.Count; j++)
                {
                    if (list_Student[j].MaLop == list_class[i].MaLop)
                    {

                        for (int t = 0; t < list_mark.Count; t++)
                            if ((subject.MaMon == list_mark[t].MaMon) && (list_mark[t].MaHocSinh == list_Student[j].MaHocSinh) && (list_mark[t].DTBHK >= 5) && semester.MaHocKy == list_mark[t].MaHocKy)
                                count++;
                    }

                }
                if (_report.SiSo == 0)
                {
                 
                    break;
                }
                else
                {
                    if (count == 0)
                    {
                        break;
                    }
                    else
                    {

                        float tl = ((float)count / (float)_report.SiSo) * 100;
                        //  tl =(%0.2f)tl;
                        _report.SLDat = count;
                        _report.TyLe = Convert.ToString(tl) + "%";
                        list_report.Add(_report);
                    }
                }


            }
            return list_report;
        }
        private void comSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Mon_DTO subject = new Mon_DTO();
          //  int a = comSubject.SelectedIndex;
            subject =(Mon_DTO ) comSubject.Items [comSubject.SelectedIndex];
            HocKy_DTO semester = new HocKy_DTO();

            semester = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
           

             List <HocSinh_DTO> list_Student = HocSinh_BUS.SelectStudentAll();

             List<Diem_DTO> list_mark = Diem_BUS.SelectDiemAll();
            Lop_DTO _class = new Lop_DTO();
            List <Lop_DTO> list_class = Lop_BUS.SelectClassAll();
            List<ReportSubject_DTO> list_report = new List<ReportSubject_DTO> ();
            for(int i=0 ;i<list_class.Count;i++)
            {
                ReportSubject_DTO _report = new ReportSubject_DTO();
                _report.STT = i + 1;
                _report.TenLop = list_class[i].TenLop;
                _report.SiSo = list_class[i].SiSo;
                int count = 0;
                for (int j = 0; j < list_Student.Count;j++ )
                {
                    if (list_Student[j].MaLop == list_class[i].MaLop)
                    {
                        
                        for (int t = 0; t < list_mark.Count; t++)
                             if ((subject.MaMon == list_mark[t].MaMon) && (list_mark[t].MaHocSinh == list_Student[j].MaHocSinh )&&( list_mark[t].DTBHK >= 5)&& semester .MaHocKy ==list_mark[t].MaHocKy )
                                count++;
                    }
                    
                }
                if (_report.SiSo == 0)
                {
                    break;
                   // _report.SLDat = 0;
                   // _report.TyLe ="0" + "%";
                    //list_report.Add(_report);
                }
                else
                {
                   
                    float tl = ((float)count / (float)_report.SiSo) * 100;
                    if (count == 0)
                    {
                        break;
                    }
                    else
                    {
                        //  tl =(%0.2f)tl;
                        _report.SLDat = count;
                        _report.TyLe = Convert.ToString(tl) + "%";
                        list_report.Add(_report);
                    }
                   
                }
                

            }
            dataGridReportSubject.DataSource = list_report;
        }

        private void comSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
          // dataGridReportSubject.DataSource = _Report();
        }
        
       
       
        private void butPrint_Click(object sender, EventArgs e)
        {
            Mon_DTO _m = new Mon_DTO();
            _m =(Mon_DTO )comSubject .Items [comSubject.SelectedIndex ];
            _IdSubject = _m.MaMon;
            HocKy_DTO _h = new HocKy_DTO();
            _h = (HocKy_DTO)comSemester.Items[comSemester.SelectedIndex];
            _IdSemester = _h.MaHocKy;
          foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals("FrmReport"))
                    form.Close();
            }
            FrmReport frm = new FrmReport();
            frm.Owner = this;

            frm.Show();
        }

        
    }
}