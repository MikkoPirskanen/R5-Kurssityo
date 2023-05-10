namespace Mökkihöperö
{
    partial class UusiAsiakas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UusiAsiakas));
            etunimiBox = new TextBox();
            sukunimiBox = new TextBox();
            osoiteBox = new TextBox();
            postinroBox = new TextBox();
            emailBox = new TextBox();
            puhnroBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lisaaBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // etunimiBox
            // 
            etunimiBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            etunimiBox.Location = new Point(474, 215);
            etunimiBox.MaxLength = 32;
            etunimiBox.Name = "etunimiBox";
            etunimiBox.Size = new Size(251, 33);
            etunimiBox.TabIndex = 0;
            // 
            // sukunimiBox
            // 
            sukunimiBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sukunimiBox.Location = new Point(474, 256);
            sukunimiBox.MaxLength = 32;
            sukunimiBox.Name = "sukunimiBox";
            sukunimiBox.Size = new Size(251, 33);
            sukunimiBox.TabIndex = 1;
            // 
            // osoiteBox
            // 
            osoiteBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            osoiteBox.Location = new Point(474, 300);
            osoiteBox.MaxLength = 50;
            osoiteBox.Name = "osoiteBox";
            osoiteBox.Size = new Size(251, 33);
            osoiteBox.TabIndex = 2;
            // 
            // postinroBox
            // 
            postinroBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            postinroBox.Location = new Point(474, 341);
            postinroBox.MaxLength = 5;
            postinroBox.Name = "postinroBox";
            postinroBox.Size = new Size(89, 33);
            postinroBox.TabIndex = 3;
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.Location = new Point(474, 389);
            emailBox.MaxLength = 30;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(251, 33);
            emailBox.TabIndex = 4;
            // 
            // puhnroBox
            // 
            puhnroBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            puhnroBox.Location = new Point(474, 435);
            puhnroBox.MaxLength = 10;
            puhnroBox.Name = "puhnroBox";
            puhnroBox.PlaceholderText = "0401234567";
            puhnroBox.Size = new Size(111, 33);
            puhnroBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(268, 218);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 6;
            label1.Text = "Etunimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LemonChiffon;
            label2.Location = new Point(268, 259);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 7;
            label2.Text = "Sukunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LemonChiffon;
            label3.Location = new Point(268, 303);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 8;
            label3.Text = "Lähiosoite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LemonChiffon;
            label4.Location = new Point(268, 344);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 9;
            label4.Text = "Postinro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LemonChiffon;
            label5.Location = new Point(268, 392);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LemonChiffon;
            label6.Location = new Point(268, 435);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 11;
            label6.Text = "Puhelinnumero";
            // 
            // lisaaBtn
            // 
            lisaaBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lisaaBtn.Location = new Point(348, 540);
            lisaaBtn.Name = "lisaaBtn";
            lisaaBtn.Size = new Size(96, 42);
            lisaaBtn.TabIndex = 12;
            lisaaBtn.Text = "Lisää";
            lisaaBtn.UseVisualStyleBackColor = true;
            lisaaBtn.Click += lisaaBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(551, 540);
            button1.Name = "button1";
            button1.Size = new Size(96, 42);
            button1.TabIndex = 13;
            button1.Text = "Peruuta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UusiAsiakas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(button1);
            Controls.Add(lisaaBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(puhnroBox);
            Controls.Add(emailBox);
            Controls.Add(postinroBox);
            Controls.Add(osoiteBox);
            Controls.Add(sukunimiBox);
            Controls.Add(etunimiBox);
            DoubleBuffered = true;
            Name = "UusiAsiakas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UusiAsiakas";
            Load += UusiAsiakas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox etunimiBox;
        private TextBox sukunimiBox;
        private TextBox osoiteBox;
        private TextBox postinroBox;
        private TextBox emailBox;
        private TextBox puhnroBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button lisaaBtn;
        private Button button1;
    }
}