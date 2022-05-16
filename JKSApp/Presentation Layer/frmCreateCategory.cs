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
    public partial class frmCreateCategory : Form
    {
        CU OP = CU.Insert;
        public frmCreateCategory(CU op)
        {
            InitializeComponent();
            OP = op;
        }

        private void frmCreateCategory_Load(object sender, EventArgs e)
        {
            Display dis = new Display();
            List<string> lnum = dis.AddNumbers();
            for (int i = 1; i < lnum.Count; i++)
            {
                cbxMinAge.Items.Add(lnum[i]);
                cbxMaxAge.Items.Add(lnum[i]);
            }
            if (OP==CU.Update)
            {
                Category cat = StaticBindingSource.source.Current as Category;
                txtAchievementName.Text = cat.CategoryDescription;
                cbxMinAge.SelectedItem = cat.MinAge.ToString();
                cbxMaxAge.SelectedItem = cat.MaxAge.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (OP==CU.Insert)
            {
                Category cat = new Category(0,txtAchievementName.Text,int.Parse(cbxMinAge.SelectedItem.ToString()), int.Parse(cbxMaxAge.SelectedItem.ToString()));
                if (cat.insertCategory())
                {
                    MessageBox.Show("Successfully added new Category");
                    Close();
                }               
            }
            else
            {
                Category cat = StaticBindingSource.source.Current as Category;
                cat.CategoryDescription = txtAchievementName.Text;
                cat.MinAge = int.Parse(cbxMinAge.Text);
                cat.MaxAge = int.Parse(cbxMaxAge.Text);
                if (cat.updateCategory())
                {
                    MessageBox.Show("Successfully updated Category");
                    Close();
                }
            }
        }

        private void frmCreateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
