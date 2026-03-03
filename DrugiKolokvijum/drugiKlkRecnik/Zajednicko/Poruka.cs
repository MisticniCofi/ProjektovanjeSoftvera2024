using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class Poruka
    {
        public Poruka(Operacija operacija, string tekst)
        {
            Operacija = operacija;
            Tekst = tekst;
        }

        public Operacija Operacija { get; set; }
        public List<Rec>? Reci { get; set; }

        public String Tekst { get; set; }

        //Razmisljam sta treba da se desi kada treba ceo recnik da se prebaci
        //Smislicemo
    }
}
