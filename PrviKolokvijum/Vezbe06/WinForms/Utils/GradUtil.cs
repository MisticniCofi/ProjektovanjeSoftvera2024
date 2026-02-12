using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Utils
{
    internal class GradUtil
    {
        public static List<Grad> Gradovi { get; set; } = new List<Grad>()
        {
            new Grad
            {
                Ptt = 11000,
                Naziv = "Beograd"
            },
            new Grad
            {
                Ptt = 21000,
                Naziv = "Novi Sad"
            },
            new Grad
            {
                Ptt = 18000,
                Naziv = "Nis"
            },
        };
    }
}
