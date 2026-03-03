using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerskaAp
{
    public partial class GlavnaForma : Form
    {

        BindingList<Red> redovi = new BindingList<Red>
        {
            new Red(-1,-1,-1),
            new Red(-1,-1,-1),
             new Red(-1,-1,-1)
        };
        Server s = new Server();

        

        public GlavnaForma(String ime, String prezime)
        {
            InitializeComponent();
            dgvTabela.DataSource = redovi;
            txtInfo.Text = "Dobro dosli " + ime + " " + prezime;
            

            
            
        }

        private void btnPocni_Click(object sender, EventArgs e)
        {

            dgvTabela.Refresh();
            dgvTabela.Update();
            List<int> vrednosti = new List<int>
            {
                redovi[0].PrvaKol,
                redovi[0].DrugaKol,
                redovi[0].TrecaKol,
                redovi[1].PrvaKol,
                redovi[1].DrugaKol,
                redovi[1].TrecaKol,
                redovi[2].PrvaKol,
                redovi[2].DrugaKol,
                redovi[2].TrecaKol,
            };
            s.vrednosti = vrednosti;
            s.Listen();
            s.Start();
            
        }
    }
}
