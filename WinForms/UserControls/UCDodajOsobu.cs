using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Utils;

namespace WinForms.UserControls
{
    public partial class UCDodajOsobu : UserControl
    {
        private readonly FrmMode mode;

        public UCDodajOsobu(FrmMode mode)
        {
            InitializeComponent();

            this.mode = mode;
            if (mode == FrmMode.Add)
            {
                btn.Text = "Dodaj osobu";
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text)
                                || string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Nisu uneti svi podaci!");
                return false;
            }
            return true;
        }

        private Osoba ProcitajPodatkeSaForme()
        {
            Osoba o = new();
            o.Ime = txtIme.Text;
            o.Prezime = txtPrezime.Text;
            o.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text,
                "dd.MM.yyyy. HH:mm", CultureInfo.InvariantCulture);
            o.Grad = (Grad)cmbGrad.SelectedItem;
            if (rbMuški.Checked)
            {
                o.Pol = Pol.Muski;
            }
            else if (rbZenski.Checked)
            {
                o.Pol = Pol.Zenski;
            }
            return o;
        }

        private void btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Validacija()) return;

                Osoba o = ProcitajPodatkeSaForme();
                if (mode == FrmMode.Add)
                {

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
