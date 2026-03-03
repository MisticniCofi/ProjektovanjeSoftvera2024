using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    public class User
    {
        public User(string sifra, string username)
        {
            Sifra = sifra;
            Username = username;
            Ulogovan = false;
        }

        public String Sifra { get; set; }

        public String Username { get; set; }

        public bool Ulogovan { get; set; }
    }
}
