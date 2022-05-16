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
    public partial class frmCategory : Form
    {
        Category cat = new Category();
        
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategorycs_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.getAll();
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.getAll();
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.Rows.Count != 0)
            {
                Display dis = new Display();
                dis.categoryListView(lvMembers);
            }
            else lvMembers.Items.Clear();
            
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void dgvCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsCategory.Show(this, new Point(e.X + ((Control)sender).Left+260, e.Y + ((Control)sender).Top));
            }
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Event cat = new Event();
            StaticBindingSource.source.DataSource= cat.SortTable(ObjectType.category,tsmcbxSort.Text,"ASC");
            dgvCategory.DataSource = StaticBindingSource.source;

        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Event cat = new Event();
            StaticBindingSource.source.DataSource = cat.SortTable(ObjectType.category, tsmcbxSort.Text, "DESC");
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.Search(txtSearch.Text);
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void frmCategory_EnabledChanged(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.getAll();
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void frmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
