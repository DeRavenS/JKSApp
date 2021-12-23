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
    public partial class frmCategory : Form
    {
        Category cat = new Category();
        
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategorycs_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.getAll();
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = cat.getAll();
            dgvCategory.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.categoryListView(lvMembers);
        }
    }
}
