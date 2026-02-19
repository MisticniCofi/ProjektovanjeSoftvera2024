namespace KlijentskaAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KvizForma kviz = new KvizForma();
            kviz.ShowDialog();
            
        }
    }
}
