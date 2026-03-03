using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    public class User
    {
        public User(string ime, string prezime, string email, string sifra)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Sifra = sifra;
            Ulogovan = false;
        }

        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String Email { get; set; }

        public String Sifra { get; set; }

        public bool Ulogovan { get; set; }


    }
}
