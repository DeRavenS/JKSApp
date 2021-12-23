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
    public partial class frmCreateMember : Form
    {
        CU operation;
        List<int> ldojoID = new List<int>();
        Member member = null;
        public frmCreateMember(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateMember(CU op,Object obj)
        {
            InitializeComponent();
            operation = op;
            member = obj as Member;
        }

        private void frmCreateMember_Load(object sender, EventArgs e)
        {
            Dojo doj = new Dojo();
            foreach (Dojo dojo in doj.getDojo())
            {
                cbxDojo.Items.Add(dojo.Name);
                ldojoID.Add(dojo.DojoID);
            }
            if (member!=null)
            {
                txtCertificateNumber.Text = member.CertificateNumber;
                txtCity.Text = member.MemberCity;
                txtCountry.Text = member.MemberCountry;
                txtEmail.Text = member.MemberEmail;
                txtIDnum.Text = member.MemberIDNumber;
                txtJAPAffiliation.Text = member.JAPAfilliationNumber;
                txtLastName.Text = member.MemberLastName;
                txtName.Text = member.MemberFirstName;
                txtPhone.Text = member.MemberPhone;
                txtProvince.Text = member.MemberProvince;
                txtSAAffiliation.Text = member.SAAfilliationNumber;
                txtStreet.Text = member.MemberStreet;
                txtSubUrb.Text = member.MemberSuburb;
                ckbxInstructor.Checked = member.Instructor;
                ckbxJAPBook.Checked = member.JAPBook;
                ckbxSABook.Checked = member.SABook;
                ckbx.Checked = member.Active;
                dtpDOB.Value = member.DOB;
                cbxDojo.SelectedIndex = cbxDojo.Items.IndexOf(member.GetDojoName());
                cbxGender.SelectedIndex = cbxGender.Items.IndexOf(member.MemberGender);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {
                Member mem = new Member(0,ldojoID[cbxDojo.SelectedIndex],1,txtSAAffiliation.Text,txtJAPAffiliation.Text,txtName.Text,txtLastName.Text,txtPhone.Text,txtEmail.Text,txtStreet.Text,txtSubUrb.Text,txtCity.Text,txtProvince.Text,txtCountry.Text,cbxGender.Text,txtIDnum.Text,txtCertificateNumber.Text,ckbx.Checked,ckbxInstructor.Checked,ckbxJAPBook.Checked,ckbxSABook.Checked,Convert.ToDateTime(dtpDOB.Value.ToString("yyyy/MM/dd")));
                if (mem.InsertMember()) Close();
            }
            else
            {
                member.CertificateNumber = txtCertificateNumber.Text ;
                member.MemberCity = txtCity.Text;
                member.MemberCountry = txtCountry.Text;
                member.MemberEmail = txtEmail.Text;
                member.MemberIDNumber = txtIDnum.Text;
                member.JAPAfilliationNumber = txtJAPAffiliation.Text;
                member.MemberLastName = txtLastName.Text;
                member.MemberFirstName = txtName.Text;
                member.MemberPhone = txtPhone.Text;
                member.MemberProvince = txtProvince.Text;
                member.SAAfilliationNumber = txtSAAffiliation.Text;
                member.MemberStreet = txtStreet.Text;
                member.MemberSuburb = txtSubUrb.Text;
                member.Instructor = ckbxInstructor.Checked;
                member.JAPBook = ckbxJAPBook.Checked;
                member.SABook = ckbxSABook.Checked;
                member.Active = ckbx.Checked;
                member.DOB= dtpDOB.Value;
                member.DojoID= ldojoID[cbxDojo.SelectedIndex];
                member.MemberGender = cbxGender.Text;
                if (member.updateMember())
                {
                    Close();
                }
            }
        }
    }
}
