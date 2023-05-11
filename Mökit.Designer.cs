namespace Mökkihöperö
{
    partial class Mokit
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
            textBox1 = new TextBox();
            btnHaku = new Button();
            btnPerustiedot = new Button();
            btnOsoitetiedot = new Button();
            btnKuvausJaVarustelu = new Button();
            dataGridView1 = new DataGridView();
            btnTeeVaraus = new Button();
            btnLisaaMokki = new Button();
            btnMuokkaaMokki = new Button();
            btnPoistaMokki = new Button();
            btnLisaaAlue = new Button();
            btnMuokkaaAluetta = new Button();
            btnPoistaAlue = new Button();
            btnAlueenPalvelut = new Button();
            btnAsiakkaat = new Button();
            btnRaportointi = new Button();
            btnLaskutus = new Button();
            btnAlueet = new Button();
            btnLisaaPalvelu = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Hakukenttä";
            // 
            // btnHaku
            // 
            btnHaku.Location = new Point(243, 10);
            btnHaku.Name = "btnHaku";
            btnHaku.Size = new Size(94, 29);
            btnHaku.TabIndex = 1;
            btnHaku.Text = "Haku";
            btnHaku.UseVisualStyleBackColor = true;
            btnHaku.Click += btnHaku_Click;
            // 
            // btnPerustiedot
            // 
            btnPerustiedot.Location = new Point(903, 47);
            btnPerustiedot.Name = "btnPerustiedot";
            btnPerustiedot.Size = new Size(122, 29);
            btnPerustiedot.TabIndex = 2;
            btnPerustiedot.Text = "Perustiedot";
            btnPerustiedot.UseVisualStyleBackColor = true;
            btnPerustiedot.Click += btnPerustiedot_Click;
            // 
            // btnOsoitetiedot
            // 
            btnOsoitetiedot.Location = new Point(767, 47);
            btnOsoitetiedot.Name = "btnOsoitetiedot";
            btnOsoitetiedot.Size = new Size(130, 29);
            btnOsoitetiedot.TabIndex = 3;
            btnOsoitetiedot.Text = "Osoitetiedot";
            btnOsoitetiedot.UseVisualStyleBackColor = true;
            btnOsoitetiedot.Click += btnOsoitetiedot_Click;
            // 
            // btnKuvausJaVarustelu
            // 
            btnKuvausJaVarustelu.Location = new Point(767, 12);
            btnKuvausJaVarustelu.Name = "btnKuvausJaVarustelu";
            btnKuvausJaVarustelu.Size = new Size(196, 29);
            btnKuvausJaVarustelu.TabIndex = 4;
            btnKuvausJaVarustelu.Text = "Kuvaus ja varustelu";
            btnKuvausJaVarustelu.UseVisualStyleBackColor = true;
            btnKuvausJaVarustelu.Click += btnKuvausJaVarustelu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1101, 494);
            dataGridView1.TabIndex = 5;
            // 
            // btnTeeVaraus
            // 
            btnTeeVaraus.Location = new Point(1228, 157);
            btnTeeVaraus.Name = "btnTeeVaraus";
            btnTeeVaraus.Size = new Size(220, 29);
            btnTeeVaraus.TabIndex = 8;
            btnTeeVaraus.Text = "Tee varaus";
            btnTeeVaraus.UseVisualStyleBackColor = true;
            btnTeeVaraus.Click += btnTeeVaraus_Click;
            // 
            // btnLisaaMokki
            // 
            btnLisaaMokki.Location = new Point(12, 610);
            btnLisaaMokki.Name = "btnLisaaMokki";
            btnLisaaMokki.Size = new Size(128, 29);
            btnLisaaMokki.TabIndex = 9;
            btnLisaaMokki.Text = "Lisää mökki";
            btnLisaaMokki.UseVisualStyleBackColor = true;
            btnLisaaMokki.Click += btnLisaaMokki_Click;
            // 
            // btnMuokkaaMokki
            // 
            btnMuokkaaMokki.Location = new Point(146, 610);
            btnMuokkaaMokki.Name = "btnMuokkaaMokki";
            btnMuokkaaMokki.Size = new Size(166, 29);
            btnMuokkaaMokki.TabIndex = 10;
            btnMuokkaaMokki.Text = "Muokkaa mökkiä";
            btnMuokkaaMokki.UseVisualStyleBackColor = true;
            btnMuokkaaMokki.Click += btnMuokkaaMokki_Click;
            // 
            // btnPoistaMokki
            // 
            btnPoistaMokki.Location = new Point(318, 610);
            btnPoistaMokki.Name = "btnPoistaMokki";
            btnPoistaMokki.Size = new Size(134, 29);
            btnPoistaMokki.TabIndex = 11;
            btnPoistaMokki.Text = "Poista mökki";
            btnPoistaMokki.UseVisualStyleBackColor = true;
            btnPoistaMokki.Click += btnPoistaMokki_Click;
            // 
            // btnLisaaAlue
            // 
            btnLisaaAlue.Location = new Point(669, 610);
            btnLisaaAlue.Name = "btnLisaaAlue";
            btnLisaaAlue.Size = new Size(120, 29);
            btnLisaaAlue.TabIndex = 12;
            btnLisaaAlue.Text = "Lisää alue";
            btnLisaaAlue.UseVisualStyleBackColor = true;
            btnLisaaAlue.Click += BtnLisaaAlue_Click;
            // 
            // btnMuokkaaAluetta
            // 
            btnMuokkaaAluetta.Location = new Point(795, 610);
            btnMuokkaaAluetta.Name = "btnMuokkaaAluetta";
            btnMuokkaaAluetta.Size = new Size(140, 29);
            btnMuokkaaAluetta.TabIndex = 13;
            btnMuokkaaAluetta.Text = "Muokkaa aluetta";
            btnMuokkaaAluetta.UseVisualStyleBackColor = true;
            btnMuokkaaAluetta.Click += btnMuokkaaAluetta_Click;
            // 
            // btnPoistaAlue
            // 
            btnPoistaAlue.Location = new Point(941, 610);
            btnPoistaAlue.Name = "btnPoistaAlue";
            btnPoistaAlue.Size = new Size(104, 29);
            btnPoistaAlue.TabIndex = 14;
            btnPoistaAlue.Text = "Poista alue";
            btnPoistaAlue.UseVisualStyleBackColor = true;
            btnPoistaAlue.Click += BtnPoistaAlue_Click;
            // 
            // btnAlueenPalvelut
            // 
            btnAlueenPalvelut.Location = new Point(969, 12);
            btnAlueenPalvelut.Name = "btnAlueenPalvelut";
            btnAlueenPalvelut.Size = new Size(156, 29);
            btnAlueenPalvelut.TabIndex = 15;
            btnAlueenPalvelut.Text = "Alueen palvelut";
            btnAlueenPalvelut.UseVisualStyleBackColor = true;
            btnAlueenPalvelut.Click += BtnAlueenPalvelut_Click;
            // 
            // btnAsiakkaat
            // 
            btnAsiakkaat.Location = new Point(1228, 335);
            btnAsiakkaat.Name = "btnAsiakkaat";
            btnAsiakkaat.Size = new Size(220, 31);
            btnAsiakkaat.TabIndex = 16;
            btnAsiakkaat.Text = "Asiakkaat";
            btnAsiakkaat.UseVisualStyleBackColor = true;
            btnAsiakkaat.Click += BtnAsiakkaat_Click;
            // 
            // btnRaportointi
            // 
            btnRaportointi.Location = new Point(1228, 372);
            btnRaportointi.Name = "btnRaportointi";
            btnRaportointi.Size = new Size(220, 29);
            btnRaportointi.TabIndex = 17;
            btnRaportointi.Text = "Raportointi";
            btnRaportointi.UseVisualStyleBackColor = true;
            btnRaportointi.Click += BtnHallinta_Click;
            // 
            // btnLaskutus
            // 
            btnLaskutus.Location = new Point(1228, 407);
            btnLaskutus.Name = "btnLaskutus";
            btnLaskutus.Size = new Size(220, 29);
            btnLaskutus.TabIndex = 18;
            btnLaskutus.Text = "Laskutus";
            btnLaskutus.UseVisualStyleBackColor = true;
            btnLaskutus.Click += BtnLaskutus_Click;
            // 
            // btnAlueet
            // 
            btnAlueet.Location = new Point(1031, 47);
            btnAlueet.Name = "btnAlueet";
            btnAlueet.Size = new Size(94, 29);
            btnAlueet.TabIndex = 19;
            btnAlueet.Text = "Alueet";
            btnAlueet.UseVisualStyleBackColor = true;
            btnAlueet.Click += btnAlueet_Click;
            // 
            // btnLisaaPalvelu
            // 
            btnLisaaPalvelu.Location = new Point(1231, 192);
            btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            btnLisaaPalvelu.Size = new Size(217, 29);
            btnLisaaPalvelu.TabIndex = 20;
            btnLisaaPalvelu.Text = "Lisää Palvelu";
            btnLisaaPalvelu.UseVisualStyleBackColor = true;
            btnLisaaPalvelu.Click += btnLisaaPalvelu_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 21;
            comboBox1.DropDown += comboBox1_DropDown;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Mokit
            // 
            ClientSize = new Size(1528, 684);
            Controls.Add(comboBox1);
            Controls.Add(btnLisaaPalvelu);
            Controls.Add(btnAlueet);
            Controls.Add(btnLaskutus);
            Controls.Add(btnRaportointi);
            Controls.Add(btnAsiakkaat);
            Controls.Add(btnAlueenPalvelut);
            Controls.Add(btnPoistaAlue);
            Controls.Add(btnMuokkaaAluetta);
            Controls.Add(btnLisaaAlue);
            Controls.Add(btnPoistaMokki);
            Controls.Add(btnMuokkaaMokki);
            Controls.Add(btnLisaaMokki);
            Controls.Add(btnTeeVaraus);
            Controls.Add(dataGridView1);
            Controls.Add(btnKuvausJaVarustelu);
            Controls.Add(btnOsoitetiedot);
            Controls.Add(btnPerustiedot);
            Controls.Add(btnHaku);
            Controls.Add(textBox1);
            Name = "Mokit";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Button btnHaku;
        private Button btnPerustiedot;
        private Button btnOsoitetiedot;
        private Button btnKuvausJaVarustelu;
        private DataGridView dataGridView1;
        private Button btnTeeVaraus;
        private Button btnLisaaMokki;
        private Button btnMuokkaaMokki;
        private Button btnPoistaMokki;
        private Button btnLisaaAlue;
        private Button btnMuokkaaAluetta;
        private Button btnPoistaAlue;
        private Button btnAlueenPalvelut;
        private Button btnAsiakkaat;
        private Button btnRaportointi;
        private Button btnLaskutus;
        private Button btnAlueet;
        private Button btnLisaaPalvelu;
        private ComboBox comboBox1;
    }
}
#endregion
