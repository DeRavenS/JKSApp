using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using JKSApp.DataLayer;
using System.Windows.Forms;

namespace JKSApp.BusinessLayer
{
    enum ObjectType
    {
        dojo,
        competition,
        member,
        events,
        achievement,
        belt,
        category,
        grading,
        qualification,
        affiliation

    }

    class DatabaseOperation
    {
        DataHandler dh = new DataHandler();
        
        public List<object> search(string table, string criteria, string srch,ObjectType ot)
        {
            List<object> lobj = new List<object>();
            if (dh.testCon())
            {
                OleDbCommand cmd = new OleDbCommand($"Select * from {table} where {criteria} like {srch}", dh.ConString);
                OleDbDataReader reader = cmd.ExecuteReader();
                using (reader)
                {                   
                    switch (ot)
                    {    
                        case ObjectType.dojo:
                            lobj.Add(new Dojo(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),reader.GetString(6), reader.GetBoolean(7)));
                            break;
                        case ObjectType.competition:      
                            while (reader.Read())
                            {        
                                lobj.Add(new Competition(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                            }
                            break;
                        case ObjectType.member:
                            break;
                        default:
                            break;
                    }
                }


            }
            dh.ConString.Close();
            return lobj;
        }

        public bool InsertData(string table, string values)
        {
            if (dh.testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Insert into {table} Values({values})", dh.ConString);
                    cmd.ExecuteReader();
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
                dh.ConString.Close();
                return false;
            }

        }

        public string CompetitorStats(int MemberID)
        {
            DataHandler datah = new DataHandler();
            List<int[]> lpos = new List<int[]>();
           
                    try
                    {
                        lpos = datah.MemberCompetition(MemberID);
                        if (lpos != null)
                        {
                            if (lpos.Count != 0)
                            {
                                string final = "";
                                final = $"\tKata\tKumite\tUnison\tTeamKumite\nGold:\t{lpos[0][0]}\t{lpos[1][0]}\t{lpos[2][0]}\t{lpos[3][0]}";
                                final += $"\nSilver:\t{lpos[0][1]}\t{lpos[1][1]}\t{lpos[2][1]}\t{lpos[3][1]}";
                                final += $"\nSilver:\t{lpos[0][2]}\t{lpos[1][2]}\t{lpos[2][2]}\t{lpos[3][2]}";
                               
                                return final;
                            }
                        }


                        return "Member competed in 0 Competitions";
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                       
                        return null;
                    }          
        }     
    }
}
