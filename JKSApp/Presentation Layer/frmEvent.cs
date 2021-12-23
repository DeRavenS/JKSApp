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
            Display dis = new Display();
            dis.eventListView(lvMembers);
        }
    }
}
