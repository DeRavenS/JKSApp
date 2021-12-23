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
    public partial class frmCreateDojo : Form
    {
        CU operation;
        Dojo doj = null;
        public frmCreateDojo(CU op)
        {
            InitializeComponent();
            operation = op;
        }
        public frmCreateDojo(CU op,Object dojo)
        {
            InitializeComponent();
            operation = op;
            doj = dojo as Dojo;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (operation==CU.Insert)
            {
                Dojo dojo = new Dojo(txtName.Text, txtStreet.Text, txtSubUrb.Text, txtCity.Text, txtProvince.Text, txtCountry.Text, true);
                if (dojo.insertDojo())
                {                   
                    Close();
                }
            }
            else
            {
                doj.City = txtCity.Text;
                doj.Country=txtCountry.Text;
                doj.Name = txtName.Text;
                doj.Province=txtProvince.Text ;
                doj.Street =txtStreet.Text;
                doj.Suburb =txtSubUrb.Text;
                if (doj.updateDojo())
                {
                    Close();
                }
                
            }
            
        }

        private void frmCreateDojo_Load(object sender, EventArgs e)
        {
            if (doj!=null)
            {
                txtCity.Text = doj.City;
                txtCountry.Text = doj.Country;
                txtName.Text = doj.Name;
                txtProvince.Text = doj.Province;
                txtStreet.Text = doj.Street;
                txtSubUrb.Text = doj.Suburb;              
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {          
            Close();
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
