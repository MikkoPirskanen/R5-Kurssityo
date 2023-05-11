namespace Mökkihöperö
{
    partial class Varaukset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Varaukset));
            label1 = new Label();
            Mökit = new Label();
            alueenMokit = new ListBox();
            alueet = new ComboBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            uusiVarausBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Moccasin;
            label1.Location = new Point(79, 119);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 1;
            label1.Text = "Alueet";
            // 
            // Mökit
            // 
            Mökit.AutoSize = true;
            Mökit.BackColor = Color.Transparent;
            Mökit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mökit.ForeColor = Color.Moccasin;
            Mökit.Location = new Point(79, 258);
            Mökit.Name = "Mökit";
            Mökit.Size = new Size(60, 25);
            Mökit.TabIndex = 2;
            Mökit.Text = "Mökit";
            // 
            // alueenMokit
            // 
            alueenMokit.BackColor = Color.WhiteSmoke;
            alueenMokit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            alueenMokit.FormattingEnabled = true;
            alueenMokit.ItemHeight = 20;
            alueenMokit.Location = new Point(27, 314);
            alueenMokit.Name = "alueenMokit";
            alueenMokit.Size = new Size(167, 184);
            alueenMokit.TabIndex = 4;
            alueenMokit.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // alueet
            // 
            alueet.BackColor = Color.WhiteSmoke;
            alueet.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            alueet.FormattingEnabled = true;
            alueet.Items.AddRange(new object[] { "Ahvenanmaa", "Etelä-Karjala", "Etelä-Pohjanmaa", "Etelä-Savo", "Kainuu", "Kanta-Häme", "Keski-Pohjanmaa", "Keski-Suomi", "Kymenlaakso", "Lappi", "Pirkanmaa", "Pohjanmaa", "Pohjois-Karjala", "Pohjois-Pohjanmaa", "Pohjois-Savo", "Päijät-Häme", "Satakunta", "Uusimaa", "Varsinais-Suomi" });
            alueet.Location = new Point(27, 179);
            alueet.Name = "alueet";
            alueet.Size = new Size(167, 28);
            alueet.TabIndex = 6;
            alueet.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(707, 264);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(488, 228);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 8;
            label2.Text = "Mökin tiedot";
            // 
            // uusiVarausBtn
            // 
            uusiVarausBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            uusiVarausBtn.Location = new Point(567, 592);
            uusiVarausBtn.Name = "uusiVarausBtn";
            uusiVarausBtn.Size = new Size(183, 42);
            uusiVarausBtn.TabIndex = 9;
            uusiVarausBtn.Text = "Uusi varaus";
            uusiVarausBtn.UseVisualStyleBackColor = true;
            uusiVarausBtn.Click += uusiVarausBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(323, 592);
            button1.Name = "button1";
            button1.Size = new Size(183, 42);
            button1.TabIndex = 10;
            button1.Text = "Takaisin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Varaukset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(button1);
            Controls.Add(uusiVarausBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(alueet);
            Controls.Add(alueenMokit);
            Controls.Add(Mökit);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Varaukset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Varaukset";
            Load += Varaukset_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Mökit;
        private ListBox alueenMokit;
        private ComboBox alueet;
        private DataGridView dataGridView1;
        private Label label2;
        private Button uusiVarausBtn;
        private Button button1;
    }
}