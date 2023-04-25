namespace Mökkihöperö
{
    partial class Mokit
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

        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            hakuNappi = new Button();
            lisaaNappi = new Button();
            muokkaaNappi = new Button();
            poistaNappi = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            hakuNappi.Click += hakuNappi_Click;

            // 
            // hakuNappi
            // 
            hakuNappi.Location = new Point(170, 12);
            hakuNappi.Name = "button1";
            hakuNappi.Size = new Size(94, 29);
            hakuNappi.TabIndex = 0;
            hakuNappi.Text = "Haku";
            hakuNappi.UseVisualStyleBackColor = true;
            // 
            // lisaaNappi
            // 
            lisaaNappi.Location = new Point(270, 12);
            lisaaNappi.Name = "button2";
            lisaaNappi.Size = new Size(94, 29);
            lisaaNappi.TabIndex = 1;
            lisaaNappi.Text = "Lisää";
            lisaaNappi.UseVisualStyleBackColor = true;
            // 
            // muokkaaNappi
            // 
            muokkaaNappi.Location = new Point(370, 12);
            muokkaaNappi.Name = "button3";
            muokkaaNappi.Size = new Size(94, 29);
            muokkaaNappi.TabIndex = 2;
            muokkaaNappi.Text = "Muokkaa";
            muokkaaNappi.UseVisualStyleBackColor = true;
            // 
            // poistaNappi
            // 
            poistaNappi.Location = new Point(470, 12);
            poistaNappi.Name = "button4";
            poistaNappi.Size = new Size(94, 29);
            poistaNappi.TabIndex = 3;
            poistaNappi.Text = "Poista";
            poistaNappi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Hakukenttä";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1124, 240);
            dataGridView1.TabIndex = 5;
            // 
            // Mokit
            // 
            ClientSize = new Size(1148, 406);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(poistaNappi);
            Controls.Add(muokkaaNappi);
            Controls.Add(lisaaNappi);
            Controls.Add(hakuNappi);
            Name = "Mokit";
            Load += Mokit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }

    private SqlConnection connection;
    private string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;";
    private SqlDataAdapter dataAdapter;
    private DataTable table;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button hakuNappi;
    private Button lisaaNappi;
    private Button muokkaaNappi;
    private Button poistaNappi;
    private TextBox textBox1;
    private DataGridView dataGridView1;
    
}
