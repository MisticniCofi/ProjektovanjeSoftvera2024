using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicko
{
    public class Serializer
    {
        public Socket soket;
        public NetworkStream ns;
        public StreamReader sr;
        public StreamWriter sw;

        public Serializer(Socket soket)
        {
            this.soket = soket;
            ns = new NetworkStream(soket);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            sr = new StreamReader(ns); 
        }

        public void Posalji(Poruka p)
        {
            sw.WriteLine(JsonSerializer.Serialize(p));
        }

        public Poruka Primi()
        {
            Poruka p = JsonSerializer.Deserialize<Poruka>(sr.ReadLine());
            return p;
        }
    }
}
