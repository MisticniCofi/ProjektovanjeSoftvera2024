using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class SrbRec
    {
        public int SrbRecId { get; set; }

        public string SrbNaziv { get; set; }

        public string VratiNazivKlase()
        {
            return this.GetType().Name;
        }
    }
}
