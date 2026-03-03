using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        Server s = new Server();
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            btnDodaj.Enabled = false;
            dgvKorisnici.DataSource = s.korisnici;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            s.Listen();

            Thread serverskaNit = new Thread(s.Start);
            serverskaNit.IsBackground = true;
            serverskaNit.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            s.Stop();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String pass = txtPass.Text;

            Admin a = s.admini.FirstOrDefault(a => a.Email == email && a.Sifra == pass);

            if (a == null)
            {
                MessageBox.Show("Ne postoji admin");
                return;
            }

            btnLogin.Enabled = false;
            btnStart.Enabled = true;
            btnDodaj.Enabled = true;
            txtWelcome.Text = "Dobro dosli " + a.Ime + " " + a.Prezime;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool validno = false;

            User u = new User(txtP.Text, txtU.Text);

            User provera = s.korisnici.FirstOrDefault(provera => provera.Username == u.Username);
            if(provera != null)
            {
                MessageBox.Show("Korisnik sa tim kor imenom vec postoji");
                return;
            }

            
            validno = u.Username.All(Char.IsLetter);
            if (!validno)
            {
                MessageBox.Show("Nije validan format kor imena");
                return;
            }

            validno = u.Sifra.Any(char.IsLetter) && u.Sifra.Any(char.IsDigit);
            if (!validno)
            {
                MessageBox.Show("Nije validan format sifre");
                return;
            }



            s.korisnici.Add(u);
            dgvKorisnici.Refresh();
        }
    }
}
