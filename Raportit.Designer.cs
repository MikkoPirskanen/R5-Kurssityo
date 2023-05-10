namespace Mökkihöperö
{
    partial class Raportit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportit));
            button1 = new Button();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            majoituksetDgv = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)majoituksetDgv).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(421, 139);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 0;
            button1.Text = "Hae";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            startDatePicker.Location = new Point(86, 149);
            startDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(296, 33);
            startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            endDatePicker.Location = new Point(581, 149);
            endDatePicker.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(305, 33);
            endDatePicker.TabIndex = 3;
            // 
            // majoituksetDgv
            // 
            majoituksetDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            majoituksetDgv.Location = new Point(86, 269);
            majoituksetDgv.Name = "majoituksetDgv";
            majoituksetDgv.RowTemplate.Height = 25;
            majoituksetDgv.Size = new Size(800, 396);
            majoituksetDgv.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(439, 707);
            button2.Name = "button2";
            button2.Size = new Size(96, 42);
            button2.TabIndex = 28;
            button2.Text = "Peruuta";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(167, 95);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 29;
            label1.Text = "Alkupäivä";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LawnGreen;
            label2.Location = new Point(690, 95);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 30;
            label2.Text = "Loppupäivä";
            // 
            // Raportit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 761);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(majoituksetDgv);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Raportit";
            Text = "Raportit";
            Load += Raportit_Load;
            ((System.ComponentModel.ISupportInitialize)majoituksetDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private DataGridView majoituksetDgv;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}