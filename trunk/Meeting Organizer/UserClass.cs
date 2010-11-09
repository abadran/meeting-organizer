using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meeting_Organizer
{
    class UserClass
    {
        private string name;
        private string login;

        public UserClass()
        {
            name = "";
            login = "";
        }

        public UserClass(string n, string l)
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
