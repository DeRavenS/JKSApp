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
    public partial class frmAddMemberQualification : Form
    {
        frmMember frmMember = new frmMember();
        Qualification qual = new Qualification();
        List<string> l = new List<string>();
        Member mem = new Member();
        public frmAddMemberQualification(frmMember frmmember, List<string> litems,Object m)
        {
            InitializeComponent();
            frmMember = frmmember;
            l = litems;
            mem = m as Member;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxQualifications.Items.Add(cbxQualifications.Text);
            cbxQualifications.Items.Remove(cbxQualifications.SelectedItem);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbxQualifications.SelectedItems.Count != 0)
            {
                cbxQualifications.Items.Add(lbxQualifications.SelectedItem);
                lbxQualifications.Items.Remove(lbxQualifications.SelectedItem);
            }
            else MessageBox.Show("Please select Item to remove");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Qualification item in qual.getAll())
            {
                if (lbxQualifications.Items.Contains(item.QualificationDescription))
                {
                    mem.InsertMemberItem(ObjectType.qualification, item.QualificationID.ToString());             
                }
               
            }
            MessageBox.Show("Insert Successful");
            this.Close();
            
        }

        private void frmAddMemberQualification_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMember.Enabled = true;
        }

        private void frmAddMemberQualification_Load(object sender, EventArgs e)
        {                    
            foreach (Qualification item in qual.getAll())
            {
                if (!l.Contains(item.QualificationDescription))
                {
                    cbxQualifications.Items.Add(item.QualificationDescription);
                }
            } 

        }

        private void lbxQualifications_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsRemoveQualifications.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));
            }
        }
    }
}
