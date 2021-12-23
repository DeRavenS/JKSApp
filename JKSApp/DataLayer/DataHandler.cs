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
                                lobj.Add(new Dojo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetBoolean(7)));
                                break;                          
                            case ObjectType.member:
                                lobj.Add(new Member(reader.GetInt32(0), reader.GetInt32(17), reader.GetInt32(18), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(19), reader.GetBoolean(15), reader.GetBoolean(16), reader.GetBoolean(20), reader.GetBoolean(21),reader.GetDateTime(5)));
                                break;
                            case ObjectType.events:
                                lobj.Add(new Event(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                                    break;
                            case ObjectType.grading:
                                lobj.Add(new Grading(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                                break;
                            case ObjectType.achievement:
                                lobj.Add(new Achievement(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.affiliation:
                                lobj.Add(new Affiliation(reader.GetInt32(0), reader.GetDecimal(1),reader.GetDateTime(2),reader.GetInt32(3)));
                                break;
                            case ObjectType.belt:
                                lobj.Add(new Belt(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.category:
                                lobj.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
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
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Qualification.QualificationID,Qualification.QualificationDescription from Qualification,MemberQualification where MemberQualification.MemberID ={id} and Qualification.QualificationID=MemberQualification.QualificationID",Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message +": Qualifications not found");
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

        public DataTable MemberAchievements(string id)
        {
            if (testCon())
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
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Distinct Event.EventDescription,Event.EventDate,Event.EventID from Event,MemberEvent where MemberEvent.MemberID ={id} and Event.EventID=MemberEvent.EventID", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": Events not found");
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

        public DataTable MemberGrading(string id)
        {
            if (testCon())
            {
                DataTable dt = new DataTable();
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter($"Select Grading.GradingDescription,Grading.GradingDate,Grading.GradingID,GradingInformation.AttemptedGrade from Grading,GradingInformation where GradingInformation.MemberID ={id} and Grading.GradingID=GradingInformation.GradingID order by Grading.GradingDate DESC", Con);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": Gradings not found");
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
                OleDbDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        switch (ot)
                        {
                            case ObjectType.dojo:
                                lobj.Add(new Dojo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetBoolean(7)));
                                break;
                            case ObjectType.member:
                                lobj.Add(new Member(reader.GetInt32(0), reader.GetInt32(17), reader.GetInt32(18), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(19), reader.GetBoolean(15), reader.GetBoolean(16), reader.GetBoolean(20), reader.GetBoolean(21), reader.GetDateTime(5)));
                                break;
                            case ObjectType.events:
                                lobj.Add(new Event(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                                break;
                            case ObjectType.grading:
                                lobj.Add(new Grading(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                                break;
                            case ObjectType.achievement:
                                lobj.Add(new Achievement(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.affiliation:
                                lobj.Add(new Affiliation(reader.GetInt32(0), reader.GetDecimal(1), reader.GetDateTime(2), reader.GetInt32(3)));
                                break;
                            case ObjectType.belt:
                                lobj.Add(new Belt(reader.GetInt32(0), reader.GetString(1)));
                                break;
                            case ObjectType.category:
                                lobj.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
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
    }
}

