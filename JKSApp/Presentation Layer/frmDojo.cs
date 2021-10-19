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
    public partial class frmDojo : Form
    {
        BindingSource source = new BindingSource();
        
        public frmDojo()
        {
            InitializeComponent();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Hide();
        }

        private void btnSearchDojo_Click(object sender, EventArgs e)
        {

        }

        private void frmDojo_Load(object sender, EventArgs e)
        {
            Dojo dojo = new Dojo();
            source.DataSource = dojo.getDojo();
            dgvDojo.DataSource = source;
            dgvDojo.Columns["DojoID"].Visible = false;
        }

        private void btnNewDojo_Click(object sender, EventArgs e)
        {
            frmCreateDojo frm = new frmCreateDojo(this);
            frm.Show();
            this.Enabled = false;
        }

        private void btnNewDojo_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Dojo dojo = new Dojo();
                source.DataSource = dojo.getDojo();
                dgvDojo.DataSource = source;
                dgvDojo.Columns["DojoID"].Visible = false;
            }
        }
    }
}
