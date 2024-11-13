
using BrokerBP = BrokerBazePodataka.BrokerBazePodataka;

using Microsoft.Data.SqlClient;
using Domen;

namespace Primer01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vezbe05;Integrated Security=True;");
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into grad values (13456, 'Grad')";


            //SQL komanda koja nije upit zato ide ExecuteNonQuery (IzvrsiNeUpit)
            command.ExecuteNonQuery();

            connection.Close();

        }
    }
}