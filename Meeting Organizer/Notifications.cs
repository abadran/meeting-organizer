using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    public class Notifications
    {
        private IEnumerable<Event> events = null;
        public Notifications(IEnumerable<Event> e)
        {
            events = e;
        }
        public int numberOfNotifications {
            get {
                return events.Count();
            }
        }

        public Event getEvent(int i)
        {
            return events.ElementAt(i);
        }
    }
}
