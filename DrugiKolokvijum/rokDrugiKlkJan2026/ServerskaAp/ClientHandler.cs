using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace ServerskaAp
{
    public class ClientHandler
    {
        private Socket klijentskiSoket;
        private Server server;
        public Serializer ser;

        public ClientHandler(Socket klijentskiSoket, Server server)
        {
            this.klijentskiSoket = klijentskiSoket;
            this.server = server;
        }

        internal void Handle()
        {
            while(true)
            {
                Poruka poruka = ser.Primi();

                switch(poruka.Operacija)
                {
                    
                }
            }
        }
    }
}
