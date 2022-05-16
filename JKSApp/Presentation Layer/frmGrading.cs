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
            if (dgvGrading.Rows.Count != 0)
            {
                Display dis = new Display();
                dis.gradingListView(lvMembers);
            }
            else lvMembers.Items.Clear();
            
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Grading grad = new Grading();
            StaticBindingSource.source.DataSource = grad.SortTable(ObjectType.grading, tsmcbxSort.Text, "ASC");
            dgvGrading.DataSource = StaticBindingSource.source;
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Grading grad = new Grading();
            StaticBindingSource.source.DataSource = grad.SortTable(ObjectType.grading, tsmcbxSort.Text, "DESC");
            dgvGrading.DataSource = StaticBindingSource.source;
        }

        private void dgvGrading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsGrading.Show(this, new Point(e.X + ((Control)sender).Left+260, e.Y + ((Control)sender).Top));
            }
        }

        private void btnSearchGrading_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = grade.Search(txtSearchGrading.Text);
        }

        private void frmGrading_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                StaticBindingSource.source.DataSource = grade.getGrading();
                dgvGrading.DataSource = StaticBindingSource.source;
            }          
        }

        private void frmGrading_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
