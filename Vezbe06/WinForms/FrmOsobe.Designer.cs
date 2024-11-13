namespace WinForms
{
    partial class FrmOsobe
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
            pnlOsoba = new Panel();
            btnDodajGrad = new Button();
            btnDodaj = new Button();
            panel3 = new Panel();
            rbZenski = new RadioButton();
            rbMuški = new RadioButton();
            label5 = new Label();
            cmbGrad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtDatumRodjenja = new TextBox();
            label2 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            pnlTabela = new Panel();
            dgvOsobe = new DataGridView();
            btnIzbaci = new Button();
            pnlOsoba.SuspendLayout();
            panel3.SuspendLayout();
            pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).BeginInit();
            SuspendLayout();
            // 
            // pnlOsoba
            // 
            pnlOsoba.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOsoba.BackColor = SystemColors.ActiveCaption;
            pnlOsoba.Controls.Add(btnDodajGrad);
            pnlOsoba.Controls.Add(btnDodaj);
            pnlOsoba.Controls.Add(panel3);
            pnlOsoba.Controls.Add(cmbGrad);
            pnlOsoba.Controls.Add(label4);
            pnlOsoba.Controls.Add(label3);
            pnlOsoba.Controls.Add(txtDatumRodjenja);
            pnlOsoba.Controls.Add(label2);
            pnlOsoba.Controls.Add(txtPrezime);
            pnlOsoba.Controls.Add(label1);
            pnlOsoba.Controls.Add(txtIme);
            pnlOsoba.Location = new Point(124, 60);
            pnlOsoba.Name = "pnlOsoba";
            pnlOsoba.Size = new Size(365, 420);
            pnlOsoba.TabIndex = 0;
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Location = new Point(298, 175);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(38, 23);
            btnDodajGrad.TabIndex = 11;
            btnDodajGrad.Text = "+";
            btnDodajGrad.UseVisualStyleBackColor = true;
            btnDodajGrad.Click += btnDodajGrad_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(61, 276);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(295, 29);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbZenski);
            panel3.Controls.Add(rbMuški);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(61, 213);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 57);
            panel3.TabIndex = 9;
            // 
            // rbZenski
            // 
            rbZenski.AutoSize = true;
            rbZenski.Location = new Point(84, 32);
            rbZenski.Name = "rbZenski";
            rbZenski.Size = new Size(59, 19);
            rbZenski.TabIndex = 12;
            rbZenski.TabStop = true;
            rbZenski.Text = "Ženski";
            rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuški
            // 
            rbMuški.AutoSize = true;
            rbMuški.Location = new Point(84, 7);
            rbMuški.Name = "rbMuški";
            rbMuški.Size = new Size(57, 19);
            rbMuški.TabIndex = 11;
            rbMuški.TabStop = true;
            rbMuški.Text = "Muski";
            rbMuški.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 4);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 10;
            label5.Text = "Pol:";
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(140, 175);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(152, 23);
            cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 176);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Grad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 132);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            txtDatumRodjenja.Location = new Point(140, 127);
            txtDatumRodjenja.Name = "txtDatumRodjenja";
            txtDatumRodjenja.Size = new Size(196, 23);
            txtDatumRodjenja.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(140, 85);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(196, 23);
            txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 46);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(140, 41);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(196, 23);
            txtIme.TabIndex = 0;
            // 
            // pnlTabela
            // 
            pnlTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabela.Controls.Add(dgvOsobe);
            pnlTabela.Location = new Point(511, 60);
            pnlTabela.Name = "pnlTabela";
            pnlTabela.Size = new Size(485, 420);
            pnlTabela.TabIndex = 1;
            // 
            // dgvOsobe
            // 
            dgvOsobe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOsobe.Dock = DockStyle.Fill;
            dgvOsobe.Location = new Point(0, 0);
            dgvOsobe.Name = "dgvOsobe";
            dgvOsobe.Size = new Size(485, 420);
            dgvOsobe.TabIndex = 0;
            // 
            // btnIzbaci
            // 
            btnIzbaci.Location = new Point(884, 31);
            btnIzbaci.Name = "btnIzbaci";
            btnIzbaci.Size = new Size(112, 23);
            btnIzbaci.TabIndex = 2;
            btnIzbaci.Text = "Izbaci";
            btnIzbaci.UseVisualStyleBackColor = true;
            btnIzbaci.Click += btnIzbaci_Click;
            // 
            // FrmOsobe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 591);
            Controls.Add(btnIzbaci);
            Controls.Add(pnlTabela);
            Controls.Add(pnlOsoba);
            Name = "FrmOsobe";
            Text = "Rad sa osobama";
            pnlOsoba.ResumeLayout(false);
            pnlOsoba.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOsoba;
        private Button btnDodajGrad;
        private Button btnDodaj;
        private Panel panel3;
        private RadioButton rbZenski;
        private RadioButton rbMuški;
        private Label label5;
        private ComboBox cmbGrad;
        private Label label4;
        private Label label3;
        private TextBox txtDatumRodjenja;
        private Label label2;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
        private Panel pnlTabela;
        private DataGridView dgvOsobe;
        private Button btnIzbaci;
    }
}