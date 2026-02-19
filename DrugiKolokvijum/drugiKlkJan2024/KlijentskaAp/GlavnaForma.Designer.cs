namespace KlijentskaAp
{
    partial class GlavnaForma
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
            btnSend = new Button();
            btnLogout = new Button();
            txtPoruka = new TextBox();
            txtOdgovor = new TextBox();
            txtSvi = new TextBox();
            cbKorisnici = new ComboBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(357, 148);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(151, 23);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(60, 296);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(448, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(60, 148);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(263, 23);
            txtPoruka.TabIndex = 2;
            // 
            // txtOdgovor
            // 
            txtOdgovor.Location = new Point(60, 239);
            txtOdgovor.Name = "txtOdgovor";
            txtOdgovor.Size = new Size(448, 23);
            txtOdgovor.TabIndex = 3;
            // 
            // txtSvi
            // 
            txtSvi.Location = new Point(705, 77);
            txtSvi.Name = "txtSvi";
            txtSvi.Size = new Size(280, 23);
            txtSvi.TabIndex = 5;
            // 
            // cbKorisnici
            // 
            cbKorisnici.FormattingEnabled = true;
            cbKorisnici.Location = new Point(60, 103);
            cbKorisnici.Name = "cbKorisnici";
            cbKorisnici.Size = new Size(263, 23);
            cbKorisnici.TabIndex = 6;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 450);
            Controls.Add(cbKorisnici);
            Controls.Add(txtSvi);
            Controls.Add(txtOdgovor);
            Controls.Add(txtPoruka);
            Controls.Add(btnLogout);
            Controls.Add(btnSend);
            Name = "GlavnaForma";
            Text = "GlavnaForma";
            FormClosing += GlavnaForma_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Button btnLogout;
        private TextBox txtPoruka;
        private TextBox txtOdgovor;
        private TextBox txtSvi;
        private ComboBox cbKorisnici;
    }
}