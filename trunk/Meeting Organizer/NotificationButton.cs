using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    public class NotificationButton: System.Windows.Forms.Button
    {
        //public Event evt { get; set; }
        //private Database db = null;
        public Invitation invitation { get; set; }
        //public NotificationButton(Event e, Database db_)
        public NotificationButton(Invitation inv)
        {
            invitation = inv;
        }
    }
}
