using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class Rec
    {
        public Rec(string srpskaRec, List<string> prevodi)
        {
            SrpskaRec = srpskaRec;
            Prevodi = prevodi;
        }

        public String SrpskaRec { get; set; }

        public List<String> Prevodi { get; set; }
    }
}
