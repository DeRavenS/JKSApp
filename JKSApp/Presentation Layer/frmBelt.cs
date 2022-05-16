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
    public partial class frmBelt : Form
    {
        Belt belt = new Belt();
        
        public frmBelt()
        {
            InitializeComponent();
        }

        private void frmBelt_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = belt.getAll();
            dgvBelt.DataSource =StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = belt.getAll();
            dgvBelt.DataSource = StaticBindingSource.source;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           StaticBindingSource.source.MoveNext();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Belt b = new Belt();
            StaticBindingSource.source.DataSource = b.Search(txtSearchBelt.Text);
            dgvBelt.DataSource = StaticBindingSource.source;
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Belt belt = new Belt();
            StaticBindingSource.source.DataSource=belt.SortTable(ObjectType.belt,tsmcbxSort.Text,"ASC");
            dgvBelt.DataSource = StaticBindingSource.source;
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Belt belt = new Belt();
            StaticBindingSource.source.DataSource = belt.SortTable(ObjectType.belt, tsmcbxSort.Text, "DESC");
            dgvBelt.DataSource = StaticBindingSource.source;
        }

        private void dgvBelt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsBelt.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));
            }
        }

        private void frmBelt_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                StaticBindingSource.source.DataSource = belt.getAll();
                dgvBelt.DataSource = StaticBindingSource.source;
            }
        }

        private void frmBelt_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
