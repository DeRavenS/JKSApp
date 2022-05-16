using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;
using System.Windows.Forms;
using System.Data;


namespace JKSApp.BusinessLayer
{
    class Event: table
    {
        int eventID;
        string eventDescription;

        public Event()
        {
        }

        public Event(int eventID, string eventDescription)
        {
            this.EventID = eventID;
            this.EventDescription = eventDescription;
        }

        public int EventID { get => eventID; set => eventID = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }

        public List<Event> getEvents()
        {
            DataHandler dh = new DataHandler();
            List<Event> lev = new List<Event>();
            foreach  (Event ev in dh.GetAll(ObjectType.events))
            {
                lev.Add(ev as Event);
            }
            return lev;
        }

        public DataTable getEventMembers()
        {
            DataHandler dh = new DataHandler();
            return dh.EventMembers(EventID.ToString());
        }

        public override void openInsertForm(CU op)
        {
            Presentation_Layer.frmCreateEvent frmCreateEvent = new Presentation_Layer.frmCreateEvent(op);
            frmCreateEvent.Show();
        }
        public override void openUpdateForm(Object obj)
        {
            Presentation_Layer.frmCreateEvent frmCreateEvent = new Presentation_Layer.frmCreateEvent(CU.Update,obj);
            frmCreateEvent.Show();
        }

        public bool InsertEvent()
        {
            DataHandler dh = new DataHandler();
            if (dh.InsertItem("Event(EventDescription,EventDate)", $"'{EventDescription}'"))
            {
                MessageBox.Show("Successfully added Event");
                return true;
            }
            else
            {
                MessageBox.Show("Operation Failed");
                return false;
            }
        }
        public bool updateEvent()
        {
            DataHandler dh = new DataHandler();
            if (dh.UpdateItem("Event", $"EventDescription='{EventDescription}'", EventID.ToString()))
            {
                MessageBox.Show("Event Updated Successfully");
                return true;
            }
            else return false;
        }

        public override void DeleteItem()
        {
            DataHandler dh = new DataHandler();
            DialogResult dr = MessageBox.Show($"Are you sure you want to delete {EventDescription} and all its associated entries from the database?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (dh.DeleteItem("MemberEvent", $"EventID={EventID}") && dh.DeleteItem("Event", $"EventID={EventID}"))
                {
                    MessageBox.Show("Delete Operation successful");
                }
                else
                {
                    MessageBox.Show("Could not delete all entries");
                }
            }
        }

        public List<Event> Search(string srch)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            List<Event> lev = new List<Event>();
            foreach (Event ev in databaseOperation.search("Event", $"EventDescription", $"'%{srch}%'", ObjectType.events))
            {
                lev.Add(ev);
            }

            return lev;
        }
    }
}
