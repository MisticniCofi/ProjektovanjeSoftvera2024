using Microsoft.Data.SqlClient;

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

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}