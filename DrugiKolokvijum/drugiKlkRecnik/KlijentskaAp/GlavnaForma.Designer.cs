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
            dgvReci = new DataGridView();
            txtPretraga = new TextBox();
            btnPretraga = new Button();
            txtPrevodi = new TextBox();
            btnUnesi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReci).BeginInit();
            SuspendLayout();
            // 
            // dgvReci
            // 
            dgvReci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReci.Location = new Point(193, 201);
            dgvReci.Name = "dgvReci";
            dgvReci.Size = new Size(452, 237);
            dgvReci.TabIndex = 0;
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(193, 62);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(195, 23);
            txtPretraga.TabIndex = 1;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(447, 62);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(198, 23);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // txtPrevodi
            // 
            txtPrevodi.Location = new Point(193, 106);
            txtPrevodi.Name = "txtPrevodi";
            txtPrevodi.Size = new Size(452, 23);
            txtPrevodi.TabIndex = 3;
            // 
            // btnUnesi
            // 
            btnUnesi.Location = new Point(193, 153);
            btnUnesi.Name = "btnUnesi";
            btnUnesi.Size = new Size(452, 23);
            btnUnesi.TabIndex = 4;
            btnUnesi.Text = "Unesi prevod";
            btnUnesi.UseVisualStyleBackColor = true;
            btnUnesi.Click += btnUnesi_Click;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnesi);
            Controls.Add(txtPrevodi);
            Controls.Add(btnPretraga);
            Controls.Add(txtPretraga);
            Controls.Add(dgvReci);
            Name = "GlavnaForma";
            Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)dgvReci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReci;
        private TextBox txtPretraga;
        private Button btnPretraga;
        private TextBox txtPrevodi;
        private Button btnUnesi;
    }
}