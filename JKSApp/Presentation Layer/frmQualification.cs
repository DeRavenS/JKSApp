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
        BindingSource source = new BindingSource();
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
            source.DataSource = qual.getAll();
            dgvQualification.DataSource = source;
        }
    }
}
