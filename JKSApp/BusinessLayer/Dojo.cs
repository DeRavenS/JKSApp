using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using JKSApp.Presentation_Layer;
using System.Windows.Forms;
using System.Data;

namespace JKSApp.BusinessLayer
{
    class Dojo:table
    {
        DatabaseOperation operation = new DatabaseOperation();
        DataHandler dh = new DataHandler();
        int dojoID;
        string name, street, suburb, city, province, country;
        bool active;

        public Dojo()
        {
        }

        public Dojo(string name, string street, string suburb, string city, string province, string country, bool active)
        {
            this.Name = name;
            this.Street = street;
            this.Suburb = suburb;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.Active = active;
        }

        public Dojo(int dojoID, string name, string street, string suburb, string city, string province, string country, bool active)
        {
            this.dojoID = dojoID;
            this.name = name;
            this.street = street;
            this.suburb = suburb;
            this.city = city;
            this.province = province;
            this.country = country;
            this.active = active;
        }

        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }
        public bool Active { get => active; set => active = value; }
        public int DojoID { get => dojoID; set => dojoID = value; }

        public bool insertDojo()
        {
            if (operation.InsertData("Dojo(DojoName,DojoStreet,DojoSuburb,DojoCity,DojoProvince,DojoCountry,Active)", $"'{Name}','{Street}','{Suburb}','{City}','{Province}','{Country}',{active}"))
            {
                MessageBox.Show("Insert Succesful");
                return true;
            }
            else return false;
        }
        public bool updateDojo()
        {
            if (dh.UpdateItem("Dojo", $"DojoName='{Name}',DojoStreet='{Street}',DojoSuburb='{Suburb}',DojoCity='{City}',DojoProvince='{Province}',DojoCountry='{Country}',Active={active}",DojoID.ToString()))
            {
                MessageBox.Show("Update Succesful");
                return true;
            }
            else return false;
        }


        public List<Dojo> getDojo()
        {

            List<Dojo> ldojo = new List<Dojo>();
            foreach (var item in dh.GetAll(ObjectType.dojo))
            {
                ldojo.Add(item as Dojo);
            }
            return ldojo;
        }

        public DataTable getDojoMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.DojoMembers(DojoID.ToString());
        }

        public override void openInsertForm(CU op)
        {
            frmCreateDojo frmaddDojo = new frmCreateDojo(CU.Insert);
            frmaddDojo.Show();
        }

        public override void openUpdateForm(Object obj)
        {
            frmCreateDojo frmaddDojo = new frmCreateDojo(CU.Update,obj);
            frmaddDojo.Show();
        }
        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {Name} and all its associated entries and members from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("Member", $"DojoID={DojoID}") && dh.DeleteItem("Dojo", $"DojoID={DojoID}"))
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
