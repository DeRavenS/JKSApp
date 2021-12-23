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
        member,
        events,
        achievement,
        belt,
        category,
        grading,
        qualification,
        affiliation

    }

    public enum CU
    {
        Insert,
        Update
    }

    class DatabaseOperation
    {
        DataHandler dh = new DataHandler();
        
        public List<object> search(string table, string criteria, string srch,ObjectType ot)
        {
            List<object> lobj = new List<object>();
            if (dh.testCon())
            {
                OleDbCommand cmd = new OleDbCommand($"Select * from {table} where {criteria} like {srch}", dh.Con);             
                OleDbDataReader reader = cmd.ExecuteReader();
                using (reader)
                {                   
                    switch (ot)
                    {    
                        case ObjectType.dojo:
                            while (reader.Read())
                            {
                                lobj.Add(new Dojo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetBoolean(7)));
                            }                         
                            break;
                        case ObjectType.member:
                            break;
                        case ObjectType.belt:
                            while (reader.Read())
                            {
                                lobj.Add(new Belt(reader.GetInt32(0), reader.GetString(1)));
                            }                           
                            break;
                        default:
                            break;
                    }
                }
            }
            dh.Con.Close();
            return lobj;
        }

        public bool InsertData(string table, string values)
        {
            if (dh.testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Insert into {table} Values({values})", dh.Con);

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
                dh.Con.Close();
                return false;
            }

        }

        public string GetEntityName(string table, string ID)
        {
            if (dh.testCon())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Select * from {table} where {table}ID = {ID}", dh.Con);
                   
                    OleDbDataReader reader= cmd.ExecuteReader();
                    string text = "";
                    try
                    {
                        while (reader.Read())
                        {
                            text = reader.GetString(1);
                        }
                        
                       
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }
                    return text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
            else
            {
                MessageBox.Show("Can't connect to database");
                dh.Con.Close();
                return "";
            }

        }

        


    }
}
