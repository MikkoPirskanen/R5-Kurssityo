neamespace Mökkihöperö
{
    partial class Mokit
{

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

    private void InitializeComponent()
    {
        button1 = new Button();
        textBox1 = new TextBox();
        dataGridView1 = new DataGridView();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        monthCalendar1 = new MonthCalendar();
        label1 = new Label();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(244, 43);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "Haku";
        button1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(42, 43);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(196, 27);
        textBox1.TabIndex = 1;
        textBox1.Text = "Hakukenttä";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(42, 88);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(1031, 385);
        dataGridView1.TabIndex = 2;
        // 
        // button2
        // 
        button2.Location = new Point(440, 43);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 3;
        button2.Text = "Perustiedot";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(540, 43);
        button3.Name = "button3";
        button3.Size = new Size(129, 29);
        button3.TabIndex = 4;
        button3.Text = "Osoitetiedot";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(675, 43);
        button4.Name = "button4";
        button4.Size = new Size(157, 29);
        button4.TabIndex = 5;
        button4.Text = "Kuvaus ja Varustelu";
        button4.UseVisualStyleBackColor = true;
        // 
        // monthCalendar1
        // 
        monthCalendar1.Location = new Point(1111, 125);
        monthCalendar1.Name = "monthCalendar1";
        monthCalendar1.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(1167, 90);
        label1.Name = "label1";
        label1.Size = new Size(97, 20);
        label1.TabIndex = 7;
        label1.Text = "Varaustilanne";
        // 
        // button5
        // 
        button5.Location = new Point(1111, 344);
        button5.Name = "button5";
        button5.Size = new Size(220, 29);
        button5.TabIndex = 8;
        button5.Text = "Varaa mökki";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(42, 490);
        button6.Name = "button6";
        button6.Size = new Size(94, 29);
        button6.TabIndex = 9;
        button6.Text = "Lisää Mökki";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(142, 490);
        button7.Name = "button7";
        button7.Size = new Size(147, 29);
        button7.TabIndex = 10;
        button7.Text = "Muokkaa Mökkiä";
        button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new Point(295, 490);
        button8.Name = "button8";
        button8.Size = new Size(146, 29);
        button8.TabIndex = 11;
        button8.Text = "Poista Mökki";
        button8.UseVisualStyleBackColor = true;
        // 
        // Mokit
        // 
        this.ClientSize = new Size(1349, 550);
        this.Controls.Add(button8);
        this.Controls.Add(button7);
        this.Controls.Add(button6);
        this.Controls.Add(button5);
        this.Controls.Add(label1);
        this.Controls.Add(monthCalendar1);
        this.Controls.Add(button4);
        this.Controls.Add(button3);
        this.Controls.Add(button2);
        this.Controls.Add(dataGridView1);
        this.Controls.Add(textBox1);
        this.Controls.Add(button1);
        this.Name = "Mokit";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private Button button1;
    private TextBox textBox1;
    private DataGridView dataGridView1;
    private Button button2;
    private Button button3;
    private Button button4;
    private MonthCalendar monthCalendar1;
    private Label label1;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
}
