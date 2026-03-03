using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace KlijentskaAp
{
    internal class Klijent
    {
        public Socket soket;

        public Serializer ser;

        public Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);    
            
        }

        public void Povezi()
        {
            soket.Connect("127.0.0.1", 9999);
            ser = new Serializer(soket);
        }

        public void Posalji(Zahtev z)
        {
            ser.Posalji(z);
        }

        public Odgovor Primi()
        {
            return ser.Primi<Odgovor>();
        }

        public void CLose()
        {
            soket.Close();
        }
    }
}
