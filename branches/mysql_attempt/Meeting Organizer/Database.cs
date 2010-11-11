using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Meeting_Organizer
{
    public class Database
    {
        private MeetingOrganizer db;
        public Database()
        {
            string filePath = Properties.Settings.Default.DBConnection;
            if (File.Exists("C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf"))
            {
                filePath = "Data Source=C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf";
            }
            db = new MeetingOrganizer(filePath);
        }

        public User getUserWithLogin(string login)
        {
            IEnumerable<User> users = from p in db.User
                        where (p.Login == login)
                        select p;
            if (users.Count() != 0)
            {
                return users.ElementAt(0);
            }
            else
            {
                return null;
            }
        }
        // get the user with a particular login and password.
        public User getUserWithLoginAndPassword(string login, string password)
        {

            IEnumerable<User> users = from p in db.User
                        where (p.Login == login) && (p.Password == password)
                        select p;
            if (users.Count() != 0)
            {
                return users.ElementAt(0);
            }
            else
            {
                return null;
            }
        }

        // create a new user in the db.
        public void createNewUser(User user)
        {
            db.User.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        // get the list of notifications for a user.
        public Notifications getNotificationsForUser(User user)
        {
            IEnumerable<Event>  eventList = from usr in db.User
                              join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId 
                              join evt in db.Event on evtInvitee.EventId equals evt.Id
                              where (evtInvitee.InviteeResponse == 0) && (evtInvitee.InviteeId == user.Id) 
                              select evt;
            return new Notifications(eventList);
        }

        // get list of users.
        public User[] getUsers()
        {
            IEnumerable<User> users = from p in db.User
                                        select p;
            return users.ToArray<User>();
        }

        // get list of users except for the one with login loginOfUserToSkip.
        public User[] getUserNamesSkipping(string loginOfUserToSkip)
        {
            IEnumerable<User> users = from p in db.User
                                        where p.Login != loginOfUserToSkip
                                        select p;
            return users.ToArray<User>();
        }

        public User getUserWithId(int id)
        {
            IEnumerable<User> users = from p in db.User
                        where (p.Id == id)
                        select p;
            if (users.Count() != 0)
            {
                return users.ElementAt(0);
            }
            else
            {
                return null;
            }
        }        

        public void createInvitation(Invitation invitation)
        {
            db.Event.InsertOnSubmit(invitation.evt);
            db.SubmitChanges();
            //MessageBox.Show(invitation.evt.Id.ToString(), "foo", MessageBoxButtons.OK);
            foreach (User user in invitation.users) {
                EventInviteeRelation ei = new EventInviteeRelation();
                ei.EventId = invitation.evt.Id;
                ei.InviteeId = user.Id;
                db.EventInviteeRelation.InsertOnSubmit(ei);
            }
            db.SubmitChanges();
        }

        public User[] getInviteesForEvent(Event e)
        {
            IEnumerable<User>  users = from usr in db.User
                              join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId 
                              where (evtInvitee.EventId == e.Id) 
                              select usr;
            return users.ToArray<User>();
        }

        internal void acceptEvent(Event evt, User currentUser)
        {
            IEnumerable<EventInviteeRelation> tmp = from ei in db.EventInviteeRelation
                                                    where (ei.InviteeId == currentUser.Id) && (ei.EventId == evt.Id)
                                                    select ei;
            EventInviteeRelation record = tmp.ElementAt(0);
            record.InviteeResponse = 1;
            db.SubmitChanges();
        }

        internal void declineEvent(Event evt, User currentUser)
        {
            IEnumerable<EventInviteeRelation> tmp = from ei in db.EventInviteeRelation
                                                    where (ei.InviteeId == currentUser.Id) && (ei.EventId == evt.Id)
                                                    select ei;
            EventInviteeRelation record = tmp.ElementAt(0);
            record.InviteeResponse = 2;
            db.SubmitChanges();
        }
    }
}
