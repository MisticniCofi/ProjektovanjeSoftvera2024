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
            s.forma = this;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s.Listen();
            Thread serverskaNit = new Thread(s.Start);
            serverskaNit.IsBackground = true;
            s.Start();
        }
    }
}
