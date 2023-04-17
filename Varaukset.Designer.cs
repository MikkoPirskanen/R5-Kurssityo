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
            listBox2 = new ListBox();
            varausKalenteri = new MonthCalendar();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 96);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Alueet";
            // 
            // Mökit
            // 
            Mökit.AutoSize = true;
            Mökit.Location = new Point(286, 96);
            Mökit.Name = "Mökit";
            Mökit.Size = new Size(38, 15);
            Mökit.TabIndex = 2;
            Mökit.Text = "Mökit";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(203, 136);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(167, 199);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // varausKalenteri
            // 
            varausKalenteri.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            varausKalenteri.ForeColor = SystemColors.WindowText;
            varausKalenteri.Location = new Point(112, 485);
            varausKalenteri.MaxDate = new DateTime(2028, 12, 31, 0, 0, 0, 0);
            varausKalenteri.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            varausKalenteri.Name = "varausKalenteri";
            varausKalenteri.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Etelä-Savo", "Keski-Suomi", "Pohjois-Savo" });
            comboBox1.Location = new Point(53, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(545, 390);
            dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 96);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Mökin tiedot";
            // 
            // Varaukset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(varausKalenteri);
            Controls.Add(listBox2);
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
        private ListBox listBox2;
        private MonthCalendar varausKalenteri;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}