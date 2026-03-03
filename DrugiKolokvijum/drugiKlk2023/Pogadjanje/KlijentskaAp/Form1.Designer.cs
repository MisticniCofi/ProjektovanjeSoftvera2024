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
            table = new TableLayoutPanel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            txtPoruka = new TextBox();
            btnPovezi = new Button();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 3;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.45815F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.54185F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            table.Controls.Add(textBox9, 2, 2);
            table.Controls.Add(textBox8, 1, 2);
            table.Controls.Add(textBox7, 0, 2);
            table.Controls.Add(textBox5, 1, 1);
            table.Controls.Add(textBox4, 0, 1);
            table.Controls.Add(textBox3, 2, 0);
            table.Controls.Add(textBox2, 1, 0);
            table.Controls.Add(textBox1, 0, 0);
            table.Controls.Add(textBox6, 2, 1);
            table.Location = new Point(297, 143);
            table.Name = "table";
            table.RowCount = 3;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            table.Size = new Size(318, 132);
            table.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(214, 61);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(96, 23);
            textBox9.TabIndex = 9;
            textBox9.Click += textBox9_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(105, 61);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(96, 23);
            textBox8.TabIndex = 8;
            textBox8.Click += textBox8_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 61);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(96, 23);
            textBox7.TabIndex = 7;
            textBox7.Click += textBox7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(105, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(96, 23);
            textBox5.TabIndex = 5;
            textBox5.Click += textBox5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(96, 23);
            textBox4.TabIndex = 4;
            textBox4.Click += textBox4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(96, 23);
            textBox3.TabIndex = 3;
            textBox3.Click += textBox3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(96, 23);
            textBox2.TabIndex = 2;
            textBox2.Click += textBox2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(214, 32);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(96, 23);
            textBox6.TabIndex = 6;
            textBox6.Click += textBox6_Click;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(300, 320);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(315, 23);
            txtPoruka.TabIndex = 2;
            // 
            // btnPovezi
            // 
            btnPovezi.Location = new Point(297, 53);
            btnPovezi.Name = "btnPovezi";
            btnPovezi.Size = new Size(318, 23);
            btnPovezi.TabIndex = 3;
            btnPovezi.Text = "Povezi se";
            btnPovezi.UseVisualStyleBackColor = true;
            btnPovezi.Click += btnPovezi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPovezi);
            Controls.Add(txtPoruka);
            Controls.Add(table);
            Name = "Form1";
            Text = "Form1";
            table.ResumeLayout(false);
            table.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel table;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox txtPoruka;
        private Button btnPovezi;
    }
}
