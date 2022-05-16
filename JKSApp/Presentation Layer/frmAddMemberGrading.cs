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
    public partial class frmAddMemberGrading : Form
    {        
        Grading grad = new Grading();
        List<string> l = new List<string>();
        Member mem = new Member();
        public frmAddMemberGrading(frmMember frmmember, List<string> litems, Object m)
        {
            InitializeComponent();
            l = litems;
            mem = m as Member;
        }

        private void frmAddMemberGrading_Load(object sender, EventArgs e)
        {
            Belt belt = new Belt();
            foreach (Belt item in belt.getAll())
            {
                cbxGrade.Items.Add(item.BeltName);
            }
            foreach (Grading item in grad.getGrading())
            {
                cbxGradings.Items.Add($"{item.GradingDescription}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Grading item in grad.getGrading())
            {
                if (cbxGradings.Text== $"{item.GradingDescription}")
                {
                    Belt belt = new Belt();
                    foreach (Belt b in belt.getAll())
                    {
                        if (b.BeltName==cbxGrade.Text)
                        {
                            if (mem.InsertMemberItem(ObjectType.grading, $"{item.GradingID},{b.BeltID},{ckbPassed.Checked},'{dtpGrading.Value.ToString("yyyy/MM/dd")}'"))
                            {
                                MessageBox.Show("Grading added");
                            }                          
                            break;
                        }                  
                    }                   
                }                
            }           
            Close();
        }

        private void frmAddMemberGrading_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
