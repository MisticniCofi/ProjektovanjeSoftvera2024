using Domen;
using Microsoft.Data.SqlClient;

namespace BrokerBazePodataka
{
    public class BrokerBP
    {
        SqlConnection connection;

        public BrokerBP()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IgircaVezba;Integrated Security=True");
        }

        public void Connect()
        {
            connection.Open();
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public void UnesiOruzije(Oruzije o)
        {

            this.Connect();

            string upit = "insert into Ajtem (Naziv, Opis, Cena, Retkost, Epitet) output inserted.Id values (@Naziv, @Opis, @Cena, @Retkost, @Epitet)";
            SqlCommand cmd = new SqlCommand(upit, connection);
            cmd.Parameters.AddWithValue("@Naziv", o.Naziv);
            if (o.Opis != null)
                cmd.Parameters.AddWithValue("@Opis", o.Opis);
            else
                cmd.Parameters.AddWithValue("Opis", "NULL");
            cmd.Parameters.AddWithValue("@Cena", o.Cena);
            cmd.Parameters.AddWithValue("@Retkost", o.Retkost.ToString());
            cmd.Parameters.AddWithValue("@Epitet", o.Epitet.ToString());
            //Enum.Parse<o.Epitet>



            int ubaceniId = (int)cmd.ExecuteScalar();

            upit = "insert into Oruzije (Id, Steta, BrzinaNapada) values (@Id, @Steta, @BrzinaNapada)";
            cmd = new SqlCommand(upit, connection);

            cmd.Parameters.AddWithValue("@Id", ubaceniId);
            cmd.Parameters.AddWithValue("@Steta", o.Steta);
            cmd.Parameters.AddWithValue("@BrzinaNapada", o.BrzinaNapada);

            cmd.ExecuteNonQuery();


            this.Disconnect();
        }



    }
}
