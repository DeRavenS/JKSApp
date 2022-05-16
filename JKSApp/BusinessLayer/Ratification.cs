using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JKSApp.DataLayer;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    class Ratification
    {
        int ratificationID;
        DateTime sADate, jAPDate;
        int memberID;

        public Ratification()
        {
        }

        public Ratification(int ratificationID, DateTime sADate, DateTime jAPDate, int memberID)
        {
            this.RatificationID = ratificationID;
            this.SADate = sADate;
            this.JAPDate = jAPDate;
            this.MemberID = memberID;
        }

        public int RatificationID { get => ratificationID; set => ratificationID = value; }
        public DateTime SADate { get => sADate; set => sADate = value; }
        public DateTime JAPDate { get => jAPDate; set => jAPDate = value; }
        public int MemberID { get => memberID; set => memberID = value; }

       public List<object> getAll()
        {
            DataHandler dh = new DataHandler();
            return dh.GetAll(ObjectType.ratification);
        }

        public bool deleteRatification(string id)
        {
            DataHandler dh = new DataHandler();
            return dh.DeleteItem("Ratification",$"MemberID={id}");
        }

        public bool insertRatification(DateTime sadate,DateTime japdate,int id)
        {
            DataHandler dh = new DataHandler();
            return dh.InsertItem("Ratification(SADate,JAPDate,MemberID)", $"'{sadate.ToString("yyyy/MM/dd")}','{japdate.ToString("yyyy/MM/dd")}',{id}");
        }
    }
}
