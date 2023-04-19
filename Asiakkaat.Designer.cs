namespace Mökkihöperö
{
    partial class Asiakkaat
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
            haeNappi = new Button();
            lisääNappi = new Button();
            päivitäNappi = new Button();
            poistaNappi = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // haeNappi
            // 
            haeNappi.Location = new Point(139, 44);
            haeNappi.Margin = new Padding(3, 2, 3, 2);
            haeNappi.Name = "haeNappi";
            haeNappi.Size = new Size(82, 22);
            haeNappi.TabIndex = 0;
            haeNappi.Text = "Hae";
            haeNappi.UseVisualStyleBackColor = true;
            haeNappi.Click += haeNappi_Click;
            // 
            // lisääNappi
            // 
            lisääNappi.Location = new Point(24, 89);
            lisääNappi.Margin = new Padding(3, 2, 3, 2);
            lisääNappi.Name = "lisääNappi";
            lisääNappi.Size = new Size(82, 22);
            lisääNappi.TabIndex = 1;
            lisääNappi.Text = "Lisää";
            lisääNappi.UseVisualStyleBackColor = true;
            lisääNappi.Click += lisääNappi_Click;
            // 
            // päivitäNappi
            // 
            päivitäNappi.Location = new Point(24, 116);
            päivitäNappi.Margin = new Padding(3, 2, 3, 2);
            päivitäNappi.Name = "päivitäNappi";
            päivitäNappi.Size = new Size(82, 22);
            päivitäNappi.TabIndex = 2;
            päivitäNappi.Text = "Päivitä";
            päivitäNappi.UseVisualStyleBackColor = true;
            päivitäNappi.Click += päivitäNappi_Click;
            // 
            // poistaNappi
            // 
            poistaNappi.Location = new Point(24, 142);
            poistaNappi.Margin = new Padding(3, 2, 3, 2);
            poistaNappi.Name = "poistaNappi";
            poistaNappi.Size = new Size(82, 22);
            poistaNappi.TabIndex = 3;
            poistaNappi.Text = "Poista";
            poistaNappi.UseVisualStyleBackColor = true;
            poistaNappi.Click += poistaNappi_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 44);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(234, 44);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(576, 248);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Asiakkaat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(984, 761);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(poistaNappi);
            Controls.Add(päivitäNappi);
            Controls.Add(lisääNappi);
            Controls.Add(haeNappi);
            Name = "Asiakkaat";
            Text = "Asiakkaat";
            Load += Asiakkaat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button haeNappi;
        private Button lisääNappi;
        private Button päivitäNappi;
        private Button poistaNappi;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
