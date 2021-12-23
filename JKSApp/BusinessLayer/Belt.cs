using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Belt
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
    }
}
