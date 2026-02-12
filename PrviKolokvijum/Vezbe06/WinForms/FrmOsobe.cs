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

namespace WinForms
{
    public partial class FrmOsobe : Form
    {
        private BindingList<Osoba> osobe = new BindingList<Osoba>();
        public FrmOsobe()
        {
            InitializeComponent();
            cmbGrad.DataSource = GradUtil.Gradovi;
            cmbGrad.DisplayMember = "Naziv";

            dgvOsobe.DataSource = osobe;
            dgvOsobe.Columns["Id"].Visible = false;
            dgvOsobe.Columns["DatumRodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy.";


            dgvOsobe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIme.Text)
                    || string.IsNullOrEmpty(txtPrezime.Text))
                {
                    MessageBox.Show("Nisu uneti svi podaci!");
                    return;
                }

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
                DialogResult result = MessageBox.Show("Da li ste sigurni da zelite da sacuvate?",
                    "Sacuvaj korisnika",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    osobe.Add(o);
                }
                else
                {
                    MessageBox.Show("Nije sacuvano!");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count > 0)
            {
                Osoba o = (Osoba)dgvOsobe.SelectedRows[0].DataBoundItem;
                osobe.Remove(o);
            }
            MessageBox.Show("Niste odabrali red!");
        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            GradDialog dialog = new GradDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Grad je uspesno dodat!");
                // azurirati cmb da ukljuci i dodati grad
                cmbGrad.DataSource = null;
                cmbGrad.DataSource = GradUtil.Gradovi;
                
            }
        }
    }
}
