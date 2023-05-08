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

        private void haeNappi_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * from posti", connection);

            hakukentta.Text = cmd.ExecuteScalar().ToString();
            connection.Close();




        }

        private void lisääNappi_Click(object sender, EventArgs e)
        {

            UusiAsiakas uusi = new UusiAsiakas();
            uusi.ShowDialog();

            // Päivitä DataGridView
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM asiakas";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlQuery, sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();




        }

        private void päivitäNappi_Click(object sender, EventArgs e)
        {



        }
        private void poistaNappi_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow valittuRivi = dataGridView1.SelectedRows[0];
                valittuRivi.Selected = true;



                int id = Convert.ToInt32(valittuRivi.Cells["asiakas_id"].Value);


                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM asiakas WHERE asiakas_id = @id", con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();


                con.Close();

                dataGridView1.Rows.Remove(valittuRivi);


            }
            catch
            {
                MessageBox.Show("Valitse poistettava rivi.");

                return;

            }



        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string hakusana = hakukentta.Text;
            if (hakusana.Length > 3)
            {
                // Etsi DataGridViewistä hakusanalla
                try
                {


                    foreach (DataGridViewRow rivi in dataGridView1.Rows)
                    {
                        if (rivi.Cells[1].Value.ToString().Equals(hakusana))

                        {
                          
                            
                            
                            dataGridView1.CurrentCell = dataGridView1.Rows[rivi.Index].Cells[0];
                            dataGridView1.Rows[rivi.Index].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rivi.Index;

                            return;
                        }

                    }
                }
                                catch
                {
                    MessageBox.Show("Ei löytynyt.");
                    return;
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
