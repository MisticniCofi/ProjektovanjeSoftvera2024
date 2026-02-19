using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicko;

namespace KlijentskaAplikacija
{
    public partial class KvizForma : Form
    {
        public List<Pitanje> pitanja = new List<Pitanje>();
        int brojPoena;
        int neodgovorenih;
        int tacnih;
        int netacnih;
        int trenutno;
        int vreme;

        Klijent k;
        public KvizForma()
        {
            InitializeComponent();
            neodgovorenih = 0;
            tacnih = 0;
            netacnih = 0;
            trenutno = 0;
            brojPoena = 0;
            k = Klijent.Instance;

            this.Azuriraj();
        }

        public void Azuriraj()
        {
            txtNeodgovrenih.Text = neodgovorenih.ToString();
            txtTacnih.Text = tacnih.ToString();
            txtNetacnih.Text = netacnih.ToString();
            int pom = trenutno + 1;
            txtRedniBr.Text = pom.ToString();
            txtBrojPoena.Text = brojPoena.ToString();
        }

        private void btnPokreniKviz_Click(object sender, EventArgs e)
        {
            k.Posalji(Operacija.PITANJA, null, "daj pitanja");
            pitanja = k.Primi().Pitanja;

            this.PromeniPitanje();


        }

        private void btnPosaljiOdg_Click(object sender, EventArgs e)
        {


            if (cbOdgovor.SelectedIndex == pitanja[trenutno].IndeksTacnog)
            {
                cbOdgovor.BackColor = Color.Green;
                tacnih++;
                brojPoena += 4;
                this.Azuriraj();
            }
            else
            {
                cbOdgovor.BackColor = Color.Red;
                netacnih++;
                brojPoena -= 2;
                this.Azuriraj();
            }

            this.Refresh();
            trenutno++;



            Thread.Sleep(3000);

            cbOdgovor.BackColor = Color.White;
            this.Refresh();

            this.PromeniPitanje();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vreme++;
            txtVreme.Text = vreme.ToString();

            if (vreme / 10 == pitanja[trenutno].Sekunde)
            {

                neodgovorenih++;
                trenutno++;
                this.Azuriraj();
                this.PromeniPitanje();
            }
        }

        public void PromeniPitanje()
        {
            vreme = 0;
            txtVreme.Text = vreme.ToString();
            if (trenutno == 5)
            {
                timer1.Stop();
                return;
            }

            txtPitanje.Text = pitanja[trenutno].TekstPitanja;
            cbOdgovor.DataSource = pitanja[trenutno].Odgovori;

            timer1.Start();
            k.Posalji(Operacija.ODGOVOR, null, "E uradio sam pitanje");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            k.Posalji(Operacija.LOGOUT, null, "Aj cao");
            this.Close();
        }
    }
}
