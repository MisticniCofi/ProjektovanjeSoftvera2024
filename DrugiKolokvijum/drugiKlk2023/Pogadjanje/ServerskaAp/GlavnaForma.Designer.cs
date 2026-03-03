namespace ServerskaAp
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
            txtInfo = new TextBox();
            btnPocni = new Button();
            dgvTabela = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(233, 70);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(286, 23);
            txtInfo.TabIndex = 0;
            // 
            // btnPocni
            // 
            btnPocni.Location = new Point(233, 266);
            btnPocni.Name = "btnPocni";
            btnPocni.Size = new Size(286, 23);
            btnPocni.TabIndex = 1;
            btnPocni.Text = "Pocni Igru";
            btnPocni.UseVisualStyleBackColor = true;
            btnPocni.Click += btnPocni_Click;
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(233, 110);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.Size = new Size(286, 150);
            dgvTabela.TabIndex = 3;
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTabela);
            Controls.Add(btnPocni);
            Controls.Add(txtInfo);
            Name = "GlavnaForma";
            Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfo;
        private Button btnPocni;
        private DataGridView dgvTabela;
    }
}