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
        public Socket klijentskiSoket;
        private Server server;
        public Serializer ser;
        public String username;


        public ClientHandler(Socket klijentskiSoket, Server server)
        {
            this.klijentskiSoket = klijentskiSoket;
            this.server = server;
            ser = new Serializer(klijentskiSoket);
        }

        internal void Handle()
        {
            while(true)
            {
                Poruka p = ser.Primi();

                switch(p.Operacija)
                {
                    case Operacija.LOGIN:
                    {
                            username = p.Tekst.Split(" ")[0];
                            String password = p.Tekst.Split(" ")[1].TrimEnd('\0');

                            User u = server.korisnici.FirstOrDefault(x => x.Username == username && x.Sifra == password);

                            if(u == null)
                            {
                                Poruka poruka = new Poruka(Operacija.ERROR, "Neuspesno", "/", "/");
                                ser.Posalji(poruka);
                                this.Stop();
                                return;
                            }

                            Poruka povratna = new Poruka(Operacija.LOGIN, "Uspesno", "/", "/");
                            ser.Posalji(povratna);
                            u.Ulogovan = true;

                            String ulogovani = String.Join(',', server.korisnici
                                .Where(x => x.Ulogovan)
                                .Select(x => x.Username));

                            Poruka broadcast = new Poruka(Operacija.OSVEZI_KORISNIKE, ulogovani, "/", "/");
                            

                            foreach(ClientHandler ch in server.klijenti)
                            {
                                ch.ser.Posalji(broadcast);
                            }
                            continue;

                    }

                    case Operacija.POSALJISVIMA:
                        {
                           // Poruka boradcast = new Poruka(Operacija.POSALJISVIMA, p.Tekst, username, "svima");
                            foreach(ClientHandler ch in server.klijenti)
                            {
                                ch.ser.Posalji(p);
                            }
                            continue;
                        }

                    case Operacija.POSALJI:
                        {
                            Poruka povratna = new Poruka(Operacija.POSALJI, p.Tekst, p.OdKoga, p.Kome);

                            ClientHandler ch = server.klijenti.FirstOrDefault(x => x.username == p.Kome);
                            ch.ser.Posalji(p);
                            continue;
                        }

                    

                }
            }
        }

        public void Stop()
        {
            server.klijenti.Remove(this);
            klijentskiSoket.Close();
        }

        
    }
}
