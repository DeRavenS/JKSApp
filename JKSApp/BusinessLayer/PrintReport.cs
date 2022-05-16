using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKSApp.BusinessLayer
{
    class PrintReport
    {
        string date,affiliation;
        string dojo;
        DataGridView dataGrid;
        public string Date { get => date; set => date = value; }
        public string Affiliation { get => affiliation; set => affiliation = value; }
        public string Dojo { get => dojo; set => dojo = value; }

        public PrintReport()
        {
        }
        public PrintReport(DataGridView datagrid)
        {
            dataGrid = datagrid;
        }
        public PrintReport(string dojo, DataGridView datagrid)
        {
            dataGrid = datagrid;
            Dojo = dojo;
        }

        public PrintReport(string date, string affiliation, DataGridView datagrid)
        {
            this.Date = date;
            this.Affiliation = affiliation;
            dataGrid = datagrid;
        }
        public PrintReport(string date, string affiliation, string dojo, DataGridView datagrid)
        {
            this.Date = date;
            this.Affiliation = affiliation;
            this.Dojo = dojo;
            dataGrid = datagrid;
        }

        public void printReport(PrintPreviewDialog ppd, PrintDocument printDoc)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "Print Document";
            printDlg.Document = printDocument;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            ppd.Document = printDoc;
            if (printDlg.ShowDialog() == DialogResult.OK) ppd.ShowDialog();
            //ppd.ShowDialog();
        }
        public void PrintDoc_licensedToJapan()
        {
            Member mem = new Member();
            List<LTJ> lltj = new List<LTJ>();
            foreach (Member item in mem.GetMember())
            {
                if (item.isAffiliated(Date,Affiliation))
                {                   
                    lltj.Add(new LTJ(item.MemberFirstName,item.MemberLastName,item.JAPAfilliationNumber,item.GetDojoName(),item.lastGradingDate(),item.GetBeltDescr(item.BeltID.ToString()),item.DOB.ToString()));
                }              
            }
            dataGrid.DataSource = lltj;           
        }

        public void PrintDoc_memberList()
        {
            Member mem = new Member();
            List<Member> lobj = new List<Member>();
           
            foreach (Member item in mem.GetMember())
            {
                lobj.Add(item);
            }
            dataGrid.DataSource = lobj;          
        }
        

        public void PrintDoc_qualificationStatuses()
        {
            Member mem = new Member();
            List<QS> lqs = new List<QS>();
            foreach (Member item in mem.GetMember())
            {               
                DataRowCollection drc = item.getMemberQualifications().Rows;
                string qual = "";
                if (drc.Count != 0)
                {
                    foreach (DataRow dr in drc)
                    {
                        qual += $"{dr["QualificationDescription"]}\n";
                    }
                }
                else qual = "No Qualifications";
                lqs.Add(new QS(item.MemberFirstName,item.MemberLastName,qual,item.GetDojoName()));
            }
            dataGrid.DataSource = lqs;
        }      

        public void PrintDoc_affiliatedPerDojo()
        {
            Member mem = new Member();
            List<APD> lapd = new List<APD>();
            foreach (Member item in mem.GetMember())
            {
                if (item.isAffiliated(Date,Affiliation)&&item.GetDojoName()==Dojo)
                {
                    lapd.Add(new APD(item.MemberFirstName, item.MemberLastName, item.JAPAfilliationNumber, item.GetDojoName(), item.DOB.ToString("yyyy/MM/dd"), item.GetBeltDescr(item.BeltID.ToString()),item.isAffiliated(Date, "JAP Affiliation").ToString(),item.isAffiliated(Date,"SA Affiliation").ToString(),item.JAPBook.ToString()));                 
                }
            }
            dataGrid.DataSource = lapd;
        }
        public void PrintDoc_gradingHistoryPerDojo()
        {
            Member mem = new Member();
            List<GH> lGH = new List<GH>();
            foreach (Member item in mem.GetMember())
            {
                if (item.GetDojoName() == Dojo)
                {
                    string text = "";
                    List<string> ltext = item.gradingHistory();
                    if (ltext.Count != 0)
                    {
                        foreach (string dateBelt in ltext)
                        {
                            text += $"{dateBelt}\n";
                        }
                    }
                    else text = "No Grading History";
                    
                    lGH.Add(new GH(item.MemberFirstName, item.MemberLastName, item.JAPAfilliationNumber,item.SAAfilliationNumber,item.GetBeltDescr(item.BeltID.ToString()),item.DOB.ToString("yyyy/MM/dd"),item.lastGradingDate(),text,item.GetDojoName()));
                }
            }
            dataGrid.DataSource = lGH;
        }
    }
}
