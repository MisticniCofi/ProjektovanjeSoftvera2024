using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    public class Red
    {
        public Red(int prvaKol, int drugaKol, int trecaKol)
        {
            PrvaKol = prvaKol;
            DrugaKol = drugaKol;
            TrecaKol = trecaKol;
        }

        public int PrvaKol { get; set; }
        public int DrugaKol { get; set; }
        public int TrecaKol { get; set; }


    }
}
