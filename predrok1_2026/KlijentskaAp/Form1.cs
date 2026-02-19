using Pomocne;

namespace KlijentskaAp
{
    public partial class Form1 : Form
    {
        Klijent k;
        int brojac;
        public Form1()
        {
            InitializeComponent();

            brojac = 0;
            timer1.Start();




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            k = new Klijent();
            k.Posalji(txtLogin.Text, Pomocne.Operacija.LOGIN);

            Poruka poruka = k.Primi();

            txtOdgovor.Text = poruka.Operacija.ToString() + " " + poruka.Tekst;
            if (!poruka.Tekst.StartsWith("Uspesno"))
            {
                return;
            }

            timer1.Stop();

            Thread primajPoruke = new Thread(() =>
            {
                while (true)
                {
                    poruka = k.Primi();

                    Invoke(new Action(() =>
                    {
                        this.txtOdgovor.Text = poruka.Operacija.ToString() + " " + poruka.Tekst;
                    }));
                }


            });


            primajPoruke.IsBackground = true;
            primajPoruke.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            k.Posalji(txtPoruka.Text, Pomocne.Operacija.ADD);

        }

        private void btnMinmax_Click(object sender, EventArgs e)
        {
            k.Posalji(txtPoruka.Text, Pomocne.Operacija.MINMAX);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            k.Posalji(txtPoruka.Text, Pomocne.Operacija.DATE);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            k.Posalji(k.username, Pomocne.Operacija.LOGOUT);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac++;
            txtTimer.Text = brojac.ToString();
            if(brojac == 100)
            {
                this.Close();
            }
        }
    }
}
