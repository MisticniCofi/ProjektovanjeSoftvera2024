using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pomocne;

namespace ServerskaAp
{
    internal class ClientHandler
    {
        public Socket soket;
        public Server server;

        public Serializer ser;

        public ClientHandler(Socket soket, Server server)
        {
            this.soket = soket;
            this.server = server;
            ser = new Serializer(this.soket);
        }

        public void Handle()
        {
            while(true)
            {
                Poruka poruka = ser.Primi<Poruka>();


            }

        }
    }
}
