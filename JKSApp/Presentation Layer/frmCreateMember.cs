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
    public partial class frmCreateMember : Form
    {
        CU operation;
        List<int> ldojoID = new List<int>();
        Member member = null;
        string photoPath;
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
            txtSAAffiliation.ReadOnly = true;
            pnlRatiication.Visible = false;
            Display dis = new Display();
            Dojo doj = new Dojo();
            foreach (Dojo dojo in doj.getDojo())
            {
                cbxDojo.Items.Add(dojo.Name);
                cbxBelts.DataSource = dis.BeltNames();
                ldojoID.Add(dojo.DojoID);
            }
            if (member != null)
            {
                cbxBelts.DataSource = dis.BeltNames();
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
                photoPath = member.MemberPhoto;
                try
                {
                    pictures pic = new pictures();
                    pic.loadPic(pbxMemberPhoto, member);
                }
                catch (Exception)
                {
                }

                if (member.getRatificationDetails() == null)
                {
                    ckbxRatification.Checked = false;
                }
                else
                {
                    ckbxRatification.Checked = true;
                    Ratification rat = member.getRatificationDetails();
                    dtpJAPRatDate.Value = rat.JAPDate;
                    dtpSARatDate.Value = rat.SADate;
                }
            }
            else
            {
                Member mem = new Member();
                txtSAAffiliation.Text = mem.getSAAffiliationNumber();
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
                pictures pic = new pictures();
                Member mems = new Member();                               
                Member mem = new Member(0, ldojoID[cbxDojo.SelectedIndex], txtSAAffiliation.Text, txtJAPAffiliation.Text, txtName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, txtStreet.Text, txtSubUrb.Text, txtCity.Text, txtProvince.Text, txtCountry.Text, cbxGender.Text, txtIDnum.Text, mems.getSAAffiliationNumber(), ckbx.Checked, ckbxInstructor.Checked, ckbxJAPBook.Checked, ckbxSABook.Checked, Convert.ToDateTime(dtpDOB.Value.ToString("yyyy/MM/dd")),pic.picName(photoPath),member.GetBeltID(cbxBelts.Text));
                if (mem.InsertMember())
                {
                    pic.SavePhoto(photoPath);
                    Ratification rat = new Ratification();
                    if (ckbxRatification.Checked)
                    {
                        rat.insertRatification(dtpSARatDate.Value, dtpJAPRatDate.Value, member.MemberID);
                    }                 
                    Close();
                }                   
            }
            else
            {
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
                pictures pic = new pictures();
                member.MemberPhoto = pic.picName(photoPath);
                if (member.updateMember())
                {
                    pic.SavePhoto(photoPath);
                    //add code to see if Rat changed
                    Ratification rat = new Ratification();
                    if (ckbxRatification.Checked==false)
                    {                        
                        rat.deleteRatification(member.MemberID.ToString());
                    }
                    else
                    {
                        rat.insertRatification(dtpSARatDate.Value,dtpJAPRatDate.Value,member.MemberID);
                    }
                    Close();
                }
            }
        }

        private void frmCreateMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }

        private void ckbxRatification_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxRatification.Checked)
            {
                pnlRatiication.Visible = true;
            }
            else pnlRatiication.Visible = false;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            pictures pic = new pictures();
            photoPath = pic.UploadPhoto();
            if (photoPath != null)
            {
                Image image = Image.FromFile(photoPath);
                pbxMemberPhoto.Image = image;
            }           
        }
    }
}
