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
    public partial class frmCreateAffiliation : Form
    {
        Affiliation affiliation = StaticBindingSource.source.Current as Affiliation;
        CU OP = CU.Insert;
        public frmCreateAffiliation(CU op)
        {
            InitializeComponent();
            OP = op;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (OP==CU.Insert)
            {
                Affiliation aff = new Affiliation(0,txtEventName.Text);
                if (aff.InsertAffiliation())
                {
                    Close();
                }             
            }
            else
            {
                affiliation.AffiliationDescription = txtEventName.Text;
                if (affiliation.updateAffiliation())
                {
                    Close();
                }
            }
        }

        private void frmCreateAffiliation_Load(object sender, EventArgs e)
        {
            if (OP==CU.Update)
            {
                txtEventName.Text = affiliation.AffiliationDescription;
            }
        }

        private void frmCreateAffiliation_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
