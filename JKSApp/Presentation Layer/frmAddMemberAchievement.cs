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
    public partial class frmAddMemberAchievement : Form
    {
        frmMember frmMember = new frmMember();
        Achievement ach = new Achievement();
        List<string> l = new List<string>();
        Member mem = new Member();
        public frmAddMemberAchievement(frmMember frmmember, List<string> litems, Object m)
        {
            InitializeComponent();
            frmMember = frmmember;
            l = litems;
            mem = m as Member;
        }

        private void frmAddMemberAchievement_Load(object sender, EventArgs e)
        {
            
            foreach (Achievement item in ach.getAchievement())
            {
                    cbxAchievement.Items.Add($"{item.AchievementDescription}");               
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Achievement item in ach.getAchievement())
            {
                if (cbxAchievement.Text == item.AchievementDescription)
                {                  
                    mem.InsertMemberItem(ObjectType.achievement, $"{item.AchievementID},'{dtpAchievement.Value.ToString("yyyy")}'");
                }
            }
            MessageBox.Show("Operation Complete");
            this.Close();
            
        }

        private void frmAddMemberAchievement_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMember.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
