using BrokerBP;
using Domen;
using System.Collections.Generic;

namespace TestKonzolna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrokerBazePodataka broker = new BrokerBazePodataka();
            List<Prevod> jezici = broker.VratiSlogovePrevod();
            broker.IspisiSlogove( jezici);

        }
    }
}
