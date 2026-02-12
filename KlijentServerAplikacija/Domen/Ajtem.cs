using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public abstract class Ajtem
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string? Opis { get; set; }
        public int Cena { get; set; }
        public Retkost Retkost { get; set; }

        public Epitet Epitet { get; set; }
    }
}
