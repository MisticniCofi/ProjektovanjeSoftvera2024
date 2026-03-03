using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public BindingList<User> korisnici = new BindingList<User>
        {
            new User("user1","user1","user1@gmail.com","user1"),
            new User("user2","user2","user2@gmail.com","user2"),
            new User("user3","user3","user3@gmail.com","user3"),
            new User("t","tovic","t","t"),
        };

        public List<Rec> reci = new List<Rec>
        {
            new Rec("Kola", new List<String>{"Car", "Cart"}),
            new Rec("Mis", new List<String>{"Mouse"}),
            new Rec("Ikona", new List<String>{"Icon"}),
        };

        public List<ClientHandler> klijenti = new List<ClientHandler>();

        public Socket serverskiSoket;

        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Listen()
        {
            if (serverskiSoket.IsBound) return;

            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            serverskiSoket.Listen();
        }

        public void Start()
        {
            while(true)
            {
                Socket klijentskiSoket = serverskiSoket.Accept();

                ClientHandler ch = new ClientHandler(klijentskiSoket, this);
                klijenti.Add(ch);

                Thread usluziKlijenta = new Thread(ch.Handle);
                usluziKlijenta.Start();

            }
        }
    }
}
