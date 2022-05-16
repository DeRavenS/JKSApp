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
    public partial class frmCreateQualification : Form
    {
        CU operation;
        Qualification qualification = null;
        public frmCreateQualification(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateQualification(CU op,object obj)
        {
            InitializeComponent();
            operation = op;
            qualification = obj as Qualification;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation == CU.Insert)
            {
                Qualification qual = new Qualification(0, txtQualificationName.Text);
                if (qual.InsertQualification()) Close();
            }
            else
            {
                qualification.QualificationDescription = txtQualificationName.Text;
                if (qualification.updateQualification())
                {
                    Close();
                }
            }
        }

        private void frmCreateQualification_Load(object sender, EventArgs e)
        {
            if (qualification!=null)
            {
                txtQualificationName.Text = qualification.QualificationDescription;
            }
        }

        private void frmCreateQualification_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
