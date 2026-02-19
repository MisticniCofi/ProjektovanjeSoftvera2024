namespace ServerskaAp
{
    public partial class ServerskaForma : Form
    {
        Server server;
        public ServerskaForma()
        {
            InitializeComponent();
            String pom = File.ReadAllLines("../../../app.config")[2];
            pom = pom.Trim();
            pom = pom.Split(" ")[2];
            txtMaks.Text = pom;
            
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            server = new Server(Int32.Parse(txtMaks.Text));
            server.Listen();
            server.Start();
        }
    }
}
