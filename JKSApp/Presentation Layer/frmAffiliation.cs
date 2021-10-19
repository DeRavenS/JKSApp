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
    public partial class frmAffiliation : Form
    {
        BindingSource source = new BindingSource();
        Affiliation aff = new Affiliation();
        public frmAffiliation()
        {
            InitializeComponent();
        }

        private void frmAffiliation_Load(object sender, EventArgs e)
        {
            source.DataSource = aff.getAll();
            dgvAffiliation.DataSource = source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void btnDisplayAllAchievement_Click(object sender, EventArgs e)
        {
            source.DataSource = aff.getAll();
            dgvAffiliation.DataSource = source;
        }
    }
}
