namespace KlijentskaAp
{
    partial class KlijentskaForma
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
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            btnSend = new Button();
            btnLogout = new Button();
            txtLogin = new TextBox();
            txtPosalji = new TextBox();
            txtPorukaOdServera = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTimer = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(492, 99);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(492, 201);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(111, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Posalji";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(320, 330);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(274, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(320, 99);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(157, 23);
            txtLogin.TabIndex = 3;
            
            // 
            // txtPosalji
            // 
            txtPosalji.Location = new Point(320, 202);
            txtPosalji.Name = "txtPosalji";
            txtPosalji.Size = new Size(157, 23);
            txtPosalji.TabIndex = 4;
            // 
            // txtPorukaOdServera
            // 
            txtPorukaOdServera.Location = new Point(320, 269);
            txtPorukaOdServera.Name = "txtPorukaOdServera";
            txtPorukaOdServera.Size = new Size(283, 23);
            txtPorukaOdServera.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // txtTimer
            // 
            txtTimer.Location = new Point(99, 201);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(171, 23);
            txtTimer.TabIndex = 6;
            // 
            // KlijentskaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTimer);
            Controls.Add(txtPorukaOdServera);
            Controls.Add(txtPosalji);
            Controls.Add(txtLogin);
            Controls.Add(btnLogout);
            Controls.Add(btnSend);
            Controls.Add(btnLogin);
            Name = "KlijentskaForma";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnSend;
        private Button btnLogout;
        private TextBox txtLogin;
        private TextBox txtPosalji;
        private TextBox txtPorukaOdServera;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTimer;
    }
}
