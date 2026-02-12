using Domen;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;


namespace BrokerBP
{
    public class BrokerBazePodataka
    {
        public SqlConnection connection;

        public void Connect()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=1111_ProjSoft;Integrated Security=True");
            connection.Open();

        }

        public void Disconnect()
        {
            connection?.Close();
        }

        public BrokerBazePodataka()
        {
            this.Connect();
        }

        public void IspisiSlogove<T>(List<T> t)
        {
            foreach (T item in t)
            {
                Console.WriteLine(item.ToString());
                            
            }
        }
        

        public List<SrbRec> VratiSlogoveSrbRec()
        {
            List<Object[]> lista = this.VratiSlogove("SrbRec");
            List<SrbRec> rezultat = new List<SrbRec>();
            foreach (Object[] obj in lista)
            {
                SrbRec sr = new SrbRec();
                sr.SrbRecId = (int)obj[0];
                sr.SrbNaziv = (string)obj[1];
                
                rezultat.Add(sr);
            }
            return rezultat;
        }
        public List<Prevod> VratiSlogovePrevod()
        {
            List<Object[]> lista = this.VratiSlogove("Prevod");
            List<Prevod> rezultat = new List<Prevod>();
            foreach (Object[] obj in lista)
            {
                Prevod p = new Prevod();
                p.JezikId = (int)obj[0];
                p.SrbRecId = (int)obj[1];
                p.PrevodRB = (int)obj[2];
                p.PrevodRec = (string)obj[3];
                rezultat.Add(p);
            }
            return rezultat;
        }
        public List<Jezik> VratiSlogoveJezik()
        {
            List<Object[]> lista = this.VratiSlogove("Jezik");
            List<Jezik> rezultat = new List<Jezik>();
            foreach (Object[] obj in lista)
            {
                Jezik j = new Jezik();
                j.JezikId = (int)obj[0];
                j.NazivJezika = (string)obj[1];
                j.SkraceniNaziv = (string)obj[2];
                rezultat.Add(j);
            }
            return rezultat;

        }

        public List<Prevod> VratiSvePrevodZadateReci(SrbRec rec)
        {   
            //lista sa svim prevodima svih reci (nije efikasno uopste, bolje da se uradi preko sql upita)
            List<Prevod> pocetnaListaPrevoda= this.VratiSlogovePrevod();
            List<Prevod> filtriranaLista = new List<Prevod>();

            foreach(Prevod p in pocetnaListaPrevoda)
            {
                if(rec.SrbRecId == p.SrbRecId)
                {
                    filtriranaLista.Add(p);
                }
            }
            return filtriranaLista;
        }

        public List<Prevod> VratiPrevodeZadateReciNaZadatomJeziku(SrbRec rec, Jezik jezik)
        {
            this.Connect();

            string upit = "select * from prevod p " +
                "where p.jezikid = @jezikid and p.srbrecid = @srbrecid";

            SqlCommand cmd = new SqlCommand(upit, this.connection);
            cmd.Parameters.AddWithValue("jezikid", jezik.JezikId);
            cmd.Parameters.AddWithValue("srbrecid", rec.SrbRecId);
            
            SqlDataReader reader = cmd.ExecuteReader();

            List<Prevod> rezultat = new List<Prevod>();

            //List<string> rezultat = new List<string>();

            while (reader.Read())
            {
                Prevod p = new Prevod();
                p.JezikId = (int)reader["JezikId"];
                p.SrbRecId = (int)reader["SrbRecId"];
                p.PrevodRB = (int)reader["PrevodRB"];
                p.PrevodRec = (string)reader["PrevodRec"];
                rezultat.Add(p);
                //string pomocna = (string)reader["prevodrec"];
                //rezultat.Add(pomocna);
            }

            

            this.Disconnect();
            reader.Close();

            return rezultat;
        }



        public bool DodajPrevedenuRec(string rec, string prevod, int jezikId)
        {
            this.Connect();

            string upit = "insert into srbrec (srbnaziv) output inserted.srbrecid values (@rec)";

            SqlCommand cmd = new SqlCommand(upit, this.connection);

            cmd.Parameters.AddWithValue("@rec", rec);
            int idNoveReci = (int)cmd.ExecuteScalar();

            string[] visePrevoda = prevod.Split('#');


            //mazohisti mogu da nastave ovaj kod
            //List<String> visePrevoda = new List<String>();
            //string pomocni = "";
            //for (int i = 0; i < prevod.Length - 1; i++)
            //{
            //    pomocni += prevod.Substring(i, i + 1);
            //    if (prevod.Substring(i, i + 1).Equals("#")) {
            //        visePrevoda.Add(pomocni.Trim('#'));
            //    }

            //}


            for(int i = 0; i < visePrevoda.Length; i ++)
            {
                upit = "insert into prevod (jezikId, srbrecId, prevodrec) values (@jezikId, @srbRecId ,@prevod)";

                cmd = new SqlCommand(upit, this.connection);


                cmd.Parameters.AddWithValue("@jezikId", jezikId);
                cmd.Parameters.AddWithValue("@srbRecId", idNoveReci);
                cmd.Parameters.AddWithValue("@prevod", visePrevoda[i]);

                cmd.ExecuteNonQuery();

            }




            this.Disconnect();


            return true;


        }





        //genericka metoda za vracanje slogova bilo kog objekta

        public List<Object[]> VratiSlogove(string imeKlase)
        {
            //this kljucna rec se u ovom slucaju koristi za poziv BrokeraBazePodataka
            //svakoj metodi u C# je prosledjena instanca klase koja ju je pozvala
            //hvala Nini sa Programskih
            this.Connect();
            //PARAMETRIZOVANI SQL UPIT OVDE NE RADI
            //JER SE NE MOZE PROSLEDITI IME TABELE KAO PARAMETAR
            string upitVratiSlogove = $"select * from {imeKlase}";

            //ne radi
            //string upitVratiSlogove = $"select * from @klasa";
            //string parametarImenaKlase = imeKlase;
            //  cmd.Parameters.AddWithValue("@klasa", parametarImenaKlase);

            SqlCommand cmd = new SqlCommand(upitVratiSlogove, this.connection);

            

            SqlDataReader reader = cmd.ExecuteReader();





            List<Object[]> izlazReadera = new List<Object[]>();

            //ako reader nije nista procitao vrati praznu listu
            if (!reader.HasRows) return izlazReadera;

            int brojKolona = reader.FieldCount;
            int brojacRedova = 0;
            while (reader.Read())
            {
                Object[] pomocniObjekat = new Object[reader.FieldCount];

                //reader.GetValues() upisuje ceo red u prosledjen Object[] niz koji smo napravili na liniji iznad
                reader.GetValues(pomocniObjekat);
                //dodajemo ceo red u listu
                izlazReadera.Add(pomocniObjekat);



            }

            reader.Close();
            this.Disconnect();

            return izlazReadera;

        }
    }
}
