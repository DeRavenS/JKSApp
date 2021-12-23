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
    public partial class frmAddMemberEvent : Form
    {
        frmMember frmMember = new frmMember();
        Event ev = new Event();
        List<string> l = new List<string>();
        List<string[]> larray = new List<string[]>();
        Member mem = new Member();
        public frmAddMemberEvent(frmMember frmmember, List<string[]> litems, Object m)
        {
            InitializeComponent();
            frmMember = frmmember;
            larray = litems;
            mem = m as Member;
        }

        private void frmAddMemberEvent_Load(object sender, EventArgs e)
        {          
            foreach (Event item in ev.getEvents())
            {
                if (!l.Contains(item.EventDescription))
                {
                    cbxEvents.Items.Add($"{item.EventDescription}, {item.EventDate.ToString("yyyy/MM/dd")}");
                }
            }
        }

        private void frmAddMemberEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMember.Enabled = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbxEvents.SelectedItems.Count != 0)
            {
                cbxEvents.Items.Add(lbxEvents.SelectedItem);
                lbxEvents.Items.Remove(lbxEvents.SelectedItem);
            }
            else MessageBox.Show("Please select Item to remove");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxEvents.Items.Count != 0)
            {
                lbxEvents.Items.Add(cbxEvents.Text);
                cbxEvents.Items.RemoveAt(cbxEvents.SelectedIndex);
            }
            if (cbxEvents.Items.Count==0)
            {
                cbxEvents.Text = "";
            }
            cbxEvents.SelectedIndex = -1;
        }

        private void lbxEvents_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsRemoveEvents.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top));
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Event item in ev.getEvents())
            {
                if (lbxEvents.Items.Contains($"{item.EventDescription}, {item.EventDate.ToString("yyyy/MM/dd")}"))
                {                                  
                    mem.InsertMemberItem(ObjectType.events, item.EventID.ToString());
                }

            }
            MessageBox.Show("Insert Successful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
