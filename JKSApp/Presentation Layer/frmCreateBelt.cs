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
    public partial class frmCreateBelt : Form
    {
        CU OP = CU.Insert;
        public frmCreateBelt(CU op)
        {
            InitializeComponent();
            OP = op;
        }

        private void frmCreateBelt_Load(object sender, EventArgs e)
        {
            if (OP==CU.Update)
            {
                Belt belt = StaticBindingSource.source.Current as Belt;
                txtAchievementName.Text = belt.BeltName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (OP==CU.Insert)
            {
                Belt b = new Belt();
                Belt belt = new Belt(b.getNextBeltID(),txtAchievementName.Text);
                if (belt.insertBelt())
                {
                    Close();
                }
            }
            else
            {
                Belt belt = StaticBindingSource.source.Current as Belt;
                belt.BeltName = txtAchievementName.Text;
                if (belt.updateBelt())
                {
                    Close();
                }
                
            }
        }

        private void frmCreateBelt_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
