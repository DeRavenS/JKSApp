using JKSApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKSApp.Presentation_Layer
{
    public partial class frmAddMemberAffiliation : Form
    {
        public frmAddMemberAffiliation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddMemberAffiliation_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void frmAddMemberAffiliation_Load(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.affiliationListViewID(lvMembers);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Affiliation aff = StaticBindingSource.source.Current as Affiliation;
            if (aff.InsertMemberAffiliation(lvMembers, dtpAffiliation))
            {
                Close();
            }      
        }
    }
}
