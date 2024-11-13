
using Domen;
using Microsoft.Data.SqlClient;


//using automatski oslobadja memoriju promenljive po zavrsetku koriscenja
//tako sto poziva funkciju Dispose() na kraju bloka nad kojim je pozvan ili
//dokle god vazi opseg te promenljive
//u slucaju SqlConnectiona, to je funkcija Close() koja nasledjuje Dispose()
//using je prakticniji jer ne moramo sami da zatvaramo konekciju vec se program sam brine za to
//posebno je bitno osloboditi memoriju onih objekata koje garbace collector nece sam pokupiti

//u ovom slucaju je opseg promenljive cela skripta
using SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vezbe06;Integrated Security=True;");
try
{
    connection.Open();

    //drugi nacin kreiranja upita
    //omogucava neke naprednije opcije koje ja ne vidim kako mogu da se korsite
    //ako neko zna, neka napise

    //SqlConnection sadrzi metodu CreateCommand()
    //posle koje imamo SqlCommand objekat
    //koji zna sa kojom bazom je povezan ali ne sadrzi nikakav upit pa moramo i njega proslediti

  
    using SqlCommand command = connection.CreateCommand();
    command.CommandText = "select * from osoba o join grad g on(o.Ptt=g.Ptt)";

    //instanca SqlDataReadera zaduzena za izvrsavanje upita
    //command mu prosledjuje instancu SqlConnectiona
    //reader izvrsava upit i cuva podatke u matrici
    //postoji polje FieldCount koje nam daje broj kolona koje ima reader
    using SqlDataReader reader = command.ExecuteReader();
    
    //lista Osoba u koju se smesta rezultat upita
    List<Osoba> result = new List<Osoba>();

    //Read() vraca true ako ima redova/slogova/ntorki u bazi koji jos uvek nisu procitani
    while (reader.Read())
    {
        //pravi novu Osobu u koju smesta jedan ceo slog

        Osoba osoba = new Osoba();

        //potrebno je da podatke iz readera smestimo u objekat
        //reader["Id"] je podatak koji se nalazi u koloni "Id" nakon SQL upita
        //treba se kastovati jer po defaultu rider daje objekte
        osoba.Id = (long)reader["Id"];
        osoba.Ime = reader.GetString(1);
        osoba.Prezime = (string)reader["Prezime"];
        //konverzija stringa u Enum
        osoba.Pol = Enum.Parse<Pol>(reader["Pol"].ToString());
        osoba.DatumRodjenja = (DateTime)reader["DatumRodjenja"];

        osoba.Grad = new Grad();
        osoba.Grad.Ptt = (long)reader["ptt"];
        osoba.Grad.Naziv = (string)reader["naziv"];
        result.Add(osoba);
    }

    
    Console.WriteLine("Ucitana je lista osoba:");

    //ispis rezultata upita

    foreach (Osoba o in result)
    {
        Console.WriteLine($"Id:{o.Id}, Ime:{o.Ime}, Prezime:{o.Prezime}, Pol:{o.Pol}, Datum Rodjenja:{o.DatumRodjenja}, Grad:{o.Grad.Naziv}");
    }

    

}
catch (SqlException ex)
{
    Console.WriteLine($"Greska: {ex.Message}");
}

//poziva se Dispose() od usinga