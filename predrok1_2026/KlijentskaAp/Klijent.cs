using Pomocne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskaAp
{
    public class Klijent
    {
        Socket soket;
        public Serializer serializer;

        public Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 9999);

            serializer = new Serializer(soket);
        }

        //sad treba ove poruke proslediti formi
        //zabo mi mozak
        public void PrimajPoruke()
        {
            while (soket.Connected)
            {
                Poruka poruka = serializer.Primi<Poruka>();
            }

        }

        public void Posalji(String s, Operacija o)
        {
            serializer.Posalji(s, o);
        }
    }
}
