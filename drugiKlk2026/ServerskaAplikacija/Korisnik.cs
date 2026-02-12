using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAplikacija
{
    internal class Korisnik
    {
        public Korisnik(string username, bool ulogovan)
        {
            Username = username;
            Ulogovan = ulogovan;
        }

        public String Username { get; set; }

        public bool Ulogovan { get; set; }
    }
}
