using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    class DailySchedule
    {
        DailySchedule(IEnumerable<Event> e)
        {
            evts = e;
        }

        private DateTime date = DateTime.Now;
        private IEnumerable<Event> evts;

        public IEnumerable<Event> events
        {
            get
            {
                return evts;
            }
        }
        



        public DateTime dateTime
        {
            get
            {
                return date;
            }
            set
            {
                dateTime = value;
            }
        }
    }
}
