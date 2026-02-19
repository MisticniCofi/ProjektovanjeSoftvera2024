using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class User
    {
        public User(string username, string sifra)
        {
            Username = username;
            Sifra = sifra;
            Ulogovan = false;
            PokrenuoKviz = false;
            TrenutnoPitanje = -1;
        }

        public String Username { get; set; }

        public String Sifra { get; set; }

        public bool Ulogovan { get; set; }

        public bool PokrenuoKviz { get; set; }

        public int TrenutnoPitanje { get; set; }
    }
}
