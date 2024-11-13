using Domen;
using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validacija()) return;
            User u = new User()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
            };
            try
            {
                Kontroler k = new Kontroler();
                User dbUser = k.Login(u);
                FrmGlavna glavna = new FrmGlavna();
                this.Visible = false;
                glavna.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri prijavljivanju!");
            }
        }

        private bool Validacija()
        {
            txtUsername.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            bool isValid = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.BackColor = Color.Salmon;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Salmon;
                isValid = false;
            }
            return isValid;
        }
    }
}
