using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    internal class Server
    {
        public Socket serverskiSoket;
        public List<ClientHandler> klijenti = new List<ClientHandler>();

        public int trenutnoUlogovanih;

        public List<User> registrovani = new List<User> {
            new User("Miroslav", false),
            new User("Perica", false),
            new User("Natasa",false)
        };
            


        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Start()
        {
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            serverskiSoket.Listen();
            trenutnoUlogovanih = 0;

            while(true)
            {
                Socket klijentskiSoket = serverskiSoket.Accept();
                ClientHandler ch = new ClientHandler(klijentskiSoket, this);
                klijenti.Add(ch);
                trenutnoUlogovanih++;

                Thread usluziKlijenta = new Thread(ch.Handle);
                usluziKlijenta.Start();
            }
        }
    }
}
