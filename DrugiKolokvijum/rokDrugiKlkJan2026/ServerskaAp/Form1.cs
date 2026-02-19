namespace ServerskaAp
{
    public partial class Form1 : Form
    {
        Server s;
        public Form1()
        {
            InitializeComponent();
            s = new Server();
            dgvKlijenti.DataSource = s.registrovani;

       //     this.Refreshuj();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s.maksUlogovanih = Int32.Parse(txtMaks.Text);
            Thread serverskaNit = new Thread(s.Start);
            serverskaNit.IsBackground = true;
            serverskaNit.Start();

            btnPokreni.Enabled = false;
        }

        public void Refreshuj()
        {
            Thread apdejt = new Thread(() =>
            {
                while (true)
                {
                    Invoke(new Action(() =>
                    {
                        dgvKlijenti.Refresh();
                    }));
                    Thread.Sleep(10);
                }

            });
            apdejt.IsBackground = true;
            apdejt.Start();
        }
    }
}
