using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{

    public partial class FormaSaPrevodima : Form
    {
        BrokerBazePodataka broker = new BrokerBazePodataka();

        public FormaSaPrevodima()
        {
            InitializeComponent();
            this.napuniCb();
        }

        public void napuniCb()
        {
            //ovde postoji mali problem
            //cbOdabirJezika.DataSource okida dogadja SelectedIndexChanged
            //i onda on pokusa da izvadi iz cbSrpskeReci reci ali ih ne moze naci
            cbOdabirJezika.DataSource = broker.VratiSlogoveJezik();
            cbOdabirJezika.DisplayMember = "NazivJezika";

            cbSrpskeReci.DataSource = broker.VratiSlogoveSrbRec();
            cbSrpskeReci.DisplayMember = "SrbNaziv";
        }

        private void cbSrpskeReci_SelectedIndexChanged(object sender, EventArgs e)
        {
               //greska
               //SrbRec rec = (SrbRec)cbSrpskeReci.SelectedItem;
               //dgvPrevedeneReci.DataSource = broker.VratiSvePrevodZadateReci(rec);

               
               //ako ne stavimo ovu metodu, pri promeni jezika u comboboxu srpskih reci, datagridview se ne bi menjao
               //samo pozovemo metou iz odabirjezika koja sve radi

               cbOdabirJezika_SelectedIndexChanged(sender, e);
        }

            private void cbOdabirJezika_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jezik jezik = (Jezik)cbOdabirJezika.SelectedItem;
            SrbRec rec = (SrbRec)cbSrpskeReci.SelectedItem;
            dgvPrevedeneReci.DataSource = broker.VratiPrevodeZadateReciNaZadatomJeziku(rec, jezik);
        }

        private void btnDodajPrevod_Click(object sender, EventArgs e)
        {
            DodajPrevod dp = new DodajPrevod(this);
            dp.ShowDialog();
        }
    }
}
