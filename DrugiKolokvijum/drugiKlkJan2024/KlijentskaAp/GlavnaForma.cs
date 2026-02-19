using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentskaAp
{
    public partial class GlavnaForma : Form
    {
        Korisnik k = Korisnik.Instance;
        public BindingList<String> ulogovani = new BindingList<string>();


        public GlavnaForma()
        {
            InitializeComponent();
            cbKorisnici.DataSource = ulogovani;
            k.PorukaStigla += HandlePorukaStigla;
            k.PrimajPoruke();

        }

        public void HandlePorukaStigla(String poruka)
        {

            try
            {
                this.Invoke((MethodInvoker)delegate
                   {
                       if (poruka.StartsWith("LOGOUT")) return;


                       if (poruka.StartsWith("ADD"))
                       {
                           String user = poruka.Split(" ")[1].Trim();
                           ulogovani.Add(user);
                           txtSvi.Text = poruka;
                           return;
                       }

                       if (poruka.StartsWith("REMOVE"))
                       {
                           String user = poruka.Split(" ")[1].Trim();
                           ulogovani.Remove(user);

                           txtSvi.Text = poruka;
                           return;
                       }
                       txtSvi.Text = poruka;
                   });
            }
            catch (ThreadInterruptedException)
            {

                MessageBox.Show("Nit je zaustavljena");

            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            String poruka = "SEND " + k.username + " " + cbKorisnici.Text + " " + txtPoruka.Text;
            k.Posalji(poruka);
            MessageBox.Show(poruka);


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            k.Posalji("LOGOUT");


            btnSend.Enabled = false;
            k.nitPrimaPoruke.Interrupt();
            this.Close();
        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            k.PorukaStigla -= HandlePorukaStigla;
            
        }
    }
}
