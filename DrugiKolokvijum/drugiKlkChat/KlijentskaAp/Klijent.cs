using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace KlijentskaAp
{
    public class Klijent
    {
        //necu singleton jer ipak treba samo jedna forma pa je lakse
        
        public Socket soket;

        public Serializer ser;

        public Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
        }

        public void Povezi()
        {
            if (soket.Connected) return;
            soket.Connect("127.0.0.1", 9999);
            ser = new Serializer(soket);
        }

        public void Posalji(Poruka p)
        {
            ser.Posalji(p);
        }

        public Poruka Primi()
        {
            return ser.Primi();
        }
        
    }
}
