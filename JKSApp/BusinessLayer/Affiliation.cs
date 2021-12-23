using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Affiliation
    {
        int affiliationID;
        decimal affiliationFee;
        DateTime affiliationDate;
        int memberID;

        public Affiliation()
        {
        }

        public Affiliation(int affiliationID, decimal affiliationFee, DateTime affiliationDate, int memberID)
        {
            this.AffiliationID = affiliationID;
            this.AffiliationFee = affiliationFee;
            this.AffiliationDate = affiliationDate;
            this.MemberID = memberID;
        }

        public int AffiliationID { get => affiliationID; set => affiliationID = value; }
        public decimal AffiliationFee { get => affiliationFee; set => affiliationFee = value; }
        public DateTime AffiliationDate { get => affiliationDate; set => affiliationDate = value; }
        public int MemberID { get => memberID; set => memberID = value; }

        public List<Affiliation> getAll()
        {
            DataHandler dh = new DataHandler();
            List<Affiliation> laff = new List<Affiliation>();
            foreach (Affiliation aff in dh.GetAll(ObjectType.affiliation))
            {
                laff.Add(aff);
            }

            return laff;
        }
    }
}
