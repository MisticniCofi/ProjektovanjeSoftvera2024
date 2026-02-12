namespace WinForms
{
    partial class GradDialog
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
            label1 = new Label();
            txtPtt = new TextBox();
            txtNaziv = new TextBox();
            label2 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ptt";
            // 
            // txtPtt
            // 
            txtPtt.Location = new Point(116, 33);
            txtPtt.Name = "txtPtt";
            txtPtt.Size = new Size(143, 23);
            txtPtt.TabIndex = 1;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(116, 77);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(143, 23);
            txtNaziv.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(116, 122);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(143, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj grad";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // GradDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 187);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(txtPtt);
            Controls.Add(label1);
            Name = "GradDialog";
            Text = "GradDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPtt;
        private TextBox txtNaziv;
        private Label label2;
        private Button btnDodaj;
    }
}