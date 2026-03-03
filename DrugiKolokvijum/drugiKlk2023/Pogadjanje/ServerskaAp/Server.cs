using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicko;

namespace ServerskaAp
{
    internal class Server
    {

        public Socket serverskiSoket;
        public Serializer ser;
        public Socket klijentskiSoket;

        public List<int> vrednosti;
        public int brojac = 0;
        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);   
            
        }

        public void Listen()
        {
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            serverskiSoket.Listen();
        }

        public void Start()
        {
            klijentskiSoket = serverskiSoket.Accept();
            ser = new Serializer(klijentskiSoket);

            this.Handle();
        }

        public void Handle()
        {
            while(true)
            {
                Zahtev z = ser.Primi<Zahtev>();
                int BrojPolja = z.BrojPolja;
                //Odgovor o = new Odgovor({ 0, 1 });
                if(BrojPolja == -1)
                {
                    Odgovor o = new Odgovor(vrednosti);
                    ser.Posalji(o);
                    continue;
                }

                if(BrojPolja == -2)
                {
                    brojac++;
                    if(brojac==5)
                    {
                        return;
                    }
                }

                
            }
        }

        public void Posalji(Odgovor o)
        {
            ser.Posalji(o);
        }

        public void Close()
        {
            klijentskiSoket.Close();
        }
    }
}
