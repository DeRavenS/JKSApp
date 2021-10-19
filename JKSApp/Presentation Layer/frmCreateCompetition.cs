using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;
using JKSApp.DataLayer;

namespace JKSApp.Presentation_Layer
{
    public partial class frmCreateCompetition : Form
    {
        
        public frmCreateCompetition()
        {
            InitializeComponent();
        }

        private void btnCreateComp_Click(object sender, EventArgs e)
        {
            Competition comp = new Competition();
            if (comp.InsertComp(txtCompName.Text, dtComp.Value.Date))
            {
                MessageBox.Show("Succesfully Inserted");
                frmCompetition frm = new frmCompetition();
                frm.Show();
                Close();
            } 
        }

        private void frmCreateCompetition_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCompetition frm = new frmCompetition();
            frm.Show();
            Close();
        }
    }
}
