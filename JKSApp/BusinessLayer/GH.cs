using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    //grading history
    class GH
    {
        string memberFirstName, memberLastName, jAPAffiliationNumber, sAAffiliationNumber, beltDescription, dOB,dojoName, lastGradingDate, gradingInfo;

        public GH(string memberFirstName, string memberLastName, string jAPAffiliationNumber, string sAAffiliationNumber, string beltDescription, string dOB, string lastGradingDate, string gradingInfo, string dojoName)
        {
            MemberFirstName = memberFirstName;
            MemberLastName = memberLastName;
            JAPAffiliationNumber = jAPAffiliationNumber;
            SAAffiliationNumber = sAAffiliationNumber;
            BeltDescription = beltDescription;
            DOB = dOB;
            LastGradingDate = lastGradingDate;
            GradingInfo = gradingInfo;
            DojoName = dojoName;
        }

        public string MemberFirstName { get => memberFirstName; set => memberFirstName = value; }
        public string MemberLastName { get => memberLastName; set => memberLastName = value; }
        public string JAPAffiliationNumber { get => jAPAffiliationNumber; set => jAPAffiliationNumber = value; }
        public string SAAffiliationNumber { get => sAAffiliationNumber; set => sAAffiliationNumber = value; }
        public string BeltDescription { get => beltDescription; set => beltDescription = value; }
        public string DOB { get => dOB; set => dOB = value; }
        public string LastGradingDate { get => lastGradingDate; set => lastGradingDate = value; }
        public string GradingInfo { get => gradingInfo; set => gradingInfo = value; }
        public string DojoName { get => dojoName; set => dojoName = value; }
    }
}
