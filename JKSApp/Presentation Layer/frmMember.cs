using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.BusinessLayer;

namespace JKSApp.Presentation_Layer
{
    public partial class frmMember : Form
    {
        Member Mem = new Member();
        Display dis = new Display();
        ObjectType objActiveView;
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            //Info on form
            StaticBindingSource.source.DataSource = Mem.GetMember();
            dgvMember.DataSource = StaticBindingSource.source;
            dgvMember.Columns["MemberPhoto"].Visible = false;
            //filter           
            List<string>[] laddress = dis.populateAddressFilter();          
            cbxSuburbFilter.DataSource = laddress[0];
            cbxCityFilter.DataSource = laddress[1];
            cbxProvinceFilter.DataSource = laddress[2];
            cbxCountryFilter.DataSource = laddress[3];

            cbxGenderFilter.SelectedIndex = 0;
            cbxActiveFilter.SelectedIndex = 0;
            cbxInstructorFilter.SelectedIndex = 0;
            cbxSABookFilter.SelectedIndex = 0;
            cbxJAPBookFilter.SelectedIndex = 0;
            cbxRatification.SelectedIndex = 0;

            cbxDojoFilter.DataSource = dis.DojoNames();
            cbxCategoryFilter.DataSource = dis.CategoryNames();
            cbxMinAge.DataSource = dis.AddNumbers();
            cbxMaxAge.DataSource = dis.AddNumbers();
            cbxBelt.DataSource = dis.BeltNames();
            pnlRatification.Visible = false;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }    

