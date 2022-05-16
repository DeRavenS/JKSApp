using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using JKSApp.Presentation_Layer;

namespace JKSApp.BusinessLayer
{
    class Member:table
    {
        int memberID, dojoID, categoryID, beltID;
        string sAAfilliationNumber, jAPAfilliationNumber, memberFirstName, memberLastName, memberPhone, memberEmail, memberStreet, memberSuburb, memberCity, memberProvince, memberCountry, memberGender, memberIDNumber, certificateNumber;
        bool active, dojohead, jAPBook, sABook;
        DateTime dOB;
        string memberPhoto;

        public Member()
        {
        }

        public Member(int memberID, int dojoID, string sAAfilliationNumber, string jAPAfilliationNumber, string memberFirstName, string memberLastName, string memberPhone, string memberEmail, string memberStreet, string memberSuburb, string memberCity, string memberProvince, string memberCountry, string memberGender, string memberIDNumber, string certificateNumber, bool active, bool instructor, bool jAPBook, bool sABook, DateTime dOB,string memberphoto, int beltID)
        {
            this.memberID = memberID;
            this.dojoID = dojoID;           
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
            this.dojohead = instructor;
            this.jAPBook = jAPBook;
            this.sABook = sABook;
            this.dOB = dOB;
            this.memberPhoto = memberphoto;
            this.BeltID = beltID;
            setCatID();
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
        public bool Instructor { get => dojohead; set => dojohead = value; }
        public bool JAPBook { get => jAPBook; set => jAPBook = value; }
        public bool SABook { get => sABook; set => sABook = value; }
        public DateTime DOB 
        { get => dOB; 
          set 
            { 
                dOB = value;
                setCatID();
            }
        }

        public string MemberPhoto { get => memberPhoto; set => memberPhoto = value; }
        public int BeltID { get => beltID; set => beltID = value; }

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
        public int GetBeltID(string beltDesc)
        {
            Belt belt = new Belt();
            int id=0;
            foreach (Belt item in belt.getAll())
            {
                if (item.BeltName==beltDesc)
                {
                   id = item.BeltID;
                    break;
                }
            }
            return id;
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
        public string lastGradingDate()
        {
            DataHandler dh = new DataHandler();
            string date = dh.lastGradingDate(MemberID.ToString());
            if (date==null)
            {
                return "No Grading Date Found";
            }
            return date;
        }

        public bool DeleteMemberItem(ObjectType tbl,string id,string tblID)
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
                    success = dh.DeleteItem("MemberEvent",$"MEID={tblID};");
                    break;
                case ObjectType.achievement:
                    success = dh.DeleteItem("MemberAchievement", $"MemberID={MemberID} and AchievementID={id} and YearAchieved = '{tblID}'");
                    break;
                case ObjectType.belt:
                    break;
                case ObjectType.category:
                    break;
                case ObjectType.grading:
                    success = dh.DeleteItem("GradingInformation", $"GIID={tblID}");
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
                    string[] ltemp = id.Split(',');
                    success = dh.InsertItem("MemberEvent(MemberID,EventID,EventDate)", $"{MemberID},{ltemp[0]},'{ltemp[1]}'");
                    break;
                case ObjectType.achievement:
                    success = dh.InsertItem("MemberAchievement(MemberID,AchievementID,YearAchieved)", $"{MemberID},{id}");
                    break;
                case ObjectType.belt:
                    break;
                case ObjectType.category:
                    break;
                case ObjectType.grading:                   
                    success = dh.InsertItem("GradingInformation(MemberID,GradingID,AttemptedGrade,Passed,GradingDate)", $"{MemberID},{id}");
                    break;
                case ObjectType.qualification:
                    success = dh.InsertItem("MemberQualification(MemberID,QualificationID,SAQualificationDate,JAPQualificationDate)", $"{MemberID},{id}");
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
            frmCreateMember frmCreateMember = new Presentation_Layer.frmCreateMember(op);
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
            if (dh.InsertItem("Member(SAAfilliationNumber,JAPAfilliationNumber,MemberFirstName,MemberLastName,MemberDOB,MemberPhone,MemberEmail,MemberStreet,MemberSuburb,MemberCity,MemberProvince,MemberCountry,MemberGender,MemberIDNumber,Active,DojoHead,DojoID,CategoryID,CertificateNumber,JAPBook,SABook,MemberPhoto)", $"'{SAAfilliationNumber}','{JAPAfilliationNumber}','{MemberFirstName}','{MemberLastName}','{DOB}','{MemberPhone}','{MemberEmail}','{MemberStreet}','{MemberSuburb}','{MemberCity}','{MemberProvince}','{MemberCountry}','{MemberGender}','{MemberIDNumber}',{Active},{Instructor},{DojoID},{CategoryID},'{CertificateNumber}',{JAPBook},{SABook},'{MemberPhoto}'"))
            {
                pictures pic = new pictures();
                pic.SavePhoto(MemberPhoto);
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
            if (dh.UpdateItem("Member", $"SAAfilliationNumber='{SAAfilliationNumber}',JAPAfilliationNumber='{JAPAfilliationNumber}',MemberFirstName='{MemberFirstName}',MemberLastName='{MemberLastName}',MemberDOB='{DOB}',MemberPhone='{MemberPhone}',MemberEmail='{MemberEmail}',MemberStreet='{MemberStreet}',MemberSuburb='{MemberSuburb}',MemberCity='{MemberCity}',MemberProvince='{MemberProvince}',MemberCountry='{MemberCountry}',MemberGender='{MemberGender}',MemberIDNumber='{MemberIDNumber}',Active={Active},DojoHead={Instructor},DojoID={DojoID},CategoryID={CategoryID},CertificateNumber='{CertificateNumber}',JAPBook={JAPBook},SABook={SABook},MemberPhoto='{MemberPhoto}'",memberID.ToString()))
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
                if (dh.DeleteItem("MemberAchievement", $"MemberID={MemberID}") && dh.DeleteItem("MemberQualification", $"MemberID={MemberID}") && dh.DeleteItem("MemberEvent", $"MemberID={MemberID}") && dh.DeleteItem("GradingInformation", $"MemberID={MemberID}") && dh.DeleteItem("Member", $"MemberID={MemberID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }
        }

        public int getAge()
        {
            return DateTime.Now.Subtract(DOB).Days/365;
        }

        public void setCatID()
        {
            Category cat = new Category();
            foreach (Category item in cat.getAll())
            {
                if (getAge() >= item.MinAge && getAge() <= item.MaxAge)
                {
                    CategoryID = item.CategoryID;
                    break;
                }
                CategoryID = 0;
            }
        }
        public string getSAAffiliationNumber()
        {
            List<int> lmem = new List<int>();
            foreach (Member item in GetMember())
            {
                lmem.Add(int.Parse(item.SAAfilliationNumber));
            }
            
            lmem.Sort();
            int num = lmem[lmem.Count-1];
            string sanum = num.ToString();
            string newnum = sanum;
            for (int i = 0+sanum.Length; i <7; i++)
            {
                newnum = "0" + newnum;
            }
            return newnum;
        }

        public bool isAffiliated(string date,string affiliation)
        {
            DataHandler dh = new DataHandler();
            return dh.isAffiliated(MemberID.ToString(),date,affiliation);
        }

        public List<Member> filterMembers(string suburb, string city, string province, string country, string minage, string maxage, string active, string instructor, string JAPBook, string SABook, string dojo, string category, string gender,string ratification)
        {
            int dojoid=0, catid=0;
            Dojo doj = new Dojo();
            foreach (Dojo item in doj.getDojo())//Finding dojoID
            {
                if (item.Name==dojo)
                {
                    dojoid = item.DojoID;
                    break;
                }
            }
            Category Cat = new Category();
            foreach (Category item in Cat.getAll())//Finding CatID
            {
                if (item.CategoryDescription == category)
                {
                    catid = item.CategoryID;
                    break;
                }
            }

            //Filtering
            List<Member> lmemFilter = new List<Member>();
            foreach (Member item in GetMember())
            {   
                if (suburb!="Any")
                {
                    if (item.MemberSuburb!=suburb)
                    {
                        continue;
                    }                    
                }
                if (city != "Any")
                {
                    if (item.MemberCity!= city)
                    {
                        continue;
                    }
                }
                if (province != "Any")
                {
                    if (item.MemberProvince != province)
                    {
                        continue;
                    }
                }
                if (country != "Any")
                {
                    if (item.MemberCountry != country)
                    {
                        continue;
                    }
                }

                if (minage != "Any")
                {
                    if (item.getAge()<int.Parse(minage))
                    {
                        continue;
                    }
                }
                if (maxage != "Any")
                {
                    if (item.getAge() > int.Parse(maxage))
                    {
                        continue;
                    }
                }
                if (gender != "Any")
                {
                    if (item.MemberGender!= gender)
                    {
                        continue;
                    }
                }
                if (active != "Any")
                {
                    if (item.Active != bool.Parse(active))
                    {
                        continue;
                    }
                }
                if (instructor != "Any")
                {
                    if (item.Instructor != bool.Parse(instructor))
                    {
                        continue;
                    }
                }
                if (JAPBook != "Any")
                {
                    if (item.JAPBook != bool.Parse(JAPBook))
                    {
                        continue;
                    }
                }
                if (SABook != "Any")
                {
                    if (item.SABook != bool.Parse(SABook))
                    {
                        continue;
                    }
                }
                if (dojo != "Any")
                {
                    if (dojoid != item.DojoID)
                    {
                        continue;
                    }
                }
                if (category != "Any")
                {
                    if (catid != item.CategoryID)
                    {
                        continue;
                    }
                }
                if (ratification !="Any")
                {
                    bool bflag = false;
                    Ratification rat = new Ratification();
                    foreach (Ratification r in rat.getAll())
                    {
                        if (r.MemberID==item.MemberID)
                        {
                            bflag = true;
                            break;
                        }
                    }

                    if (bflag!=bool.Parse(ratification))
                    {
                        continue;
                    }
                }
                lmemFilter.Add(item);
            }
            return lmemFilter;
        }
        public List<Member> Search(string srch)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            List<Member> lmem = new List<Member>();
            foreach (Member mem in databaseOperation.search("Member", $"MemberFirstName", $"'%{srch}%' or MemberLastName like '%{srch}%'", ObjectType.member))
            {
                lmem.Add(mem);
            }

            return lmem;
        }
        public List<string> gradingHistory()
        {
            DataHandler dh = new DataHandler();
            return dh.gradingHistory(MemberID.ToString());
        }

        public Ratification getRatificationDetails()
        {
            Ratification rat = new Ratification();
            foreach (Ratification item in rat.getAll())
            {
                if (item.MemberID==MemberID)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
