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
            button1 = new Button();
            Raportti = new ListBox();
            label3 = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 265);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 0;
            button1.Text = "Hae";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Raportti
            // 
            Raportti.FormattingEnabled = true;
            Raportti.ItemHeight = 15;
            Raportti.Location = new Point(463, 143);
            Raportti.Name = "Raportti";
            Raportti.Size = new Size(324, 349);
            Raportti.TabIndex = 1;

            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(118, 143);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(118, 192);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 3;
            // 
            // Raportit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(984, 761);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(label3);
            Controls.Add(Raportti);
            Controls.Add(button1);
            Name = "Raportit";
            Text = "Raportit";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox Raportti;
        private Label label3;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
    }
}