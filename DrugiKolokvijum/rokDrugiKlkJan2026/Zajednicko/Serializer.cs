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
        public NetworkStream soketStream;
        public StreamReader sr;
        public StreamWriter sw;

        public Serializer(Socket soket) 
        {
            this.soket = soket;
            soketStream = new NetworkStream(soket);
            sr = new StreamReader(soketStream);
            sw = new StreamWriter(soketStream);
            sw.AutoFlush = true;
        }

        public void Posalji(Poruka poruka)
        {
            String tekstPoruke = JsonSerializer.Serialize(poruka);
            sw.WriteLine(tekstPoruke);
        }

        public Poruka Primi()
        {
            Poruka poruka = JsonSerializer.Deserialize<Poruka>(sr.ReadLine());
            return poruka;
        }
    }
}
