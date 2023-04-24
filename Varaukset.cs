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
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mökkihöperö
{
    public partial class Varaukset : Form
    {
        public int selectedMokkiId = 0;


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



            string query = "SELECT * FROM varaus WHERE mokki_mokki_id = 2";
            MySqlCommand cmdx = new MySqlCommand(query, connection);
            cmdx.Parameters.AddWithValue("@mokki_mokki_id", selectedMokkiId);
            cmdx.Parameters.AddWithValue("@varattu_alkupvm", startDate.ToString("yyyy-MM-dd"));
            cmdx.Parameters.AddWithValue("@varattu_loppupvm", endDate.ToString("yyyy-MM-dd"));

          cmdx.ExecuteReader();

            // Oletetaan, että varauksen alku- ja loppupäivämäärät ovat tallennettu muuttujiin startDate ja endDate.

            label1.Text = startDate.ToString("yyyy-MM-dd");


            // Määritä valittu alue kalenterissa
          //  varausKalenteri.SelectionStart = startDate;
           // varausKalenteri.SelectionEnd = endDate;

            // Lisää jokainen päivämäärä varattujen päivämäärien joukkoon
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                varausKalenteri.AddBoldedDate(date);
            }

            // Värjää kalenterissa olevat päivät, jotka ovat varattuja
            varausKalenteri.UpdateBoldedDates();

          


            // Sulje lukija ja tietokantayhteys
            reader.Close();
            connection.Close();


        }





        private void Varaukset_Load(object sender, EventArgs e)
        {

        }

        private void uusiVarausBtn_Click(object sender, EventArgs e)
        {
            // Tällä voit laittaa tietokantaan testidataa


            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand xxx = new MySqlCommand("INSERT INTO posti (postinro, toimipaikka) VALUES (50000, 'MIKKELI')", connection);

            xxx.ExecuteNonQuery();

            MySqlCommand cmd = new MySqlCommand("REPLACE INTO mokki (mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) " +
                                      "VALUES (1, 12, (SELECT postinro FROM posti WHERE toimipaikka = 'MIKKELI'), 'Villa rötiskö', 'Katuosoite 2', 500, 'Upea huvila kaikilla herkuilla', 8, 'Keittiö ja sauna löytyy joo')", connection);


            cmd.ExecuteNonQuery();
            /*
            MySqlCommand cmd = new MySqlCommand("INSERT INTO alue (alue_id, nimi) VALUES (10,'Etelä-Karjala'), (11,'Etelä-Pohjanmaa'), (12,'Etelä-Savo'), (13,'Kainuu'), (14,'Kanta-Häme'), (15,'Keski-Pohjanmaa'), (16,'Keski-Suomi'), (17,'Kymenlaakso'), (18,'Lappi'), (19,'Pirkanmaa'), (20,'Pohjanmaa'), (21,'Pohjois-Karjala'), (22,'Pohjois-Pohjanmaa'), (23,'Pohjois-Savo'), (24,'Päijät-Häme'), (25,'Satakunta'), (26,'Uusimaa'), (27,'Varsinais-Suomi')", connection);
            cmd.ExecuteNonQuery();
             */







        }

        private void varausKalenteri_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void varausKalenteri_DateSelected(object sender, DateRangeEventArgs e)
        {
           



        }
    }
}
