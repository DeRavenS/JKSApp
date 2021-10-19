using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.DataLayer;
using JKSApp.BusinessLayer;
using System.Data.OleDb;

namespace JKSApp.Presentation_Layer
{
    public partial class frmCompetition : Form
    {
     
        Display dis = new Display();
        DataHandler dh = new DataHandler();
        DatabaseOperation operation = new DatabaseOperation();
        Competition comp = new Competition();
        BindingSource source = new BindingSource();
        public frmCompetition()
        {
            InitializeComponent();
        }

        private void frmCompetition_Load(object sender, EventArgs e)
        {
            source.DataSource =comp.getComp();
            dgvCompetitions.DataSource = source;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmmain = new frmMainMenu();
            frmmain.Show();
            Close();
        }

        private void btnDisplayAllComp_Click(object sender, EventArgs e)
        {
            source.DataSource = comp.getComp();
            dgvCompetitions.DataSource = source;
            txtSearchComp.Text = "";
            cbxSearchCompetitor.Text = "";
        }

        private void btnNewCompetition_Click(object sender, EventArgs e)
        {
            frmCreateCompetition frm = new frmCreateCompetition();
            frm.Show();
            this.Close();
        }

        private void btnSearchComp_Click_1(object sender, EventArgs e)
        {
            source.DataSource = comp.CompSearch(txtSearchComp.Text);
            dgvCompetitions.DataSource = source;
            dis.RefreshDVG(dgvCompetitions, source);
        }

        private void btnFilterFinished_Click(object sender, EventArgs e)
        {
            source.DataSource= comp.ClosedComp();
            dgvCompetitions.DataSource = source;
            dis.RefreshDVG(dgvCompetitions,source);
        }

        private void btnFilterUpcoming_Click(object sender, EventArgs e)
        {
            source.DataSource = comp.UpcomingComp();
            dgvCompetitions.DataSource = source;
            dis.RefreshDVG(dgvCompetitions, source);
        }

        private void btnCompetitorStats_Click(object sender, EventArgs e)
        {

            rtxtStats.Text = operation.CompetitorStats(1);
        }
    }
}
