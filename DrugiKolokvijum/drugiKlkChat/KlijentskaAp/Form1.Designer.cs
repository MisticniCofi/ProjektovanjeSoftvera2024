namespace KlijentskaAp
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            listUlogovani = new ListBox();
            txtSvima = new TextBox();
            btnSvima = new Button();
            btnJednom = new Button();
            txtJednom = new TextBox();
            listSve = new ListBox();
            listTri = new ListBox();
            listOdJednog = new ListBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(99, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(99, 112);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(99, 159);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // listUlogovani
            // 
            listUlogovani.FormattingEnabled = true;
            listUlogovani.ItemHeight = 15;
            listUlogovani.Location = new Point(230, 344);
            listUlogovani.Name = "listUlogovani";
            listUlogovani.Size = new Size(120, 94);
            listUlogovani.TabIndex = 3;
            listUlogovani.SelectedIndexChanged += ListUlogovani_SelectedIndexChanged;
            // 
            // txtSvima
            // 
            txtSvima.Location = new Point(99, 244);
            txtSvima.Name = "txtSvima";
            txtSvima.Size = new Size(100, 23);
            txtSvima.TabIndex = 4;
            // 
            // btnSvima
            // 
            btnSvima.Location = new Point(99, 293);
            btnSvima.Name = "btnSvima";
            btnSvima.Size = new Size(100, 23);
            btnSvima.TabIndex = 5;
            btnSvima.Text = "P Svima";
            btnSvima.UseVisualStyleBackColor = true;
            btnSvima.Click += btnSvima_Click;
            // 
            // btnJednom
            // 
            btnJednom.Location = new Point(230, 293);
            btnJednom.Name = "btnJednom";
            btnJednom.Size = new Size(100, 23);
            btnJednom.TabIndex = 6;
            btnJednom.Text = "P Jednom";
            btnJednom.UseVisualStyleBackColor = true;
            btnJednom.Click += btnJednom_Click;
            // 
            // txtJednom
            // 
            txtJednom.Location = new Point(230, 244);
            txtJednom.Name = "txtJednom";
            txtJednom.Size = new Size(100, 23);
            txtJednom.TabIndex = 7;
            // 
            // listSve
            // 
            listSve.FormattingEnabled = true;
            listSve.ItemHeight = 15;
            listSve.Location = new Point(419, 41);
            listSve.Name = "listSve";
            listSve.Size = new Size(162, 139);
            listSve.TabIndex = 8;
            // 
            // listTri
            // 
            listTri.FormattingEnabled = true;
            listTri.ItemHeight = 15;
            listTri.Location = new Point(598, 41);
            listTri.Name = "listTri";
            listTri.Size = new Size(179, 139);
            listTri.TabIndex = 9;
            // 
            // listOdJednog
            // 
            listOdJednog.FormattingEnabled = true;
            listOdJednog.ItemHeight = 15;
            listOdJednog.Location = new Point(419, 235);
            listOdJednog.Name = "listOdJednog";
            listOdJednog.Size = new Size(162, 139);
            listOdJednog.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listOdJednog);
            Controls.Add(listTri);
            Controls.Add(listSve);
            Controls.Add(txtJednom);
            Controls.Add(btnJednom);
            Controls.Add(btnSvima);
            Controls.Add(txtSvima);
            Controls.Add(listUlogovani);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private ListBox listUlogovani;
        private TextBox txtSvima;
        private Button btnSvima;
        private Button btnJednom;
        private TextBox txtJednom;
        private ListBox listSve;
        private ListBox listTri;
        private ListBox listOdJednog;
    }
}
