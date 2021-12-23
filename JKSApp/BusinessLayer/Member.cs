using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace JKSApp.BusinessLayer
{
    class Member:table
    {
        int memberID, dojoID, categoryID;
        string sAAfilliationNumber, jAPAfilliationNumber, memberFirstName, memberLastName, memberPhone, memberEmail, memberStreet, memberSuburb, memberCity, memberProvince, memberCountry, memberGender, memberIDNumber, certificateNumber;
        bool active, instructor, jAPBook, sABook;
        DateTime dOB;

        public Member()
        {
        }

        public Member(int memberID, int dojoID, int categoryID, string sAAfilliationNumber, string jAPAfilliationNumber, string memberFirstName, string memberLastName, string memberPhone, string memberEmail, string memberStreet, string memberSuburb, string memberCity, string memberProvince, string memberCountry, string memberGender, string memberIDNumber, string certificateNumber, bool active, bool instructor, bool jAPBook, bool sABook, DateTime dOB)
        {
            this.memberID = memberID;
            this.dojoID = dojoID;
            this.categoryID = categoryID;
            this.sAAfilliationNumber = sAAfilliationNumber;
            this.jAPAfilliationNumber = jAPAfilliationNumber;
            this.memberFirstName = memberFirstName;
            this.memberLastName = memberLastName;
            this.memberPhone = memberPhone;
            this.memberEmail = memberEmail;
            this.memberStreet = memberStreet;
            this.memberSuburb = memberSuburb;
            this.memberCity = memberCity;
            this.memberProvince = memberProvince;
            this.memberCountry = memberCountry;
            this.memberGender = memberGender;
            this.memberIDNumber = memberIDNumber;
            this.certificateNumber = certificateNumber;
            this.active = active;
            this.instructor = instructor;
            this.jAPBook = jAPBook;
            this.sABook = sABook;
            this.dOB = dOB;
        }

        public int MemberID { get => memberID; set => memberID = value; }
        public int DojoID { get => dojoID; set => dojoID = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string SAAfilliationNumber { get => sAAfilliationNumber; set => sAAfilliationNumber = value; }
        public string JAPAfilliationNumber { get => jAPAfilliationNumber; set => jAPAfilliationNumber = value; }
        public string MemberFirstName { get => memberFirstName; set => memberFirstName = value; }
        public string MemberLastName { get => memberLastName; set => memberLastName = value; }
        public string MemberPhone { get => memberPhone; set => memberPhone = value; }
        public string MemberEmail { get => memberEmail; set => memberEmail = value; }
        public string MemberStreet { get => memberStreet; set => memberStreet = value; }
        public string MemberSuburb { get => memberSuburb; set => memberSuburb = value; }
        public string MemberCity { get => memberCity; set => memberCity = value; }
        public string MemberProvince { get => memberProvince; set => memberProvince = value; }
        public string MemberCountry { get => memberCountry; set => memberCountry = value; }
        public string MemberGender { get => memberGender; set => memberGender = value; }
        public string MemberIDNumber { get => memberIDNumber; set => memberIDNumber = value; }
        public string CertificateNumber { get => certificateNumber; set => certificateNumber = value; }
        public bool Active { get => active; set => active = value; }
        public bool Instructor { get => instructor; set => instructor = value; }
        public bool JAPBook { get => jAPBook; set => jAPBook = value; }
        public bool SABook { get => sABook; set => sABook = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }

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
                if (mem.MemberFirstName.Contains(srch)||mem.MemberLastName.Contains(srch))
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

        public string GetDojoName()
        {
            DatabaseOperation operation = new DatabaseOperation();
            string text = "";
            if ((text = operation.GetEntityName("Dojo", DojoID.ToString())) == "")
            {
                return "Not Found";
            }
            else
                return text;

        }

        public string GetCatDescr()
        {
            DatabaseOperation operation = new DatabaseOperation();
            string text = "";
            if ((text = operation.GetEntityName("Category", CategoryID.ToString())) == "")
            {
                return "Not Found";
            }
            else
                return text;
        }

        public string GetBeltDescr(string beltid)
        {
            DatabaseOperation operation = new DatabaseOperation();
            string text = "";
            if ((text = operation.GetEntityName("Belt", beltid)) == "")
            {
                return "Not Found";
            }
            else
                return text;
        }

        public DataTable getMemberQualifications()
        {
            DataHandler dh = new DataHandler();           
            return dh.MemberQualification(MemberID.ToString());
        }

        public DataTable getMemberAchievements()
        {
            DataHandler dh = new DataHandler();
            return dh.MemberAchievements(MemberID.ToString());
        }
        public DataTable getMemberEvents()
        {
            DataHandler dh = new DataHandler();
            return dh.MemberEvents(MemberID.ToString());
        }
        public DataTable getMemberGrading()
        {
            DataHandler dh = new DataHandler();
            return dh.MemberGrading(MemberID.ToString());
        }

        public bool DeleteMemberItem(ObjectType tbl,string id)
        {
            DataHandler dh = new DataHandler();
            bool success = false;
            switch (tbl)
            {
                case ObjectType.dojo:
                    break;
                case ObjectType.member:
                    break;
                case ObjectType.events:
                    success = dh.DeleteItem("MemberEvent",$"MemberID={MemberID} and EventID={id}");
                    break;
                case ObjectType.achievement:
                    success = dh.DeleteItem("MemberAchievement", $"MemberID={MemberID} and AchievementID={id}");
                    break;
                case ObjectType.belt:
                    break;
                case ObjectType.category:
                    break;
                case ObjectType.grading:
                    success = dh.DeleteItem("GradingInformation", $"MemberID={MemberID} and GradingID={id}");
                    break;
                case ObjectType.qualification:
                    success=dh.DeleteItem("MemberQualification", $"MemberID={MemberID} and QualificationID={id}");                   
                    break;
                case ObjectType.affiliation:
                    break;
                default:
                    break;
            }
            return success;
        }

        public bool InsertMemberItem(ObjectType tbl, string id)
        {
            DataHandler dh = new DataHandler();
            bool success = false;
            switch (tbl)
            {
                case ObjectType.dojo:
                    break;
                case ObjectType.member:
                    break;
                case ObjectType.events:
                    success = dh.InsertItem("MemberEvent(MemberID,EventID)", $"{MemberID},{id}");
                    break;
                case ObjectType.achievement:
                    success = dh.InsertItem("MemberAchievement(MemberID,AchievementID,YearAchieved)", $"{MemberID},{id}");
                    break;
                case ObjectType.belt:
                    break;
                case ObjectType.category:
                    break;
                case ObjectType.grading:
                    success = dh.InsertItem("GradingInformation(MemberID,GradingID,AttemptedGrade,Passed)", $"{MemberID},{id}");
                    break;
                case ObjectType.qualification:
                    success = dh.InsertItem("MemberQualification(MemberID,QualificationID)", $"{MemberID},{id}");
                    break;
                case ObjectType.affiliation:
                    break;
                default:
                    break;
            }
            return success;
        }

        public override void openInsertForm(CU op)
        {
            Presentation_Layer.frmCreateMember frmCreateMember = new Presentation_Layer.frmCreateMember(op);
            frmCreateMember.Show();
        }

        public override void openUpdateForm(Object obj)
        {
            Presentation_Layer.frmCreateMember frmCreateMember = new Presentation_Layer.frmCreateMember(CU.Update,obj);
            frmCreateMember.Show();
        }

        public bool InsertMember()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Member(SAAfilliationNumber,JAPAfilliationNumber,MemberFirstName,MemberLastName,MemberDOB,MemberPhone,MemberEmail,MemberStreet,MemberSuburb,MemberCity,MemberProvince,MemberCountry,MemberGender,MemberIDNumber,Active,Instructor,DojoID,CategoryID,CertificateNumber,JAPBook,SABook)", $"'{SAAfilliationNumber}','{JAPAfilliationNumber}','{MemberFirstName}','{MemberLastName}','{DOB}','{MemberPhone}','{MemberEmail}','{MemberStreet}','{MemberSuburb}','{MemberCity}','{MemberProvince}','{MemberCountry}','{MemberGender}','{MemberIDNumber}',{Active},{Instructor},{DojoID},{CategoryID},'{CertificateNumber}',{JAPBook},{SABook}"))
            {
                MessageBox.Show("Successfully added Member");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }
        }
        public bool updateMember()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Member", $"SAAfilliationNumber='{SAAfilliationNumber}',JAPAfilliationNumber='{JAPAfilliationNumber}',MemberFirstName='{MemberFirstName}',MemberLastName='{MemberLastName}',MemberDOB='{DOB}',MemberPhone='{MemberPhone}',MemberEmail='{MemberEmail}',MemberStreet='{MemberStreet}',MemberSuburb='{MemberSuburb}',MemberCity='{MemberCity}',MemberProvince='{MemberProvince}',MemberCountry='{MemberCountry}',MemberGender='{MemberGender}',MemberIDNumber='{MemberIDNumber}',Active={Active},Instructor={Instructor},DojoID={DojoID},CategoryID={CategoryID},CertificateNumber='{CertificateNumber}',JAPBook={JAPBook},SABook={SABook}",memberID.ToString()))
            {
                MessageBox.Show("Successfully Updated");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }
            
        }
        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {MemberFirstName} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("MemberAchievement", $"MemberID={MemberID}") && dh.DeleteItem("MemberQualification", $"MemberID={MemberID}") && dh.DeleteItem("MemberEvent", $"MemberID={MemberID}") && dh.DeleteItem("GradingInfo", $"MemberID={MemberID}") && dh.DeleteItem("Member", $"MemberID={MemberID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }
        }
    }
}
