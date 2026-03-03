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
        public StreamWriter sw;
        public StreamReader sr;

        public Serializer(Socket soket)
        {
            this.soket = soket;
            ns = new NetworkStream(soket);
            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);
            sw.AutoFlush = true;
        }

        public void Posalji(object obj)
        {


            sw.WriteLine(JsonSerializer.Serialize(obj));
        }

        public T Primi<T>(){
            return JsonSerializer.Deserialize<T>(sr.ReadLine());

        }
    }
}
