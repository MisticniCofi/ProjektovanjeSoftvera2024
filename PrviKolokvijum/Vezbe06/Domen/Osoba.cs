//vidi klasu Grad za objasnjenje


namespace Domen
{
    public class Osoba
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        
        //atribut Pol je tipa Pol
        public Pol Pol { get; set; }

        //atribut Grad je tipa Grad
        //sto znaci da treba da mu se da instanca klase Grad

        //i sto znaci da svaka Osoba mora da bude zitelj tacno jednog Grada
        //tada je Grad spoljni kljuc Osobe
        public Grad Grad { get; set; }
    }
}