using BrokerBP;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class DodajPrevod : Form
    {
        //promenljiva u koju cemo da stavimo idJezika
        private int idOdabranogJezika;
        public DodajPrevod(FormaSaPrevodima fm)
        {
            InitializeComponent();

            //prosledili smo putem konstruktora formu koja je instancirala trenutnu formu
            //na formi sa prevodima se nalazi informacija o jeziku
            Jezik odabranJezik = (Jezik)fm.cbOdabirJezika.SelectedValue;
            this.idOdabranogJezika = odabranJezik.JezikId;
        }

        private void btnDodajPrevodDrugaForma_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li zelite da sacuvate prevod/e?", "Sacuvaj korisnika",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) 
                {
                    //zatvara formu
                    this.Close();
                    //moramo ici return jer funkcija nastavlja da se izvrsava nezavisno od forme, tako da i yes i no skladiste podatke u bazi
                    return;
                }
            BrokerBazePodataka broker = new BrokerBazePodataka();
            string rec = txtRecNaSrpskom.Text;
            string prevod = txtPrevodReci.Text;
            
            broker.DodajPrevedenuRec(rec, prevod, idOdabranogJezika);
            
        }
    }
}
