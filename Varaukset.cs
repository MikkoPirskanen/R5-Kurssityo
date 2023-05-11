using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mökkihöperö
{
    public partial class Varaukset : Form

    {
        public static string selectedMokki = "";


        public static int selectedMokkiId;


        DateTime startDate;
        DateTime endDate;

        string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";



        public Varaukset()
        {
            InitializeComponent();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Tyhjennä listboxi
            alueenMokit.Items.Clear();

            // Muodosta tietokantayhteys
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Hae valitun alueen mökit
            string selectedArea = alueet.SelectedItem.ToString();

            // Suorita kysely valitun alueen mökeistä
            MySqlCommand cmd = new MySqlCommand(
                "SELECT mokkinimi FROM mokki WHERE alue_id = (SELECT alue_id FROM alue WHERE nimi = @selectedArea)", connection);
            cmd.Parameters.AddWithValue("@selectedArea", selectedArea);

            // Lue hakutulokset
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string mokkiNimi = reader.GetString("mokkinimi");
                alueenMokit.Items.Add(mokkiNimi);
            }

            // Sulje lukija ja tietokantayhteys
            reader.Close();
            connection.Close();
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Muodosta tietokantayhteys
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Hae valitun mökin tiedot

            if (alueenMokit.SelectedItem != null)
            {

                string selectedCabin = alueenMokit.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM mokki WHERE mokkinimi = @selectedCabin", connection);
                cmd.Parameters.AddWithValue("@selectedCabin", selectedCabin);
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("mokkinimi", "Mökin nimi");
                dataGridView1.Columns.Add("katuosoite", "Katuosoite");
                dataGridView1.Columns.Add("hinta", "Hinta");
                dataGridView1.Columns.Add("kuvaus", "Kuvaus");
                dataGridView1.Columns.Add("henkilomaara", "Henkilömäärä");
                dataGridView1.Columns.Add("varustelu", "Varustelu");


                while (reader.Read())
                {
                    selectedMokkiId = reader.GetInt32("mokki_id");
                    string mokkiNimi = reader.GetString("mokkinimi");
                    string katuosoite = reader.GetString("katuosoite");
                    string hinta = reader.GetString("hinta");
                    string kuvaus = reader.GetString("kuvaus");
                    string henkilomaara = reader.GetString("henkilomaara");
                    string varustelu = reader.GetString("varustelu");
                    string[] row = new string[] { mokkiNimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu };
                    dataGridView1.Rows.Add(row);

                }

                reader.Close();



                string query = "SELECT * FROM varaus WHERE mokki_mokki_id = @mokki_mokki_id AND varattu_alkupvm <= @varattu_alkupvm AND varattu_loppupvm >= @varattu_loppupvm";
                MySqlCommand cmdx = new MySqlCommand(query, connection);
                cmdx.Parameters.AddWithValue("@mokki_mokki_id", selectedMokkiId);
                cmdx.Parameters.AddWithValue("@varattu_alkupvm", startDate.ToString("yyyy-MM-dd"));
                cmdx.Parameters.AddWithValue("@varattu_loppupvm", endDate.ToString("yyyy-MM-dd"));

                cmdx.ExecuteReader();


                // Sulje lukija ja tietokantayhteys
                reader.Close();
                connection.Close();

            }
            else
            {
                MessageBox.Show("Valitse alue ja mökki ensin");
            }
        }


        private void Varaukset_Load(object sender, EventArgs e)
        {

        }

        private void uusiVarausBtn_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.SelectedCells[0].Selected = true;
                if (dataGridView1.SelectedCells[0].Value != null && dataGridView1.SelectedCells[0].Value.ToString() != "")
                {
                    selectedMokki = dataGridView1.SelectedCells[0].Value.ToString();
                    UusiVaraus uusiVaraus = new UusiVaraus();
                    uusiVaraus.Show();
                }
                else
                {
                    MessageBox.Show("Valitse mökki ensin");
                }
            }


        }

        private void varausKalenteri_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void varausKalenteri_DateSelected(object sender, DateRangeEventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selectedMokki = row.Cells["mokkinimi"].Value.ToString();

                VarausTiedot varaustiedot = new VarausTiedot();
                varaustiedot.Show();
            }
        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
