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

namespace JKSApp.Presentation_Layer
{
    public partial class frmQualification : Form
    {
        
        Qualification qual = new Qualification();
        public frmQualification()
        {
            InitializeComponent();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void frmQualification_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = qual.getAll();
            dgvQualification.DataSource = StaticBindingSource.source;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = qual.getAll();
            dgvQualification.DataSource = StaticBindingSource.source;
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvQualification_SelectionChanged(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.qualificationListView(lvMembers);
        }
    }
}
