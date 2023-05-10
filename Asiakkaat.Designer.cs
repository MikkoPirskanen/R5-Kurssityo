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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asiakkaat));
            lisääNappi = new Button();
            poistaNappi = new Button();
            hakukentta = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
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
            hakukentta.Location = new Point(431, 548);
            hakukentta.Margin = new Padding(3, 2, 3, 2);
            hakukentta.Name = "hakukentta";
            hakukentta.Size = new Size(244, 35);
            hakukentta.TabIndex = 4;
            hakukentta.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(182, 260);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(753, 258);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(495, 654);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 6;
            button1.Text = "Takaisin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Asiakkaat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(hakukentta);
            Controls.Add(poistaNappi);
            Controls.Add(lisääNappi);
            DoubleBuffered = true;
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
        private Button button1;
    }
}
