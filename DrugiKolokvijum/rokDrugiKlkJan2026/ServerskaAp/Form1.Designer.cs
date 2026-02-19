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
            txtMaks = new TextBox();
            btnPokreni = new Button();
            dgvKlijenti = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).BeginInit();
            SuspendLayout();
            // 
            // txtMaks
            // 
            txtMaks.Location = new Point(275, 91);
            txtMaks.Name = "txtMaks";
            txtMaks.Size = new Size(198, 23);
            txtMaks.TabIndex = 0;
            // 
            // btnPokreni
            // 
            btnPokreni.Location = new Point(544, 91);
            btnPokreni.Name = "btnPokreni";
            btnPokreni.Size = new Size(100, 23);
            btnPokreni.TabIndex = 1;
            btnPokreni.Text = "Pokreni";
            btnPokreni.UseVisualStyleBackColor = true;
            btnPokreni.Click += btnPokreni_Click;
            // 
            // dgvKlijenti
            // 
            dgvKlijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijenti.Location = new Point(245, 198);
            dgvKlijenti.Name = "dgvKlijenti";
            dgvKlijenti.Size = new Size(457, 203);
            dgvKlijenti.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKlijenti);
            Controls.Add(btnPokreni);
            Controls.Add(txtMaks);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaks;
        private Button btnPokreni;
        private DataGridView dgvKlijenti;
    }
}
