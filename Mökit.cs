using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using MySqlX.XDevAPI.Common;
using MySql.Data.MySqlClient;


namespace Mökkihöperö
{
    public partial class Mokit : Form
    {
        // Muuta tähän tietokannan yhteysasetukset
        private const string ConnectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

        public Mokit()
        {
            InitializeComponent();
        }

        private void Mokit_Load(object sender, EventArgs e)
        {
            // Näytä ensimmäinen näkymä oletuksena
            ShowPerustiedot();
        }

        // Navigointi napit
        private void BtnLaskutus_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus();
            laskutus.Show();
        }

        private void BtnHallinta_Click(object sender, EventArgs e)
        {
            Raportit raportit = new Raportit();
            raportit.Show();

        }

        private void BtnAsiakkaat_Click(object sender, EventArgs e)
        {
            Asiakkaat asiakkaat = new Asiakkaat();

            asiakkaat.Show();
        }


        // Näytä perustiedot-näkymä
        private void btnPerustiedot_Click(object sender, EventArgs e)
        {
            ShowPerustiedot();
        }

        // Näytä osoitetiedot-näkymä
        private void btnOsoitetiedot_Click(object sender, EventArgs e)
        {
            ShowOsoitetiedot();
        }

        // Näytä kuvaus ja varustelu-näkymä
        private void btnKuvausJaVarustelu_Click(object sender, EventArgs e)
        {
            ShowKuvausJaVarustelu();
        }

        // Näytä alueen palvelut-näkymä
        private void BtnAlueenPalvelut_Click(object sender, EventArgs e)
        {
            ShowAlueenPalvelut();
        }



        // Näytä perustiedot
        private void ShowPerustiedot()
        {




            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();


            string sqlQuery = @"SELECT A.nimi, M.mokkinimi, M.katuosoite, M.henkilomaara, M.hinta, M.Kuvaus, M.varustelu FROM mokki M JOIN alue A ON A.alue_id = M.alue_id";



            MySqlCommand cmd = new MySqlCommand(sqlQuery, sqlConnection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "mokit");

            dataGridView1.DataSource = dataSet.Tables["mokit"];
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 300;

            dataGridView1.Columns[0].HeaderText = "Alue";
            dataGridView1.Columns[1].HeaderText = "Mökin nimi";
            dataGridView1.Columns[2].HeaderText = "Katuosoite";
            dataGridView1.Columns[3].HeaderText = "Hlö";
            dataGridView1.Columns[4].HeaderText = "Hinta";
            dataGridView1.Columns[5].HeaderText = "Kuvaus";
            dataGridView1.Columns[6].HeaderText = "Varustelu";





            sqlConnection.Close();

        }

        private void ShowOsoitetiedot()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // Avaa yhteys tietokantaan
                connection.Open();

                // SQL-kysely mökkien osoitetietojen hakemiseksi
                string query = @"SELECT mokkinimi, katuosoite, postinro, postitoimipaikka
                                 FROM mokki M
                                 JOIN posti P ON P.postinro = M.postinro";

