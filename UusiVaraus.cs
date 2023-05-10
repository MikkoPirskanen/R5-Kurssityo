using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mökkihöperö
{
    public partial class UusiVaraus : Form
    {
        public string ConnectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

        public UusiVaraus()
        {
            InitializeComponent();
        }

        private void UusiVaraus_Load(object sender, EventArgs e)
        {
            label1.Text = Varaukset.selectedMokki;
            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker2.MinDate = DateTime.Now.Date;



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            this.Close();

        }

        private void lisaaBtn_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Alkupäivämäärä ei voi olla loppupäivämäärää myöhemmin. Tarkista päivämäärät ja yritä uudelleen.");
                return;
            }


            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d+$");


            if (string.IsNullOrEmpty(puhnroBox.Text) || string.IsNullOrEmpty(etunimiBox.Text) || string.IsNullOrEmpty(sukunimiBox.Text) || string.IsNullOrEmpty(postinroBox.Text) || string.IsNullOrEmpty(osoiteBox.Text) || string.IsNullOrEmpty(emailBox.Text))
            {
                MessageBox.Show("Kaikki kentät ovat pakollisia. Täytä puuttuvat kentät ennen tietojen tallentamista.");
                return;

            }
            if (postinroBox.Text.Length != 5)
            {
                MessageBox.Show("Postinumeron on oltava juuri 5 merkkiä. Tarkista postinumero ja yritä uudelleen.");
                return;
            }

            if (puhnroBox.Text != "" && !regex.IsMatch(puhnroBox.Text))
            {
                MessageBox.Show("Puhelinnumeron on oltava numeroita. Tarkista puhelinnumero ja yritä uudelleen.");
                return;
            }


            DateTime varattualkupvm = DateTime.Parse(dateTimePicker1.Text);
            DateTime varattuloppupvm = DateTime.Parse(dateTimePicker2.Text);
            int mokkix = Varaukset.selectedMokkiId;

            label11.Text = mokkix.ToString();



            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO varaus (asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm,varattu_loppupvm) VALUES (@asiakas_id, @mokki_mokki_id, @varattupvm, @vahvistuspvm, @varattualkupvm, @varattuloppupvm)");
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@asiakas_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@varattupvm", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@vahvistuspvm", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@varattualkupvm", varattualkupvm);
                cmd.Parameters.AddWithValue("@varattuloppupvm", varattuloppupvm);
                cmd.Parameters.AddWithValue("@etunimi", etunimiBox.Text);
                cmd.Parameters.AddWithValue("@sukunimi", sukunimiBox.Text);
                cmd.Parameters.AddWithValue("@lahiosoite", osoiteBox.Text);
                cmd.Parameters.AddWithValue("@postinro", postinroBox.Text);
                cmd.Parameters.AddWithValue("@puhelinnro", puhnroBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@mokki_mokki_id", mokkix);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Varaus lisätty onnistuneesti!");
                connection.Close();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe lisätessä asiakasta tietokantaan: " + ex.Message);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT etunimi, sukunimi, lahiosoite, postinro, email, puhelinnro FROM asiakas WHERE asiakas_id=@asiakas_id", connection);
            cmd.Parameters.AddWithValue("@asiakas_id", textBox1.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    etunimiBox.Text = reader["etunimi"].ToString();
                    sukunimiBox.Text = reader["sukunimi"].ToString();
                    postinroBox.Text = reader["postinro"].ToString();
                    osoiteBox.Text = reader["lahiosoite"].ToString();
                    emailBox.Text = reader["email"].ToString();
                    puhnroBox.Text = reader["puhelinnro"].ToString();
                }
            }
            else
            {
                etunimiBox.Text = "";
                sukunimiBox.Text = "";
                postinroBox.Text = "";
                osoiteBox.Text = "";
                emailBox.Text = "";
                puhnroBox.Text = "";
            }

            reader.Close();
            connection.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM varaus WHERE mokki_mokki_id=@mokki_mokki_id", connection);
            cmd.Parameters.AddWithValue("@mokki_mokki_id", Varaukset.selectedMokkiId);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                DateTime varattualkupvm = DateTime.Parse(reader["varattu_alkupvm"].ToString());
                DateTime varattuloppupvm = DateTime.Parse(reader["varattu_loppupvm"].ToString());

               label1.Text = varattualkupvm.ToString();


        }



    }
}

}
