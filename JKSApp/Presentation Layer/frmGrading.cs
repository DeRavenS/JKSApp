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
    public partial class frmGrading : Form
    {
        Grading grade = new Grading();
        
        public frmGrading()
        {
            InitializeComponent();
        }

        private void frmGrading_Load(object sender, EventArgs e)
        {
           StaticBindingSource.source.DataSource = grade.getGrading();
            dgvGrading.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAllGrading_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = grade.getGrading();
            dgvGrading.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvGrading_SelectionChanged(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.gradingListView(lvMembers);
        }
    }
}
