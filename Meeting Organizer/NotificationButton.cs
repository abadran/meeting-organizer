using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    class NotificationButton: System.Windows.Forms.Button
    {
        public Event evt { get; set; }
        private Database db = null;
        public NotificationButton(Event e, Database db_)
        {
            evt = e;
            db = db_;
        }
    }
}
