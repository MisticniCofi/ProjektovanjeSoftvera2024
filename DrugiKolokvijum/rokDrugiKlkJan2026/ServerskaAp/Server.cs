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
        public Socket serverskiSoket;

        public int trenutnoUlogovanih;
        public int maksUlogovanih;

        public List<ClientHandler> klijenti = new List<ClientHandler>();

        public BindingList<User> registrovani = new BindingList<User>
        {
            new User("pera", "pera"),
            new User("jana", "jana"),
            new User("zika", "zika"),
            new User("mika", "mika"),
            new User("ana", "ana"),
        };

        public List<Pitanje> pitanja = new List<Pitanje>
        {
            new Pitanje("Koji je najbolji faks?", new List<String> {"fon","etf","fpn"}, 0, 5),
            new Pitanje("Kad ne znas tacan odgovor pritisni?", new List<String> {"a","b","c"}, 1, 5),
            new Pitanje("Dana u godini?", new List<String> {"19","365","2"}, 1, 10),
            new Pitanje("Sadasnja godina?", new List<String> {"2001","2089","2026"}, 2, 5),
            new Pitanje("Najbolji slatkis?", new List<String> {"medeno srce","jafa","muchmellow"}, 0, 5),
            new Pitanje("zemlja u kojoj zivimo?", new List<String> {"aa","bb","srb"}, 2, 5),
            new Pitanje("Najjaci teniser?", new List<String> {"Djovak","Djokovic","No1e"}, 0, 10),
            new Pitanje("Najveca opstina u Bg?", new List<String> {"NBG","Vozdovac","Palilula"}, 2, 5),
            new Pitanje("Najveca zemlja na svetu", new List<String> {"Amerika","Rusija","Kina"}, 1, 5),
            new Pitanje("Po kom liku se zove anime Naruto?", new List<String> {"Saskeu","Sakuri","Narutu"}, 2, 5),
        };

        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            trenutnoUlogovanih = 0;
        }

        public void Listen()
        {
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
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
