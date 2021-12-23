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
    public partial class frmAchievement : Form
    {
        Achievement ach = new Achievement();
        BindingSource source = new BindingSource();
        string sortOrder = "";
        public frmAchievement()
        {
            InitializeComponent();
        }

        private void frmAchievement_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ach.getAchievement();
            dgvAchievement.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAllAchievement_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = ach.getAchievement();
            dgvAchievement.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvAchievement_SelectionChanged(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.achievementListView(lvMembers);
        }
    }
}