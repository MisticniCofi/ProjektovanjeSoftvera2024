using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAplikacija
{
    internal class ClientHandler
    {
        public Socket soket;
        byte[] data;
        Server server;
        String korisnickoIme;
        
        public ClientHandler(Socket soket, Server server)
        {
            this.soket = soket;
            this.server = server;
        }

        public void Handle()
        {
            while (true)
            {
                String poruka = this.Primi();

                if (poruka.StartsWith("LOGIN"))
                {
                    if (server.trenutnoUlogovanih > server.maksUlogovanih)
                    {
                        this.Posalji("ERROR: Dostignut maks broj klijenata na serevru");
                        soket.Close();
                        return;

                    }

                    korisnickoIme = poruka.Split(" ")[1];
                    korisnickoIme = korisnickoIme.Split("\0")[0];
                    //LOGIN korisnickoIme

                    //[0] LOGIN
                    //[1] korisnickoIme\0\0....

                    bool postoji = false;

                    foreach(Korisnik k in server.registrovani)
                    {
                        if (k.Username.Equals(korisnickoIme))
                        {
                            postoji = true;
                            if(k.Ulogovan == false)
                            {
                                this.Posalji("Uspesno logovanje");
                                k.Ulogovan = true;
                                break;
                            }

                            else
                            {
                                this.Posalji("ERROR: Korisnik je vec ulogovan");
                                return;
                                
                            }
                        }
                    }

                    if(postoji == false)
                    {
                        this.Posalji("ERROR: Korisnik ne postoji");
                        soket.Close();
                        return;
                    }
                    

                    

                }

                

                if (poruka.StartsWith("SEND"))
                {
                    this.Posalji("Poruka primljena");
                }

                if (poruka.StartsWith("LOGOUT"))
                {
                    
                    foreach(Korisnik k in server.registrovani)
                    {
                       if(k.Username.Equals(korisnickoIme))
                        {
                            k.Ulogovan = false;
                        }
                    }
                    this.Posalji("Uspesno ste se izlogovali");
                    soket.Close();
                    return;
                }

                
                Console.WriteLine(poruka);
            }
            
        }

        public String Primi()
        {
            data = new byte[1024];
            soket.Receive(data);
            String porukaOdKlijenta = Encoding.UTF8.GetString(data);

            return porukaOdKlijenta;
            
        }

        public void Posalji(string poruka)
        {
            data = Encoding.UTF8.GetBytes(poruka);
            soket.Send(data);

        }

    }
}
