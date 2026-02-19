namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        Server s;
        public Form1()
        {
            InitializeComponent();
            s = new Server();
            dgvKorisnici.DataSource = s.registrovani;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s.Listen();
            s.Start();
        }
    }
}
