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
            label1 = new Label();
            Mökit = new Label();
            alueenMokit = new ListBox();
            varausKalenteri = new MonthCalendar();
            alueet = new ComboBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            uusiVarausBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Alueet";
            // 
            // Mökit
            // 
            Mökit.AutoSize = true;
            Mökit.Location = new Point(57, 145);
            Mökit.Name = "Mökit";
            Mökit.Size = new Size(38, 15);
            Mökit.TabIndex = 2;
            Mökit.Text = "Mökit";
            // 
            // alueenMokit
            // 
            alueenMokit.FormattingEnabled = true;
            alueenMokit.ItemHeight = 15;
            alueenMokit.Location = new Point(17, 181);
            alueenMokit.Name = "alueenMokit";
            alueenMokit.Size = new Size(167, 199);
            alueenMokit.TabIndex = 4;
            alueenMokit.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // varausKalenteri
            // 
            varausKalenteri.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            varausKalenteri.ForeColor = SystemColors.WindowText;
            varausKalenteri.Location = new Point(57, 436);
            varausKalenteri.MaxDate = new DateTime(2028, 12, 31, 0, 0, 0, 0);
            varausKalenteri.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            varausKalenteri.Name = "varausKalenteri";
            varausKalenteri.TabIndex = 5;
            varausKalenteri.DateChanged += varausKalenteri_DateChanged;
            varausKalenteri.DateSelected += varausKalenteri_DateSelected;
            // 
            // alueet
            // 
            alueet.FormattingEnabled = true;
            alueet.Items.AddRange(new object[] { "Ahvenanmaa", "Etelä-Karjala", "Etelä-Pohjanmaa", "Etelä-Savo", "Kainuu", "Kanta-Häme", "Keski-Pohjanmaa", "Keski-Suomi", "Kymenlaakso", "Lappi", "Pirkanmaa", "Pohjanmaa", "Pohjois-Karjala", "Pohjois-Pohjanmaa", "Pohjois-Savo", "Päijät-Häme", "Satakunta", "Uusimaa", "Varsinais-Suomi" });
            alueet.Location = new Point(17, 96);
            alueet.Name = "alueet";
            alueet.Size = new Size(121, 23);
            alueet.TabIndex = 6;
            alueet.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(708, 178);
            dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 111);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Mökin tiedot";
            // 
            // uusiVarausBtn
            // 
            uusiVarausBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            uusiVarausBtn.Location = new Point(519, 611);
            uusiVarausBtn.Name = "uusiVarausBtn";
            uusiVarausBtn.Size = new Size(183, 42);
            uusiVarausBtn.TabIndex = 9;
            uusiVarausBtn.Text = "Uusi varaus";
            uusiVarausBtn.UseVisualStyleBackColor = true;
            uusiVarausBtn.Click += uusiVarausBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 508);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // Varaukset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(label3);
            Controls.Add(uusiVarausBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(alueet);
            Controls.Add(varausKalenteri);
            Controls.Add(alueenMokit);
            Controls.Add(Mökit);
            Controls.Add(label1);
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
        private MonthCalendar varausKalenteri;
        private ComboBox alueet;
        private DataGridView dataGridView1;
        private Label label2;
        private Button uusiVarausBtn;
        private Label label3;
    }
}