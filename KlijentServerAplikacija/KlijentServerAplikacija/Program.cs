using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using PomocneFunkcije;
using System.Text;
using Domen;
using System.Text.Json;
using BrokerBazePodataka;


string path = @"D:\git\ProjektovanjeSoftvera2024\KlijentServerAplikacija\config.txt";
string pathItemi = @"D:\git\ProjektovanjeSoftvera2024\KlijentServerAplikacija\itemi.txt";
string podrazumevanaAdresa = "127.0.0.1";
string? json;
BrokerBP brokerBP = new BrokerBP();





using Socket serverskiSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
IPEndPoint endPoint = Provera.PoveziNaIpEndpointIzFajla(path);
serverskiSoket.Bind(endPoint);



Console.WriteLine("Cekamo na klijenta... ");
//otvoren za nadolazece konekcije koje mogu stati u red
 serverskiSoket.Listen();
    


//blokirajuca metoda
//prihvata prvi soket u redu i nastavlja
//ako nema u redu nijednog, blokira dok ne dobije
using Socket klijentskiSoket = serverskiSoket.Accept();
Console.WriteLine("Klijent povezan");

StreamReader sr = new StreamReader(pathItemi);
List<Oruzije> oruzija = new List<Oruzije>();
json = sr.ReadLine();

while (json != null)
{
    Oruzije or = JsonSerializer.Deserialize<Oruzije>(json);
    oruzija.Add(or);
    json = sr.ReadLine();
}
IEnumerable<Oruzije> poKriterijumu = oruzija.Where(x => x.Retkost == Retkost.Obicno);
foreach(var oruzije in poKriterijumu)
{
    Console.WriteLine(oruzije.Naziv);
}

return;
sr.Close();


using NetworkStream stream = new NetworkStream(klijentskiSoket);
using StreamReader reader = new StreamReader(stream);

json = reader.ReadLine();
Oruzije o = JsonSerializer.Deserialize <Oruzije> (json);

using StreamWriter writer = new StreamWriter(pathItemi, true);
writer.WriteLine(json);
//ako se ovde ne pozove flush a aplikacija se ugasi, nece se upisati nista
writer.Flush();

//Console.WriteLine(o.Epitet.ToString());

brokerBP.UnesiOruzije(o);

Console.ReadLine();




//while(true)
//{
//    klijentskiSoket.Receive(buffer);
//    string poruka = Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(poruka);

//    Console.WriteLine(ime+":");
//    poruka = Console.ReadLine();
//    klijentskiSoket.Send(Encoding.UTF8.GetBytes(ime + ":\n" + poruka));
//    Thread.Sleep(1000);
//}

