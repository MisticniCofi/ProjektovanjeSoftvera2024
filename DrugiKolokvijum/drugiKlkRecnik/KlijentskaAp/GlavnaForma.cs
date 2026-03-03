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

namespace KlijentskaAp
{
    public partial class GlavnaForma : Form
    {
        private List<Rec>? reci;
        public BindingList<RecPom> bindingReci = new BindingList<RecPom>();
        Klijent k = Klijent.Instance;

        public GlavnaForma(List<Rec>? reci)
        {
            InitializeComponent();
            btnUnesi.Enabled = false;
            this.reci = reci;
            foreach (Rec r in reci)
            {
                String srpska = r.SrpskaRec;
                String prevodi = String.Join(';', r.Prevodi);
                RecPom recPom = new RecPom(srpska, prevodi);
                bindingReci.Add(recPom);

            }

            dgvReci.DataSource = bindingReci;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {

            Poruka p = new Poruka(Operacija.PREVEDI, txtPretraga.Text);
            k.Posalji(p);

            Poruka odServera = k.Primi();
            if (odServera.Operacija == Operacija.ERROR)
            {
                var rez = MessageBox.Show("Greska", "Rec ne postoji, zelite li da unesete prevod?", MessageBoxButtons.YesNo);
                if (rez != DialogResult.Yes) return;

                btnUnesi.Enabled = true;

                return;
            }

            txtPrevodi.Text = odServera.Tekst;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            List<String> prevodi = txtPrevodi.Text.Split(" ").ToList();

            Rec r = new Rec(txtPretraga.Text, prevodi);
            List<Rec> zaSlanje = new List<Rec>();
            zaSlanje.Add(r);

            Poruka p = new Poruka(Operacija.UNESI_PREVOD, "heheee");
            p.Reci = zaSlanje;

            k.Posalji(p);

            btnUnesi.Enabled = false;
        }
    }
}
