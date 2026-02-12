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
using WinForms.Utils;

namespace WinForms
{
    public partial class GradDialog : Form
    {
        public Grad Grad { get; set; }
        public GradDialog()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Dodati validaciju
            Grad = new Grad();
            Grad.Ptt = long.Parse(txtPtt.Text);
            Grad.Naziv = txtNaziv.Text;
            GradUtil.Gradovi.Add(Grad);
           //sve je ok dodat je grad
           DialogResult = DialogResult.OK;
            
        }
    }
}
