using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskaAp
{
    
    internal class Klijent
    {
        public Socket soket;
        byte[] data;
        public Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 9999);
        }

        public String Primi()
        {
            data = new byte[1024];
            soket.Receive(data);
            String porukaOdKlijenta = Encoding.UTF8.GetString(data);

            return porukaOdKlijenta;
        }

        public void Posalji(string poruka)
        {
            data = Encoding.UTF8.GetBytes(poruka);
            soket.Send(data);

        }

    }
}
