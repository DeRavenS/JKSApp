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
using System.Threading;

namespace JKSApp.Presentation_Layer
{
    delegate void del(ListView lvMembers);
    public partial class frmAffiliation : Form
    {      
        Affiliation aff = new Affiliation();
        public frmAffiliation()
        {
            InitializeComponent();
        }

        private void frmAffiliation_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = aff.getAll();
            dgvAffiliation.DataSource = StaticBindingSource.source;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void dgvAffiliation_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAffiliation.Rows.Count!=0)
            {
                var t = new Thread(() => affiliationListView(lvMembers));
                t.Start();        
            }          
        }

        private void frmAffiliation_EnabledChanged(object sender, EventArgs e)
        {

            if (Enabled)
            {
                StaticBindingSource.source.DataSource = aff.getAll();
                dgvAffiliation.DataSource = StaticBindingSource.source;
            }
        }

        private void btnMemberAffiliation_Click(object sender, EventArgs e)
        {
            frmAddMemberAffiliation frm = new frmAddMemberAffiliation();
            frm.Show();
            this.Enabled = false;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Affiliation aff = new Affiliation();
            StaticBindingSource.source.DataSource = aff.SortTable(ObjectType.affiliation, tsmcbxSort.Text, "ASC");
            dgvAffiliation.DataSource = StaticBindingSource.source;
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Affiliation aff = new Affiliation();
            StaticBindingSource.source.DataSource = aff.SortTable(ObjectType.affiliation, tsmcbxSort.Text, "DESC");
            dgvAffiliation.DataSource = StaticBindingSource.source;
        }

        private void affiliationListView(ListView lvMembers)
        {
            Affiliation af = StaticBindingSource.source.Current as Affiliation;
            if (lvMembers.InvokeRequired)
            {
                var d = new del(affiliationListView);
                lvMembers.Invoke(d, new object[] { lvMembers }); 
            }
            else
            {
                lvMembers.Items.Clear();
                foreach (DataRow item in af.getAffiliationMembers().Rows)
                {
                    ListViewItem itm = new ListViewItem(item["MemberFirstName"].ToString());
                    itm.SubItems.Add(item["MemberLastName"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(item["AffiliationDate"].ToString()).ToString("yyyy/MM/dd"));
                    lvMembers.Items.Add(itm);
                }
            }           
        }
    }
}
