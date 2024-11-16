namespace KorisnickiInterfejs
{
    partial class FormaSaPrevodima
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
            this.cbSrpskeReci = new System.Windows.Forms.ComboBox();
            this.dgvPrevedeneReci = new System.Windows.Forms.DataGridView();
            this.cbOdabirJezika = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajPrevod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevedeneReci)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSrpskeReci
            // 
            this.cbSrpskeReci.FormattingEnabled = true;
            this.cbSrpskeReci.Location = new System.Drawing.Point(69, 95);
            this.cbSrpskeReci.Name = "cbSrpskeReci";
            this.cbSrpskeReci.Size = new System.Drawing.Size(188, 21);
            this.cbSrpskeReci.TabIndex = 0;
            this.cbSrpskeReci.SelectedIndexChanged += new System.EventHandler(this.cbSrpskeReci_SelectedIndexChanged);
            // 
            // dgvPrevedeneReci
            // 
            this.dgvPrevedeneReci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevedeneReci.Location = new System.Drawing.Point(69, 137);
            this.dgvPrevedeneReci.Name = "dgvPrevedeneReci";
            this.dgvPrevedeneReci.Size = new System.Drawing.Size(456, 185);
            this.dgvPrevedeneReci.TabIndex = 1;
            // 
            // cbOdabirJezika
            // 
            this.cbOdabirJezika.FormattingEnabled = true;
            this.cbOdabirJezika.Location = new System.Drawing.Point(332, 95);
            this.cbOdabirJezika.Name = "cbOdabirJezika";
            this.cbOdabirJezika.Size = new System.Drawing.Size(193, 21);
            this.cbOdabirJezika.TabIndex = 2;
            this.cbOdabirJezika.SelectedIndexChanged += new System.EventHandler(this.cbOdabirJezika_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi jezik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberi rec:";
            // 
            // btnDodajPrevod
            // 
            this.btnDodajPrevod.Location = new System.Drawing.Point(431, 62);
            this.btnDodajPrevod.Name = "btnDodajPrevod";
            this.btnDodajPrevod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDodajPrevod.Size = new System.Drawing.Size(94, 23);
            this.btnDodajPrevod.TabIndex = 5;
            this.btnDodajPrevod.Text = "Dodaj  prevod";
            this.btnDodajPrevod.UseVisualStyleBackColor = true;
            this.btnDodajPrevod.Click += new System.EventHandler(this.btnDodajPrevod_Click);
            // 
            // FormaSaPrevodima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 357);
            this.Controls.Add(this.btnDodajPrevod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOdabirJezika);
            this.Controls.Add(this.dgvPrevedeneReci);
            this.Controls.Add(this.cbSrpskeReci);
            this.Name = "FormaSaPrevodima";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevedeneReci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSrpskeReci;
        private System.Windows.Forms.DataGridView dgvPrevedeneReci;
        public System.Windows.Forms.ComboBox cbOdabirJezika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajPrevod;
    }
}

