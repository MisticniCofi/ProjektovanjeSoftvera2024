using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerskaAp
{
    internal class ClientHandler
    {
        public Socket soket;
        public Server server;
        byte[] data;
        public String username;

        public ClientHandler(Socket soket, Server server) { 
            this.soket = soket;
            this.server = server;
        }

        public void Handle()
        {
            while (soket.Connected)
            {
                String porukaOdKlijenta = this.Primi();
                
                

                if(porukaOdKlijenta.StartsWith("LOGIN"))
                {
                    if(server.trenutnoUlogovanih >= server.maksBrojKlijenata)
                    {
                        this.Posalji("maks broj klijenata vec povezan nema mesta");
                        soket.Close();
                        return;
                    }
                    username = porukaOdKlijenta.Split(" ")[1].Trim();
                    foreach (String u in server.ulogovani)
                    {
                        if(u.Equals(username))
                        {
                            this.Posalji("Vec ulogovan korisnik sa ovim imenom");
                            soket.Close();
                            return;
                        }
                    }

                    
                    server.ulogovani.Add(username);
                    this.Posalji("Uspesno logovanje");

                    this.PosaljiSvima("ADD " + username);
                    //server.trenutnoUlogovanih++;

                    //String sviUlogovani = "";
                    //foreach(String u in server.ulogovani)
                    //{
                    //    if (u.Equals(username)) continue;
                    //    sviUlogovani += " " + u;
                    //}
                    //this.Posalji(sviUlogovani);
                }
                if (porukaOdKlijenta.StartsWith("SEND"))
                {
                    String od = porukaOdKlijenta.Split(" ")[1].Trim();
                    String ka = porukaOdKlijenta.Split(" ")[2].Trim();
                    String poruka = porukaOdKlijenta.Split(" ")[3].Trim();

                    this.PosaljiOdredjenom("MESSAGE FROM " + od + ": " + poruka, ka);
                    continue;
                }
                if (porukaOdKlijenta.StartsWith("LOGOUT"))
                {
                    this.PosaljiSvima("REMOVE " + username);
                    server.ulogovani.Remove(username);
                    this.Posalji("Izlogovani ste " + username);
                    soket.Close();
                    server.trenutnoUlogovanih--;
                    server.klijenti.Remove(this);
                    return;
                }

            }

        }

        public void Posalji(String poruka)
        {
            data = Encoding.UTF8.GetBytes(poruka);
            soket.Send(data);
        }

        public String Primi()
        {
            data = new byte[1024];
            soket.Receive(data);
            String poruka = Encoding.UTF8.GetString(data);
            return poruka;
        }

        public void PosaljiSvima(String poruka)
        {
            foreach(ClientHandler ch in server.klijenti)
            {
                if (ch.Equals(this)) continue;

                ch.Posalji(poruka);
            }
        }

        public void PosaljiOdredjenom(String poruka, String username)
        {
            
            foreach(ClientHandler klijent in server.klijenti)
            {
                if(klijent.username == username)
                {
                    klijent.Posalji(poruka);
                    return;
                }
            }
        }
    }
}
