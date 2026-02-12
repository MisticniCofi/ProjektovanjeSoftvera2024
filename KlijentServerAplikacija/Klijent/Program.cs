using Domen;
using PomocneFunkcije;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;


string path = @"D:\git\ProjektovanjeSoftvera2024\KlijentServerAplikacija\config.txt";
using Socket soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


IPEndPoint server = Provera.PoveziNaIpEndpointIzFajla(path);

Thread.Sleep(1000);
soket.Connect(server);

byte[] nizBajtova = new byte[1024];

Console.WriteLine("Unesite username");
string? ime = Console.ReadLine();

Oruzije o = new Oruzije();
o.Id = 1;
o.Steta = 10;
o.Naziv = "Mac";
o.BrzinaNapada = 5;
o.Cena = 200;

using NetworkStream stream = new NetworkStream(soket);
using StreamWriter writer = new StreamWriter(stream);

string json = JsonSerializer.Serialize(o);

writer.WriteLine(json);







//while (true) {
//    Console.WriteLine(ime+":");    
//    string? poruka = Console.ReadLine();
//    nizBajtova = Encoding.UTF8.GetBytes(ime + ":\n"+poruka);
//    soket.Send(nizBajtova);
//    Thread.Sleep(1000);
//    soket.Receive(nizBajtova);
//    Console.WriteLine(Encoding.UTF8.GetString(nizBajtova));


//}
