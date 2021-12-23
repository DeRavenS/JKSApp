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
    public partial class frmDojo : Form
    {
       
       
        public frmDojo()
        {
            InitializeComponent();
            Dojo dojo = new Dojo();                  
        }      

        private void btnSearchDojo_Click(object sender, EventArgs e)
        {

        }

        private void frmDojo_Load(object sender, EventArgs e)
        {
            Dojo dojo = new Dojo();
            StaticBindingSource.source.DataSource = dojo.getDojo();
            dgvDojo.DataSource = StaticBindingSource.source;
            dgvDojo.Columns["DojoID"].Visible = false;         
        }
       
        private void btnNewDojo_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Dojo dojo = new Dojo();
                StaticBindingSource.source.DataSource = dojo.getDojo();
                dgvDojo.DataSource = StaticBindingSource.source;
                dgvDojo.Columns["DojoID"].Visible = false;
            }
        }

        private void dgvDojo_SelectionChanged(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.dojoListView(lvMembers);
        }
    }
}
