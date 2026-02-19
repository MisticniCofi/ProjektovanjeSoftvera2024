using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    internal class User
    {
        public User(string username, bool ulogovan)
        {
            Username = username;
            Ulogovan = ulogovan;
        }

        public String Username { get; set; }

        public bool Ulogovan { get; set; }
    }
}
