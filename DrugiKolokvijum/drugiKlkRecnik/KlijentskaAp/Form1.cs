using Zajednicko;

namespace KlijentskaAp
{
    
    public partial class Form1 : Form
    {
        Klijent k = Klijent.Instance;
        public Form1()
        {
            InitializeComponent();
            k.Povezi();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Poruka p = new Poruka(Operacija.LOGIN, txtEmail.Text + " " + txtPass.Text);
            k.Posalji(p);

            Poruka odServera = k.Primi();

            if(odServera.Operacija == Operacija.ERROR)
            {
                MessageBox.Show("Greska");
                return;
            }

            //oprez
            List<Rec> reci = odServera.Reci;

            k.email = txtEmail.Text;
            this.Visible = false;
            GlavnaForma gf = new GlavnaForma(reci);
            gf.ShowDialog();
            

        }
    }
}
