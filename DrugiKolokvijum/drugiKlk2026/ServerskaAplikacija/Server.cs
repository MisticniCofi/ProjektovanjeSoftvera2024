using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAplikacija
{
    internal class Server
    {
        Socket serverskiSoket;

        List<ClientHandler> klijenti = new List<ClientHandler>();

        public List<Korisnik> registrovani = new List<Korisnik>
        {
            new Korisnik("pera", false),
            new Korisnik("ana", false),
            new Korisnik("zika", false)
        };

        public int maksUlogovanih;
        public int trenutnoUlogovanih;

        public Server()
        {
            serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverskiSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            trenutnoUlogovanih = 0;

        }

        public void Start()
        {
            
            serverskiSoket.Listen();

            Console.WriteLine("Unesi broj maks ulogovanih: ");
            maksUlogovanih = Int32.Parse(Console.ReadLine());

            Thread ulogovaniNit = new Thread(IspisiUlogovane);
            ulogovaniNit.Start();

            while (true)
            {
                Socket klijentskiSoket = serverskiSoket.Accept();
                ClientHandler ch = new ClientHandler(klijentskiSoket, this);
                klijenti.Add(ch);
                trenutnoUlogovanih++;
                Console.WriteLine("Trenutno ulogovanih: " + trenutnoUlogovanih);
                Console.WriteLine("Maks ulogovanih " + maksUlogovanih);
                Console.WriteLine("Klijent povezan");


                Thread usluzivanjeKlijenta = new Thread(ch.Handle);
                usluzivanjeKlijenta.Start();

            }
            
        }

        public void IspisiUlogovane()
        {


            while (true)
            {
                foreach (Korisnik k in registrovani)
                {
                    if (k.Ulogovan == true)
                    {
                        Console.WriteLine(k.Username + " ulogovan");
                    }
                    else
                    {
                        Console.WriteLine(k.Username + " izlogovan");
                    }

                }
                Thread.Sleep(5000);
            }
        }

        public void Stop()
        {
            serverskiSoket.Close();

            foreach(ClientHandler ch in klijenti)
            {
                ch.soket.Shutdown(SocketShutdown.Both);
                ch.soket.Close();
            }
        }
    }
}
