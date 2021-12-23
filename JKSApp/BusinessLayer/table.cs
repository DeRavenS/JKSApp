using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    abstract class table
    {
        public abstract void openInsertForm(CU op);
        public abstract void openUpdateForm(Object obj);
        public abstract void DeleteItem();
        public List<object> SortTable(ObjectType objtype,string col,string order)
        {
            DataLayer.DataHandler dh= new DataLayer.DataHandler();
            return dh.GetAllSort(objtype, col, order);
        }
    }
}
