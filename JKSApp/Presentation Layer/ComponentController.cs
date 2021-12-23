using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using JKSApp.DataLayer;
using JKSApp.Presentation_Layer;
using System.Data;

namespace JKSApp.BusinessLayer
{
    class ComponentController
    {
        public Form activeForm = new Form();
        public static Button activeButton;
        public void GetForm(Form frm, Panel pnl,Button btn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (activeButton != null)
            {
                activeButton.BackColor = activeButton.Parent.BackColor;
            }
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnl.Controls.Add(frm);
            frm.Show();
            activeForm = frm;
            activeButton = btn;
            activeButton.BackColor = activeButton.FlatAppearance.MouseOverBackColor;
        }
    }
}
