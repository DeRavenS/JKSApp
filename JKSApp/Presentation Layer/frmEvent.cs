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
        BindingSource source = new BindingSource();
        public frmEvent()
        {
            InitializeComponent();
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
            source.DataSource = ev.getEvents();
            dgvEvent.DataSource = source;
        }

        private void btnDisplayAllEvent_Click(object sender, EventArgs e)
        {
            source.DataSource = ev.getEvents();
            dgvEvent.DataSource = source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Hide();
        }
    }
}
