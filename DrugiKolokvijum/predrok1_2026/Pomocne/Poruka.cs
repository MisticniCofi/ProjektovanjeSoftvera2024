namespace Pomocne
{
    public class Poruka
    {
        public Poruka(string tekst, Operacija operacija)
        {
            Tekst = tekst;
            Operacija = operacija;
        }

        public String Tekst { get; set; }
        public Operacija Operacija { get; set; }
    }
}
