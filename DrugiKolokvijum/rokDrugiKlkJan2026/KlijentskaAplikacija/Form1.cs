using Zajednicko;

namespace KlijentskaAplikacija
{
    public partial class Form1 : Form
    {
        Klijent k;
        public Form1()
        {
            InitializeComponent();

            k = Klijent.Instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            k.Povezi();
            String userPass = txtUser.Text + " " + txtPass.Text;
            k.Posalji(Zajednicko.Operacija.LOGIN, null, userPass );

            String odgovor = k.Primi().Tekst;

            if(!odgovor.StartsWith("Uspesno"))
            {
                MessageBox.Show(odgovor);
                return;
            }

            this.Visible = false;
            KvizForma kviz = new KvizForma();
            kviz.ShowDialog();
            
        }
    }
}
