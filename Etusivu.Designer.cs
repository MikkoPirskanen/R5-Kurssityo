namespace Mökkihöperö
{
    partial class Etusivu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            raporttINappi = new Button();
            hallintaNappi = new Button();
            laskutusNappi = new Button();
            paneeli = new Panel();
            SuspendLayout();
            // 
            // raporttINappi
            // 
            raporttINappi.Location = new Point(144, 115);
            raporttINappi.Name = "raporttINappi";
            raporttINappi.Size = new Size(75, 23);
            raporttINappi.TabIndex = 0;
            raporttINappi.Text = "Raportit";
            raporttINappi.UseVisualStyleBackColor = true;
            raporttINappi.Click += raporttINappi_Click;
            // 
            // hallintaNappi
            // 
            hallintaNappi.Location = new Point(144, 174);
            hallintaNappi.Name = "hallintaNappi";
            hallintaNappi.Size = new Size(75, 23);
            hallintaNappi.TabIndex = 1;
            hallintaNappi.Text = "Hallinta";
            hallintaNappi.UseVisualStyleBackColor = true;
            hallintaNappi.Click += hallintaNappi_Click;
            // 
            // laskutusNappi
            // 
            laskutusNappi.Location = new Point(144, 236);
            laskutusNappi.Name = "laskutusNappi";
            laskutusNappi.Size = new Size(75, 23);
            laskutusNappi.TabIndex = 2;
            laskutusNappi.Text = "Laskutus";
            laskutusNappi.UseVisualStyleBackColor = true;
            laskutusNappi.Click += laskutusNappi_Click_1;
            // 
            // paneeli
            // 
            paneeli.Location = new Point(262, 54);
            paneeli.Name = "paneeli";
            paneeli.Size = new Size(345, 277);
            paneeli.TabIndex = 3;
            // 
            // Etusivu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paneeli);
            Controls.Add(laskutusNappi);
            Controls.Add(hallintaNappi);
            Controls.Add(raporttINappi);
            Name = "Etusivu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button raporttINappi;
        private Button hallintaNappi;
        private Button laskutusNappi;
        private Panel paneeli;
    }
}