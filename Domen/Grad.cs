namespace Domen
{
    public class Grad
    {
        public long Ptt { get; set; }
        public string Naziv { get; set; }

        public override string? ToString()
        {
            return Naziv;
        }
    }
}