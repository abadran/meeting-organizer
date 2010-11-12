using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    public class Notifications
    {
        public IEnumerable<Event> events { get; set; }
        public Notifications(IEnumerable<Event> e)
        {
            events = e;
        }
        public int numberOfNotifications {
            get {
                if (events == null) {
                    return 0;
                } else {
                    return events.Count();
                }
            }
        }

        public Event getEvent(int i)
        {
            return events.ElementAt(i);
        }
    }
}
