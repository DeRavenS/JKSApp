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
        Event ev = new Event();
        Member mem = new Member();
        public frmAddMemberEvent(Object m)
        {
            InitializeComponent();
            mem = m as Member;
        }

        private void frmAddMemberEvent_Load(object sender, EventArgs e)
        {           
            foreach (Event item in ev.getEvents())
            {
                cbxEvents.Items.Add($"{item.EventDescription}");               
            }
        }

        private void frmAddMemberEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
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
                if (cbxEvents.Text == $"{item.EventDescription}")
                {
                    mem.InsertMemberItem(ObjectType.events, $"{item.EventID},{dtpEvent.Value.ToString("yyyy,MM,dd")}");
                    break;
                }
            }
            MessageBox.Show("Insert Successful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
