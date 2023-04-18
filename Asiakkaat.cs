using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkihöperö
{
    public partial class Asiakkaat : Form
    {
        private string connectionString = "connection_string_here";

        public Asiakkaat()
        {
            InitializeComponent();
        }

        private void haeNappi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Asiakkaat WHERE asiakas_id LIKE @search OR postinumero LIKE @search OR etunimi LIKE @search OR sukunimi LIKE @search OR lahiosoite LIKE @search OR email LIKE @search OR puhelinnumero LIKE @search", connection);
                command.Parameters.AddWithValue("@search", "%" + Hakukentta.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                TulosDataGridView.DataSource = table;
            }
        }

        private void lisääNappi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Asiakkaat (postinumero, etunimi, sukunimi, lahiosoite, email, puhelinnumero) VALUES (@postinumero, @etunimi, @sukunimi, @lahiosoite, @email, @puhelinnumero)", connection);
                command.Parameters.AddWithValue("@postinumero", PostinumeroTextBox.Text);
                command.Parameters.AddWithValue("@etunimi", EtunimiTextBox.Text);
                command.Parameters.AddWithValue("@sukunimi", SukunimiTextBox.Text);
                command.Parameters.AddWithValue("@lahiosoite", LahiosoiteTextBox.Text);
                command.Parameters.AddWithValue("@email", EmailTextBox.Text);
                command.Parameters.AddWithValue("@puhelinnumero", PuhelinnumeroTextBox.Text);
                command.ExecuteNonQuery();
            }
        }

        private void päivitäNappi_Click(object sender, EventArgs e)
        {
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
        }
        private void poistaNappi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Asiakkaat WHERE asiakas_id = @asiakas_id", connection);
                command.Parameters.AddWithValue("@asiakas_id", AsiakasIdTextBox.Text);
                command.ExecuteNonQuery();
            }
        }
    }
}
