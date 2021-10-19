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
    public partial class frmMember : Form
    {
        BindingSource source = new BindingSource();
        Member mem = new Member();
        Display dis = new Display();
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            source.DataSource = mem.GetMember();
            dgvMember.DataSource = source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void btnDisplayAllMember_Click(object sender, EventArgs e)
        {
            source.DataSource = mem.GetMember();
            dgvMember.DataSource = source;
            dis.RefreshDVG(dgvMember,source);
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            source.DataSource = mem.SearchMember(txtSearchMember.Text, mem.GetMember());
            dgvMember.DataSource = source;
            
        }
    }
}
