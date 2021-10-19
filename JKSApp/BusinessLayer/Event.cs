using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKSApp.DataLayer;

namespace JKSApp.BusinessLayer
{
    class Event
    {
        int eventID;
        string eventDescription;
        DateTime eventDate;

        public Event()
        {
        }

        public Event(int eventID, string eventDescription, DateTime eventDate)
        {
            this.EventID = eventID;
            this.EventDescription = eventDescription;
            this.EventDate = eventDate;
        }

        public int EventID { get => eventID; set => eventID = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }

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
    }
}
