using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class Poruka
    {
        public Poruka(Operacija operacija, string tekst, string odKoga, string kome)
        {
            Operacija = operacija;
            Tekst = tekst;
            OdKoga = odKoga;
            Kome = kome;

            Vreme = DateTime.Now;
        }

        public Operacija Operacija { get; set; }

        public String Tekst { get; set; }

        public String OdKoga {  get; set; }

        public String Kome { get; set; }

        public DateTime Vreme { get; set; }
        

    }
}
