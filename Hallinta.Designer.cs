namespace Mökkihöperö
{
    partial class Hallinta
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
            asiakasNappi = new Button();
            varausNappi = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(401, 73);
            label1.Name = "label1";
            label1.Size = new Size(147, 50);
            label1.TabIndex = 0;
            label1.Text = "Hallinta";
            // 
            // asiakasNappi
            // 
            asiakasNappi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            asiakasNappi.Location = new Point(332, 354);
            asiakasNappi.Name = "asiakasNappi";
            asiakasNappi.Size = new Size(342, 72);
            asiakasNappi.TabIndex = 1;
            asiakasNappi.Text = "Hallitse asiakkaita";
            asiakasNappi.UseVisualStyleBackColor = true;
            asiakasNappi.Click += asiakasNappi_Click;
            // 
            // varausNappi
            // 
            varausNappi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            varausNappi.Location = new Point(332, 567);
            varausNappi.Name = "varausNappi";
            varausNappi.Size = new Size(342, 82);
            varausNappi.TabIndex = 2;
            varausNappi.Text = "Hallitse varauksia";
            varausNappi.UseVisualStyleBackColor = true;
            varausNappi.Click += varausNappi_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(278, 242);
            button1.Name = "button1";
            button1.Size = new Size(448, 74);
            button1.TabIndex = 3;
            button1.Text = "Hallitse alueita ja mökkejä";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(332, 457);
            button2.Name = "button2";
            button2.Size = new Size(342, 72);
            button2.TabIndex = 4;
            button2.Text = "Hallitse palveluita";
            button2.UseVisualStyleBackColor = true;
            // 
            // Hallinta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(984, 761);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(varausNappi);
            Controls.Add(asiakasNappi);
            Controls.Add(label1);
            Name = "Hallinta";
            Text = "Hallinta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button asiakasNappi;
        private Button varausNappi;
        private Button button1;
        private Button button2;
    }
}