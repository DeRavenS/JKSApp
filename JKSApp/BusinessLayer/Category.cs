using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKSApp.DataLayer;
using System.Data;
using JKSApp.Presentation_Layer;

namespace JKSApp.BusinessLayer
{
    class Category:table
    {
        int categoryID;
        string categoryDescription;
        int minAge, maxAge;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryDescription { get => categoryDescription; set => categoryDescription = value; }
        public int MinAge { get => minAge; set => minAge = value; }
        public int MaxAge { get => maxAge; set => maxAge = value; }

        public Category(int categoryID, string categoryDescription,int min, int max)
        {
            this.CategoryID = categoryID;
            this.CategoryDescription = categoryDescription;
            MinAge = min;
            MaxAge = max;
        }

        public Category()
        {
        }

        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {CategoryDescription} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("Category", $"CategoryID={CategoryID}"))
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
            frmCreateCategory frmCreateCat = new frmCreateCategory(CU.Insert);
            frmCreateCat.Show();
        }
        public override void openUpdateForm(object obj)
        {
            frmCreateCategory frmCreateCat = new frmCreateCategory(CU.Update);
            frmCreateCat.Show();
        }
        public List<Category> getAll()
        {
            DataHandler dh = new DataHandler();
            List<Category> lcat = new List<Category>();
            foreach (Category item in dh.GetAll(ObjectType.category))
            {
                lcat.Add(item);
            }
            return lcat;
        }
        public List<Category> Search(string srch)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            List<Category> lcat = new List<Category>();
            foreach (Category cat in databaseOperation.search("Category", $"CategoryDescription", $"'%{srch}%'", ObjectType.category))
            {
                lcat.Add(cat);
            }

            return lcat;
        }

        public DataTable getCategoryMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.CategoryMembers(categoryID.ToString());
        }
        public bool insertCategory()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Category(CategoryDescription,MinAge,MaxAge)", $"'{CategoryDescription}',{MinAge},{MaxAge}"))
            {               
                Member mem = new Member();
                foreach (Member item in mem.GetMember())
                {
                    item.setCatID();
                }
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }

        }
        public bool updateCategory()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Category", $"CategoryDescription='{CategoryDescription}',MinAge={MinAge},MaxAge={MaxAge}", categoryID.ToString()))
            {
                return true;
            }
            else return false;
        }
    }
}
