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
                dtpEventDate.Value = eve.EventDate;
            }           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {             
                Event ev = new Event(0, txtEventName.Text,Convert.ToDateTime(dtpEventDate.Value.ToString("yyyy/MM/dd")));
                MessageBox.Show(ev.EventDate.ToString());
                if (ev.InsertEvent()) Close();                                
            }
            else
            {
                eve.EventDate = Convert.ToDateTime(dtpEventDate.Value.ToString("yyyy/MM/dd"));
                eve.EventDescription = txtEventName.Text;              
                if (eve.updateEvent())
                {
                    Close();
                }
            }
        }
    }
}
