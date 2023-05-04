using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace Mökkihöperö
{
    public partial class Mokit : Form
    {
        // Muuta tähän tietokannan yhteysasetukset
        private const string ConnectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;";

        public Mokit()
        {
            InitializeComponent();
        }

        private void Mokit_Load(object sender, EventArgs e)
        {
            // Näytä ensimmäinen näkymä oletuksena
            ShowPerustiedot();
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
        private void btnAlueenPalvelut_Click(object sender, EventArgs e)
        {
            ShowAlueenPalvelut();
        }

        // Näytä perustiedot
        private void ShowPerustiedot()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // Avaa yhteys tietokantaan
                connection.Open();

                // SQL-kysely mökkien perustietojen hakemiseksi
                string query = @"SELECT A.nimi AS alue, M.mokkinimi, M.henkilomaara, M.hinta, M.alue_id, M.mokki_id
                                 FROM mokki M
                                 JOIN alue A ON A.alue_id = M.alue_id";

                // Luo SQL-komento ja yhdistä se tietokantayhteyteen
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Luo uusi DataTable ja täytä se SQL-komennon tuloksilla
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());

                    // Aseta taulukko datagridview-kontrolliin
                    dataGridView1.DataSource = table;
                }
            }
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
        // Mökkien hallintaa: mökin lisäys
        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // TODO: suorita lisäys SQL-kysely
            }
        }
        // Mökin muokkaus
        private void btnMuokkaaMokki_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // TODO: suorita muokkaus SQL-kysely
            }
        }
        // Mökin poisto
        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                // TODO: suorita poisto SQL-kysely
            }
        }
    }
}





