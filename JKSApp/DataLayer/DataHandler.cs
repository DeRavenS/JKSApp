using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using JKSApp.BusinessLayer;
using System.Data;
using System.Configuration;

namespace JKSApp.DataLayer
{
    class DataHandler
    {

        // OleDbConnection conString = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppContext.BaseDirectory}\JKSNew.mdb");
        static string conString = $@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {AppContext.BaseDirectory}\JKSNew.mdb";       
        public static string constring1 { get => conString; set => conString = value; }
        public OleDbConnection Con { get => con; set => con = value; }

        OleDbConnection con = new OleDbConnection(constring1);

        public List<object> GetAll(ObjectType ot)
        {
            
            List<object> lobj = new List<object>();
            if (testCon())
            {
                string tbl;
                switch (ot)
                {
                    case ObjectType.dojo:
                        tbl = "Dojo";
                        break;                  
                    case ObjectType.member:
                        tbl="Member";
                        break;
                    case ObjectType.achievement:
                        tbl = "Achievement";
                        break;
                    case ObjectType.affiliation:
                        tbl = "Affiliation";
                        break;
                    case ObjectType.belt:
                        tbl = "Belt";
                        break;
                    case ObjectType.category:
                        tbl = "Category";
                        break;
                    case ObjectType.events:
                        tbl = "Event";
                        break;
                    case ObjectType.grading:
                        tbl = "Grading";
                        break;
                    case ObjectType.qualification:
                        tbl = "Qualification";
                        break;
                    case ObjectType.ratification:
                        tbl = "Ratification";
                        break;
                    default:
                        return lobj;
                        
                }
                
                OleDbCommand cmd = new OleDbCommand($"Select * from {tbl}", Con);
                OleDbDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        switch (ot)
                        {
                            case ObjectType.dojo:
                                lobj.Add(new Dojo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),reader.GetBoolean(9),reader.GetString(7),reader.GetString(8)));
                                break;                          
                            case ObjectType.member:
                                var arrbyte=reader["MemberPhoto"];
                                string arr;
                                if (arrbyte != null)
                                {
                                    arr = arrbyte as string;
                                }
                                else arr = null;
                                lobj.Add(new Member(reader.GetInt32(0), reader.GetInt32(17), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(19), reader.GetBoolean(15), reader.GetBoolean(16), reader.GetBoolean(20), reader.GetBoolean(21),reader.GetDateTime(5),arr,(int)reader["BeltID"]));
                                break;
                            case ObjectType.events:
                                lobj.Add(new Event(reader.GetInt32(0), reader.GetString(1)));
                                    break;
                            case ObjectType.grading:
                                lobj.Add(new Grading(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.achievement:
                                lobj.Add(new Achievement(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.affiliation:
                                lobj.Add(new Affiliation(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.belt:
                                lobj.Add(new Belt(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.category:
                                lobj.Add(new Category(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));
                                break;
                            case ObjectType.qualification:
                                lobj.Add(new Qualification(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.ratification:
                                lobj.Add(new Ratification(reader.GetInt32(0), reader.GetDateTime(1),reader.GetDateTime(2),reader.GetInt32(3)));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            Con.Close();
            return lobj;
        }
        

        public bool testCon()
        {

            try
            {
                Con.Open();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable MemberQualification(string id)
        {
            if (testCon())
            {
                using (con)
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter($"Select Qualification.QualificationID,Qualification.QualificationDescription,MemberQualification.SAQualificationDate,MemberQualification.JAPQualificationDate from Qualification,MemberQualification where MemberQualification.MemberID ={id} and Qualification.QualificationID=MemberQualification.QualificationID", Con);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ": Qualifications not found");
                        return null;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }

        }

        public DataTable MemberAchievements(string id)
        {
            if (testCon())
            {
                using (con)
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter($"Select Achievement.AchievementDescription,MemberAchievement.YearAchieved,Achievement.AchievementID from Achievement,MemberAchievement where MemberAchievement.MemberID ={id} and Achievement.AchievementID=MemberAchievement.AchievementID", Con);
                        da.Fill(dt);

                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ": Achievements not found");
                        return null;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }

        }

        public DataTable MemberEvents(string id)
        {
            if (testCon())
            {
                using (con)
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter($"Select Event.EventDescription,MemberEvent.EventDate,Event.EventID,MemberEvent.MEID from Event,MemberEvent where MemberEvent.MemberID ={id} and Event.EventID=MemberEvent.EventID", Con);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ": Events not found");
                        return null;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }

        }

        public DataTable MemberGrading(string id)
        {
            if (testCon())
            {
                using (con)
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter($"Select Grading.GradingDescription,GradingInformation.GradingDate,Grading.GradingID,GradingInformation.AttemptedGrade,GradingInformation.GIID from Grading,GradingInformation where GradingInformation.MemberID ={id} and Grading.GradingID=GradingInformation.GradingID order by GradingInformation.GradingDate DESC", Con);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ": Gradings not found");
                        return null;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public DataTable AchievementMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select DISTINCT (MemberAchievement.MemberID), Member.MemberFirstName, Member.MemberLastName  from Member,MemberAchievement where Member.MemberID=MemberAchievement.MemberID and MemberAchievement.AchievementID={id}", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }

        public DataTable CategoryMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select MemberFirstName,MemberLastName from Member where CategoryID={id}", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }

        public DataTable DojoMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select MemberFirstName,MemberLastName from Member where DojoID={id}", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public DataTable AffiliationMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Member.MemberID,Member.MemberFirstName,Member.MemberLastName,MemberAffiliation.AffiliationDate from Member,MemberAffiliation where MemberAffiliation.AffiliationID={id} and Member.MemberID=MemberAffiliation.MemberID", Con);
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " \n: Members not found");
                    con.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }

        public DataTable EventMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Member.MemberFirstName,member.MemberLastName from Member,MemberEvent where MemberEvent.EventID={id}and Member.MemberID=MemberEvent.MemberID", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public DataTable GradingMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Member.MemberFirstName,Member.MemberLastName from Member,GradingInformation where GradingInformation.GradingID={id} and Member.MemberID=GradingInformation.MemberID", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public DataTable QualificationMembers(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Member.MemberFirstName,Member.MemberLastName from Member,MemberQualification where MemberQualification.QualificationID={id} and Member.MemberID=MemberQualification.MemberID", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": members not found");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }

        public bool DeleteItem(string table, string criteria)
        {
            if (testCon())
            {                
                try
                {                  
                    OleDbCommand cmd = new OleDbCommand($"Delete from {table} where {criteria}", Con);
                    cmd.ExecuteNonQuery();                
                    Con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return false;
            }
        }

        public bool InsertItem(string table, string criteria)
        {
            if (testCon())
            {
                using (Con)
                {
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand($"Insert into {table} Values({criteria})", Con);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }             
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return false;
            }
        }

        public bool UpdateItem(string table, string criteria, string id)
        {
            if (testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Update {table} SET {criteria} where {table}ID={id}", Con);                   
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                    return false;
                }
               
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return false;
            }
        }

        public List<object> GetAllSort(ObjectType ot,string col,string order)
        {
            List<object> lobj = new List<object>();
            if (testCon())
            {
                string tbl;
                switch (ot)
                {
                    case ObjectType.dojo:
                        tbl = "Dojo";
                        break;
                    case ObjectType.member:
                        tbl = "Member";
                        break;
                    case ObjectType.achievement:
                        tbl = "Achievement";
                        break;
                    case ObjectType.affiliation:
                        tbl = "Affiliation";
                        break;
                    case ObjectType.belt:
                        tbl = "Belt";
                        break;
                    case ObjectType.category:
                        tbl = "Category";
                        break;
                    case ObjectType.events:
                        tbl = "Event";
                        break;
                    case ObjectType.grading:
                        tbl = "Grading";
                        break;
                    case ObjectType.qualification:
                        tbl = "Qualification";
                        break;

                    default:
                        return lobj;

                }
                OleDbCommand cmd = new OleDbCommand($"Select * from {tbl} order by {col} {order}", Con);
                OleDbDataReader reader=null;
                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid sorting criteria");
                    return null;
                }
                
                using (reader)
                {
                    while (reader.Read())
                    {
                        switch (ot)
                        {
                            case ObjectType.dojo:
                                lobj.Add(new Dojo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),reader.GetBoolean(9), reader.GetString(7), reader.GetString(8) ));
                                break;
                            case ObjectType.member:
                                var arrbyte = reader["MemberPhoto"];
                                string arr;
                                if (arrbyte != null)
                                {
                                    arr = arrbyte as string;
                                }
                                else arr = null;
                                lobj.Add(new Member(reader.GetInt32(0), reader.GetInt32(17), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(19), reader.GetBoolean(15), reader.GetBoolean(16), reader.GetBoolean(20), reader.GetBoolean(21), reader.GetDateTime(5), arr, (int)reader["BeltID"]));
                                break;
                            case ObjectType.events:
                                lobj.Add(new Event(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.grading:
                                lobj.Add(new Grading(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.achievement:
                                lobj.Add(new Achievement(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.affiliation:
                                lobj.Add(new Affiliation(reader.GetInt32(0),reader.GetString(1)));
                                break;
                            case ObjectType.belt:
                                lobj.Add(new Belt(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.category:
                                lobj.Add(new Category(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));
                                break;
                            case ObjectType.qualification:
                                lobj.Add(new Qualification(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            Con.Close();
            return lobj;
        }
        public string lastGradingDate(string id)
        {
            if (testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Select GradingDate from GradingInformation where Passed=True and MemberID={id}", Con);
                    OleDbDataReader reader = cmd.ExecuteReader();                  
                    if (reader.Read())
                    {
                        string date = reader.GetDateTime(0).ToString("yyyy/MM/dd");
                        con.Close();
                        return date;
                    }
                    else
                    {
                        Con.Close();
                        return null;
                    }                                     
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+":\nCould not retreive Grading Date");
                    Con.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public List<string> gradingHistory(string id)
        {
            if (testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Select GradingInformation.GradingDate, Belt.BeltName from GradingInformation,Belt where GradingInformation.Passed=True and GradingInformation.MemberID={id} and Belt.BeltID=GradingInformation.AttemptedGrade", Con);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    List<string> lGrad = new List<string>();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            lGrad.Add(string.Format("{0} : {1}", reader.GetDateTime(0).ToString("yyyy/MM/dd"), reader.GetString(1)));
                        }
                    }
                    Con.Close();
                    return lGrad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ":\nCould not retreive Grading Date");
                    Con.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return null;
            }
        }
        public bool isAffiliated(string id,string date,string affiliation)
        {
            if (testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Select AffiliationID from Affiliation where AffiliationDescription='{affiliation}'", Con);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    using (Con)
                    {
                        int affID;
                        bool bflag = false;
                        using (reader)
                        {
                            if (reader.Read())
                            {
                                affID = reader.GetInt32(0);
                                bflag = true;
                            }
                            else
                            {
                                Con.Close();
                                return false;
                            }
                        }
                        if (bflag)
                        {
                            cmd.CommandText = $"Select MemberID from MemberAffiliation where AffiliationID={affID} and year(AffiliationDate)={date} and MemberID={id}";
                            OleDbDataReader finalRead = cmd.ExecuteReader();
                            if (finalRead.Read())
                            {
                                return true;
                            }
                            else return false;
                        }
                        else return false;
                        
                    }                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ":\nCould not retreive list of licensed to Japan");
                    Con.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                Con.Close();
                return false;
            }
        }
    }
}

