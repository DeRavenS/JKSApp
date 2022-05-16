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
    public partial class frmEvent : Form
    {
        Event ev = new Event();
        
        public frmEvent()
        {
            InitializeComponent();
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
           StaticBindingSource.source.DataSource = ev.getEvents();
            dgvEvent.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAllEvent_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ev.getEvents();
            dgvEvent.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Hide();
        }

        private void dgvEvent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEvent.Rows.Count != 0)
            {
                Display dis = new Display();
                dis.eventListView(lvMembers);
            }
            else lvMembers.Items.Clear();
            
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            StaticBindingSource.source.DataSource = ev.SortTable(ObjectType.events, tsmcbxSort.Text, "ASC");
            dgvEvent.DataSource = StaticBindingSource.source;
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            StaticBindingSource.source.DataSource = ev.SortTable(ObjectType.events, tsmcbxSort.Text, "DESC");
            dgvEvent.DataSource = StaticBindingSource.source;
        }

        private void dgvEvent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsEvent.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));
            }
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ev.Search(txtSearchEvent.Text);
        }

        private void frmEvent_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                StaticBindingSource.source.DataSource = ev.getEvents();
                dgvEvent.DataSource = StaticBindingSource.source;
            }           
        }

        private void frmEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
