using System.ComponentModel;
using Zajednicko;

namespace KlijentskaAp
{
    public partial class Form1 : Form
    {
        Klijent k = new Klijent();
        String username;

        BindingList<String> tri = new BindingList<String>();
        BindingList<String> sve = new BindingList<String>();
        List<Poruka> poruke = new List<Poruka>();

        public Form1()
        {
            InitializeComponent();
            btnJednom.Enabled = false;
            btnSvima.Enabled = false;

            listSve.DataSource= sve;
            listTri.DataSource = tri;

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            k.Povezi();
            Poruka p = new Poruka(Operacija.LOGIN, txtUser.Text + " " + txtPass.Text, "/", "/");
            k.Posalji(p);

            Poruka primljena = k.Primi();

            if (primljena.Operacija == Operacija.ERROR)
            {
                MessageBox.Show("Greska");
                return;
            }

            username = txtUser.Text;

            btnJednom.Enabled = true;
            btnSvima.Enabled = true;

            Thread komunikacija = new Thread(() =>
            {
                while (k.soket.Connected)
                {
                    Poruka primljena = k.Primi();
                    poruke.Add(primljena);

                    switch (primljena.Operacija)
                    {
                        case Operacija.OSVEZI_KORISNIKE:
                            {
                                List<String> korisnici = primljena.Tekst.Split(",").ToList();
                                this.Invoke(() =>
                                {

                                    listUlogovani.DataSource = korisnici;
                                    
                                });
                                continue;

                            }

                        case Operacija.POSALJISVIMA:
                            {
                                this.Azuriraj(primljena);
                                continue;
                            }

                        case Operacija.POSALJI:
                            {
                                this.Azuriraj(primljena);
                                continue;
                            }
                    }

                    
                }

            });
            komunikacija.IsBackground = true;
            komunikacija.Start();
        }

        private void btnSvima_Click(object sender, EventArgs e)
        {
            k.Posalji(new Poruka(Operacija.POSALJISVIMA, txtSvima.Text, username, "svima"));
        }

        private void btnJednom_Click(object sender, EventArgs e)
        {
            k.Posalji(new Poruka(Operacija.POSALJI, txtJednom.Text, username, listUlogovani.Text));

        }

        private void ListUlogovani_SelectedIndexChanged(object sender, EventArgs e)
        {
            String izabranKorisnik = listUlogovani.SelectedValue.ToString();
            List<Poruka> filtrirana = poruke.Where(x => x.OdKoga == izabranKorisnik).ToList();
            List<String> sredjeno = new List<string>();

            foreach(Poruka p in filtrirana)
            {
                String pom;
                if (p.Tekst.Length >= 20)
                {
                    pom = p.Vreme + " " + p.Kome + " " + p.Tekst.Substring(0, 20);

                }

                else pom = p.Vreme + " " + p.Kome + " " + p.Tekst;

                sredjeno.Add(pom);
            }

            listOdJednog.DataSource = null;
            listOdJednog.DataSource = sredjeno;
        }

        public void Azuriraj(Poruka primljena)
        {
            String pom;
            if (primljena.Tekst.Length >= 20)
            {
                pom = primljena.OdKoga + " " + primljena.Kome + " " + primljena.Tekst.Substring(0, 20);

            }

            else pom = primljena.OdKoga + " " + primljena.Kome + " " + primljena.Tekst;


            sve.Add(pom);

            if (tri.Count > 2)
            {
                tri.RemoveAt(0);
            }
            tri.Add(pom);

            this.Invoke(() =>
            {
                listSve.DataSource = null;
                listSve.DataSource = sve;

                listTri.DataSource = null;
                listTri.DataSource = tri;
            });
        }
    }
}
