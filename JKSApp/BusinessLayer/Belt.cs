using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Windows.Forms;
using JKSApp.Presentation_Layer;

namespace JKSApp.BusinessLayer
{
    class Belt: table
    {
        int beltID;
        string beltName;

        public Belt()
        {
        }

        public Belt(int beltID, string beltName)
        {
            this.BeltID = beltID;
            this.BeltName = beltName;
        }

        public int BeltID { get => beltID; set => beltID = value; }
        public string BeltName { get => beltName; set => beltName = value; }

        public List<Belt> getAll()
        {
            DataHandler dh = new DataHandler();
            List<Belt> lbelt = new List<Belt>();
            foreach (Belt belt in dh.GetAll(ObjectType.belt))
            {
                lbelt.Add(belt);
            }

            return lbelt;
        }

        public List<Belt> Search(string srch)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            List<Belt> lbelt = new List<Belt>();
            foreach (Belt belt in databaseOperation.search("Belt", $"BeltName", $"'%{srch}%'", ObjectType.belt))
            {
                lbelt.Add(belt);
            }

            return lbelt;
        }

        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {BeltName} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("Belt", $"BeltID={BeltID}"))
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
            frmCreateBelt frmCreateBelt = new frmCreateBelt(CU.Insert);
            frmCreateBelt.Show();
        }
        public override void openUpdateForm(object obj)
        {
            frmCreateBelt frmCreateBelt = new frmCreateBelt(CU.Update);
            frmCreateBelt.Show();
        }
        public bool insertBelt()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Belt(BeltName)", $"'{BeltName}'"))
            {
                MessageBox.Show("operation Successful");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }

        }
        public bool updateBelt()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Belt", $"BeltName='{BeltName}'", BeltID.ToString()))
            {
                MessageBox.Show("operation Successful");
                return true;
            }
            else return false;
        }
        public int getNextBeltID()
        {          
            List<int> lint = new List<int>();
            foreach (Belt item in getAll())
            {
                lint.Add(item.BeltID);
            }
            lint.Sort();
            return lint[lint.Count];
        }
    }
}
