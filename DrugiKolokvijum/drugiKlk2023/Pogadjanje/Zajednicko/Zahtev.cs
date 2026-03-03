namespace Zajednicko
{
    public class Zahtev
    {
        //od 1 do 9 koje je polje gadjao
        public int BrojPolja { get; set; }

        //da li da mu posalje sad sva polja ili ne


        public Zahtev(int brojPolja)
        { 
            BrojPolja = brojPolja;
        }
    }
}
