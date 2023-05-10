namespace Mökkihöperö
{
    partial class UusiPalvelu
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
            valitseAlue = new ComboBox();
            valitseNimi = new TextBox();
            valitseHinta = new TextBox();
            valitseKuvaus = new TextBox();
            Alue = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ALVnäyttö = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // valitseAlue
            // 
            valitseAlue.FormattingEnabled = true;
            valitseAlue.Location = new Point(164, 81);
            valitseAlue.Name = "valitseAlue";
            valitseAlue.Size = new Size(182, 33);
            valitseAlue.TabIndex = 0;
            valitseAlue.DropDown += valitseAlue_DropDown;
            valitseAlue.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // valitseNimi
            // 
            valitseNimi.Location = new Point(164, 131);
            valitseNimi.Name = "valitseNimi";
            valitseNimi.Size = new Size(182, 31);
            valitseNimi.TabIndex = 1;
            valitseNimi.TextChanged += textBox1_TextChanged;
            // 
            // valitseHinta
            // 
            valitseHinta.Location = new Point(164, 185);
            valitseHinta.Name = "valitseHinta";
            valitseHinta.Size = new Size(182, 31);
            valitseHinta.TabIndex = 2;
            valitseHinta.TextChanged += valitseHinta_TextChanged;
            valitseHinta.KeyPress += valitseHinta_KeyPress;
            // 
            // valitseKuvaus
            // 
            valitseKuvaus.Location = new Point(164, 242);
            valitseKuvaus.Name = "valitseKuvaus";
            valitseKuvaus.Size = new Size(453, 31);
            valitseKuvaus.TabIndex = 3;
            // 
            // Alue
            // 
            Alue.AutoSize = true;
            Alue.Location = new Point(80, 81);
            Alue.Name = "Alue";
            Alue.Size = new Size(47, 25);
            Alue.TabIndex = 4;
            Alue.Text = "Alue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 131);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 5;
            label1.Text = "Nimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 185);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Hinta (E)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 242);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 7;
            label3.Text = "Kuvaus";
            // 
            // ALVnäyttö
            // 
            ALVnäyttö.AutoSize = true;
            ALVnäyttö.Location = new Point(402, 185);
            ALVnäyttö.Name = "ALVnäyttö";
            ALVnäyttö.Size = new Size(0, 25);
            ALVnäyttö.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(164, 305);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 9;
            button1.Text = "Lisää palvelu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UusiPalvelu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ALVnäyttö);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Alue);
            Controls.Add(valitseKuvaus);
            Controls.Add(valitseHinta);
            Controls.Add(valitseNimi);
            Controls.Add(valitseAlue);
            Name = "UusiPalvelu";
            Text = "UusiPalvelu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox valitseAlue;
        private TextBox valitseNimi;
        private TextBox valitseHinta;
        private TextBox valitseKuvaus;
        private Label Alue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label ALVnäyttö;
        private Button button1;
    }
}