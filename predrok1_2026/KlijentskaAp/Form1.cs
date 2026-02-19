using Pomocne;

namespace KlijentskaAp
{
    public partial class Form1 : Form
    {
        Klijent k;
        public Form1()
        {
            InitializeComponent();
            k = new Klijent();

            


            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            k.Posalji(txtLogin.Text, Pomocne.Operacija.LOGIN);

            Poruka poruka = k.Primi();
            if (!poruka.Tekst.StartsWith("Uspesno"))
            {
                txtOdgovor.Text = poruka.Tekst;
                return;
            }


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
    }
}
