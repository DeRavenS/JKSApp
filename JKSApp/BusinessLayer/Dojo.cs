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
        string phone, email;

        public Dojo()
        {
        }

        public Dojo(string name, string street, string suburb, string city, string province, string country, bool active,string phone, string email)
        {
            this.Name = name;
            this.Street = street;
            this.Suburb = suburb;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.Active = active;
            Phone = phone;
            Email = email;
        }

        public Dojo(int dojoID, string name, string street, string suburb, string city, string province, string country, bool active, string phone, string email)
        {
            this.dojoID = dojoID;
            this.name = name;
            this.street = street;
            this.suburb = suburb;
            this.city = city;
            this.province = province;
            this.country = country;
            this.active = active;
            Phone = phone;
            Email = email;
        }

        public string Name { get => name; set => name = value;}
        public string Street { get => street; set => street = value;}
        public string Suburb { get => suburb; set => suburb = value;}
        public string City { get => city; set => city = value;}
        public string Province { get => province; set => province = value;}
        public string Country { get => country; set => country = value;}
        public bool Active { get => active; set => active = value;}
        public int DojoID { get => dojoID; set => dojoID = value;}
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public bool insertDojo()
        {
            if (operation.InsertData("Dojo(DojoName,DojoStreet,DojoSuburb,DojoCity,DojoProvince,DojoCountry,DojoPhone,DojoEMail,Active)", $"'{Name}','{Street}','{Suburb}','{City}','{Province}','{Country}','{Phone}','{Email}',{active}"))
            {
                MessageBox.Show("Insert Succesful");
                return true;
            }
            else return false;
        }
        public bool updateDojo()
        {
            if (dh.UpdateItem("Dojo", $"DojoName='{Name}',DojoStreet='{Street}',DojoSuburb='{Suburb}',DojoCity='{City}',DojoProvince='{Province}',DojoCountry='{Country}',DojoPhone='{Phone}',DojoEMail='{Email}',Active={active}",DojoID.ToString()))
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

        public List<Dojo> filterDojo(string suburb, string city, string province, string country, string minstud, string maxstud, string active)
        {          
            //Filtering
            List<Dojo> ldojoFilter = new List<Dojo>();
            foreach (Dojo item in getDojo())
            {
                if (suburb != "Any")
                {
                    if (item.Suburb != suburb)
                    {
                        continue;
                    }
                }
                if (city != "Any")
                {
                    if (item.City != city)
                    {
                        continue;
                    }
                }
                if (province != "Any")
                {
                    if (item.Province != province)
                    {
                        continue;
                    }
                }
                if (country != "Any")
                {
                    if (item.Country != country)
                    {
                        continue;
                    }
                }

                if (minstud != "Any")
                {
                    if (item.getDojoMembers().Rows.Count < int.Parse(minstud))
                    {
                        continue;
                    }
                }
                if (maxstud != "Any")
                {
                    if (item.getDojoMembers().Rows.Count > int.Parse(maxstud))
                    {
                        continue;
                    }
                }
                if (active != "Any")
                {
                    if (item.Active != bool.Parse(active))
                    {
                        continue;
                    }
                }              
                ldojoFilter.Add(item);
            }
            return ldojoFilter;
        }
        public List<Dojo> Search(string srch)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            List<Dojo> ldoj = new List<Dojo>();
            foreach (Dojo doj in databaseOperation.search("Dojo", $"DojoName", $"'%{srch}%'", ObjectType.dojo))
            {
                ldoj.Add(doj);
            }

            return ldoj;
        }
    }
}
