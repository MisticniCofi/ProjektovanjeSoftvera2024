namespace WinForms.UserControls
{
    partial class UCDodajOsobu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDodajGrad = new Button();
            btn = new Button();
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
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Anchor = AnchorStyles.None;
            btnDodajGrad.Location = new Point(265, 153);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(38, 23);
            btnDodajGrad.TabIndex = 11;
            btnDodajGrad.Text = "+";
            btnDodajGrad.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.None;
            btn.Location = new Point(28, 254);
            btn.Name = "btn";
            btn.Size = new Size(295, 29);
            btn.TabIndex = 10;
            btn.Text = "Dodaj";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(rbZenski);
            panel3.Controls.Add(rbMuški);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(28, 191);
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
            cmbGrad.Anchor = AnchorStyles.None;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(107, 153);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(152, 23);
            cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(66, 154);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Grad:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            txtDatumRodjenja.Anchor = AnchorStyles.None;
            txtDatumRodjenja.Location = new Point(107, 105);
            txtDatumRodjenja.Name = "txtDatumRodjenja";
            txtDatumRodjenja.Size = new Size(196, 23);
            txtDatumRodjenja.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(49, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Anchor = AnchorStyles.None;
            txtPrezime.Location = new Point(107, 63);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(196, 23);
            txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(71, 24);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Anchor = AnchorStyles.None;
            txtIme.Location = new Point(107, 19);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(196, 23);
            txtIme.TabIndex = 0;
            // 
            // UCDodajOsobu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodajGrad);
            Controls.Add(btn);
            Controls.Add(panel3);
            Controls.Add(txtIme);
            Controls.Add(cmbGrad);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDatumRodjenja);
            Name = "UCDodajOsobu";
            Size = new Size(335, 308);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajGrad;
        private Button btn;
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
    }
}
