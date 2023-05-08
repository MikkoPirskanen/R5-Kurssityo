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
            lisääNappi = new Button();
            poistaNappi = new Button();
            hakukentta = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lisääNappi
            // 
            lisääNappi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lisääNappi.Location = new Point(47, 316);
            lisääNappi.Margin = new Padding(3, 2, 3, 2);
            lisääNappi.Name = "lisääNappi";
            lisääNappi.Size = new Size(112, 38);
            lisääNappi.TabIndex = 1;
            lisääNappi.Text = "Lisää";
            lisääNappi.UseVisualStyleBackColor = true;
            lisääNappi.Click += lisääNappi_Click;
            // 
            // poistaNappi
            // 
            poistaNappi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            poistaNappi.Location = new Point(47, 416);
            poistaNappi.Margin = new Padding(3, 2, 3, 2);
            poistaNappi.Name = "poistaNappi";
            poistaNappi.Size = new Size(112, 37);
            poistaNappi.TabIndex = 3;
            poistaNappi.Text = "Poista";
            poistaNappi.UseVisualStyleBackColor = true;
            poistaNappi.Click += poistaNappi_Click;
            // 
            // hakukentta
            // 
            hakukentta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            hakukentta.Location = new Point(182, 189);
            hakukentta.Margin = new Padding(3, 2, 3, 2);
            hakukentta.Name = "hakukentta";
            hakukentta.Size = new Size(244, 35);
            hakukentta.TabIndex = 4;
            hakukentta.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(182, 260);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(753, 258);
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
            Controls.Add(hakukentta);
            Controls.Add(poistaNappi);
            Controls.Add(lisääNappi);
            Name = "Asiakkaat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asiakkaat";
            Load += Asiakkaat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button lisääNappi;
        private Button poistaNappi;
        private TextBox hakukentta;
        private DataGridView dataGridView1;
    }
}
