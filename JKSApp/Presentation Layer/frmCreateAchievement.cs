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
    public partial class frmCreateAchievement : Form
    {
        CU operation;
        Achievement achievement = null;
        public frmCreateAchievement(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateAchievement(CU op,Object ach)
        {
            InitializeComponent();
            operation = op;
            achievement = ach as Achievement;
        }

        private void lblCompName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {
                Achievement ach = new Achievement(0, txtAchievementName.Text);
                if (ach.InsertAchievement())
                {
                    Close();
                }                  
            }
            else
            {
                achievement.AchievementDescription = txtAchievementName.Text;
                if (achievement.updateAchievement())
                {
                    Close();
                }
            }
            
        }

        private void frmCreateAchievement_Load(object sender, EventArgs e)
        {
            if (achievement!= null)
            {
                txtAchievementName.Text = achievement.AchievementDescription;
            }
        }

        private void frmCreateAchievement_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void txtAchievementName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
