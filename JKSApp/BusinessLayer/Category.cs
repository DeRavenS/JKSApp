using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Category
    {
        int categoryID;
        string categoryDescription;

        public Category()
        {
        }

        public Category(int categoryID, string categoryDescription)
        {
            this.categoryID = categoryID;
            this.categoryDescription = categoryDescription;
        }

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryDescription { get => categoryDescription; set => categoryDescription = value; }

        public List<Category> getAll()
        {
            DataHandler dh = new DataHandler();
            List<Category> lcat = new List<Category>();
            foreach (Category cat in dh.GetAll(ObjectType.category))
            {
                lcat.Add(cat);
            }

            return lcat;
        }
    }
}
