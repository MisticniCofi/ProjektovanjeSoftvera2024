//i namespace i klasa imaju naziv BrokerBazePodataka
//stoga je potrebna ova skalamerija ispod da se kompajler ne bi zbunio

using BrokerBP = BrokerBazePodataka.BrokerBazePodataka;
using Domen;
using System.Reflection.Metadata;

//kontroler poslovne logike, procitaj skriptu i shvati (5 min)
//dodaje i vraca domenske objekte skladistene u bazi podataka

namespace PoslovnaLogika
{
    public class Kontroler
    {


        private BrokerBP bbp = new BrokerBP();
        public User Login(User u)
        {
            bbp.Connect();
            try
            {
                User dbUser = bbp.GetUserByUserPass(u);
                return dbUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public void AddPerson(Osoba o)
        {
            bbp.Connect();
            try
            {
                bbp.DodajOsobu(o);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }

        public List<Grad> VratiGradove()
        {
            bbp.Connect();
            try
            {
                return bbp.VratiGradove();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                bbp.Disconnect();
            }
        }
    }
}
