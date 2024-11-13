using Domen;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace BrokerBazePodataka
{
    //procitaj i shvati koncept brokera baze podataka iz skripte (5 min)
    //kod komuniciranja sa SqlServerom i bazom u C#, potrebne su nam 3 klase:
    //SqlConnection - za uspostavljanje i obustavljanje konekcije
    //SqlCommand - za kreiranje upita
    //SqlDataReader - za izvrsavanje upita, privremeno cuvanje rezultata upita i upisivanje rezultata u objekte
    public class BrokerBazePodataka
    {

        //deklarisanje polja SqlConnection
        //koji ce nam sluziti za otvaranje i zatvaranje veze sa bazom

        private SqlConnection connection;
        public void Connect()
        {
            try
            {
                //pozivanje konstruktora kom se prosledjuje
                //u DataSource ide lokacija gde je smesten SQL server
                //u Initial Catalog kako se zove baza u okviru servera
                //integrated security ne znam ali mislim da nije ni bitno

                // @ - stringovi se uzimaju tako kako su napisani
                // u suprotnom bismo pisali (localdb)\\MSSQLLocalDB

                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vezbe06;Integrated Security = True;");

                //uspostavlja vezu sa serverom i bazom

                connection.Open();
            }

            //hvata SqlException ukoliko dodje do greske prilikom uspostavljanja veze
            //ali ne obradjuje exception ni na koji nacin (throw; samo baca exception bez ikakve obrade)
            catch (SqlException ex)
            {
                Console.WriteLine("Nije uspesno uspostavljena veza sa bazom podataka!");
                throw;
            }
        }
        public void Disconnect()
        {
            //obustavlja konekciju sa serverom i bazom
            //upitnik kod connection - ako je null nista ne radi, ako nije null pozovi metodu Close()
            connection?.Close();

        }
        public User GetUserByUserPass(User user)
        {
            try
            {
                //upit koji saljemo bazi podataka
                //bukvalno isti upiti koje smo koristili u SQL-u na bazama u 3. godini
                
                //parametrizovan sql upit sto vidimo po @user i @pass
                //@user i @pass se menjaju vrednostima koje mi prosledjujemo i
                //porede sa vrednostima u kolonama username i password u bazi
                //[user] - uglaste zagrade oznacavaju da to nije kljucna rec USER koja postoji u SQLu

                string upit = $"select id, firstname, lastname from [user] where username=@user and password=@pass";

                //SqlCommand konstruktor uzima string upita i vezu sa bazom podataka
                //da bi znao kojoj bazi podataka salje upit
                //upit i dalje nije izvrsen

                //connection je polje BrokeraBazePodataka
                //sto znaci da svaka instanca BBP mora da ima connection
                //ne moramo mi u okviru metoda da ga definisemo ili da uspostavljamo i obustavljamo vezu

                //using - objasnjen u projektu InsertOsobaSaJoinom fajl Program.cs
                using SqlCommand cmd = new SqlCommand(upit, connection);
                
                    
                //ove dve linije dodaju parametre user i pass parametrizovanom SQL upitu
                //uzimaju vrednost od usera koji je vec prosledjen metodi u kojoj se nalazimo
                cmd.Parameters.AddWithValue("user", user.UserName);
                cmd.Parameters.AddWithValue("pass", user.Password);


                //SqlDataReader - izvrsava upita, privremeno cuva rezultata upita u nekoj kao matrici

                //cmd.ExecuteReader() je na neku foru konstruktor
                //neka neko objasni ako je razumeo

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //smestanje rezultata u usera
                    //mnogo bolje objasnjenu u projektu InsertOsobaSaJoinom fajl Program.cs
                    user.Id = reader.GetInt64(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    return user;
                }
                else
                {
                    throw new Exception("Ne postoji korisnik sa zadatim podacima!");
                }

                //do ovde traju promenljive cmd i reader, using automatski poziva Dispose()
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
            //jos jedan parametrizovan SQL

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
