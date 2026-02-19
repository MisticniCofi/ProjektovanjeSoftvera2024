namespace Zajednicko
{
    public class Pitanje
    {
        public Pitanje(string tekstPitanja, List<string> odgovori, int indeksTacnog, int sekunde)
        {
            TekstPitanja = tekstPitanja;
            Odgovori = odgovori;
            IndeksTacnog = indeksTacnog;
            Sekunde = sekunde;
        }

        public String TekstPitanja { get; set; }

        public List<String> Odgovori { get; set; }

        public int IndeksTacnog { get; set; }
        
        public int Sekunde {  get; set; }
    }
}