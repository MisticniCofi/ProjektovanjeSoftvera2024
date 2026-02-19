using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskaAp
{
    public class Korisnik
    {
        private static Korisnik instance;
        public Socket soket;
        byte[] data;
        public Thread nitPrimaPoruke;
        public event Action<String> PorukaStigla;
        public String username;

        private Korisnik()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
        }

        public static Korisnik Instance
        {
            get
            { 
                if(instance == null)
                {
                    instance = new Korisnik();
                }
                return instance;
            }
        }

        public void PrimajPoruke()
        {
            if (nitPrimaPoruke != null) return;

            nitPrimaPoruke = new Thread(() =>
            {
                while(soket.Connected)
                {
                    String poruka = this.Primi();

                    PorukaStigla?.Invoke(poruka);
                }
            });

            nitPrimaPoruke.IsBackground = true;
            nitPrimaPoruke.Start();
        }

        public void PoveziSe()
        {
            soket.Connect("127.0.0.1", 9998);

        }

        public void Posalji(String poruka)
        {
            data = Encoding.UTF8.GetBytes(poruka);
            soket.Send(data);
        }

        public String Primi()
        {
            data  = new byte[1024];
            soket.Receive(data);
            String poruka = Encoding.UTF8.GetString(data);
            return poruka;
        }
    }

}

