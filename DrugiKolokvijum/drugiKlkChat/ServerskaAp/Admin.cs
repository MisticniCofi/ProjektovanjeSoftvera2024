using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    public class Admin
    {
        public Admin(string email, string sifra, string ime, string prezime)
        {
            Email = email;
            Sifra = sifra;
            Ime = ime;
            Prezime = prezime;
        }

        public String Email { get; set; }

        public String Sifra { get; set; }

        public String Ime { get; set; }

        public String Prezime { get; set; }
    }
}