                // Luo SQL-komento ja yhdistä se tietokantayhteyteen
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Luo DataTable, joka sisältää tietokannasta haetut tiedot
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());

                    // Aseta DataGridView näyttämään tietokannasta haetut tiedot
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void ShowKuvausJaVarustelu()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // Avaa yhteys tietokantaan
                connection.Open();

                // SQL-kysely mökkien kuvauksen ja varustelun hakemiseksi
                string query = @"SELECT kuvaus, varustelu
                             FROM mokki";

                // Luo SQL-komento ja yhdistä se tietokantayhteyteen
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Luo DataTable, joka sisältää tietokannasta haetut tiedot
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());

                    // Aseta DataGridView näyttämään tietokannasta haetut tiedot
                    dataGridView1.DataSource = table;
                }
            }
        }


        private void ShowAlueenPalvelut()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // Avaa yhteys tietokantaan
                connection.Open();

                // SQL-kysely alueen palvelujen hakemiseksi
                string query = @"SELECT p.nimi, p.kuvaus
                         FROM palvelu p
                         JOIN alue a ON a.alue_id = p.alue_id
                         WHERE a.alue_id = @alue_id";

                // Luo SQL-komento ja yhdistä se tietokantayhteyteen
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Lisää alue_id parametriin
                    command.Parameters.AddWithValue("@alue_id", textBox1.Text);

                    // Luo DataTable, joka sisältää tietokannasta haetut tiedot
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());

                    // Aseta DataGridView näyttämään tietokannasta haetut tiedot
                    dataGridView1.DataSource = table;
                }
            }
        }
        //
        // Hakukone
        //
        private void btnHaku_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text.Contains(searchText))
                    {
                        textBox.BackColor = Color.Yellow;
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
                else if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                            {
                                cell.Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                cell.Style.BackColor = Color.White;
                            }
                        }
                    }
                }
                else if (control is ListView)
                {
                    ListView listView = (ListView)control;
                    foreach (ListViewItem item in listView.Items)
                    {
                        if (item.Text.Contains(searchText))
                        {
                            item.BackColor = Color.Yellow;
                        }
                        else
                        {
                            item.BackColor = Color.White;
                        }
                    }
                }
            }
        }



        // Mökin poistaminen
        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            try
            {
                // Tarkistetaan, onko käyttäjä valinnut mökin
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Haetaan valitun mökin tiedot
                    int mokkiId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string postinro = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                    // Kysytään käyttäjältä varmistus ennen tietojen poistoa
                    DialogResult result = MessageBox.Show("Haluatko varmasti poistaa valitun mökin?", "Vahvista poisto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();

                            // Poistetaan mökki taulusta
                            string deleteMokkiQuery = "DELETE FROM mokki WHERE mokki_id = @mokki_id";
                            SqlCommand deleteMokkiCommand = new SqlCommand(deleteMokkiQuery, connection);
                            deleteMokkiCommand.Parameters.AddWithValue("@mokki_id", mokkiId);
                            deleteMokkiCommand.ExecuteNonQuery();



                            // Päivitetään näkymä
                            dataGridView1.DataSource = haeMokit();
                        }
                    }
                }
                else
                {
                    throw new Exception("Valitse poistettava mökki.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // Mökkien hallintaa: mökin lisäys


        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            // Avaa pop-up-ikkuna tiedon syöttämistä varten
            var formPopup = new Form();
            var alueLabel = new Label() { Text = "Alueen nimi:" };
            var alueDropdown = new ComboBox() { DataSource = GetAlueet(), DisplayMember = "nimi", ValueMember = "alue_id" };
            var postiLabel = new Label() { Text = "Postinumero ja -toimipaikka:" };
            var postiTextbox = new TextBox();
            var mokkiNimiLabel = new Label() { Text = "Mökin nimi:" };
            var mokkiNimiTextbox = new TextBox();
            var katuosoiteLabel = new Label() { Text = "Katuosoite:" };
            var katuosoiteTextbox = new TextBox();
            var hintaLabel = new Label() { Text = "Hinta per yö:" };
            var hintaTextbox = new TextBox();
            var kuvausLabel = new Label() { Text = "Kuvaus:" };
            var kuvausTextbox = new TextBox();
            var henkilomaaraLabel = new Label() { Text = "Henkilömäärä:" };
            var henkilomaaraTextbox = new TextBox();
            var varusteluLabel = new Label() { Text = "Varustelu:" };
            var varusteluTextbox = new TextBox();
            var lisaaButton = new Button() { Text = "Lisää" };
            var peruutaButton = new Button() { Text = "Peruuta" };

            formPopup.Controls.Add(alueLabel);
            formPopup.Controls.Add(alueDropdown);
            formPopup.Controls.Add(postiLabel);
            formPopup.Controls.Add(postiTextbox);
            formPopup.Controls.Add(mokkiNimiLabel);
            formPopup.Controls.Add(mokkiNimiTextbox);
            formPopup.Controls.Add(katuosoiteLabel);
            formPopup.Controls.Add(katuosoiteTextbox);
            formPopup.Controls.Add(hintaLabel);
            formPopup.Controls.Add(hintaTextbox);
            formPopup.Controls.Add(kuvausLabel);
            formPopup.Controls.Add(kuvausTextbox);
            formPopup.Controls.Add(henkilomaaraLabel);
            formPopup.Controls.Add(henkilomaaraTextbox);
            formPopup.Controls.Add(varusteluLabel);
            formPopup.Controls.Add(varusteluTextbox);
            formPopup.Controls.Add(lisaaButton);
            formPopup.Controls.Add(peruutaButton);

            alueLabel.Location = new System.Drawing.Point(20, 20);
            alueDropdown.Location = new System.Drawing.Point(130, 20);
            postiLabel.Location = new System.Drawing.Point(20, 50);
            postiTextbox.Location = new System.Drawing.Point(200, 50);
            mokkiNimiLabel.Location = new System.Drawing.Point(20, 80);
            mokkiNimiTextbox.Location = new System.Drawing.Point(200, 80);
            katuosoiteLabel.Location = new System.Drawing.Point(20, 110);
            katuosoiteTextbox.Location = new System.Drawing.Point(200, 110);
            hintaLabel.Location = new System.Drawing.Point(20, 140);
            hintaTextbox.Location = new System.Drawing.Point(200, 140);
            kuvausLabel.Location = new System.Drawing.Point(20, 170);
            kuvausTextbox.Location = new System.Drawing.Point(200, 170);
            henkilomaaraLabel.Location = new System.Drawing.Point(20, 200);
            henkilomaaraTextbox.Location = new System.Drawing.Point(200, 200);
            varusteluLabel.Location = new System.Drawing.Point(20, 230);
            varusteluTextbox.Location = new System.Drawing.Point(200, 230);
            lisaaButton.Location = new System.Drawing.Point(20, 280);
            peruutaButton.Location = new System.Drawing.Point(100, 280);



            lisaaButton.Click += (object s, EventArgs ea) =>
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Mokit (alue_id, postinro, postitmp, nimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES (@alue_id, @postinro, @postitmp, @nimi, @katuosoite, @hinta, @kuvaus, @henkilomaara, @varustelu)", connection);
                        cmd.Parameters.AddWithValue("@alue_id", alueDropdown.SelectedValue);
                        cmd.Parameters.AddWithValue("@postinro", postiTextbox.Text);
                        cmd.Parameters.AddWithValue("@postitmp", postiTextbox.Text);
                        cmd.Parameters.AddWithValue("@nimi", mokkiNimiTextbox.Text);
                        cmd.Parameters.AddWithValue("@katuosoite", katuosoiteTextbox.Text);
                        cmd.Parameters.AddWithValue("@hinta", hintaTextbox.Text);
                        cmd.Parameters.AddWithValue("@kuvaus", kuvausTextbox.Text);
                        cmd.Parameters.AddWithValue("@henkilomaara", henkilomaaraTextbox.Text);
                        cmd.Parameters.AddWithValue("@varustelu", varusteluTextbox.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Mökki lisätty onnistuneesti!");
                        formPopup.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe lisätessä mökkiä tietokantaan: " + ex.Message);
                }
            };

            peruutaButton.Click += (object s, EventArgs ea) =>
            {
                formPopup.Close();
            };

            formPopup.ShowDialog();

        }
        private DataTable GetAlueet()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT alue_id, nimi FROM alue";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(table);
            }
            return table;
        }
        // Mökin muokkaus

        private void btnMuokkaaMokki_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                form.Text = "Muokkaa mökkiä";
                form.StartPosition = FormStartPosition.CenterScreen;

                Label labelMokkiId = new Label();
                labelMokkiId.Text = "Mökin ID:";
                labelMokkiId.AutoSize = true;
                labelMokkiId.Location = new Point(10, 10);

                TextBox txtMokkiId = new TextBox();
                txtMokkiId.Location = new Point(labelMokkiId.Right + 5, 10);
                txtMokkiId.Width = 200;

                Label labelAlueId = new Label();
                labelAlueId.Text = "Alue ID:";
                labelAlueId.AutoSize = true;
                labelAlueId.Location = new Point(10, labelMokkiId.Bottom + 10);

                TextBox txtAlueId = new TextBox();
                txtAlueId.Location = new Point(labelAlueId.Right + 5, labelMokkiId.Bottom + 10);
                txtAlueId.Width = 200;

                Label labelPostinro = new Label();
                labelPostinro.Text = "Postinumero:";
                labelPostinro.AutoSize = true;
                labelPostinro.Location = new Point(10, labelAlueId.Bottom + 10);

                TextBox txtPostinro = new TextBox();
                txtPostinro.Location = new Point(labelPostinro.Right + 5, labelAlueId.Bottom + 10);
                txtPostinro.Width = 200;

                Label labelMokkinimi = new Label();
                labelMokkinimi.Text = "Mökin nimi:";
                labelMokkinimi.AutoSize = true;
                labelMokkinimi.Location = new Point(10, labelPostinro.Bottom + 10);

                TextBox txtMokkinimi = new TextBox();
                txtMokkinimi.Location = new Point(labelMokkinimi.Right + 5, labelPostinro.Bottom + 10);
                txtMokkinimi.Width = 200;

                Label labelKatuosoite = new Label();
                labelKatuosoite.Text = "Katuosoite:";
                labelKatuosoite.AutoSize = true;
                labelKatuosoite.Location = new Point(10, labelMokkinimi.Bottom + 10);

                TextBox txtKatuosoite = new TextBox();
                txtKatuosoite.Location = new Point(labelKatuosoite.Right + 5, labelMokkinimi.Bottom + 10);
                txtKatuosoite.Width = 200;

                Label labelHinta = new Label();
                labelHinta.Text = "Hinta:";
                labelHinta.AutoSize = true;
                labelHinta.Location = new Point(10, labelKatuosoite.Bottom + 10);

                TextBox txtHinta = new TextBox();
                txtHinta.Location = new Point(labelHinta.Right + 5, labelKatuosoite.Bottom + 10);
                txtHinta.Width = 200;

                Label labelKuvaus = new Label();
                labelKuvaus.Text = "Kuvaus:";
                labelKuvaus.AutoSize = true;
                labelKuvaus.Location = new Point(10, labelHinta.Bottom + 10);

                TextBox textBoxKuvaus = new TextBox();
                textBoxKuvaus.Width = 200;
                textBoxKuvaus.Location = new Point(labelKuvaus.Right + 5, labelHinta.Bottom + 10);

                Label labelHenkilomaara = new Label();
                labelHenkilomaara.Text = "Henkilömäärä:";
                labelHenkilomaara.AutoSize = true;
                labelHenkilomaara.Location = new Point(10, labelKuvaus.Bottom + 10);

                TextBox txtHenkilomaara = new TextBox();
                txtHenkilomaara.Location = new Point(labelHenkilomaara.Right + 5, labelKuvaus.Bottom + 10);
                txtHenkilomaara.Width = 200;

                Label labelVarustelu = new Label();
                labelVarustelu.Text = "Varustelu:";
                labelVarustelu.AutoSize = true;
                labelVarustelu.Location = new Point(10, labelHenkilomaara.Bottom + 10);

                TextBox txtVarustelu = new TextBox();
                txtVarustelu.Location = new Point(labelVarustelu.Right + 5, labelHenkilomaara.Bottom + 10);
                txtVarustelu.Width = 200;


                // Mökiin tietojen tallennus
                Button buttonLisaa = new Button();
                buttonLisaa.Text = "Tallenna";
                buttonLisaa.Location = new Point(textBoxKuvaus.Right - buttonLisaa.Width, textBoxKuvaus.Bottom + 10);
                buttonLisaa.Click += (s, ea) =>
                {
                    try
                    {
                        // Haetaan syötteet tekstikentistä:
                        int mokkiId = int.Parse(txtMokkiId.Text);
                        int alueId = int.Parse(txtAlueId.Text);
                        string postinro = txtPostinro.Text;
                        string mokkinimi = txtMokkinimi.Text;
                        string katuosoite = txtKatuosoite.Text;
                        double hinta = double.Parse(txtHinta.Text);
                        string kuvaus = textBoxKuvaus.Text;
                        int henkilomaara = int.Parse(txtHenkilomaara.Text);
                        string varustelu = txtVarustelu.Text;
                        // Päivitetään tietokantaan mökin tiedot
                        // updateMokki(mokkiId, alueId, postinro, mokkinimi, katuosoite, hinta, kuvaus);

                        // Suljetaan ikkuna
                        this.Close();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Syötteissä on virheellistä tietoa: " + ex.Message);
                    }
                };



                this.Controls.Add(labelMokkinimi);
                this.Controls.Add(txtMokkinimi);
                this.Controls.Add(labelHinta);
                this.Controls.Add(txtHinta);
                this.Controls.Add(labelKuvaus);
                this.Controls.Add(textBoxKuvaus);
                this.Controls.Add(buttonLisaa);
                this.Controls.Add(labelVarustelu);
                this.Controls.Add(txtVarustelu);
                this.Controls.Add(labelHenkilomaara);
                this.Controls.Add(txtHenkilomaara);


                form.Controls.Add(labelMokkiId);
                form.Controls.Add(txtMokkiId);
                form.Controls.Add(labelAlueId);
                form.Controls.Add(txtAlueId);
                form.Controls.Add(labelPostinro);
                form.Controls.Add(txtPostinro);
                form.Controls.Add(labelMokkinimi);
                form.Controls.Add(txtMokkinimi);
                form.Controls.Add(labelKatuosoite);
                form.Controls.Add(txtKatuosoite);
                form.Controls.Add(labelHinta);
                form.Controls.Add(txtHinta);
                form.Controls.Add(labelKuvaus);
                form.Controls.Add(textBoxKuvaus);
                form.Controls.Add(buttonLisaa);

                // Haetaan tietokannasta valitun mökin tiedot
                string mokkiId = txtMokkiId.Text;
                string query = "SELECT alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu FROM mokit WHERE mokki_id = " + mokkiId;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtMokkiId.Text = reader["mokki_id"].ToString();
                        txtAlueId.Text = reader["alue_id"].ToString();
                        txtPostinro.Text = reader["postinro"].ToString();
                        txtMokkinimi.Text = reader["mokkinimi"].ToString();
                        txtKatuosoite.Text = reader["katuosoite"].ToString();
                        txtHinta.Text = reader["hinta"].ToString();
                        textBoxKuvaus.Text = reader["kuvaus"].ToString();
                        txtHenkilomaara.Text = reader["henkilomaara"].ToString();
                        txtVarustelu.Text = reader["varustelu"].ToString();

                    }

                    reader.Close();
                }

                // Näytetään ikkuna
                form.ShowDialog();



            }
        }







        private List<Mokki> haeMokit()
        {
            List<Mokki> mokit = new List<Mokki>();

            string query = "SELECT mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu FROM mokit";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Mokki mokki = new Mokki();
                        mokki.MokkiId = reader.GetInt32(0);
                        mokki.AlueId = reader.GetInt32(1);
                        mokki.Postinro = reader.GetString(2);
                        mokki.Mokkinimi = reader.GetString(3);
                        mokki.Katuosoite = reader.GetString(4);
                        mokki.Hinta = reader.GetDouble(5);
                        mokki.Kuvaus = reader.GetString(6);
                        mokki.Henkilomaara = reader.GetInt32(7);
                        mokki.Varustelu = reader.GetString(8);
                        mokit.Add(mokki);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Tulosta virheilmoitus konsoliin tai loggaa virhe
                Console.WriteLine("Virhe haettaessa mökkejä tietokannasta: " + ex.Message);
            }

            return mokit;
        }
        public class Mokki
        {
            public int MokkiId { get; set; }
            public int AlueId { get; set; }
            public string Postinro { get; set; }
            public string Mokkinimi { get; set; }
            public string Katuosoite { get; set; }
            public double Hinta { get; set; }
            public string Kuvaus { get; set; }
            public string Varustelu { get; set; }
            public int Henkilomaara { get; set; }
        }


        ////
        /// Tehdään pohja lopuille napeille, johon täytetään toiminnallisuudet myöhemmin

        private void BtnLisaaAlue_Click(object sender, EventArgs e)
        {
            using (var lisaaAluePopup = new Form())
            {
                // Luo kontrollit popup-ikkunaan
                var label = new Label();
                label.Text = "Anna uuden alueen nimi:";
                label.Location = new Point(10, 10);
                var textBox = new TextBox();
                textBox.Location = new Point(10, 30);
                var okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                okButton.Location = new Point(10, 60);
                var cancelButton = new Button();
                cancelButton.Text = "Peruuta";
                cancelButton.DialogResult = DialogResult.Cancel;
                cancelButton.Location = new Point(80, 60);

                // Lisää kontrollit popup-ikkunaan
                lisaaAluePopup.Text = "Lisää uusi alue";
                lisaaAluePopup.AcceptButton = okButton;
                lisaaAluePopup.CancelButton = cancelButton;
                lisaaAluePopup.ClientSize = new Size(200, 100);
                lisaaAluePopup.Controls.Add(label);
                lisaaAluePopup.Controls.Add(textBox);
                lisaaAluePopup.Controls.Add(okButton);
                lisaaAluePopup.Controls.Add(cancelButton);

                // Näytä popup-ikkuna ja käsittele tulos
                if (lisaaAluePopup.ShowDialog() == DialogResult.OK)
                {
                    // Lisää uusi alue tietokantaan
                    string nimi = textBox.Text;
                    string query = "INSERT INTO alue (nimi) VALUES (@nimi)";
                    using (var connection = new SqlConnection(ConnectionString))
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nimi", nimi);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void BtnPoistaAlue_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int alueId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["alue_id"].Value);
                string nimi = dataGridView1.SelectedRows[0].Cells["nimi"].Value.ToString();
                string vahvistusviesti = $"Haluatko varmasti poistaa alueen \"{nimi}\"?";

                DialogResult result = MessageBox.Show(vahvistusviesti, "Vahvista poisto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM alue WHERE alue_id = {alueId}";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Alue poistettu onnistuneesti.", "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Valitse ensin poistettava alue.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnMuokkaaAluetta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Haetaan valitun alueen tiedot
                int alueId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["alue_id"].Value);
                string nykyinenNimi = dataGridView1.SelectedRows[0].Cells["nimi"].Value.ToString();

                // Luodaan uusi ikkuna, jossa käyttäjä voi muokata alueen nimeä
                using (var muokkaaAluePopup = new Form())
                {
                    var label = new Label();
                    label.Text = "Anna uusi nimi:";
                    label.Location = new Point(10, 10);
                    var textBox = new TextBox();
                    textBox.Text = nykyinenNimi;
                    textBox.Location = new Point(10, 30);
                    var okButton = new Button();
                    okButton.Text = "OK";
                    okButton.DialogResult = DialogResult.OK;
                    okButton.Location = new Point(10, 60);
                    var cancelButton = new Button();
                    cancelButton.Text = "Peruuta";
                    cancelButton.DialogResult = DialogResult.Cancel;
                    cancelButton.Location = new Point(80, 60);

                    muokkaaAluePopup.Text = "Muokkaa alueen nimeä";
                    muokkaaAluePopup.AcceptButton = okButton;
                    muokkaaAluePopup.CancelButton = cancelButton;
                    muokkaaAluePopup.ClientSize = new Size(200, 100);
                    muokkaaAluePopup.Controls.Add(label);
                    muokkaaAluePopup.Controls.Add(textBox);
                    muokkaaAluePopup.Controls.Add(okButton);
                    muokkaaAluePopup.Controls.Add(cancelButton);

                    // Näytä popup-ikkuna ja käsittele tulos
                    if (muokkaaAluePopup.ShowDialog() == DialogResult.OK)
                    {
                        string uusiNimi = textBox.Text;

                        // Päivitä alueen nimi tietokantaan
                        string query = "UPDATE alue SET nimi = @uusiNimi WHERE alue_id = @alueId";
                        using (var connection = new SqlConnection("connection_string_here"))
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@alueId", alueId);
                            command.Parameters.AddWithValue("@uusiNimi", uusiNimi);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Valitse ensin muokattava alue.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTeeVaraus_Click(object sender, EventArgs e)
        {
            Varaukset varaus = new Varaukset();
            varaus.Show();
        }
    }
}












