using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.DataLayer;
using System.Data;

namespace JKSApp.BusinessLayer
{
    class Grading:table
    {
        int gradingID;
        string gradingDescription;
        DateTime gradingDate;
        public Grading()
        {
            
        }

        public Grading(int gradingID, string gradingDescription, DateTime gradingDate)
        {
            this.GradingID = gradingID;
            this.GradingDescription = gradingDescription;
            this.GradingDate = gradingDate;
        }

        public int GradingID { get => gradingID; set => gradingID = value; }
        public string GradingDescription { get => gradingDescription; set => gradingDescription = value; }
        public DateTime GradingDate { get => gradingDate; set => gradingDate = value; }

        public List<Grading> getGrading()
        {
            DataHandler dh = new DataHandler();
            List<Grading> lgrade = new List<Grading>();
            foreach (Grading grade in dh.GetAll(ObjectType.grading))
            {
                lgrade.Add(grade);
            }
            return lgrade;
        }
        public DataTable getGradingMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.GradingMembers(GradingID.ToString());
        }

        public override void openInsertForm(CU op)
        {
            Presentation_Layer.frmCreateGrading frmGrad = new Presentation_Layer.frmCreateGrading(op);
            frmGrad.Show();
        }

        public override void openUpdateForm(Object obj)
        {
            Presentation_Layer.frmCreateGrading frmGrad = new Presentation_Layer.frmCreateGrading(CU.Update,obj);
            frmGrad.Show();
        }
        public bool InsertGrading()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Grading(GradingDescription,GradingDate)", $"'{GradingDescription}','{GradingDate}'"))
            {
                MessageBox.Show("Successfully added Grading");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }
        }
        public bool updateGrading()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Grading", $"GradingDescription='{GradingDescription}',GradingDate='{GradingDate}'", GradingID.ToString()))
            {
                MessageBox.Show("Grading Updated Successfully");
                return true;
            }
            else return false;
        }

        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {GradingDescription} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("GradingInformation", $"GradingID={GradingID}") && dh.DeleteItem("Grading", $"GradingID={GradingID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }
        }
    }
}
