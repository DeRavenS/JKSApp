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
        BindingSource source = new BindingSource();
        public frmBelt()
        {
            InitializeComponent();
        }

        private void frmBelt_Load(object sender, EventArgs e)
        {
            source.DataSource = belt.getAll();
            dgvBelt.DataSource = source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            source.DataSource = belt.getAll();
            dgvBelt.DataSource = source;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Belt b = new Belt();
            source.DataSource = b.Search(txtSearchBelt.Text);
            dgvBelt.DataSource = source;
        }
    }
}
