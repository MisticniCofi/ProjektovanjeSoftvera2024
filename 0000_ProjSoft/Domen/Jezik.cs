using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Jezik
    {
        public int JezikId { get; set; }

        public string NazivJezika { get; set; }

        public string SkraceniNaziv { get; set; }

        public override string ToString()
        {
            return $"{this.JezikId}  {this.NazivJezika} {this.SkraceniNaziv}";
        }

        public string VratiNazivKlase()
        {
            return this.GetType().Name;
        }
    }
}
