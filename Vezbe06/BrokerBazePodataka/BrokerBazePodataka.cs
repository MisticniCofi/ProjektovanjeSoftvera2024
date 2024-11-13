using Domen;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace BrokerBazePodataka
{
    public class BrokerBazePodataka
    {
        private SqlConnection connection;
        public void Connect()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vezbe06;Integrated Security = True;");
                connection.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Nije uspesno uspostavljena veza sa bazom podataka!");
                throw;
            }
        }
        public void Disconnect()
        {
            connection?.Close();

        }
        public User GetUserByUserPass(User user)
        {
            try
            {
                string upit = $"select id, firstname, lastname from [user] where username=@user and password=@pass";
                using SqlCommand cmd = new SqlCommand(upit, connection);
                cmd.Parameters.AddWithValue("user", user.UserName);
                cmd.Parameters.AddWithValue("pass", user.Password);
                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = reader.GetInt64(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    return user;
                }
                else
                {
                    throw new Exception("Ne postoji korisnik sa zadatim podacima!");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Greska pri radu sa bazom!");
                Console.WriteLine(ex.Message);
                throw;
            }

        }
        public void DodajOsobu(Osoba o)
        {
            string insertQuery = "INSERT INTO osoba (Ime, Prezime, DatumRodjenja, Pol, Ptt) VALUES (@Ime, @Prezime, @DatumRodjenja, @Pol, @Ptt)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@Ime", o.Ime);
                cmd.Parameters.AddWithValue("@Prezime", o.Prezime);
                cmd.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                cmd.Parameters.AddWithValue("@Pol", o.Pol.ToString());
                cmd.Parameters.AddWithValue("@Ptt", o.Grad.Ptt);

                long generatedId = (long)cmd.ExecuteScalar();
                o.Id = generatedId;
            }
        }

        public List<Grad> VratiGradove(){
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from grad";
            using SqlDataReader reader = command.ExecuteReader();
            List<Grad> result = new List<Grad>();
            while (reader.Read())
            {
                Grad grad = new Grad();
                grad.Ptt = (long)reader["ptt"];
                grad.Naziv = (string)reader["naziv"];
                result.Add(grad);
            }
            return result;
        }


    }
}
