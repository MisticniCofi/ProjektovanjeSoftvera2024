using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    public class Server
    {

        public List<Admin> admini = new List<Admin>
        {
            new Admin("pera@gmail.com", "123456","Pera","Peric"),
            new Admin("mara@gmail.com", "123456", "Mara", "Maric"),
            new Admin("t", "t", "t", "tovic")
        };

        public BindingList<User> korisnici = new BindingList<User>
        {
            new User("petko", "petko"),
            new User("cvetko", "cvetko"),
            new User("petka", "petka")
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

            try
            {

                while (true)
                {
                    Socket klijentskiSoket = serverskiSoket.Accept();

                    ClientHandler ch = new ClientHandler(klijentskiSoket, this);
                    klijenti.Add(ch);
                    Thread usluziKlijenta = new Thread(ch.Handle);
                    usluziKlijenta.IsBackground = true;
                    usluziKlijenta.Start();
                }
            }
            catch (SocketException se)
            {

                MessageBox.Show("Zaustavljen server");
            }
        }

        public void Stop()
        {
            foreach(ClientHandler ch in klijenti)
            {
                //nisam siguran sta ide prvo
                ch.klijentskiSoket.Shutdown(SocketShutdown.Both);
                ch.klijentskiSoket.Close();
            }
           // serverskiSoket.Close();
        }
    }
}
