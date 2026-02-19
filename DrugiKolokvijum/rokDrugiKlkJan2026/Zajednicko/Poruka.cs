namespace Zajednicko
{
    public class Poruka
    {
        public Poruka(Operacija operacija, List<Pitanje>? pitanja, string tekst)
        {
            Operacija = operacija;
            Pitanja = pitanja;
            Tekst = tekst;
        }

        public Operacija Operacija {  get; set; }

        public List<Pitanje>? Pitanja { get; set; }

        public String Tekst {  get; set; }
    }
}