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
        BindingSource source = new BindingSource();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategorycs_Load(object sender, EventArgs e)
        {
            source.DataSource = cat.getAll();
            dgvCategory.DataSource = source;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            source.DataSource = cat.getAll();
            dgvCategory.DataSource = source;
        }
    }
}
