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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnHaku = new Button();
            btnPerustiedot = new Button();
            btnOsoitetiedot = new Button();
            btnKuvausJaVarustelu = new Button();
            dataGridView1 = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btnAlueenPalvelut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Hakukenttä";
            
            // 
            // button1
            // 
            btnHaku.Location = new Point(268, 33);
            btnHaku.Name = "btnHaku";
            btnHaku.Size = new Size(94, 29);
            btnHaku.TabIndex = 1;
            btnHaku.Text = "Haku";
            btnHaku.UseVisualStyleBackColor = true;
            btnHaku.Click += btnHaku_Click;
            // 
            // button2
            // 
            btnPerustiedot.Location = new Point(451, 31);
            btnPerustiedot.Name = "btnPerustiedot";
            btnPerustiedot.Size = new Size(94, 29);
            btnPerustiedot.TabIndex = 2;
            btnPerustiedot.Text = "Perustiedot";
            btnPerustiedot.UseVisualStyleBackColor = true;
            btnPerustiedot.Click += btnPerustiedot_Click;
            // 
            // button3
            // 
            btnOsoitetiedot.Location = new Point(551, 33);
            btnOsoitetiedot.Name = "btnOsoitetiedot";
            btnOsoitetiedot.Size = new Size(130, 29);
            btnOsoitetiedot.TabIndex = 3;
            btnOsoitetiedot.Text = "Osoitetiedot";
            btnOsoitetiedot.UseVisualStyleBackColor = true;
            btnOsoitetiedot.Click += btnOsoitetiedot_Click;
            // 
            // button4
            // 
            btnKuvausJaVarustelu.Location = new Point(687, 33);
            btnKuvausJaVarustelu.Name = "btnKuvausJaVarustelu";
            btnKuvausJaVarustelu.Size = new Size(196, 29);
            btnKuvausJaVarustelu.TabIndex = 4;
            btnKuvausJaVarustelu.Text = "Kuvaus ja varustelu";
            btnKuvausJaVarustelu.UseVisualStyleBackColor = true;
            btnKuvausJaVarustelu.Click += btnKuvausJaVarustelu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1033, 494);
            dataGridView1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1086, 126);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1145, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 7;
            label1.Text = "Varaustilanne";
            // 
            // button5
            // 
            button5.Location = new Point(1086, 355);
            button5.Name = "button5";
            button5.Size = new Size(220, 29);
            button5.TabIndex = 8;
            button5.Text = "Tee varaus";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 568);
            button6.Name = "button6";
            button6.Size = new Size(128, 29);
            button6.TabIndex = 9;
            button6.Text = "Lisää mökki";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(146, 568);
            button7.Name = "button7";
            button7.Size = new Size(166, 29);
            button7.TabIndex = 10;
            button7.Text = "Muokkaa mökkiä";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(318, 568);
            button8.Name = "button8";
            button8.Size = new Size(134, 29);
            button8.TabIndex = 11;
            button8.Text = "Poista mökki";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(669, 568);
            button9.Name = "button9";
            button9.Size = new Size(120, 29);
            button9.TabIndex = 12;
            button9.Text = "Lisää alue";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(795, 568);
            button10.Name = "button10";
            button10.Size = new Size(140, 29);
            button10.TabIndex = 13;
            button10.Text = "Muokkaa aluetta";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(941, 568);
            button11.Name = "button11";
            button11.Size = new Size(104, 29);
            button11.TabIndex = 14;
            button11.Text = "Poista alue";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            btnAlueenPalvelut.Location = new Point(889, 33);
            btnAlueenPalvelut.Name = "btnAlueenPalvelut";
            btnAlueenPalvelut.Size = new Size(156, 29);
            btnAlueenPalvelut.TabIndex = 15;
            btnAlueenPalvelut.Text = "Alueen palvelut";
            btnAlueenPalvelut.UseVisualStyleBackColor = true;
            // 
            // Mokit
            // 
            ClientSize = new Size(1353, 636);
            Controls.Add(btnAlueenPalvelut);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Controls.Add(dataGridView1);
            Controls.Add(btnKuvausJaVarustelu);
            Controls.Add(btnOsoitetiedot);
            Controls.Add(btnPerustiedot);
            Controls.Add(btnHaku);
            Controls.Add(textBox1);
            Name = "Mokit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Button btnHaku;
        private Button btnPerustiedot;
        private Button btnOsoitetiedot;
        private Button btnKuvausJaVarustelu;
        private DataGridView dataGridView1;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnAlueenPalvelut;
    }
}
