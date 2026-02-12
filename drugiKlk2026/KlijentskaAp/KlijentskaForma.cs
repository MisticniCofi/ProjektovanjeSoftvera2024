using System.Security.Policy;

namespace KlijentskaAp
{
    public partial class KlijentskaForma : Form
    {
        Klijent k;
        String korisnickoIme;
        int vreme;
        public KlijentskaForma()
        {
            InitializeComponent();
            k = new Klijent();
            btnSend.Enabled = false;
            btnLogout.Enabled = false;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            korisnickoIme = txtLogin.Text;
            k.Posalji("LOGIN " + korisnickoIme);
            btnSend.Enabled = true;
            btnLogout.Enabled = true;

            txtPorukaOdServera.Text = k.Primi();

            if (txtPorukaOdServera.Text.Equals("Uspesno logovanje"))
            {
                timer1.Enabled = false;
                txtTimer.Text = "Necu ugasiti formu ne brini";
            }

            btnLogin.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            k.Posalji("SEND " + korisnickoIme + "; " + txtPosalji.Text);
            txtPorukaOdServera.Text = k.Primi();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            k.Posalji("LOGOUT " + korisnickoIme);
            txtPorukaOdServera.Text = k.Primi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vreme++;
            txtTimer.Text = vreme.ToString();

            if (vreme == 100)
            {
                this.Close();
            }
        }

       
    }
}
