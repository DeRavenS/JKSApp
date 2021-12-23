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
        frmMember frmMember = new frmMember();
        Grading grad = new Grading();
        List<string> l = new List<string>();
        Member mem = new Member();
        public frmAddMemberGrading(frmMember frmmember, List<string> litems, Object m)
        {
            InitializeComponent();
            frmMember = frmmember;
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
                if (!l.Contains($"{item.GradingDescription}, {item.GradingDate.ToString("yyyy/MM/dd")}"))
                {
                    cbxGradings.Items.Add($"{item.GradingDescription}, {item.GradingDate.ToString("yyyy/MM/dd")}");
                }
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
                if (cbxGradings.Text== $"{item.GradingDescription}, {item.GradingDate.ToString("yyyy/MM/dd")}")
                {
                    Belt belt = new Belt();
                    foreach (Belt b in belt.getAll())
                    {
                        if (b.BeltName==cbxGrade.Text)
                        {
                            mem.InsertMemberItem(ObjectType.grading, $"{item.GradingID},{b.BeltID},{ckbPassed.Checked}");
                            MessageBox.Show("Grading added");
                        }                  
                    }                   
                }                
            }
            
            Close();
        }

        private void frmAddMemberGrading_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMember.Enabled = true;
        }
    }
}
