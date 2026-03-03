namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        Server s = new Server();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s.Listen();

            Thread serverskaNit = new Thread(s.Start);
            serverskaNit.IsBackground = true;
            serverskaNit.Start();

            dgvKorisnici.DataSource = s.korisnici;
            dgvKorisnici.Columns.Remove("Sifra");
           
            btnStart.Enabled = false;
        }
    }
}
