using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace KlijentskaAplikacija
{
    public class Klijent
    {
        private static Klijent instance;
        public Socket soket;
        public Serializer ser;
        private Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }


        public static Klijent Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new Klijent();
                }

                return instance;
            }
        }

        public void Povezi()
        {
            soket.Connect("127.0.0.1", 9999);
            ser = new Serializer(soket);
        }

        public void Posalji(Operacija operacija, List<Pitanje> pitanja, String tekst,)
        {
            Poruka poruka = new Poruka(operacija, pitanja, tekst)
        }
    }
}
