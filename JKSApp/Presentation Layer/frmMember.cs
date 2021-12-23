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
        Member Mem = new Member();
        Display dis = new Display();
        ObjectType objActiveView;
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = Mem.GetMember();
            dgvMember.DataSource = StaticBindingSource.source;
            
            
            for (int i = 0; i < dgvMember.Columns.Count; i++)
            {
                dgvMember.Columns[i].Visible = false;
            }
            dgvMember.Columns["MemberID"].Visible = true;
            dgvMember.Columns["MemberFirstName"].Visible = true;
            dgvMember.Columns["MemberLastName"].Visible = true;

            Member mem = StaticBindingSource.source.Current as Member;
            lblname.Text = mem.MemberFirstName;
            lblLastName.Text = mem.MemberLastName;
            lblIDNum.Text = mem.MemberIDNumber;
            lblDojo.Text = mem.GetDojoName();
            lblCat.Text = mem.GetCatDescr();
            lblCertificateNumber.Text = mem.CertificateNumber;
            lblDOB.Text = mem.DOB.ToString("yyyy/MM/dd");
            lblGender.Text = mem.MemberGender;
            dis.populateListViews(lvQual, lvEvent, lvGrading, lvAchievement, lblBelt);
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            Close();
        }

        private void btnDisplayAllMember_Click(object sender, EventArgs e)
        {
            StaticBindingSource.source.DataSource = Mem.GetMember();
            dgvMember.DataSource = StaticBindingSource.source;
            dis.RefreshDVG(dgvMember, StaticBindingSource.source);
        }

        

        private void dgvMember_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Member mem = StaticBindingSource.source.Current as Member;
            lblname.Text = mem.MemberFirstName;
            lblLastName.Text = mem.MemberLastName;
            lblIDNum.Text = mem.MemberIDNumber;
            lblDojo.Text = mem.GetDojoName();
            lblCat.Text = mem.GetCatDescr();
            lblCertificateNumber.Text = mem.CertificateNumber;
            lblDOB.Text = mem.DOB.ToString("yyyy/MM/dd");
            lblGender.Text = mem.MemberGender;
            dis.populateListViews(lvQual, lvEvent, lvGrading, lvAchievement, lblBelt);
        }

        private void lvQual_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));
                objActiveView = ObjectType.qualification;
            }
        }

        private void msiAdd_Click(object sender, EventArgs e)
        {
            switch (objActiveView)
            {
                case ObjectType.events:
                    List<string[]> litemse = new List<string[]>();
                    foreach (ListViewItem item in lvEvent.Items)
                    {
                        string[] arritems = new string[2] { item.SubItems[0].Text, item.SubItems[2].Text};                       
                        litemse.Add(arritems);
                    }
                    frmAddMemberEvent frme = new frmAddMemberEvent(this, litemse, (StaticBindingSource.source.Current as Member));
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
                    frmAddMemberQualification frmq = new frmAddMemberQualification(this,litemsq,(StaticBindingSource.source.Current as Member));
                    frmq.Show();                 
                    break;
                default:
                    break;
            }
            this.Enabled = false;
        }

        private void msiRemove_Click(object sender, EventArgs e)
        {
            dis.MemberListViews(lvQual,lvEvent,lvGrading,lvAchievement,objActiveView, StaticBindingSource.source.Current as Member);                
        }

        private void lvEvent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+440, e.Y + ((Control)sender).Top));
                objActiveView = ObjectType.events;
            }
        }

        private void lvAchievement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left, e.Y+100 + ((Control)sender).Top + 160));
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
                cmsMember.Show(this, new Point(e.X + ((Control)sender).Left+440, e.Y + ((Control)sender).Top+260));
                objActiveView = ObjectType.grading;
            }
        }
    }
}
