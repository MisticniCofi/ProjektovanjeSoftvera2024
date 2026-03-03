using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace ServerskaAp
{
    public class ClientHandler
    {
        private Socket klijentskiSoket;
        private Server server;
        String username;
        public Serializer ser;

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
                

                switch (p.Operacija)
                {
                    case Operacija.LOGIN:
                        {
                            //ja cu samo slati login u tekst formatu - email sifra
                            String email = p.Tekst.Split(" ")[0];
                            String sifra = p.Tekst.Split(" ")[1];

                            User u = server.korisnici.FirstOrDefault(x =>  x.Email == email && x.Sifra == sifra);

                            if(u == null)
                            {
                                Poruka povratna; 
                                povratna = new Poruka(Operacija.ERROR, "Ne postoji korisnik sa emailom i sifrom");
                                ser.Posalji(povratna);
                                continue;
                            }

                            u.Ulogovan = true;
                            Poruka uspesno = new Poruka(Operacija.LOGIN, "Uspesno");
                            uspesno.Reci = server.reci;
                            ser.Posalji(uspesno);


                            continue;
                        }

                    case Operacija.PREVEDI:
                        {
                            Rec r = server.reci.FirstOrDefault(x => x.SrpskaRec == p.Tekst);
                            if (r == null)
                            {
                                Poruka povratna;
                                povratna = new Poruka(Operacija.ERROR, "Ne postoji prevod za datu rec");
                                ser.Posalji(povratna);
                                continue;
                            }

                            Poruka uspesno = new Poruka(Operacija.PREVEDI, String.Join(',', r.Prevodi));
                            ser.Posalji(uspesno);

                            continue;
                        }

                    case Operacija.UNESI_PREVOD:
                        {
                            //samo cu da posaljem jednu rec
                            Rec r = p.Reci[0];
                            server.reci.Add(r);

                            
                            continue;
                        }
                }
            }
        }

        public void Stop()
        {
            server.klijenti.Remove(this);
            //klijentskiSoket.Shutdown(SocketShutdown.Both);
        }



    }
}
