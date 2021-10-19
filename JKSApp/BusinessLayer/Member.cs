using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Windows.Forms;

namespace JKSApp.BusinessLayer
{
    class Member
    {
        int MemberID, DojoID, CategoryID;
        string SAAfilliationNumber, JAPAfilliationNumber, MemberFirstName, MemberLastName, MemberPhone, MemberEmail, MemberStreet, MemberSuburb, MemberCity, MemberProvince, MemberCountry, MemberGender, MemberIDNumber, CertificateNumber;
        bool Active, Instructor, JAPBook, SABook;
        DateTime DOB;

        public Member()
        {
        }

        public Member(int memberID, int dojoID, int categoryID, string sAAfilliationNumber, string jAPAfilliationNumber, string memberFirstName, string memberLastName, string memberPhone, string memberEmail, string memberStreet, string memberSuburb, string memberCity, string memberProvince, string memberCountry, string memberGender, string memberIDNumber, string certificateNumber, bool active, bool instructor, bool jAPBook, bool sABook,DateTime dob)
        {
            MemberID1 = memberID;
            DojoID1 = dojoID;
            CategoryID1 = categoryID;
            SAAfilliationNumber1 = sAAfilliationNumber;
            JAPAfilliationNumber1 = jAPAfilliationNumber;
            MemberFirstName1 = memberFirstName;
            MemberLastName1 = memberLastName;
            MemberPhone1 = memberPhone;
            MemberEmail1 = memberEmail;
            MemberStreet1 = memberStreet;
            MemberSuburb1 = memberSuburb;
            MemberCity1 = memberCity;
            MemberProvince1 = memberProvince;
            MemberCountry1 = memberCountry;
            MemberGender1 = memberGender;
            MemberIDNumber1 = memberIDNumber;
            CertificateNumber1 = certificateNumber;
            Active1 = active;
            Instructor1 = instructor;
            JAPBook1 = jAPBook;
            SABook1 = sABook;
            DOB1 = dob;
        }

        public int MemberID1 { get => MemberID; set => MemberID = value; }
        public int DojoID1 { get => DojoID; set => DojoID = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string SAAfilliationNumber1 { get => SAAfilliationNumber; set => SAAfilliationNumber = value; }
        public string JAPAfilliationNumber1 { get => JAPAfilliationNumber; set => JAPAfilliationNumber = value; }
        public string MemberFirstName1 { get => MemberFirstName; set => MemberFirstName = value; }
        public string MemberLastName1 { get => MemberLastName; set => MemberLastName = value; }
        public string MemberPhone1 { get => MemberPhone; set => MemberPhone = value; }
        public string MemberEmail1 { get => MemberEmail; set => MemberEmail = value; }
        public string MemberStreet1 { get => MemberStreet; set => MemberStreet = value; }
        public string MemberSuburb1 { get => MemberSuburb; set => MemberSuburb = value; }
        public string MemberCity1 { get => MemberCity; set => MemberCity = value; }
        public string MemberProvince1 { get => MemberProvince; set => MemberProvince = value; }
        public string MemberCountry1 { get => MemberCountry; set => MemberCountry = value; }
        public string MemberGender1 { get => MemberGender; set => MemberGender = value; }
        public string MemberIDNumber1 { get => MemberIDNumber; set => MemberIDNumber = value; }
        public string CertificateNumber1 { get => CertificateNumber; set => CertificateNumber = value; }
        public bool Active1 { get => Active; set => Active = value; }
        public bool Instructor1 { get => Instructor; set => Instructor = value; }
        public bool JAPBook1 { get => JAPBook; set => JAPBook = value; }
        public bool SABook1 { get => SABook; set => SABook = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }

        public List<Member> GetMember()
        {
            DataHandler dh = new DataHandler();
            List<Member> lmem = new List<Member>();
            foreach (Member item in dh.GetAll(ObjectType.member))
            {
                lmem.Add(item);
            }
            return lmem;
        }
        public List<Member> SearchMember(string srch, List<Member> lmem)
        {
            if (srch=="")
            {
                return lmem;
            }
            List<Member> lsrch = new List<Member>();
            foreach  (Member mem in lmem)
            {
                if (mem.MemberFirstName1.Contains(srch)||mem.MemberLastName1.Contains(srch))
                {
                    lsrch.Add(mem);
                }
            }
            if (lsrch.Count==0)
            {
                MessageBox.Show("Member Not Found");
            }
            return lsrch;
        }
    }
}
