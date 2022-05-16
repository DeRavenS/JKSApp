using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    class QS
    {
        string memberFirstName, memberLastName, qualifications, dojoName;

        public QS(string memberFirstName, string memberLastName, string qualifications, string dojoname)
        {
            MemberFirstName = memberFirstName;
            MemberLastName = memberLastName;
            Qualifications = qualifications;
            DojoName = dojoname;
        }

        public string MemberFirstName { get => memberFirstName; set => memberFirstName = value; }
        public string MemberLastName { get => memberLastName; set => memberLastName = value; }
        public string Qualifications { get => qualifications; set => qualifications = value; }
        public string DojoName { get => dojoName; set => dojoName = value; }
    }
}
