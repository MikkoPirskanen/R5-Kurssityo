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
            

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open ();
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO posti (postinro, toimipaikka) VALUES (66666,'kuopio')", connection);
           

            cmd.ExecuteNonQuery();
            connection.Close();



        }

        private void päivitäNappi_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Asiakkaat SET postinumero = @postinumero, etunimi = @etunimi, sukunimi = @sukunimi, lahiosoite = @lahiosoite, email = @email, puhelinnumero = @puhelinnumero WHERE asiakas_id = @asiakas_id", connection);
                command.Parameters.AddWithValue("@postinumero", PostinumeroTextBox.Text);
                command.Parameters.AddWithValue("@etunimi", EtunimiTextBox.Text);
                command.Parameters.AddWithValue("@sukunimi", SukunimiTextBox.Text);
                command.Parameters.AddWithValue("@lahiosoite", LahiosoiteTextBox.Text);
                command.Parameters.AddWithValue("@email", EmailTextBox.Text);
                command.Parameters.AddWithValue("@puhelinnumero", PuhelinnumeroTextBox.Text);
                command.Parameters.AddWithValue("@asiakas_id", AsiakasIdTextBox.Text);
                command.ExecuteNonQuery();
            }
            */
        }
        private void poistaNappi_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Asiakkaat WHERE asiakas_id = @asiakas_id", connection);
                command.Parameters.AddWithValue("@asiakas_id", AsiakasIdTextBox.Text);
                command.ExecuteNonQuery();
            }
            */
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
