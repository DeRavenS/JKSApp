using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.Presentation_Layer;

namespace JKSApp.Presentation_Layer
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEvent frm = new frmEvent();
            frm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCompetition_Click(object sender, EventArgs e)
        {
            frmCompetition frmcomp = new frmCompetition();
            frmcomp.Show();
            Close();
        }

        private void btnDojo_Click(object sender, EventArgs e)
        {
            frmDojo frmDojo = new frmDojo();
            frmDojo.Show();
            Close();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.Show();
            Close();
        }

        private void btnAffilliation_Click(object sender, EventArgs e)
        {
            frmAffiliation frm = new frmAffiliation();
            frm.Show();
            Close();
        }

        private void btnBelt_Click(object sender, EventArgs e)
        {
            frmBelt frm = new frmBelt();
            frm.Show();
            Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
            Close();
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            frmGrading frm = new frmGrading();
            frm.Show();
            Close();
        }

        private void btnAchievement_Click(object sender, EventArgs e)
        {
            frmAchievement frm = new frmAchievement();
            frm.Show();
            Close();
        }
    }
}
