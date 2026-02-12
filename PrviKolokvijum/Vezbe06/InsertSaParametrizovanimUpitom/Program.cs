using Domen;
using Microsoft.Data.SqlClient;

Osoba o = new Osoba()
{
    Ime = "Ana",
    Prezime = "Anic",
    Pol = Pol.Zenski,
    DatumRodjenja = new DateTime(2000, 2, 2, 15, 0, 0),
    Grad = new Grad()
    {
        Ptt = 11000,
        Naziv = "Beograd"
    }
};


using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vezbe06;Integrated Security=True;"))
{
    try
    {
        conn.Open();
        Console.WriteLine("Uspesno je uspostavljena konekcija sa bazom!");

        string insertQuery = "INSERT INTO osoba (Ime, Prezime, DatumRodjenja, Pol, Ptt) VALUES (@Ime, @Prezime, @DatumRodjenja, @Pol, @Ptt)";

        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
        {
            cmd.Parameters.AddWithValue("@Ime", o.Ime);
            cmd.Parameters.AddWithValue("@Prezime", o.Prezime);
            cmd.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
            cmd.Parameters.AddWithValue("@Pol", o.Pol.ToString());
            cmd.Parameters.AddWithValue("@Ptt", o.Grad.Ptt);

            int affectedRows = cmd.ExecuteNonQuery();
            if (affectedRows > 0)
            {
                Console.WriteLine("Osoba je uspesno sacuvana!");
            }
        }
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Greska: " + ex.Message);
    }
}
