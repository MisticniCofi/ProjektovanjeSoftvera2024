using System.IO;
using System.Net;
using System.Numerics;
using System.Text.RegularExpressions;

namespace PomocneFunkcije
{
    public class Provera
    {
        static string podrazumevanaAdresa = "127.0.0.1";
        static int podrazumevanPort = 9999;
        
        //ovo pozivamo samo ako smo pre toga proverili da fajl postoji
        public static void UpisiPodrazumevaniEndpointUFajl(string path)
        {
            
            File.Delete(path);
            using StreamWriter sw = new StreamWriter(path, false);
            
            Console.WriteLine("Namestam podrazumevan endpoint!");
            sw.WriteLine("Ip endpoint: " + podrazumevanaAdresa + ":" + podrazumevanPort);

            sw.Flush();
            return;
            
        }

        //ako je dat port
        public static void UpisiPodrazumevaniEndpointUFajl(string path, int port)
        {
            using StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("Ip endpoint: " + podrazumevanaAdresa + ":" + port);

        }
        public static bool PostojiLiFajl(string path)
        {
            //ako ne postoji fajl, napravi ga na datoj adresi
            if (!File.Exists(path))
            {
                Console.WriteLine("Fajl ne postoji, namestam podrazumevan ip endpoint u novi fajl na " + path );
                UpisiPodrazumevaniEndpointUFajl(path);
                return false;
            }
            return true;
        }


        //OBAVEZNO PRVO PROVERITI DA LI POSTOJI FAJL
        public static bool PrazanLiJeFajl(string path)
        {
            using StreamReader sr = new StreamReader(path);
            string prvaLinija = sr.ReadLine();
            //ako je fajl prazan
            //dodeli podrazumevanuIpAdresu
            if (prvaLinija == null)
            {
                Console.WriteLine("Fajl je prazan, upisujem podrazumevan endpoint");
                UpisiPodrazumevaniEndpointUFajl(path);
                return true;
            }
            


            return false;

        }
        //OBAVEZNO POZIVANJE NAKON GORNJE 2 FUNKCIJE
        public static (string, bool) ProveraIpFormataUConfigFajlu(string path)
        {
            using StreamReader sr = new StreamReader(path);
            string prvaLinija = sr.ReadLine();

            //koristimo regex koji proverava da li je ip u dobrom formatu
            //Ip endpoint: x.x.x.x.:yyyy
            //regexr.com vizualizacija
            //implicitno je proverio da l je port validan tj samo od 0-9999 mnogo me je mrzelo da namestam skroz
            //tj ako neko stavi 0 baci ce exception al me mrzi da proveravam
            Regex regex = new Regex(@"^(Ip endpoint: )(([0-9]{1,3}\.){3})([0-9]{1,3})(:)([0-9]{1,4})$");

            //Console.WriteLine(regex.IsMatch(prvaLinija));

            //!!!!!!!!!!!!!!! AKO SE SR NE ZATVORI PUCA EXCEPTION  !!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!! AKO SE SR NE ZATVORI PUCA EXCEPTION  !!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!! AKO SE SR NE ZATVORI PUCA EXCEPTION  !!!!!!!!!!!!!!!!!
            sr.Close();
            if (!regex.IsMatch(prvaLinija))
            {
                Console.WriteLine("Ip adresa nije prosla regex proveru (nije u dobrom formatu)!");
                
                    
                UpisiPodrazumevaniEndpointUFajl(path);
                return (podrazumevanaAdresa, false);
            }


            //ako je dobar format
            //cita prvu liniju, deli je po razmacima
            //split pravi novi niz, nama treba treci clan niza, pogledaj config.txt




            return (prvaLinija.Split(' ')[2],true);
        }

        public static IPAddress ProveraIpBrojeva(string ipEndPoint, string path)
        {
            string[] podeljenaIpAdresaBezPorta = ipEndPoint.Split(".");
            //posto ti ostane
            podeljenaIpAdresaBezPorta[3] = podeljenaIpAdresaBezPorta[3].Split(':')[0];
            string pom = "";
            for (int i = 0; i < 4; i++)
            {
                if (Int32.Parse(podeljenaIpAdresaBezPorta[i]) > 255)
                {
                    
                    //skreni paznju korisniku gde je pogresio
                    for(int j = 0; j < 4; j++)
                    {
                        if (j == i) pom += "****";
                        pom += podeljenaIpAdresaBezPorta[j];
                        if (j == i) pom += "****";
                        if (j != 3) pom += ".";
                    }
                    Console.WriteLine("brojevi u ip adresi ne smeju biti veci od 255! "+pom);
                    UpisiPodrazumevaniEndpointUFajl(path, Int32.Parse(ipEndPoint.Split(":")[1]));

                        

                    return IPAddress.Parse(podrazumevanaAdresa);
                }
            }
            Console.WriteLine("Prosao si sve provere majstore");
            Console.WriteLine("Ip endpoint: " + ipEndPoint);

            return IPAddress.Parse(ipEndPoint.Split(":")[0]);
        }

        //port je vec proveren
        public static int NamestiPort(string ipEndPoint)
        {
            return Int32.Parse(ipEndPoint.Split(":")[1]);
        }

        public static IPEndPoint PoveziNaIpEndpointIzFajla(string path)
        {
            if(PostojiLiFajl(path) == false) return new IPEndPoint(IPAddress.Parse(podrazumevanaAdresa), podrazumevanPort);
            if(PrazanLiJeFajl(path) == true) return new IPEndPoint(IPAddress.Parse(podrazumevanaAdresa), podrazumevanPort);
            if (ProveraIpFormataUConfigFajlu(path).Item2 == false) return new IPEndPoint(IPAddress.Parse(podrazumevanaAdresa), podrazumevanPort);
            return new IPEndPoint(ProveraIpBrojeva(ProveraIpFormataUConfigFajlu(path).Item1, path),
                NamestiPort(ProveraIpFormataUConfigFajlu(path).Item1));
            
        }

       
    }
}
