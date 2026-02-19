using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace ServerskaAp
{
    public class Server
    {
        public Socket serverskiSoket;

        public int trenutnoUlogovanih;
        public int maksUlogovanih;

        public List<ClientHandler> klijenti = new List<ClientHandler>();

        public List<User> registrovani = new List<User>
        {
            new User("pera", "pera"),
            new User("jana", "jana"),
            new User("zika", "zika"),
            new User("mika", "mika"),
            new User("ana", "ana"),
        };

        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Listen()
        {
            serverskiSoket.Bind(new IPEndPoint(new IPAddress.Parse("127.0.0.1"), 9999));
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


               Thread usluziKlijenta = new Thread(ch.Handle);
               usluziKlijenta.IsBackground = true;
               usluziKlijenta.Start();


            }
            
        }
    }
}
