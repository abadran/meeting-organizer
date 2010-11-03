using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    class User
    {
        private string name;
        private string login;

        public User()
        {
            name = "";
            login = "";
        }

        public User(string n, string l)
        {
            Name = n;
            login = l;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
    }
}
