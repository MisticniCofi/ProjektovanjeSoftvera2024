namespace ServerskaAp
{
    partial class ServerskaForma
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
            btnPokreni = new Button();
            txtMaks = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPokreni
            // 
            btnPokreni.Location = new Point(317, 116);
            btnPokreni.Name = "btnPokreni";
            btnPokreni.Size = new Size(75, 23);
            btnPokreni.TabIndex = 0;
            btnPokreni.Text = "Pokreni";
            btnPokreni.UseVisualStyleBackColor = true;
            btnPokreni.Click += btnPokreni_Click;
            // 
            // txtMaks
            // 
            txtMaks.Location = new Point(335, 62);
            txtMaks.Name = "txtMaks";
            txtMaks.Size = new Size(241, 23);
            txtMaks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Maks br klijenata";
            // 
            // ServerskaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtMaks);
            Controls.Add(btnPokreni);
            Name = "ServerskaForma";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPokreni;
        private TextBox txtMaks;
        private Label label1;
    }
}
