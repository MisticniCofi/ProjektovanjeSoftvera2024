using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domen
{
    public class Prevod
    {
        public int JezikId { get; set; }
        public int SrbRecId { get; set; }
        public int PrevodRB { get; set; }
        public string PrevodRec { get; set; }

        public string VratiNazivKlase()
        {
            return this.GetType().Name;
        }

        public override string ToString()
        {
            return $"{JezikId} {SrbRecId} {PrevodRB} {PrevodRec}";
        }
    }
}
