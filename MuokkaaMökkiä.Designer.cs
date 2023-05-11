namespace Mökkihöperö
{
    partial class MuokkaaMökkiä
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nimi = new Label();
            label1 = new Label();
            valitseHlomaara = new TextBox();
            valitseKatuosoite = new TextBox();
            valitsePostinro = new TextBox();
            valitseVarustelu = new TextBox();
            valitseAlue2 = new ComboBox();
            button1 = new Button();
            valitseKuvaus = new TextBox();
            valitseNimi = new TextBox();
            valitseHinta = new TextBox();
            näytäID = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 174);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 40;
            label5.Text = "Postinro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 121);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 39;
            label6.Text = "Katuosoite";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(376, 69);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 38;
            label7.Text = "Hlömäärä";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 280);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 37;
            label8.Text = "Varustelu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 229);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 36;
            label3.Text = "Kuvaus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 174);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 35;
            label4.Text = "Hinta";
            // 
            // Nimi
            // 
            Nimi.AutoSize = true;
            Nimi.Location = new Point(96, 121);
            Nimi.Name = "Nimi";
            Nimi.Size = new Size(49, 25);
            Nimi.TabIndex = 34;
            Nimi.Text = "Nimi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 66);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 33;
            label1.Text = "Alue";
            // 
            // valitseHlomaara
            // 
            valitseHlomaara.Location = new Point(471, 68);
            valitseHlomaara.MaxLength = 5;
            valitseHlomaara.Name = "valitseHlomaara";
            valitseHlomaara.Size = new Size(182, 31);
            valitseHlomaara.TabIndex = 32;
            // 
            // valitseKatuosoite
            // 
            valitseKatuosoite.Location = new Point(471, 121);
            valitseKatuosoite.MaxLength = 30;
            valitseKatuosoite.Name = "valitseKatuosoite";
            valitseKatuosoite.Size = new Size(182, 31);
            valitseKatuosoite.TabIndex = 31;
            // 
            // valitsePostinro
            // 
            valitsePostinro.Location = new Point(471, 174);
            valitsePostinro.MaxLength = 5;
            valitsePostinro.Name = "valitsePostinro";
            valitsePostinro.Size = new Size(182, 31);
            valitsePostinro.TabIndex = 30;
            // 
            // valitseVarustelu
            // 
            valitseVarustelu.Location = new Point(180, 280);
            valitseVarustelu.Name = "valitseVarustelu";
            valitseVarustelu.Size = new Size(473, 31);
            valitseVarustelu.TabIndex = 29;
            // 
            // valitseAlue2
            // 
            valitseAlue2.FormattingEnabled = true;
            valitseAlue2.Location = new Point(180, 66);
            valitseAlue2.Name = "valitseAlue2";
            valitseAlue2.Size = new Size(182, 33);
            valitseAlue2.TabIndex = 28;
            valitseAlue2.DropDown += valitseAlue2_DropDown_2;
            valitseAlue2.SelectedIndexChanged += valitseAlue2_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(180, 335);
            button1.Name = "button1";
            button1.Size = new Size(141, 66);
            button1.TabIndex = 27;
            button1.Text = "Muokkaus valmis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // valitseKuvaus
            // 
            valitseKuvaus.Location = new Point(180, 231);
            valitseKuvaus.Name = "valitseKuvaus";
            valitseKuvaus.Size = new Size(473, 31);
            valitseKuvaus.TabIndex = 26;
            // 
            // valitseNimi
            // 
            valitseNimi.Location = new Point(180, 121);
            valitseNimi.Name = "valitseNimi";
            valitseNimi.Size = new Size(182, 31);
            valitseNimi.TabIndex = 25;
            // 
            // valitseHinta
            // 
            valitseHinta.Location = new Point(180, 174);
            valitseHinta.Name = "valitseHinta";
            valitseHinta.Size = new Size(182, 31);
            valitseHinta.TabIndex = 24;
            // 
            // näytäID
            // 
            näytäID.Location = new Point(489, 343);
            näytäID.Name = "näytäID";
            näytäID.ReadOnly = true;
            näytäID.Size = new Size(150, 31);
            näytäID.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 346);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 42;
            label2.Text = "ID";
            // 
            // MuokkaaMökkiä
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(näytäID);
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
            Name = "MuokkaaMökkiä";
            Text = "MuokkaaMökkiä";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label Nimi;
        private Label label1;
        private TextBox valitseHlomaara;
        private TextBox valitseKatuosoite;
        private TextBox valitsePostinro;
        private TextBox valitseVarustelu;
        private ComboBox valitseAlue2;
        private Button button1;
        private TextBox valitseKuvaus;
        private TextBox valitseNimi;
        private TextBox valitseHinta;
        private TextBox näytäID;
        private Label label2;
    }
}