namespace Mökit
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnHae = new Button();
            btnLisaa = new Button();
            btnMuokkaa = new Button();
            btnPoista = new Button();
            SuspendLayout();
            // 
            // btnHae
            // 
            btnHae.Location = new Point(16, 18);
            btnHae.Margin = new Padding(4, 5, 4, 5);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(100, 35);
            btnHae.TabIndex = 0;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = true;
            btnHae.Click += btnHae_Click;
            // 
            // btnLisaa
            // 
            btnLisaa.Location = new Point(124, 18);
            btnLisaa.Margin = new Padding(4, 5, 4, 5);
            btnLisaa.Name = "btnLisaa";
            btnLisaa.Size = new Size(100, 35);
            btnLisaa.TabIndex = 1;
            btnLisaa.Text = "Lisää";
            btnLisaa.UseVisualStyleBackColor = true;
            btnLisaa.Click += btnLisaa_Click;
            // 
            // btnMuokkaa
            // 
            btnMuokkaa.Location = new Point(232, 18);
            btnMuokkaa.Margin = new Padding(4, 5, 4, 5);
            btnMuokkaa.Name = "btnMuokkaa";
            btnMuokkaa.Size = new Size(100, 35);
            btnMuokkaa.TabIndex = 2;
            btnMuokkaa.Text = "Muokkaa";
            btnMuokkaa.UseVisualStyleBackColor = true;
            btnMuokkaa.Click += btnMuokkaa_Click;
            // 
            // btnPoista
            // 
            btnPoista.Location = new Point(340, 18);
            btnPoista.Margin = new Padding(4, 5, 4, 5);
            btnPoista.Name = "btnPoista";
            btnPoista.Size = new Size(100, 35);
            btnPoista.TabIndex = 3;
            btnPoista.Text = "Poista";
            btnPoista.UseVisualStyleBackColor = true;
            btnPoista.Click += btnPoista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 480);
            Controls.Add(btnPoista);
            Controls.Add(btnMuokkaa);
            Controls.Add(btnLisaa);
            Controls.Add(btnHae);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Mökit";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
    }
}
