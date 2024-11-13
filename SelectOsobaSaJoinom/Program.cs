
using Domen;
using Microsoft.Data.SqlClient;

using SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vezbe06;Integrated Security=True;");
try
{
    connection.Open();
    using SqlCommand command = connection.CreateCommand();
    command.CommandText = "select * from osoba o join grad g on(o.Ptt=g.Ptt)";
    using SqlDataReader reader = command.ExecuteReader();
    List<Osoba> result = new List<Osoba>();
    while (reader.Read())
    {
        Osoba osoba = new Osoba();
        osoba.Id = (long)reader["Id"];
        osoba.Ime = reader.GetString(1);
        osoba.Prezime = (string)reader["Prezime"];
        osoba.Pol = Enum.Parse<Pol>(reader["Pol"].ToString());
        osoba.DatumRodjenja = (DateTime)reader["DatumRodjenja"];
        osoba.Grad = new Grad();
        osoba.Grad.Ptt = (long)reader["ptt"];
        osoba.Grad.Naziv = (string)reader["naziv"];
        result.Add(osoba);
    }

    Console.WriteLine("Ucitana je lista osoba:");
    foreach (Osoba o in result)
    {
        Console.WriteLine($"Id:{o.Id}, Ime:{o.Ime}, Prezime:{o.Prezime}, Pol:{o.Pol}, Datum Rodjenja:{o.DatumRodjenja}, Grad:{o.Grad.Naziv}");
    }

}
catch (SqlException ex)
{
    Console.WriteLine($"Greska: {ex.Message}");
}