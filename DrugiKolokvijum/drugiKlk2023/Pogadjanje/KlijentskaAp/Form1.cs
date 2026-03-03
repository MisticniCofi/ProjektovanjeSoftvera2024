using System.ComponentModel;
using Zajednicko;

namespace KlijentskaAp
{
    public partial class Form1 : Form
    {

        List<int> vrednosti = new List<int>
        {
            0,1,2,3,4,5,6,7,8
        };
        Klijent k;

        int brojac = 0;
        int brojTacnih = 0;
        List<int> sifra = new List<int>();
        public Form1()
        {
            InitializeComponent();
            k = new Klijent();


        }

        public void Azuriraj(int vrednostPolja)
        {
            brojac++;
            this.Pogadjaj(-2);

            if (vrednostPolja != -1)
            {
                sifra.Add(vrednostPolja);
                brojTacnih++;
            }


            if (brojTacnih == 3)
            {

                txtPoruka.Text = "Pobedili ste, sifra je " + IzracunajSifru(sifra);
                this.Refresh();
                this.Zatvori();
                
            }

            if (brojac == 5)
            {
                txtPoruka.Text = "izgubili ste";
                this.Zatvori();
            }
        }

        public void Zatvori()
        {
            Thread.Sleep(5000);
            k.CLose();
            this.Close();
        }
        public void Pogadjaj(int indeksPolja)
        {
            Zahtev z = new Zahtev(indeksPolja);
            k.Posalji(z);
        }

        public String IzracunajSifru(List<int> sifra)
        {
            sifra.Sort();
            int sifraBroj = sifra[0] + sifra[1] * 100 + sifra[2] * 10;
            return "" + sifraBroj ;
        }
        private void btnPovezi_Click(object sender, EventArgs e)
        {
            k.Povezi();
            Zahtev z = new Zahtev(-1);
            k.Posalji(z);

            vrednosti = k.Primi().VrednostiPolja;

            txtPoruka.Text = "Uspesno povezivanje, pocnite...";

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox1.Text = vrednosti[0].ToString();

            this.Azuriraj(vrednosti[0]);

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox2.Text = vrednosti[1].ToString();
            this.Azuriraj(vrednosti[1]);

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox3.Text = vrednosti[2].ToString();
            this.Azuriraj(vrednosti[2]);

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox4.Text = vrednosti[3].ToString();
            this.Azuriraj(vrednosti[3]);

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            //na klk otkrij vrednost
            textBox5.Text = vrednosti[4].ToString();
            this.Azuriraj(vrednosti[4]);
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox6.Text = vrednosti[5].ToString();
            this.Azuriraj(vrednosti[5]);
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox7.Text = vrednosti[6].ToString();
            this.Azuriraj(vrednosti[6]);
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox8.Text = vrednosti[7].ToString();
            this.Azuriraj(vrednosti[7]);
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            //na klik otkrij vrednost
            textBox9.Text = vrednosti[8].ToString();
            this.Azuriraj(vrednosti[8]);
        }

    }
}
