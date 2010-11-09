using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Meeting_Organizer
{
    class Database
    {
        public Database()
        {
        }

        public User getUserWithLoginAndPassword(string login, string password)
        {
            string filePath = Properties.Settings.Default.DBConnection;
            if (File.Exists("C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf"))
            {
                filePath = "Data Source=C:\\Users\\Ahmed\\Documents\\Visual Studio 2010\\Projects\\Meeting Organizer\\Meeting Organizer\\Meeting Organizer.sdf";
            }
            MeetingOrganizer organizerDB = new MeetingOrganizer(filePath);
            IEnumerable<User> users = from p in organizerDB.User
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

        public DailySchedule getScheduleForUser(string login)
        {
            return null;
        }
    }
}
