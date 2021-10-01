using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace JKSApp
{
    

    public partial class Form1 : Form
    {
        BindingSource source = new BindingSource();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Uni\DBD281\Project\Karate\JKSApp\JKSApp\DataLayer\JKSNew.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from Belt";
                OleDbDataReader reader = cmd.ExecuteReader();
                source.DataSource = reader;
                dataGridView1.DataSource = source;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
