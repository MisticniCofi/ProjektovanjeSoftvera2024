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
            txtPoruka = new TextBox();
            txtOdgovor = new TextBox();
            btnLogin = new Button();
            txtLogin = new TextBox();
            btnAdd = new Button();
            btnMinmax = new Button();
            btnDate = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(187, 128);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(235, 23);
            txtPoruka.TabIndex = 0;
            // 
            // txtOdgovor
            // 
            txtOdgovor.Location = new Point(187, 189);
            txtOdgovor.Name = "txtOdgovor";
            txtOdgovor.Size = new Size(235, 23);
            txtOdgovor.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(464, 78);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(187, 78);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(235, 23);
            txtLogin.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(443, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMinmax
            // 
            btnMinmax.Location = new Point(543, 128);
            btnMinmax.Name = "btnMinmax";
            btnMinmax.Size = new Size(75, 23);
            btnMinmax.TabIndex = 5;
            btnMinmax.Text = "Minmax";
            btnMinmax.UseVisualStyleBackColor = true;
            btnMinmax.Click += btnMinmax_Click;
            // 
            // btnDate
            // 
            btnDate.Location = new Point(624, 128);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(75, 23);
            btnDate.TabIndex = 6;
            btnDate.Text = "Date";
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnDate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(474, 188);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 7;
            btnLogout.TabStop = false;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnDate);
            Controls.Add(btnMinmax);
            Controls.Add(btnAdd);
            Controls.Add(txtLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtOdgovor);
            Controls.Add(txtPoruka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPoruka;
        private TextBox txtOdgovor;
        private Button btnLogin;
        private TextBox txtLogin;
        private Button btnAdd;
        private Button btnMinmax;
        private Button btnDate;
        private Button btnLogout;
    }
}
