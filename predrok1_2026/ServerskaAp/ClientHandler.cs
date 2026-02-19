using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pomocne;

namespace ServerskaAp
{
    internal class ClientHandler
    {
        public Socket soket;
        public Server s;

        public String username;

        public Serializer ser;

        public ClientHandler(Socket soket, Server server)
        {
            this.soket = soket;
            this.s = server;
            ser = new Serializer(this.soket);
        }

        public void Handle()
        {
            while(true)
            {
                Poruka poruka = ser.Primi<Poruka>();

                switch (poruka.Operacija)
                {
                    case Operacija.LOGIN:
                        {

                            if(s.trenutnoUlogovanih >= 5)
                            {
                                ser.Posalji("Vise od 5 korisnika", Operacija.ERROR);

                                soket.Close();
                                return;
                            }
                            username = poruka.Tekst;
                            bool postoji = false;

                            foreach(User u in s.registrovani)
                            {
                                if(u.Username.Equals(username))
                                {
                                    postoji = true;

                                    if (postoji && u.Ulogovan)
                                    {
                                        ser.Posalji("Vec ulogovan", Operacija.ERROR);

                                        soket.Close();
                                        return;
                                        
                                    }

                                    else if(postoji && !u.Ulogovan)
                                    {
                                        ser.Posalji("Uspesno ulogovan", Operacija.ODGOVOR);
                                        s.trenutnoUlogovanih++;
                                        u.Ulogovan = true;
                                       
                                       

                                        break;
                                    }
                                }

                                
                            }

                            if(!postoji)
                            {
                                ser.Posalji("Ne postoji", Operacija.ERROR);
                                soket.Close();
                                return;
                                
                            }
                            break;
                        }

                    case Operacija.LOGOUT:
                        {
                            s.trenutnoUlogovanih--;
                            ser.Posalji("Izlogovani ste", Operacija.LOGOUT);
                            soket.Close();

                            foreach(User u in s.registrovani)
                            {
                                if( u.Username.Equals(username))
                                {
                                    u.Ulogovan = false;
                                    return;
                                }
                            }

                            return;
                        };
                        

                    case Operacija.ADD:
                        {
                            String[] brojevi = poruka.Tekst.Split(" ");
                            int rezultat = Int32.Parse(brojevi[0]) + Int32.Parse(brojevi[1]);

                            ser.Posalji(rezultat.ToString(), Operacija.RESULT);
                            break;
                        }

                    case Operacija.MINMAX:
                        {
                            String[] brojevi = poruka.Tekst.Split();
                            int min = Int32.MaxValue;
                            int max = Int32.MinValue; ;
                            for (int i = 0; i < brojevi.Length; i++)
                            {
                                int pom = Int32.Parse(brojevi[i]);
                                if ( pom < min)
                                {
                                    min = pom;
                                }

                                if(pom > max)
                                {
                                    max = pom;
                                }


                            }

                            String tekst = "MIN " + min.ToString() + " MAX " + max.ToString();
                            ser.Posalji(tekst, Operacija.MINMAX);

                            break;
                        };

                    case Operacija.DATE:
                        {
                            ser.Posalji("CURRENT DATE " + DateTime.Now.ToString(("dd.MM.yyyy")), Operacija.DATE);
                            break;
                        }; 


                }

            }

        }
    }
}
