using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using JKSApp.Presentation_Layer;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JKSApp.BusinessLayer
{
    class Competition:IComparable
    {
        DatabaseOperation operation = new DatabaseOperation();
        int compNum;
        string compDescription;
        DateTime compDate;
      

        public Competition()
        {
        }

        public Competition(int compNum,string compDescription, DateTime compDate )
        {
            this.compNum = compNum;
            this.compDescription = compDescription;
            this.compDate = compDate;
            
        }
        public int CompetitionNumber { get => compNum; set => compNum = value; }
        public string CompetitionDescription { get => compDescription; set => compDescription = value; }
        public DateTime CompetitionDate { get => compDate; set => compDate = value; }
        

        public int CompareTo(object obj)
        {
            Competition comp = obj as Competition;
            return CompetitionNumber.CompareTo(comp.compNum);
        }

       public List<Competition> CompSearch(string srch)
        {       
            List<object> lobj = new List<object>();
            List<Competition> lcomp = new List<Competition>();
            lobj = operation.search("Competition","CompetitionDescription",$"'%{srch}%'",ObjectType.competition);
            foreach (var obj in lobj)
            {
                lcomp.Add(obj as Competition);
            }
            if (lcomp.Count==0)
            {
                MessageBox.Show("No Competitions found");
            }
            return lcomp;
        }

        public bool InsertComp(string compdescr, DateTime compdate)
        {
            if (operation.InsertData("Competition(CompetitionDescription,CompetitionDate)", $"'{compdescr}','{compdate}'"))
            {
                return true;
            }
            else
            return false;
        }
       
        public List<Competition> getComp()
        {
            DataHandler dh = new DataHandler();
            List<Competition> lcomp = new List<Competition>(); ;
            foreach (var item in dh.GetAll(ObjectType.competition))
            {
                lcomp.Add(item as Competition);
            }
            return lcomp;
        }
        public List<Competition> UpcomingComp()
        {
            DataHandler dh = new DataHandler();
            List<Competition> lcomp = getComp();
            List<Competition> lUpcoming = new List<Competition>();
            foreach  (Competition comp in lcomp)
            {
                if (comp.compDate>DateTime.Now)
                {
                    lUpcoming.Add(comp);
                }
            }
            return lUpcoming;
        }
        public List<Competition> ClosedComp()
        {
            DataHandler dh = new DataHandler();
            List<Competition> lcomp = getComp();
            List<Competition> lClosed = new List<Competition>();
            foreach (Competition comp in lcomp)
            {
                if (comp.compDate < DateTime.Now)
                {
                    lClosed.Add(comp);
                }
            }
            return lClosed;
        }
    }
}
