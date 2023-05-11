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

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            UusiPalvelu palvelu = new UusiPalvelu();
        }
        
        // Alueet näkymä
        private void btnAlueet_Click(object sender, EventArgs e)
        {
            ShowAlueet();
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

        private void ShowAlueet()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sqlQuery = @"SELECT * FROM alue";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void ShowPerustiedot()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sqlQuery = @"SELECT M.mokki_id, A.nimi, M.mokkinimi, M.henkilomaara, M.hinta, M.alue_id FROM mokki M JOIN alue A ON A.alue_id = M.alue_id";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "mokit");

            dataGridView1.DataSource = dataSet.Tables["mokit"];
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            

            dataGridView1.Columns[0].HeaderText = "Mökki ID";
            dataGridView1.Columns[1].HeaderText = "Alue";
            dataGridView1.Columns[2].HeaderText = "Mökin nimi";
            dataGridView1.Columns[3].HeaderText = "Hlö";
            dataGridView1.Columns[4].HeaderText = "Hinta";
            dataGridView1.Columns[5].HeaderText = "Alue ID";


            connection.Close();
        }


        private void ShowOsoitetiedot()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = @"SELECT m.mokki_id, m.mokkinimi, m.katuosoite, m.postinro, p.toimipaikka AS postitoimipaikka, a.nimi AS alue
                FROM mokki m
                JOIN alue a ON a.alue_id = m.alue_id
                JOIN posti p ON p.postinro = m.postinro";

            MySqlCommand command = new MySqlCommand(query, connection);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            dataGridView1.DataSource = table;

            dataGridView1.Columns["mokki_id"].HeaderText = "Mökki ID";
            dataGridView1.Columns["mokkinimi"].HeaderText = "Mökin nimi";
            dataGridView1.Columns["katuosoite"].HeaderText = "Katuosoite";
            dataGridView1.Columns["postinro"].HeaderText = "Postinumero";
            
            dataGridView1.Columns["postitoimipaikka"].HeaderText = "Postitoimipaikka";
            dataGridView1.Columns["alue"].HeaderText = "Alue";
            connection.Close();
        }
        private void ShowKuvausJaVarustelu()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            // Avaa yhteys tietokantaan
            connection.Open();// SQL-kysely mökkien kuvauksen ja varustelun hakemiseksi
            string query = @"SELECT mokki_id, mokkinimi, kuvaus, varustelu FROM mokki";

            // Luo SQL-komento ja yhdistä se tietokantayhteyteen
            MySqlCommand command = new MySqlCommand(query, connection);

            // Luo DataTable, joka sisältää tietokannasta haetut tiedot
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            // Aseta DataGridView näyttämään tietokannasta haetut tiedot
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 400;

            connection.Close();
        }


        private void ShowAlueenPalvelut()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                // Avaa yhteys tietokantaan
                connection.Open();

                // SQL-kysely alueen palvelujen hakemiseksi
                string query = @"SELECT p.nimi, p.kuvaus
                 FROM palvelu p
                 JOIN alue a ON a.alue_id = p.alue_id
                 WHERE a.alue_id = @alue_id";

                // Luo SQL-komento ja yhdistä se tietokantayhteyteen
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Lisää alue_id parametriin
                    command.Parameters.AddWithValue("@alue_id", textBox1.Text);

                    // Luo DataTable, joka sisältää tietokannasta haetut tiedot
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());

                    // Aseta DataGridView näyttämään tietokannasta haetut tiedot
                    dataGridView1.DataSource = table;
                }
                connection.Close();
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
                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();

                            // Poistetaan mökki taulusta
                            string deleteMokkiQuery = "DELETE FROM mokki WHERE mokki_id = @mokki_id";
                            MySqlCommand deleteMokkiCommand = new MySqlCommand(deleteMokkiQuery, connection);
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
            UusiMökki mökki = new UusiMökki();
            mökki.Show();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {



                int MokkiID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                MuokkaaMökkiä muokkaamökkiä = new MuokkaaMökkiä();
                muokkaamökkiä.Show();

                muokkaamökkiä.kommunikoi(MokkiID);

            }
            else
            {
                MessageBox.Show("Valitse muokattava mökki ");
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
                    using (var connection = new MySqlConnection(ConnectionString))
                    using (var command = new MySqlCommand(query, connection))
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

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
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











