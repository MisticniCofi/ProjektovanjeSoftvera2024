using BrokerBP = BrokerBazePodataka.BrokerBazePodataka;
using Domen;
using System.Reflection.Metadata;

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
