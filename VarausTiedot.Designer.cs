namespace Mökkihöperö
{
    partial class VarausTiedot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarausTiedot));
            dataGridView1 = new DataGridView();
            uusiVarausBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(808, 361);
            dataGridView1.TabIndex = 0;
            // 
            // uusiVarausBtn
            // 
            uusiVarausBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            uusiVarausBtn.Location = new Point(409, 667);
            uusiVarausBtn.Name = "uusiVarausBtn";
            uusiVarausBtn.Size = new Size(183, 42);
            uusiVarausBtn.TabIndex = 10;
            uusiVarausBtn.Text = "Takaisin";
            uusiVarausBtn.UseVisualStyleBackColor = true;
            uusiVarausBtn.Click += uusiVarausBtn_Click;
            // 
            // VarausTiedot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(uusiVarausBtn);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "VarausTiedot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VarausTiedot";
            Load += VarausTiedot_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button uusiVarausBtn;
    }
}