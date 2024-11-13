﻿using Domen;
using Microsoft.Data.SqlClient;
using System.Data;

Osoba o = new Osoba()
{
    Ime = "Ana",
    Prezime = "Anic",
    Pol = Pol.Zenski,
    DatumRodjenja = new DateTime(2000, 2, 2, 15, 45, 0),
    Grad = new Grad()
    {
        Ptt = 11000,
        Naziv = "Beograd"
    }
};

SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vezbe06;Integrated Security=True;");
try
{
    conn.Open();
    Console.WriteLine("Uspesno je uspostavljena konekcija sa bazom!");
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = conn;
    cmd.CommandText = $"insert into osoba output inserted.id values ('{o.Ime}', '{o.Prezime}', '{o.DatumRodjenja.ToString("yyyyMMdd HH:mm")}', '{o.Pol}', {o.Grad.Ptt})";

    long generatedId = (long)cmd.ExecuteScalar();
    if (generatedId > 0)
    {
        Console.WriteLine($"Osoba je uspesno sacuvana! Njen id je {generatedId}");
    }
}
catch (SqlException ex)
{
    Console.WriteLine("Greska: " + ex.Message);
}
finally
{
        conn?.Close();
}