using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicko;

namespace KlijentskaAp
{
    public class Klijent
    {
        //Ja pravim singleton kad god imaju dve forme kod klijenta
        private static Klijent instance;
        public Socket soket;
        public Serializer ser;
        public String email;

        private Klijent()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);    
        }

        public static Klijent Instance
        {
            //kida ovaj intellisense
            //al ovo iskucajte jednom dvaput bar nezgodno je nesto (meni bar)
            get 
            { 
                if(instance==null)
                {
                    instance = new Klijent();
                } 
            return instance;
            }
        }

        public void Povezi()
        {
            if (soket.Connected) return;
            soket.Connect("127.0.0.1",9999);
            ser = new Serializer(soket);
        }

        public void Posalji(Poruka p)
        {
            ser.Posalji(p);
        }

        public Poruka Primi()
        {
            return ser.Primi();
        }
    }
}
