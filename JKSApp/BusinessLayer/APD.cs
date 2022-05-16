using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    class APD
    {
        string memberFirstName, memberLastName, jAPAfilliationNumber, dojo, beltName, dOB, jKSAffiliation,sAAffiliation,jAPBook;

        public APD(string memberFirstName, string memberLastName, string jAPAfilliationNumber, string dojo, string dOB, string beltName, string jKSAffiliation, string sAAffiliation, string jAPBook)
        {
            MemberFirstName = memberFirstName;
            MemberLastName = memberLastName;
            JAPAfilliationNumber = jAPAfilliationNumber;
            Dojo = dojo;
            DOB = dOB;
            BeltName = beltName;
            JKSAffiliation = jKSAffiliation;
            SAAffiliation = sAAffiliation;
            JAPBook = jAPBook;
        }

        public string MemberFirstName { get => memberFirstName; set => memberFirstName = value; }
        public string MemberLastName { get => memberLastName; set => memberLastName = value; }
        public string JAPAfilliationNumber { get => jAPAfilliationNumber; set => jAPAfilliationNumber = value; }
        public string Dojo { get => dojo; set => dojo = value; }
        public string DOB { get => dOB; set => dOB = value; }
        public string BeltName { get => beltName; set => beltName = value; }
        public string JKSAffiliation { get => jKSAffiliation; set => jKSAffiliation = value; }
        public string SAAffiliation { get => sAAffiliation; set => sAAffiliation = value; }
        public string JAPBook { get => jAPBook; set => jAPBook = value; }
    }
}
