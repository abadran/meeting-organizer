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
        private Database db = null;
        private User currentUser = null;
        public Invitation(User cuser, Database db_, Event e = null, User[] userList = null)
        {
            currentUser = cuser;
            db = db_;
            evt = e;
            users = userList;
        }

        public void writeToDB()
        {
            db.createInvitation(this);
        }

        public void accept(String reason)
        {
            
            db.acceptEvent(evt, currentUser, reason);
        }

        public void decline(String reason)
        {
            db.declineEvent(evt, currentUser, reason);
        }
    }
}
