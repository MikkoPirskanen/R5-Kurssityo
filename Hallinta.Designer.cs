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
            alueetjamokitNappi = new Button();
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
            // alueetjamokitNappi
            // 
            alueetjamokitNappi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            alueetjamokitNappi.Location = new Point(278, 242);
            alueetjamokitNappi.Name = "alueetjamokitNappi";
            alueetjamokitNappi.Size = new Size(448, 74);
            alueetjamokitNappi.TabIndex = 3;
            alueetjamokitNappi.Text = "Hallitse alueita ja mökkejä";
            alueetjamokitNappi.UseVisualStyleBackColor = true;
            alueetjamokitNappi.Click += button1_Click;
            // 
            // Hallinta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(984, 761);
            Controls.Add(alueetjamokitNappi);
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
        private Button alueetjamokitNappi;
    }
}