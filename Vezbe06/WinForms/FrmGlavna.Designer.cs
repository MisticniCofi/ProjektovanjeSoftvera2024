namespace WinForms
{
    partial class FrmGlavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            osobaToolStripMenuItem = new ToolStripMenuItem();
            dodajOsobuToolStripMenuItem = new ToolStripMenuItem();
            radSaOsobamaToolStripMenuItem = new ToolStripMenuItem();
            pnlMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { osobaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // osobaToolStripMenuItem
            // 
            osobaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajOsobuToolStripMenuItem, radSaOsobamaToolStripMenuItem });
            osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            osobaToolStripMenuItem.Size = new Size(53, 20);
            osobaToolStripMenuItem.Text = "Osoba";
            // 
            // dodajOsobuToolStripMenuItem
            // 
            dodajOsobuToolStripMenuItem.Name = "dodajOsobuToolStripMenuItem";
            dodajOsobuToolStripMenuItem.Size = new Size(180, 22);
            dodajOsobuToolStripMenuItem.Text = "Dodaj osobu";
            dodajOsobuToolStripMenuItem.Click += dodajOsobuToolStripMenuItem_Click;
            // 
            // radSaOsobamaToolStripMenuItem
            // 
            radSaOsobamaToolStripMenuItem.Name = "radSaOsobamaToolStripMenuItem";
            radSaOsobamaToolStripMenuItem.Size = new Size(180, 22);
            radSaOsobamaToolStripMenuItem.Text = "Rad sa osobama";
            radSaOsobamaToolStripMenuItem.Click += radSaOsobamaToolStripMenuItem_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ActiveCaption;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 24);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 426);
            pnlMain.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            Text = "Program";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem osobaToolStripMenuItem;
        private ToolStripMenuItem dodajOsobuToolStripMenuItem;
        private ToolStripMenuItem radSaOsobamaToolStripMenuItem;
        private Panel pnlMain;
    }
}
