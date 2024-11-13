using WinForms.UserControls;

namespace WinForms
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void radSaOsobamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOsobe frmOsobe = new FrmOsobe();
            frmOsobe.ShowDialog();
        }

        private void dodajOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var uc = new UCDodajOsobu(Utils.FrmMode.Add);
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }
    }
}
