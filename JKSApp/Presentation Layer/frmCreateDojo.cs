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
    public partial class frmCreateDojo : Form
    {
        frmDojo frmdojo = new frmDojo();
        public frmCreateDojo()
        {
            InitializeComponent();
        }
        public frmCreateDojo(frmDojo frm)
        {
            InitializeComponent();
            frmdojo = frm;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Dojo dojo = new Dojo(txtName.Text,txtStreet.Text,txtSubUrb.Text,txtCity.Text,txtProvince.Text,txtCountry.Text,true);
            DatabaseOperation operation = new DatabaseOperation();
            if (dojo.insertDojo())
            {
                MessageBox.Show("Insert Succesful");
                frmdojo.Enabled = true;
                Close();
            }
        }

        private void frmCreateDojo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmdojo.Enabled = true;
            Close();
        }
    }
}
