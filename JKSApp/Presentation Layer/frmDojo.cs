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
            Dojo doj = new Dojo();
            StaticBindingSource.source.DataSource= doj.Search(txtSearchComp.Text);
            dgvDojo.DataSource = StaticBindingSource.source;
            dgvDojo.Columns["DojoID"].Visible = false;
            dgvDojo.Columns["DojoID"].Visible = false;
        }

        private void frmDojo_Load(object sender, EventArgs e)
        {
            Dojo dojo = new Dojo();
            StaticBindingSource.source.DataSource = dojo.getDojo();
            dgvDojo.DataSource = StaticBindingSource.source;
            dgvDojo.Columns["DojoID"].Visible = false;

            //filter
            Display dis = new Display();
            cbxActiveFilter.SelectedIndex = 0;
            List<string>[] laddress = dis.populateAddressFilter();
            cbxSuburbFilter.DataSource = laddress[0];
            cbxCityFilter.DataSource = laddress[1];
            cbxProvinceFilter.DataSource = laddress[2];
            cbxCountryFilter.DataSource = laddress[3];
            cbxminStudFilter.DataSource = dis.AddNumbers();
            cbxmaxStudFilter.DataSource = dis.AddNumbers();
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
            if (dgvDojo.Rows.Count != 0)
            {
                Display dis = new Display();
                dis.dojoListView(lvMembers);
            }
            else lvMembers.Items.Clear();
            
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Dojo doj = new Dojo();
            StaticBindingSource.source.DataSource = doj.SortTable(ObjectType.dojo,tsmcbxSort.Text,"ASC");
            dgvDojo.DataSource = StaticBindingSource.source;
        }

        private void dgvDojo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsDojo.Show(this, new Point(e.X + ((Control)sender).Left+260, e.Y + ((Control)sender).Top));
            }
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Dojo doj = new Dojo();
            StaticBindingSource.source.DataSource = doj.SortTable(ObjectType.dojo, tsmcbxSort.Text, "DESC");
            dgvDojo.DataSource = StaticBindingSource.source;
        }

        private void btnShowHideFilters_Click(object sender, EventArgs e)
        {
            if (pnlDojoFilter.Visible)
            {
                pnlDojoFilter.Visible = false;
                btnShowHideFilters.Text = "Show Filters";
            }
            else
            {
                pnlDojoFilter.Visible = true;
                btnShowHideFilters.Text = "Hide Filters";
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbxActiveFilter.SelectedIndex = 0;
            cbxCityFilter.SelectedIndex = 0;
            cbxCountryFilter.SelectedIndex = 0;
            cbxmaxStudFilter.SelectedIndex = 0;
            cbxminStudFilter.SelectedIndex = 0;
            cbxProvinceFilter.SelectedIndex = 0;
            cbxSuburbFilter.SelectedIndex = 0;

            Dojo dojo = new Dojo();
            StaticBindingSource.source.DataSource = dojo.getDojo();
            dgvDojo.DataSource = StaticBindingSource.source;
            dgvDojo.Columns["DojoID"].Visible = false;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            Dojo doj = new Dojo();
            StaticBindingSource.source.DataSource= doj.filterDojo(cbxSuburbFilter.Text,cbxCityFilter.Text,cbxProvinceFilter.Text,cbxCountryFilter.Text,cbxminStudFilter.Text,cbxmaxStudFilter.Text,cbxActiveFilter.Text);
            dgvDojo.DataSource = StaticBindingSource.source;
            dgvDojo.Columns["DojoID"].Visible = false;
        }

        private void frmDojo_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Dojo dojo = new Dojo();
                StaticBindingSource.source.DataSource = dojo.getDojo();
                dgvDojo.DataSource = StaticBindingSource.source;
                dgvDojo.Columns["DojoID"].Visible = false;

                //filter
                Display dis = new Display();
                cbxActiveFilter.SelectedIndex = 0;
                List<string>[] laddress = dis.populateAddressFilter();
                cbxSuburbFilter.DataSource = laddress[0];
                cbxCityFilter.DataSource = laddress[1];
                cbxProvinceFilter.DataSource = laddress[2];
                cbxCountryFilter.DataSource = laddress[3];
                cbxminStudFilter.DataSource = dis.AddNumbers();
                cbxmaxStudFilter.DataSource = dis.AddNumbers();
            }
            
        }

        private void frmDojo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
