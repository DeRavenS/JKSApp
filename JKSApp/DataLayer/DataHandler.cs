using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using JKSApp.BusinessLayer;
namespace JKSApp.DataLayer
{
    class DataHandler
    {
        
        OleDbConnection conString = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppContext.BaseDirectory}\JKSNew.mdb");

        public OleDbConnection ConString { get => conString; set => conString = value; }

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
                    case ObjectType.competition:
                        tbl = "Competition";
                        break;
                    case ObjectType.member:
                        tbl="Member";
                        break;
                    default:
                        return lobj;
                        
                }
                OleDbCommand cmd = new OleDbCommand($"Select * from {tbl}", ConString);
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
                            case ObjectType.competition:                  
                                lobj.Add(new Competition(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                                break;
                            case ObjectType.member:
                                lobj.Add(new Member(reader.GetInt32(0), reader.GetInt32(17), reader.GetInt32(18), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(19), reader.GetBoolean(15), reader.GetBoolean(16), reader.GetBoolean(20), reader.GetBoolean(21),reader.GetDateTime(22)));
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
                                lobj.Add(new Affiliation(reader.GetInt32(0), reader.GetDouble(1),reader.GetDateTime(2),reader.GetInt32(3)));
                                break;
                            case ObjectType.belt:
                                lobj.Add(new Achievement(reader.GetInt32(0), reader.GetString(1)));
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
            ConString.Close();
            return lobj;
        }
        //public List<Competition> GetComp()
        //{
        //    List<Competition> lcomp = new List<Competition>();
        //    if (testCon())
        //    {
        //        OleDbCommand cmd = new OleDbCommand("Select * from Competition",ConString);
        //        OleDbDataReader reader = cmd.ExecuteReader();
        //        using (reader)
        //        {
        //            while (reader.Read())
        //            {
        //                lcomp.Add(new Competition(reader.GetInt32(0),reader.GetString(1), reader.GetDateTime(2)));
        //            }
        //        }
        //    }
        //    ConString.Close();
        //    return lcomp;
        //}

        public bool testCon()
        {
            try
            {
                ConString.Open();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<int[]> MemberCompetition(int Memberid)
        {
            using (ConString)
            {   
                try
                {
                    ConString.Open();
                    string[] arrStats= new string[4];
                    OleDbCommand cmd = new OleDbCommand($"Select KataPosition,KumitePosition,UnisonPosition,TeamKumitePosition from MemberCompetition where MemberID={Memberid}",ConString);
                    OleDbDataReader reader = cmd.ExecuteReader();              

                    if (reader.HasRows)
                    {
                        int icount = 0;
                        List<int[]> lpos = new List<int[]>();
                        lpos.Add(new int[3] { 0, 0, 0 });
                        lpos.Add(new int[3] { 0, 0, 0 }); ;
                        lpos.Add(new int[3] { 0, 0, 0 }); ;
                        lpos.Add(new int[3] { 0, 0, 0 }); ;
                        int pointer = 0;
                       
                        while (reader.Read())
                        {
                            icount++;
                            
                            foreach (var item in lpos)
                            {
                                int option = reader.GetInt32(pointer);
                                switch (reader.GetInt32(pointer))
                                {
                                    case 1:
                                        item[0]++;
                                        break;
                                    case 2:
                                        item[1]++;
                                        break;
                                    case 3:
                                        item[2]++;
                                        break;
                                    default:
                                        break;
                                }
                                pointer++;
                            }
                        }
                        return lpos;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                    return null;
                }
                
            }
        }
       
    }
}
