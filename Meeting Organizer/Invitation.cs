using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    public class Invitation
    {
        public User[] users { get; set; }
        public Event evt { get; set; }
        public Invitation(Event e = null, User[] userList = null)
        {
            evt = e;
            users = userList;
        }
    }
}
