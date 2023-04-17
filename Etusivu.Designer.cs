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
            menuStrip1 = new MenuStrip();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            lopetusToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // raporttINappi
            // 
            raporttINappi.BackColor = SystemColors.ActiveCaption;
            raporttINappi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            raporttINappi.Location = new Point(62, 246);
            raporttINappi.Name = "raporttINappi";
            raporttINappi.Size = new Size(165, 56);
            raporttINappi.TabIndex = 0;
            raporttINappi.Text = "Raportit";
            raporttINappi.UseVisualStyleBackColor = false;
            raporttINappi.Click += raporttINappi_Click;
            // 
            // hallintaNappi
            // 
            hallintaNappi.BackColor = SystemColors.ActiveCaption;
            hallintaNappi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            hallintaNappi.Location = new Point(62, 378);
            hallintaNappi.Name = "hallintaNappi";
            hallintaNappi.Size = new Size(165, 67);
            hallintaNappi.TabIndex = 1;
            hallintaNappi.Text = "Hallinta";
            hallintaNappi.UseVisualStyleBackColor = false;
            hallintaNappi.Click += hallintaNappi_Click;
            // 
            // laskutusNappi
            // 
            laskutusNappi.BackColor = SystemColors.ActiveCaption;
            laskutusNappi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            laskutusNappi.Location = new Point(62, 515);
            laskutusNappi.Name = "laskutusNappi";
            laskutusNappi.Size = new Size(165, 59);
            laskutusNappi.TabIndex = 2;
            laskutusNappi.Text = "Laskutus";
            laskutusNappi.UseVisualStyleBackColor = false;
            laskutusNappi.Click += laskutusNappi_Click_1;
            // 
            // paneeli
            // 
            paneeli.BorderStyle = BorderStyle.Fixed3D;
            paneeli.Location = new Point(262, 54);
            paneeli.Name = "paneeli";
            paneeli.Size = new Size(1000, 800);
            paneeli.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lopetusToolStripMenuItem, tietoaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1331, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(51, 20);
            tietoaToolStripMenuItem.Text = "Tietoa";
            tietoaToolStripMenuItem.Click += tietoaToolStripMenuItem_Click;
            // 
            // lopetusToolStripMenuItem
            // 
            lopetusToolStripMenuItem.Name = "lopetusToolStripMenuItem";
            lopetusToolStripMenuItem.Size = new Size(61, 20);
            lopetusToolStripMenuItem.Text = "Lopetus";
            lopetusToolStripMenuItem.Click += lopetusToolStripMenuItem_Click;
            // 
            // Etusivu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1331, 909);
            Controls.Add(paneeli);
            Controls.Add(laskutusNappi);
            Controls.Add(hallintaNappi);
            Controls.Add(raporttINappi);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Etusivu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etusivu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button raporttINappi;
        private Button hallintaNappi;
        private Button laskutusNappi;
        private Panel paneeli;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private ToolStripMenuItem lopetusToolStripMenuItem;
    }
}