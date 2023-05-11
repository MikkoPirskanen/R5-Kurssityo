namespace Mökkihöperö
{
    partial class UusiMökki
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
            valitseHinta = new TextBox();
            valitseNimi = new TextBox();
            valitseKuvaus = new TextBox();
            button1 = new Button();
            valitseAlue2 = new ComboBox();
            valitseVarustelu = new TextBox();
            valitsePostinro = new TextBox();
            valitseKatuosoite = new TextBox();
            valitseHlomaara = new TextBox();
            label1 = new Label();
            Nimi = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // valitseHinta
            // 
            valitseHinta.Location = new Point(197, 218);
            valitseHinta.Name = "valitseHinta";
            valitseHinta.Size = new Size(182, 31);
            valitseHinta.TabIndex = 3;
            valitseHinta.TextChanged += valitseHinta_TextChanged_1;
            valitseHinta.KeyPress += valitseHinta_KeyPress_1;
            // 
            // valitseNimi
            // 
            valitseNimi.Location = new Point(197, 165);
            valitseNimi.Name = "valitseNimi";
            valitseNimi.Size = new Size(182, 31);
            valitseNimi.TabIndex = 4;
            valitseNimi.TextChanged += valitseNimi_TextChanged;
            // 
            // valitseKuvaus
            // 
            valitseKuvaus.Location = new Point(197, 275);
            valitseKuvaus.Name = "valitseKuvaus";
            valitseKuvaus.Size = new Size(473, 31);
            valitseKuvaus.TabIndex = 5;
            valitseKuvaus.TextChanged += valitseKuvaus_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(197, 379);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 10;
            button1.Text = "Lisää mökki";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // valitseAlue2
            // 
            valitseAlue2.FormattingEnabled = true;
            valitseAlue2.Location = new Point(197, 110);
            valitseAlue2.Name = "valitseAlue2";
            valitseAlue2.Size = new Size(182, 33);
            valitseAlue2.TabIndex = 11;
            valitseAlue2.DropDown += valitseAlue2_DropDown_1;
            valitseAlue2.SelectedIndexChanged += valitseAlue2_SelectedIndexChanged;
            // 
            // valitseVarustelu
            // 
            valitseVarustelu.Location = new Point(197, 324);
            valitseVarustelu.Name = "valitseVarustelu";
            valitseVarustelu.Size = new Size(473, 31);
            valitseVarustelu.TabIndex = 12;
            valitseVarustelu.TextChanged += valitseVarustelu_TextChanged;
            // 
            // valitsePostinro
            // 
            valitsePostinro.Location = new Point(488, 218);
            valitsePostinro.MaxLength = 5;
            valitsePostinro.Name = "valitsePostinro";
            valitsePostinro.Size = new Size(182, 31);
            valitsePostinro.TabIndex = 13;
            valitsePostinro.TextChanged += valitsePostinro_TextChanged;
            valitsePostinro.KeyPress += valitsePostinro_KeyPress;
            // 
            // valitseKatuosoite
            // 
            valitseKatuosoite.Location = new Point(488, 165);
            valitseKatuosoite.MaxLength = 30;
            valitseKatuosoite.Name = "valitseKatuosoite";
            valitseKatuosoite.Size = new Size(182, 31);
            valitseKatuosoite.TabIndex = 14;
            valitseKatuosoite.TextChanged += valitseKatuosoite_TextChanged;
            // 
            // valitseHlomaara
            // 
            valitseHlomaara.Location = new Point(488, 112);
            valitseHlomaara.MaxLength = 5;
            valitseHlomaara.Name = "valitseHlomaara";
            valitseHlomaara.Size = new Size(182, 31);
            valitseHlomaara.TabIndex = 15;
            valitseHlomaara.TextChanged += valitseHlomaara_TextChanged;
            valitseHlomaara.KeyPress += valitseHlomaara_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 110);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 16;
            label1.Text = "Alue";
            label1.Click += label1_Click;
            // 
            // Nimi
            // 
            Nimi.AutoSize = true;
            Nimi.Location = new Point(113, 165);
            Nimi.Name = "Nimi";
            Nimi.Size = new Size(49, 25);
            Nimi.TabIndex = 17;
            Nimi.Text = "Nimi";
            Nimi.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 273);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 19;
            label3.Text = "Kuvaus";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 218);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 18;
            label4.Text = "Hinta";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 218);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 23;
            label5.Text = "Postinro";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 165);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 22;
            label6.Text = "Katuosoite";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 113);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 21;
            label7.Text = "Hlömäärä";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 324);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 20;
            label8.Text = "Varustelu";
            label8.Click += label8_Click;
            // 
            // UusiMökki
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Nimi);
            Controls.Add(label1);
            Controls.Add(valitseHlomaara);
            Controls.Add(valitseKatuosoite);
            Controls.Add(valitsePostinro);
            Controls.Add(valitseVarustelu);
            Controls.Add(valitseAlue2);
            Controls.Add(button1);
            Controls.Add(valitseKuvaus);
            Controls.Add(valitseNimi);
            Controls.Add(valitseHinta);
            Name = "UusiMökki";
            Text = "UusiMökki";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox valitseHinta;
        private TextBox valitseNimi;
        private TextBox valitseKuvaus;
        private Button button1;
        private ComboBox valitseAlue2;
        private TextBox valitseVarustelu;
        private TextBox valitsePostinro;
        private TextBox valitseKatuosoite;
        private TextBox valitseHlomaara;
        private Label label1;
        private Label Nimi;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}