namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        public List<Admin> admini = new List<Admin>
        {
            //gotovo je
            new Admin("pera@gmail.com", "123456", "Pera", "Peric"),
            new Admin("mara@gmail.com", "654321", "Mara", "Maric"),
            new Admin("t", "t", "t", "tic")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtUser.Text;
            String password = txtPass.Text;

            foreach (Admin a in admini)
            {
                if (email.Equals(a.Email) && password.Equals(a.Sifra))
                {
                    this.Visible = false;
                    GlavnaForma glavnaForma = new GlavnaForma(a.Ime, a.Prezime);
                    glavnaForma.ShowDialog();
                    return;
                }
            }
        }
    }
}
