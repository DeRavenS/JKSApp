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
    public partial class frmCreateEvent : Form
    {
        CU operation;
        Event eve = null;
        public frmCreateEvent(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateEvent(CU op,Object ev)
        {
            InitializeComponent();
            operation = op;
            eve = ev as Event;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCreateEvent_Load(object sender, EventArgs e)
        {
            if (operation!=CU.Insert)
            {
                txtEventName.Text = eve.EventDescription;
            }           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {             
                Event ev = new Event(0, txtEventName.Text);
                
                if (ev.InsertEvent()) Close();                                
            }
            else
            {                
                eve.EventDescription = txtEventName.Text;              
                if (eve.updateEvent())
                {
                    Close();
                }
            }
        }

        private void frmCreateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentController.activeForm.Enabled = true;
        }
    }
}
