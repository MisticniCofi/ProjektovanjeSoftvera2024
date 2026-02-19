using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pomocne
{
    public class Serializer
    {
        public Socket soket;
        public NetworkStream soketStream;
        public StreamReader sr;
        public StreamWriter sw;

        public Serializer(Socket s)
        {
            soket = s;
            soketStream = new NetworkStream(s);
            sr = new StreamReader(soketStream);
            sw = new StreamWriter(soketStream);
            sw.AutoFlush = true;
        }

        public void Posalji(String poruka, Operacija o)
        {
            Poruka p = new Poruka(poruka, o);
            sw.WriteLine(JsonSerializer.Serialize(p));
        }

        public Poruka Primi<Poruka>()
        {
            return JsonSerializer.Deserialize<Poruka>(sr.ReadLine());
        }
    }
}
