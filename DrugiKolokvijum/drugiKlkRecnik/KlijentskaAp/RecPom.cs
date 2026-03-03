using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskaAp
{
    public class RecPom
    {
        public RecPom(string srpskaRec, string prevodi)
        {
            SrpskaRec = srpskaRec;
            Prevodi = prevodi;
        }

        public String SrpskaRec {  get; set; }

        public String Prevodi { get; set;   }
    }
}
