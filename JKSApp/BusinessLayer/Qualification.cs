using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Qualification
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
    }
}
