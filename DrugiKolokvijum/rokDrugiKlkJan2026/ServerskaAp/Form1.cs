namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        Server s;
        public Form1()
        {
            InitializeComponent();
            s = new Server();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s.Start();
            s.maksUlogovanih = Int32.Parse(txtMaks.Text);
            btnPokreni.Enabled = false;
        }
    }
}
