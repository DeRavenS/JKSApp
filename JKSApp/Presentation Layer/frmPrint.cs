using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;

namespace JKSApp.Presentation_Layer
{
    public partial class frmPrint : Form
    {
        Button activeBtn;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            Dojo doj = new Dojo();
            Affiliation aff = new Affiliation();
            foreach (Dojo dojo in doj.getDojo())
            {
                cbxDojo.Items.Add(dojo.Name);
                cbxGradingHistoryDojo.Items.Add(dojo.Name);
            }
            foreach (Affiliation item in aff.getAll())
            {
                cbxAffiliation.Items.Add(item.AffiliationDescription);
            }
            activeBtn = btnLicensedToJapan;
        }

            private void btnLicensedToJapan_Click_1(object sender, EventArgs e)
        {
            activeBtn.BackColor = activeBtn.Parent.BackColor;
            activeBtn = btnLicensedToJapan;
            activeBtn.BackColor = activeBtn.FlatAppearance.MouseOverBackColor;
            pnlDojo.Visible = false;
            pnlGradingHistory.Visible = false;
            PrintReport pr = new PrintReport("2021", "JAP Affiliation",dgv);
            pr.PrintDoc_licensedToJapan();
        }

        private void btnAffiliatedPerDojo_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.SetChildIndex(pnlDojo, panel2.Controls.IndexOf(btnAffiliatedPerDojo)-1);
            pnlDojo.Visible = true;
            pnlGradingHistory.Visible = false;
            activeBtn.BackColor = activeBtn.Parent.BackColor;
            activeBtn = btnAffiliatedPerDojo;
            activeBtn.BackColor = activeBtn.FlatAppearance.MouseOverBackColor;
        }

        private void btnGradingHistoryPerDojo_Click(object sender, EventArgs e)
        {
            panel2.Controls.SetChildIndex(pnlDojo, panel2.Controls.IndexOf(btnGradingHistoryPerDojo) - 1);
            pnlGradingHistory.Visible = true;
            pnlDojo.Visible = false;
            activeBtn.BackColor = activeBtn.Parent.BackColor;
            activeBtn = btnGradingHistoryPerDojo;
            activeBtn.BackColor = activeBtn.FlatAppearance.MouseOverBackColor;
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            activeBtn.BackColor = activeBtn.Parent.BackColor;
            activeBtn = btnMemberList;
            activeBtn.BackColor = activeBtn.FlatAppearance.MouseOverBackColor;
            pnlDojo.Visible = false;
            pnlGradingHistory.Visible = false;
            PrintReport pr = new PrintReport(dgv);
            pr.PrintDoc_memberList();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            activeBtn.BackColor = activeBtn.Parent.BackColor;
            activeBtn =button5;
            activeBtn.BackColor = activeBtn.FlatAppearance.MouseOverBackColor;
            pnlDojo.Visible = false;
            pnlGradingHistory.Visible = false;
            PrintReport pr = new PrintReport(dgv);
            pr.PrintDoc_qualificationStatuses();
        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport();
            pr.printReport(ppd,printDoc);
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv.Width, this.dgv.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void cbxDojo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport("2021", cbxAffiliation.Text, cbxDojo.Text, dgv);
            pr.PrintDoc_affiliatedPerDojo();
        }

        private void cbxAffiliation_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport("2021", cbxAffiliation.Text, cbxDojo.Text, dgv);
            pr.PrintDoc_affiliatedPerDojo();
        }

        private void cbxGradingHistoryDojo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintReport pr = new PrintReport(cbxGradingHistoryDojo.Text,dgv);
            pr.PrintDoc_gradingHistoryPerDojo();
        }
    }
}
