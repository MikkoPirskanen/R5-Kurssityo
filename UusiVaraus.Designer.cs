namespace Mökkihöperö
{
    partial class UusiVaraus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UusiVaraus));
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lisaaBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            puhnroBox = new TextBox();
            emailBox = new TextBox();
            postinroBox = new TextBox();
            osoiteBox = new TextBox();
            sukunimiBox = new TextBox();
            etunimiBox = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(426, 78);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(471, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 33);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(471, 177);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(334, 33);
            dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 138);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 5;
            label2.Text = "Varauksen alkupäivämäärä";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 183);
            label3.Name = "label3";
            label3.Size = new Size(251, 25);
            label3.TabIndex = 6;
            label3.Text = "Varauksen loppupäivämäärä";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(533, 630);
            button1.Name = "button1";
            button1.Size = new Size(96, 42);
            button1.TabIndex = 27;
            button1.Text = "Peruuta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lisaaBtn
            // 
            lisaaBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lisaaBtn.Location = new Point(330, 630);
            lisaaBtn.Name = "lisaaBtn";
            lisaaBtn.Size = new Size(96, 42);
            lisaaBtn.TabIndex = 26;
            lisaaBtn.Text = "Varaa";
            lisaaBtn.UseVisualStyleBackColor = true;
            lisaaBtn.Click += lisaaBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(250, 525);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 25;
            label6.Text = "Puhelinnumero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(250, 482);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(250, 434);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 23;
            label4.Text = "Postinro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(250, 393);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 22;
            label7.Text = "Lähiosoite";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(250, 349);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 21;
            label8.Text = "Sukunimi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(250, 308);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 20;
            label9.Text = "Etunimi";
            // 
            // puhnroBox
            // 
            puhnroBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            puhnroBox.Location = new Point(456, 525);
            puhnroBox.MaxLength = 10;
            puhnroBox.Name = "puhnroBox";
            puhnroBox.PlaceholderText = "0401234567";
            puhnroBox.Size = new Size(111, 33);
            puhnroBox.TabIndex = 19;
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.Location = new Point(456, 479);
            emailBox.MaxLength = 30;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(251, 33);
            emailBox.TabIndex = 18;
            // 
            // postinroBox
            // 
            postinroBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            postinroBox.Location = new Point(456, 431);
            postinroBox.MaxLength = 5;
            postinroBox.Name = "postinroBox";
            postinroBox.Size = new Size(89, 33);
            postinroBox.TabIndex = 17;
            // 
            // osoiteBox
            // 
            osoiteBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            osoiteBox.Location = new Point(456, 390);
            osoiteBox.MaxLength = 50;
            osoiteBox.Name = "osoiteBox";
            osoiteBox.Size = new Size(251, 33);
            osoiteBox.TabIndex = 16;
            // 
            // sukunimiBox
            // 
            sukunimiBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sukunimiBox.Location = new Point(456, 346);
            sukunimiBox.MaxLength = 32;
            sukunimiBox.Name = "sukunimiBox";
            sukunimiBox.Size = new Size(251, 33);
            sukunimiBox.TabIndex = 15;
            // 
            // etunimiBox
            // 
            etunimiBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            etunimiBox.Location = new Point(456, 305);
            etunimiBox.MaxLength = 32;
            etunimiBox.Name = "etunimiBox";
            etunimiBox.Size = new Size(251, 33);
            etunimiBox.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(456, 264);
            textBox1.MaxLength = 32;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 33);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(250, 264);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 28;
            label10.Text = "Asiakas-ID";
            // 
            // UusiVaraus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 761);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(lisaaBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(puhnroBox);
            Controls.Add(emailBox);
            Controls.Add(postinroBox);
            Controls.Add(osoiteBox);
            Controls.Add(sukunimiBox);
            Controls.Add(etunimiBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "UusiVaraus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tee uusi varaus";
            Load += UusiVaraus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button lisaaBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox puhnroBox;
        private TextBox emailBox;
        private TextBox postinroBox;
        private TextBox osoiteBox;
        private TextBox sukunimiBox;
        private TextBox etunimiBox;
        private TextBox textBox1;
        private Label label10;
    }
}