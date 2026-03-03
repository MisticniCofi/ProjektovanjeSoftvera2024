using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class Odgovor
    {
        public List<int> VrednostiPolja { get; set; }

        public Odgovor(List<int> vrednostiPolja)
        {
            VrednostiPolja = vrednostiPolja;
        }
    }
}
