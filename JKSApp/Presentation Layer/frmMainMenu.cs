using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.Presentation_Layer;
using JKSApp.BusinessLayer;

namespace JKSApp.Presentation_Layer
{
    
    
    public partial class frmMainMenu : Form
    {
        
        ComponentController cc = new ComponentController();
        table tbl;       
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmEvent(), pnlSubForms, btnEvent);
            tbl = new Event();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnDojo_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmDojo(), pnlSubForms, btnDojo);
            tbl = new Dojo();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmMember(), pnlSubForms, btnMember);
            tbl = new Member();
        }

        private void btnAffilliation_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmAffiliation(), pnlSubForms, btnAffilliation);
        }

        private void btnBelt_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmBelt(), pnlSubForms, btnBelt);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmCategory(), pnlSubForms, btnCategory);
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmGrading(), pnlSubForms,btnGrading);
            tbl = new Grading();
        }

        private void btnAchievement_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmAchievement(),pnlSubForms,btnAchievement);
            tbl = new Achievement();
        }

        private void btnQualification_Click(object sender, EventArgs e)
        {
            cc.GetForm(new frmQualification(), pnlSubForms,btnQualification);
            tbl = new Qualification();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tbl.openInsertForm(CU.Insert);
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbl.openUpdateForm(StaticBindingSource.source.Current);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            table deltbl = StaticBindingSource.source.Current as table;
            deltbl.DeleteItem();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
        }
    }
}
