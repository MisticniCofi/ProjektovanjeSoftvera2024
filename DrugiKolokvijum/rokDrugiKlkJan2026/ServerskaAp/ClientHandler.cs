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
        private Socket klijentskiSoket;
        private Server server;
        public Serializer ser;
        public String username;
        public String sifra;
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
                Poruka poruka = ser.Primi();

                switch(poruka.Operacija)
                {
                    case Operacija.LOGIN:
                    {
                            if (server.trenutnoUlogovanih >= server.maksUlogovanih)
                            {
                                server.klijenti.Remove(this);
                                this.Odbij("Prepun server");
                                return;
                            }

                            username = poruka.Tekst.Split(" ")[0];
                            sifra = poruka.Tekst.Split(" ")[1].TrimEnd('\0');

                            User user = server.registrovani.FirstOrDefault(u => (u.Username == username && u.Sifra == sifra));

                            if (user == null)
                            {
                                this.Odbij("Ne postoji korisnik");
                                server.klijenti.Remove(this);
                                return;
                            }

                            if (user.Ulogovan)
                            {
                                this.Odbij("Vec ulogovan");
                                server.klijenti.Remove(this);
                                return;
                            }

                            user.Ulogovan = true;
                            server.trenutnoUlogovanih++;
                            ser.Posalji(new Poruka(Operacija.ODGOVOR, null, "Uspesno"));

                            break;
                    }

                    case Operacija.PITANJA:
                    {
                            List<Pitanje> random5 = (List<Pitanje>) server.pitanja.OrderBy(x => Random.Shared.Next()).Take(5).ToList();
                            ser.Posalji(new Poruka(Operacija.ODGOVOR, random5, "eo ti pitanja"));
                            User user = server.registrovani.FirstOrDefault(u => (u.Username == username && u.Sifra == sifra));
                            user.PokrenuoKviz = true;
                            user.TrenutnoPitanje = 0;
                            break;
                    }

                    case Operacija.ODGOVOR:
                        {
                            User user = server.registrovani.FirstOrDefault(u => (u.Username == username && u.Sifra == sifra));
                            
                            user.TrenutnoPitanje++;
                            break;
                        }

                    case Operacija.LOGOUT:
                        {

                            User user = server.registrovani.FirstOrDefault(u => (u.Username == username && u.Sifra == sifra)); 
                            user.Ulogovan = false;
                            server.klijenti.Remove(this);
                            return;
                        }


                }
            }
        }

        public void Odbij(String tekstGreske)
        {
            ser.Posalji(new Poruka(Operacija.ODGOVOR, null, tekstGreske));

        }
    }
}
