using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    class LTJ
    {
        string jAPAfilliationNumber, memberFirstName, memberLastName, dojo,beltName,dOB;
        string lastGradingDate;

        public LTJ(string memberFirstName, string memberLastName, string jAPAfilliationNumber, string dojo, string lastGradingDatestring, string beltName, string dOB)
        {
            this.JAPAfilliationNumber = jAPAfilliationNumber;
            this.MemberFirstName = memberFirstName;
            this.MemberLastName = memberLastName;
            this.Dojo = dojo;
            this.LastGradingDate = lastGradingDate;
            BeltName = beltName;
            DOB = dOB;
        }

        public string JAPAfilliationNumber { get => jAPAfilliationNumber; set => jAPAfilliationNumber = value;}
        public string MemberFirstName { get => memberFirstName; set => memberFirstName = value;}
        public string MemberLastName { get => memberLastName; set => memberLastName = value;}
        public string Dojo { get => dojo; set => dojo = value;}
        public string LastGradingDate { get => lastGradingDate; set => lastGradingDate = value;}
        public string BeltName { get => beltName; set => beltName = value; }
        public string DOB { get => dOB; set => dOB = value; }
    }
}
