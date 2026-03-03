namespace ServerskaAp
{
    partial class Form1
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
            btnStart = new Button();
            btnStop = new Button();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            txtWelcome = new TextBox();
            dgvKorisnici = new DataGridView();
            txtU = new TextBox();
            txtP = new TextBox();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(242, 49);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(133, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Pokreni server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(424, 48);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(138, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "Zaustavi server";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(71, 89);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(71, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Uloguj se";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtWelcome
            // 
            txtWelcome.Location = new Point(242, 12);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(320, 23);
            txtWelcome.TabIndex = 5;
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Location = new Point(282, 215);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.Size = new Size(382, 192);
            dgvKorisnici.TabIndex = 6;
            // 
            // txtU
            // 
            txtU.Location = new Point(71, 227);
            txtU.Name = "txtU";
            txtU.Size = new Size(100, 23);
            txtU.TabIndex = 7;
            // 
            // txtP
            // 
            txtP.Location = new Point(71, 278);
            txtP.Name = "txtP";
            txtP.Size = new Size(100, 23);
            txtP.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(71, 325);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 23);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(txtP);
            Controls.Add(txtU);
            Controls.Add(dgvKorisnici);
            Controls.Add(txtWelcome);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnLogin;
        private TextBox txtWelcome;
        private DataGridView dgvKorisnici;
        private TextBox txtU;
        private TextBox txtP;
        private Button btnDodaj;
    }
}
