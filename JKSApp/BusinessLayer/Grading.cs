using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Grading
    {
        int gradingID;
        string gradingDescription;
        DateTime gradingDate;
        public Grading()
        {
            
        }

        public Grading(int gradingID, string gradingDescription, DateTime gradingDate)
        {
            this.GradingID = gradingID;
            this.GradingDescription = gradingDescription;
            this.GradingDate = gradingDate;
        }

        public int GradingID { get => gradingID; set => gradingID = value; }
        public string GradingDescription { get => gradingDescription; set => gradingDescription = value; }
        public DateTime GradingDate { get => gradingDate; set => gradingDate = value; }

        public List<Grading> getGrading()
        {
            DataHandler dh = new DataHandler();
            List<Grading> lgrade = new List<Grading>();
            foreach (Grading grade in dh.GetAll(ObjectType.grading))
            {
                lgrade.Add(grade);
            }
            return lgrade;
        }
    }
}
