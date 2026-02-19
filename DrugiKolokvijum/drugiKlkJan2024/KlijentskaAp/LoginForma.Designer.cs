namespace KlijentskaAp
{
    partial class LoginForma
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
            btnLogin = new Button();
            txtLogin = new TextBox();
            txtOdgovor = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(531, 187);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(321, 187);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(176, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtOdgovor
            // 
            txtOdgovor.Location = new Point(321, 281);
            txtOdgovor.Name = "txtOdgovor";
            txtOdgovor.Size = new Size(215, 23);
            txtOdgovor.TabIndex = 2;
            // 
            // LoginForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOdgovor);
            Controls.Add(txtLogin);
            Controls.Add(btnLogin);
            Name = "LoginForma";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtLogin;
        private TextBox txtOdgovor;
    }
}
