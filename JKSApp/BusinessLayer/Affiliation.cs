using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Data;
using System.Windows.Forms;
using JKSApp.Presentation_Layer;

namespace JKSApp.BusinessLayer
{
    class Affiliation: table
    {
        int affiliationID;
        string affiliationDescription;

        public Affiliation()
        {
        }

        public Affiliation(int affiliationID, string affiliationDescription)
        {
            this.affiliationID = affiliationID;
            this.affiliationDescription = affiliationDescription;
        }

        public int AffiliationID { get => affiliationID; set => affiliationID = value; }
        public string AffiliationDescription { get => affiliationDescription; set => affiliationDescription = value; }

        public List<object> getAll()
        {
            DataHandler dh = new DataHandler();
            return dh.GetAll(ObjectType.affiliation);
        }

        public bool InsertAffiliation()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Affiliation(AffiliationDescription)", $"'{AffiliationDescription}'"))
            {
                MessageBox.Show("Successfully added affiliation");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }
        }
        public bool InsertMemberAffiliation(ListView lvMembers,DateTimePicker dtpAffiliation)
        {        
            foreach (ListViewItem item in lvMembers.SelectedItems)
            {
                DataHandler dh = new DataHandler();
                string memberID = item.SubItems[0].Text;
                DateTime affiliationdate=dtpAffiliation.Value;
                if (!dh.InsertItem("MemberAffiliation(AffiliationID,MemberID,AffiliationDate)", $"{AffiliationID},{memberID},'{affiliationdate.ToString("yyyy/MM/dd")}'"))
                {              
                    MessageBox.Show("Operation Failed");
                    return false;
                }
            }
            MessageBox.Show("Successfully added records");
            return true;           
        }
        public bool updateAffiliation()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Affiliation", $"AffiliationDescription='{AffiliationDescription}'", AffiliationID.ToString()))
            {
                MessageBox.Show("Update Successful");
                return true;
            }
            else return false;
        }
        public DataTable getAffiliationMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.AffiliationMembers(AffiliationID.ToString());
        }
        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {AffiliationDescription} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("Affiliation",$"AffiliationID={AffiliationID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }
        }

        public override void openInsertForm(CU op)
        {
            frmCreateAffiliation frm = new frmCreateAffiliation(CU.Insert);
            frm.Show();
            ComponentController.activeForm.Enabled = false;
        }

        public override void openUpdateForm(object obj)
        {
            frmCreateAffiliation frm = new frmCreateAffiliation(CU.Update);
            frm.Show();
            ComponentController.activeForm.Enabled = false;
        }
    }
}
