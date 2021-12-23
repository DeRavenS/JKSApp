using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace JKSApp.BusinessLayer
{
    class Qualification:table
    {
        int qualificationID;
        string qualificationDescription;

        public Qualification()
        {
        }

        public Qualification(int qualificationID, string qualificationDescription)
        {
            this.QualificationID = qualificationID;
            this.QualificationDescription = qualificationDescription;
        }

        public int QualificationID { get => qualificationID; set => qualificationID = value; }
        public string QualificationDescription { get => qualificationDescription; set => qualificationDescription = value; }

        public List<Qualification> getAll()
        {
            DataHandler dh = new DataHandler();
            List<Qualification> lqual = new List<Qualification>();
            foreach (Qualification qual in dh.GetAll(ObjectType.qualification))
            {
                lqual.Add(qual);
            }

            return lqual;
        }
        public DataTable getQualificationMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.QualificationMembers(QualificationID.ToString());
        }
        public string Insert(string values)
        {
            DatabaseOperation dbo = new DatabaseOperation();
            
            if (dbo.InsertData("Qualification(QualificationDescription)", values))
            {
                return "Insert Successful";
            }
                
            return "Insert Failed";
            
        }

        public override void openInsertForm(CU op)
        {
            Presentation_Layer.frmCreateQualification frmQual = new Presentation_Layer.frmCreateQualification(op);
            frmQual.Show();
        }
        public override void openUpdateForm(Object obj)
        {
            Presentation_Layer.frmCreateQualification frmQual = new Presentation_Layer.frmCreateQualification(CU.Update,obj);
            frmQual.Show();
        }

        public bool InsertQualification()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Qualification(QualificationDescription)", $"'{QualificationDescription}'"))
            {
                MessageBox.Show("Successfully added Qualification");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }

        }
        public bool updateQualification ()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Qualification", $"QualificationDescription='{QualificationDescription}'", QualificationID.ToString()))
            {
                MessageBox.Show("Update Successful");
                return true;
            }
            else return false;
        }
        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {QualificationDescription} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("MemberQualification", $"QualificationID={QualificationID}") && dh.DeleteItem("Qualification", $"QualificationID={QualificationID}"))
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
