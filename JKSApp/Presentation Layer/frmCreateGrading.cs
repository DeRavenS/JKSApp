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
    public partial class frmCreateGrading : Form
    {
        CU operation;
        Grading grading = null;
        public frmCreateGrading(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateGrading(CU op, object obj)
        {
            InitializeComponent();
            operation = op;
            grading = obj as Grading;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {
                Grading grad = new Grading(0, txtGradingName.Text);
                if (grad.InsertGrading()) Close();                                    
            }
            else
            {
                grading.GradingDescription = txtGradingName.Text;              
                if (grading.updateGrading())
                {
                    Close();
                }
            }
        }

        private void lblEventName_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateGrading_Load(object sender, EventArgs e)
        {
            if (grading!=null)
            {
                txtGradingName.Text = grading.GradingDescription;
            }
        }

        private void frmCreateGrading_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
