using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    internal class Server
    {
        public Socket serverskiSoket;
        public List<ClientHandler> klijenti = new List<ClientHandler>();
        public int maksBrojKlijenata;
        public int trenutnoUlogovanih;

        public List<String> ulogovani = new List<String>();
        public Server(int maksBrojKlijenata)
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998));
            this.maksBrojKlijenata = maksBrojKlijenata;
            trenutnoUlogovanih = 0;
        }

        public void Listen()
        {
            
            serverskiSoket.Listen();
        }

        public void Start()
        {
            this.Listen();

            while(true)
            {
                Socket klijentskiSoket = serverskiSoket.Accept();
                ClientHandler ch = new ClientHandler(klijentskiSoket, this);
                klijenti.Add(ch);

                Thread obradiKlijenta = new Thread(ch.Handle);
                obradiKlijenta.Start();
            }
        }
    }
}
