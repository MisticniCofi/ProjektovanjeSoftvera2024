//namespace Domen u kom se nalaze klase Grad, Osoba, Pol i User

//Domen u kontekstu projektovanja softvera
//predstavlja neki koncept ili entitet
//realnog sistema koji modelujemo
//npr. klasa Parfem ne predtsavlja domensku klasu u trenutnom sistemu
//jer nema nikakve veze sa onime sto radimo (vodjenje evidencije o ljudima)
namespace Domen
{
    public class Grad
    {
        //property sa getterom i setterom
        //za citanje i upisivanje vrednosti
        public long Ptt { get; set; }
        public string Naziv { get; set; }

        //overridovanje ToString metode
        //kad pozovemo nekiGrad.ToString(); vraca naziv grada
        //upitnik kod string? oznacava da je povratna vrednost nullable string
        //tj. vrednost moze biti ili Null ili neki string
        public override string? ToString()
        {
            return Naziv;
        }
    }
}