using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Mökkihöperö
{
    public partial class Asiakkaat : Form
    {
        string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";


        public Asiakkaat()
        {
            InitializeComponent();
        }

        private void haeNappi_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * from posti", connection);

            textBox1.Text = cmd.ExecuteScalar().ToString();
            connection.Close();




        }

        private void lisääNappi_Click(object sender, EventArgs e)
        {

            

        }

        private void päivitäNappi_Click(object sender, EventArgs e)
        {


            // Luodaan yhteys tietokantaan
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);

            // Avataan yhteys
            sqlConnection.Open();

            // Määritellään SQL-kysely
            string sqlQuery = "SELECT * FROM asiakas";

            // Luodaan SqlDataAdapter-olio
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, sqlConnection);

            // Luodaan DataSet-olio
            DataSet dataSet = new DataSet();

            // Täytetään DataSet-olio SqlDataAdapter-olion avulla
            dataAdapter.Fill(dataSet);

            // Asetetaan DataSet-olion taulu DataGridView:n DataSource-ominaisuudeksi
            dataGridView1.DataSource = dataSet.Tables[0];

            // Suljetaan yhteys
            sqlConnection.Close();

        }
        private void poistaNappi_Click(object sender, EventArgs e)
        {

        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
