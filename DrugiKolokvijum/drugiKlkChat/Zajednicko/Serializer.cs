using System.Net.Sockets;
using System.Text.Json;

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
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;
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
