namespace Mökkihöperö
{
    partial class Laskutus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laskutus));
            label1 = new Label();
            tulostusnappi = new Button();
            textBox1 = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            dokumenttiPrint = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(379, 48);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 0;
            label1.Text = "Laskutus";
            // 
            // tulostusnappi
            // 
            tulostusnappi.Location = new Point(353, 562);
            tulostusnappi.Margin = new Padding(2);
            tulostusnappi.Name = "tulostusnappi";
            tulostusnappi.Size = new Size(92, 33);
            tulostusnappi.TabIndex = 4;
            tulostusnappi.Text = "Tulosta";
            tulostusnappi.UseVisualStyleBackColor = true;
            tulostusnappi.Click += tulostusnappi_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(334, 202);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 310);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = dokumenttiPrint;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(485, 562);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 6;
            button1.Text = "Takaisin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Laskutus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 629);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tulostusnappi);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Laskutus";
            Text = "Laskutus";
            Load += Laskutus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button tulostusnappi;
        private TextBox textBox1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument dokumenttiPrint;
        private Button button1;
    }
}