        private void lvQual_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+290, e.Y + ((Control)sender).Top));
                objActiveView = ObjectType.qualification;
            }
        }

        private void msiAdd_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member");
            }
            else
            {
                switch (objActiveView)
                {
                    case ObjectType.events:                       
                        frmAddMemberEvent frme = new frmAddMemberEvent((StaticBindingSource.source.Current as Member));
                        frme.Show();
                        break;
                    case ObjectType.achievement:
                        List<string> litemsa = new List<string>();
                        foreach (ListViewItem item in lvAchievement.Items)
                        {
                            litemsa.Add(item.SubItems[0].Text);
                        }
                        frmAddMemberAchievement frma = new frmAddMemberAchievement(this, litemsa, (StaticBindingSource.source.Current as Member));
                        frma.Show();
                        break;
                    case ObjectType.grading:
                        List<string> litemsg = new List<string>();
                        foreach (ListViewItem item in lvGrading.Items)
                        {
                            litemsg.Add($"{item.SubItems[0].Text}, {item.SubItems[1].Text}");
                        }
                        frmAddMemberGrading frmg = new frmAddMemberGrading(this, litemsg, (StaticBindingSource.source.Current as Member));
                        frmg.Show();
                        break;
                    case ObjectType.qualification:
                        List<string> litemsq = new List<string>();
                        foreach (ListViewItem item in lvQual.Items)
                        {
                            litemsq.Add(item.SubItems[0].Text);
                        }
                        frmAddMemberQualification frmq = new frmAddMemberQualification(this, litemsq, (StaticBindingSource.source.Current as Member));
                        frmq.Show();
                        break;
                    default:
                        break;
                }
                this.Enabled = false;
            }
        }
        private void msiRemove_Click(object sender, EventArgs e)
        {
            dis.MemberListViews(lvQual,lvEvent,lvGrading,lvAchievement,objActiveView, StaticBindingSource.source.Current as Member);                
        }

        private void lvEvent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+730, e.Y + ((Control)sender).Top));
                objActiveView = ObjectType.events;
            }
        }

        private void lvAchievement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+280, e.Y+100 + ((Control)sender).Top + 160));
                objActiveView = ObjectType.achievement;
            }
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvGrading_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+730, e.Y + ((Control)sender).Top+260));
                objActiveView = ObjectType.grading;
            }
        }

        private void tsmSort_Click(object sender, EventArgs e)
        {
            tsmcbxSort.SelectedIndex = 0;
        }

        private void tsmbtnASC_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            StaticBindingSource.source.DataSource = mem.SortTable(ObjectType.member, tsmcbxSort.Text, "ASC");
            dgvMember.DataSource = StaticBindingSource.source;

            if (dgvMember.Rows.Count==0)
            {
                lvAchievement.Items.Clear();
                lvEvent.Items.Clear();
                lvGrading.Items.Clear();
                lvQual.Items.Clear();
            }
        }

        private void tsmbtnDESC_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            StaticBindingSource.source.DataSource = mem.SortTable(ObjectType.member, tsmcbxSort.Text, "DESC");
            dgvMember.DataSource = StaticBindingSource.source;

            if (dgvMember.Rows.Count == 0)
            {
                lvAchievement.Items.Clear();
                lvEvent.Items.Clear();
                lvGrading.Items.Clear();
                lvQual.Items.Clear();
            }
        }

        private void dgvMember_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmcbxSort.ToolTipText = "Please select a column to sort by.";
                cmsMemberSort.Show(this, new Point(e.X + ((Control)sender).Left + 1170, e.Y + ((Control)sender).Top-5));
            }
        }

        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            if (StaticBindingSource.source.Count!=0)
            {
                Member mem = StaticBindingSource.source.Current as Member;
                lblname.Text = mem.MemberFirstName;
                lblLastName.Text = mem.MemberLastName;
                lblDojo.Text = mem.GetDojoName();
                lblCat.Text = mem.GetCatDescr();
                lblDOB.Text = mem.getAge().ToString();
                dis.populateListViews(lvQual, lvEvent, lvGrading, lvAchievement, lblBelt);
                dis.RatificationInfo(mem.MemberID,lblSARatDate,lblJAPRatDate);
                pictures pic = new pictures();
                pic.loadPic(pbxMemberPhoto,mem);               
            }
            else
            {
                lvQual.Items.Clear();
                lvEvent.Items.Clear();
                lvGrading.Items.Clear();
                lvAchievement.Items.Clear();
                lblBelt.Text = "";
            }            
        }

        private void btnShowHideFilter_Click(object sender, EventArgs e)
        {
            if (pnlMemberFilter.Visible)
            {
                pnlMemberFilter.Visible = false;
                btnShowHideFilter.Text = "Show Filters";
            }
            else
            {
                pnlMemberFilter.Visible = true;
                btnShowHideFilter.Text = "Hide Filters";
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbxRatification.SelectedIndex = 0;
            cbxCategoryFilter.SelectedIndex = 0;
            cbxCityFilter.SelectedIndex = 0;
            cbxCountryFilter.SelectedIndex = 0;
            cbxDojoFilter.SelectedIndex = 0;
            cbxGenderFilter.SelectedIndex = 0;
            cbxMaxAge.SelectedIndex = 0;
            cbxMinAge.SelectedIndex = 0;
            cbxProvinceFilter.SelectedIndex = 0;
            cbxSuburbFilter.SelectedIndex = 0;
            cbxActiveFilter.SelectedIndex=0;
            cbxInstructorFilter.SelectedIndex = 0;
            cbxJAPBookFilter.SelectedIndex = 0;
            cbxSABookFilter.SelectedIndex = 0;
            StaticBindingSource.source.DataSource = Mem.GetMember();
            dgvMember.DataSource = StaticBindingSource.source;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = Mem.filterMembers(cbxSuburbFilter.Text,cbxCityFilter.Text,cbxProvinceFilter.Text,cbxCountryFilter.Text,cbxMinAge.Text,cbxMaxAge.Text,cbxActiveFilter.Text,cbxInstructorFilter.Text,cbxJAPBookFilter.Text,cbxSABookFilter.Text,cbxDojoFilter.Text,cbxCategoryFilter.Text,cbxGenderFilter.Text,cbxRatification.Text);
            dgvMember.DataSource = StaticBindingSource.source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource= Mem.Search(txtSearchComp.Text);
            dgvMember.DataSource = StaticBindingSource.source;
        }

        private void frmMember_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                //Info on form
                StaticBindingSource.source.DataSource = Mem.GetMember();
                dgvMember.DataSource = StaticBindingSource.source;

                //filter           
                List<string>[] laddress = dis.populateAddressFilter();
                cbxSuburbFilter.DataSource = laddress[0];
                cbxCityFilter.DataSource = laddress[1];
                cbxProvinceFilter.DataSource = laddress[2];
                cbxCountryFilter.DataSource = laddress[3];

                cbxGenderFilter.SelectedIndex = 0;
                cbxActiveFilter.SelectedIndex = 0;
                cbxInstructorFilter.SelectedIndex = 0;
                cbxSABookFilter.SelectedIndex = 0;
                cbxJAPBookFilter.SelectedIndex = 0;

                cbxDojoFilter.DataSource = dis.DojoNames();
                cbxCategoryFilter.DataSource = dis.CategoryNames();
                cbxMinAge.DataSource = dis.AddNumbers();
                cbxMaxAge.DataSource = dis.AddNumbers();
            }           
        }

        private void frmMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void btnShowHideListViews_Click(object sender, EventArgs e)
        {
            if (pnlListViews.Visible)
            {
                pnlListViews.Visible = false;
                btnShowHideListViews.Text = "Show Extra Information";
            }
            else
            {
                pnlListViews.Visible = true;
                btnShowHideListViews.Text = "Hide Extra Information";
            }
        }

        private void pnlListViews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pnlRatification.Visible)
            {
                
                pnlRatification.Visible = true;
                btnShowHideRat.Text = "Show Member Information";
            }
            else
            {
                
                pnlRatification.Visible = false;
                btnShowHideRat.Text = "Show Ratification Information";
            }           
        }
    }
}
