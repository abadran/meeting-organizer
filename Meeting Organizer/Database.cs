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
        private Meetingorganizer db;
        private MainForm mainForm;
        public Database()
        {
            //string filePath = Properties.Settings.Default.DBConnection;
            //if (File.Exists("C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf"))
            //{
            //    filePath = "Data Source=C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf";
            //}
            //db = new Meetingorganizer(filePath);
            db = new Meetingorganizer("Data Source=131.252.209.228,21; Database=meetingorganizer; User Id=test; Password=123456; Timeout=200;MultipleActiveResultSets='true'");
        }

        public Database(MainForm mainForm):
            this()
        {
            this.mainForm = mainForm;
        }

        public User getUserWithLogin(string login)
        {
            tryagain:
            try {
                IEnumerable<User> users = from p in db.User
                                          where (p.Login == login)
                                          select p;
                if (users.Count() != 0) {
                    return users.ElementAt(0);
                } else {
                    return null;
                }
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }
        // get the user with a particular login and password.
        public User getUserWithLoginAndPassword(string login, string password)
        {

            tryagain:
            try {
                IEnumerable<User> users = from p in db.User
                                          where (p.Login == login) && (p.Password == password)
                                          select p;
                if (users.Count() != 0) {
                    return users.ElementAt(0);
                } else {
                    return null;
                }
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        // create a new user in the db.
        public void createNewUser(User user)
        {
            tryagain:
            try {
                db.User.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        // get the list of notifications for a user.
        //public Notifications getNotificationsForUser(User user)
        public Event[] getNotificationsForUser(User user)
        {
            tryagain:
            try {
                IEnumerable<Event> eventList = from usr in db.User
                                               join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                               join evt in db.Event on evtInvitee.EventId equals evt.Id
                                               where (evtInvitee.InviteeResponse == 0) && (evtInvitee.InviteeId == user.Id)
                                               select evt;
                return eventList.ToArray();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
            //return new Notifications(eventList);
        }

        // get list of users.
        public User[] getUsers()
        {
            tryagain:
            try {
                IEnumerable<User> users = from p in db.User
                                          select p;
                return users.ToArray<User>();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        // get list of users except for the one with login loginOfUserToSkip.
        public User[] getUserNamesSkipping(string loginOfUserToSkip)
        {
            tryagain:
            try {
                IEnumerable<User> users = from p in db.User
                                          where p.Login != loginOfUserToSkip
                                          select p;
                return users.ToArray<User>();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        public User getUserWithId(int id)
        {
            tryagain:
            try {
                IEnumerable<User> users = from p in db.User
                                          where (p.Id == id)
                                          select p;
                if (users.Count() != 0) {
                    return users.ElementAt(0);
                } else {
                    return null;
                }
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }        

        public void createInvitation(Invitation invitation)
        {
            tryagain:
            try {
                db.Event.InsertOnSubmit(invitation.evt);
                db.SubmitChanges();
                //MessageBox.Show(invitation.evt.Id.ToString(), "foo", MessageBoxButtons.OK);
                if (invitation.users != null) {
                    foreach (User user in invitation.users) {
                        EventInviteeRelation ei = new EventInviteeRelation();
                        ei.EventId = invitation.evt.Id;
                        ei.InviteeId = user.Id;
                        db.EventInviteeRelation.InsertOnSubmit(ei);
                    }
                    db.SubmitChanges();
                }
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        public User[] getInviteesForEvent(Event e)
        {
            tryagain:
            try {
                IEnumerable<User> users = from usr in db.User
                                          join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                          where (evtInvitee.EventId == e.Id)
                                          select usr;
                return users.ToArray<User>();
            }
            catch (Exception exc) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        internal void acceptEvent(Event evt, User currentUser)
        {
            tryagain:
            try {
                IEnumerable<EventInviteeRelation> tmp = from ei in db.EventInviteeRelation
                                                        where (ei.InviteeId == currentUser.Id) && (ei.EventId == evt.Id)
                                                        select ei;
                EventInviteeRelation record = tmp.ElementAt(0);
                record.InviteeResponse = 1;
                db.SubmitChanges();
                mainForm.addBusyDay(evt.Start.Date);
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        internal void declineEvent(Event evt, User currentUser)
        {
            tryagain:
            try {
                IEnumerable<EventInviteeRelation> tmp = from ei in db.EventInviteeRelation
                                                        where (ei.InviteeId == currentUser.Id) && (ei.EventId == evt.Id)
                                                        select ei;
                EventInviteeRelation record = tmp.ElementAt(0);
                record.InviteeResponse = 2;
                db.SubmitChanges();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }
        public DateTime[] getDaysWithEventsForUserForMonth(User user, DateTime firstDayOfMonth)
        {
            tryagain:
            try {
                IEnumerable<DateTime> dateTime = from usr in db.User
                                                 join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                                 join evt in db.Event on evtInvitee.EventId equals evt.Id
                                                 where ((evt.CreatorId == user.Id) || ((evtInvitee.InviteeId == user.Id) && (evtInvitee.InviteeResponse == 1))) && ((evt.Start.Month == firstDayOfMonth.Month) && (evt.Start.Year == firstDayOfMonth.Year))
                                                 select evt.Start;
                return dateTime.ToArray();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        public Event[] getDailyEventsForUserForDay(User user, DateTime dateTime)
        {
            tryagain:
            try {
                IEnumerable<Event> dailyEvents = from usr in db.User
                                                 join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                                 join evt in db.Event on evtInvitee.EventId equals evt.Id
                                                 where ((evtInvitee.InviteeId == user.Id) && (evtInvitee.InviteeResponse == 1)) && (evt.Start.Date == dateTime.Date)
                                                 select evt;
                IEnumerable<Event> dailyEvents2 = from evt in db.Event
                                                  where (evt.CreatorId == user.Id) && (evt.Start.Date == dateTime.Date)
                                                  select evt;

                Event[] total = new Event[dailyEvents.Count() + dailyEvents2.Count()];
                dailyEvents.ToArray().CopyTo(total, 0);
                dailyEvents2.ToArray().CopyTo(total, dailyEvents.Count());
                return total;
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }

        //#### following getUpcomingEvents added by xcheng  Nov.14,  may be problematic...
        public Event[] getUpcomingEvents(User user, DateTime dateTime)
        {
            tryagain:
            try {
                IEnumerable<Event> upcomingEvents = from usr in db.User
                                                    join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                                    join evt in db.Event on evtInvitee.EventId equals evt.Id
                                                    where ((evtInvitee.InviteeId == user.Id) && (evtInvitee.InviteeResponse == 1)) && (evt.Start.Date >= dateTime.Date)
                                                    select evt;
                IEnumerable<Event> upcomingEvents2 = from evt in db.Event
                                                     where (evt.CreatorId == user.Id) && (evt.Start.Date >= dateTime.Date)
                                                     select evt;

                Event[] total = new Event[upcomingEvents.Count() + upcomingEvents2.Count()];
                upcomingEvents.ToArray().CopyTo(total, 0);
                upcomingEvents2.ToArray().CopyTo(total, upcomingEvents.Count());
                return total;
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }

        }


        public DateTime[] getTimeWithEventsForUserForMonthForDay(User user, DateTime DayOfMonth)
        {
            tryagain:
            try {
                IEnumerable<DateTime> dateTime = from usr in db.User
                                                 join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                                 join evt in db.Event on evtInvitee.EventId equals evt.Id
                                                 where ((evt.CreatorId == user.Id) || ((evtInvitee.InviteeId == user.Id) && (evtInvitee.InviteeResponse == 1))) && ((evt.Start.Day == DayOfMonth.Day) && (evt.Start.Month == DayOfMonth.Month) && (evt.Start.Year == DayOfMonth.Year))
                                                 select evt.Start;
                return dateTime.ToArray();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }
        public int[] getDurationWithEventsForUserForMonthForDay(User user, DateTime DayOfMonth)
        {
            tryagain:
            try {
                IEnumerable<int> durations = from usr in db.User
                                             join evtInvitee in db.EventInviteeRelation on usr.Id equals evtInvitee.InviteeId
                                             join evt in db.Event on evtInvitee.EventId equals evt.Id
                                             where ((evt.CreatorId == user.Id) || ((evtInvitee.InviteeId == user.Id) && (evtInvitee.InviteeResponse == 1))) && ((evt.Start.Day == DayOfMonth.Day) && (evt.Start.Month == DayOfMonth.Month) && (evt.Start.Year == DayOfMonth.Year))
                                             select evt.Duration;
                return durations.ToArray();
            }
            catch (Exception e) {
                System.Threading.Thread.Sleep(50);
                goto tryagain;
            }
        }
    }
}
