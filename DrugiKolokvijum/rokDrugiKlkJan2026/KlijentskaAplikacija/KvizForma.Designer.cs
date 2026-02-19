namespace KlijentskaAplikacija
{
    partial class KvizForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnPokreniKviz = new Button();
            txtPitanje = new TextBox();
            cbOdgovor = new ComboBox();
            btnPosaljiOdg = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtRedniBr = new TextBox();
            txtTacnih = new TextBox();
            txtNetacnih = new TextBox();
            txtNeodgovrenih = new TextBox();
            txtBrojPoena = new TextBox();
            txtVreme = new TextBox();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnPokreniKviz
            // 
            btnPokreniKviz.Location = new Point(296, 98);
            btnPokreniKviz.Name = "btnPokreniKviz";
            btnPokreniKviz.Size = new Size(192, 23);
            btnPokreniKviz.TabIndex = 0;
            btnPokreniKviz.Text = "PokreniKviz";
            btnPokreniKviz.UseVisualStyleBackColor = true;
            btnPokreniKviz.Click += btnPokreniKviz_Click;
            // 
            // txtPitanje
            // 
            txtPitanje.Location = new Point(296, 163);
            txtPitanje.Name = "txtPitanje";
            txtPitanje.Size = new Size(192, 23);
            txtPitanje.TabIndex = 1;
            // 
            // cbOdgovor
            // 
            cbOdgovor.FormattingEnabled = true;
            cbOdgovor.Location = new Point(296, 217);
            cbOdgovor.Name = "cbOdgovor";
            cbOdgovor.Size = new Size(192, 23);
            cbOdgovor.TabIndex = 2;
            // 
            // btnPosaljiOdg
            // 
            btnPosaljiOdg.Location = new Point(296, 272);
            btnPosaljiOdg.Name = "btnPosaljiOdg";
            btnPosaljiOdg.Size = new Size(192, 23);
            btnPosaljiOdg.TabIndex = 3;
            btnPosaljiOdg.Text = "PosaljiOdg";
            btnPosaljiOdg.UseVisualStyleBackColor = true;
            btnPosaljiOdg.Click += btnPosaljiOdg_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // txtRedniBr
            // 
            txtRedniBr.Location = new Point(574, 99);
            txtRedniBr.Name = "txtRedniBr";
            txtRedniBr.Size = new Size(100, 23);
            txtRedniBr.TabIndex = 4;
            // 
            // txtTacnih
            // 
            txtTacnih.Location = new Point(574, 163);
            txtTacnih.Name = "txtTacnih";
            txtTacnih.Size = new Size(100, 23);
            txtTacnih.TabIndex = 5;
            // 
            // txtNetacnih
            // 
            txtNetacnih.Location = new Point(574, 226);
            txtNetacnih.Name = "txtNetacnih";
            txtNetacnih.Size = new Size(100, 23);
            txtNetacnih.TabIndex = 6;
            // 
            // txtNeodgovrenih
            // 
            txtNeodgovrenih.Location = new Point(574, 273);
            txtNeodgovrenih.Name = "txtNeodgovrenih";
            txtNeodgovrenih.Size = new Size(100, 23);
            txtNeodgovrenih.TabIndex = 7;
            // 
            // txtBrojPoena
            // 
            txtBrojPoena.Location = new Point(576, 324);
            txtBrojPoena.Name = "txtBrojPoena";
            txtBrojPoena.Size = new Size(100, 23);
            txtBrojPoena.TabIndex = 8;
            // 
            // txtVreme
            // 
            txtVreme.Location = new Point(86, 98);
            txtVreme.Name = "txtVreme";
            txtVreme.Size = new Size(119, 23);
            txtVreme.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(110, 362);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(164, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // KvizForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(txtVreme);
            Controls.Add(txtBrojPoena);
            Controls.Add(txtNeodgovrenih);
            Controls.Add(txtNetacnih);
            Controls.Add(txtTacnih);
            Controls.Add(txtRedniBr);
            Controls.Add(btnPosaljiOdg);
            Controls.Add(cbOdgovor);
            Controls.Add(txtPitanje);
            Controls.Add(btnPokreniKviz);
            Name = "KvizForma";
            Text = "KvizForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPokreniKviz;
        private TextBox txtPitanje;
        private ComboBox cbOdgovor;
        private Button btnPosaljiOdg;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtRedniBr;
        private TextBox txtTacnih;
        private TextBox txtNetacnih;
        private TextBox txtNeodgovrenih;
        private TextBox txtBrojPoena;
        private TextBox txtVreme;
        private Button btnLogout;
    }
}