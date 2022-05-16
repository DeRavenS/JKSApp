using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;

namespace JKSApp.Presentation_Layer
{
    public partial class frmAchievement : Form
    {
        Achievement ach = new Achievement();       
        
        public frmAchievement()
        {
            InitializeComponent();
        }

        private void frmAchievement_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ach.getAchievement();
            dgvAchievement.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAllAchievement_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ach.getAchievement();
            dgvAchievement.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvAchievement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAchievement.SelectedRows.Count != 0)
            {
                Display dis = new Display();
                dis.achievementListView(lvMembers);
            }
            else lvMembers.Items.Clear();                      
        }

        private void dgvAchievement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tscbxSort.ToolTipText = "Please select a column to sort by.";
                cmsAchievement.Show(this, new Point(e.X + ((Control)sender).Left +280, e.Y + ((Control)sender).Top));
            }
        }

        private void assendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Achievement ach = new Achievement();
            StaticBindingSource.source.DataSource= ach.SortTable(ObjectType.achievement,tscbxSort.Text,"ASC");
            dgvAchievement.DataSource = StaticBindingSource.source;
        }       

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Achievement ach = new Achievement();
            StaticBindingSource.source.DataSource = ach.SortTable(ObjectType.achievement, tscbxSort.Text, "DESC");
            dgvAchievement.DataSource = StaticBindingSource.source;
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tscbxSort.SelectedIndex = 0;
        }

        private void btnSearchGrading_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ach.Search(txtSearchGrading.Text);
        }

        private void frmAchievement_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                StaticBindingSource.source.DataSource = ach.getAchievement();
                dgvAchievement.DataSource = StaticBindingSource.source;
            }
        }

    }
}