using System.Net.Sockets;

namespace KlijentskaAp
{
    public partial class LoginForma : Form
    {
        Korisnik k;

        public LoginForma()
        {
            Thread.Sleep(2500);
            InitializeComponent();
            k = Korisnik.Instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            k.soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            k.PoveziSe();
            k.Posalji("LOGIN " + txtLogin.Text);
            String odgovor = k.Primi();
            txtOdgovor.Text = odgovor;
            if(!odgovor.StartsWith("Uspesno logovanje"))
            {

                k.soket.Close();
                
                
            }
            else {
                k.username = txtLogin.Text;
                this.Visible = false;

                Form glavna = new GlavnaForma();
                glavna.ShowDialog();

                //server posalje kao prvu poruku broj ulogovanih klijenata - 1
                //onda mi ovde da pokrenemo for potlju i primimo toliko poruka

                //2. ideja
                //server posalje jedan dugacak string sa svim usernameovima
                

            }
            

        }
    }
}
