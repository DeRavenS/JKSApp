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
            StaticBindingSource.source.DataSource = qual.Search(txtSearch.Text);
            dgvQualification.DataSource = StaticBindingSource.source;
        }

        private void dgvQualification_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQualification.Rows.Count != 0)
            {
                Display dis = new Display();
                dis.qualificationListView(lvMembers);
            }
            else lvMembers.Items.Clear();
            
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Qualification qual = new Qualification();
            StaticBindingSource.source.DataSource = qual.SortTable(ObjectType.qualification, tsmcbxSort.Text, "ASC");
            dgvQualification.DataSource = StaticBindingSource.source;
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Qualification qual = new Qualification();
            StaticBindingSource.source.DataSource = qual.SortTable(ObjectType.qualification, tsmcbxSort.Text, "DESC");
            dgvQualification.DataSource = StaticBindingSource.source;
        }

        private void dgvQualification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsQualification.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top-5));
            }
        }

        private void frmQualification_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                StaticBindingSource.source.DataSource = qual.getAll();
                dgvQualification.DataSource = StaticBindingSource.source;
            }
        }

        private void frmQualification_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
