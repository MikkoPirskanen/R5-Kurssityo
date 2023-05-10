using MySql.Data.MySqlClient;
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
using static Mökkihöperö.Mokit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mökkihöperö
{
    public partial class UusiPalvelu : Form
    {
        List<string> alueIDseuranta = new List<string>();
        string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";
        public UusiPalvelu()
        {
            InitializeComponent();
            



            // Suljetaan yhteys

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void valitseHinta_TextChanged(object sender, EventArgs e)
        {

            if (valitseHinta.Text.Length > 0)
            {
                double APhinta = double.Parse(valitseHinta.Text);
                double ALVhinta = APhinta + (APhinta * 0.24);
                ALVhinta = Math.Round(ALVhinta, 2);
                ALVnäyttö.Text = "+ ALV (+24%) - " + ALVhinta;
            }
            else
            {
                ALVnäyttö.Text = " ";
            }

        }

        private void valitseHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void valitseAlue_DropDown(object sender, EventArgs e)
        {
            // Tyhjennä listboxi
            valitseAlue.Items.Clear();
            


            // Muodosta tietokantayhteys
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Suorita kysely valitun alueen mökeistä
            MySqlCommand cmd = new MySqlCommand(
                "SELECT nimi, alue_id FROM alue", connection);


            // Lue hakutulokset
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string mokkiNimi = reader.GetString("nimi");
                alueIDseuranta.Add(reader.GetString("alue_id"));
                valitseAlue.Items.Add(mokkiNimi);
            }

            // Sulje lukija ja tietokantayhteys
            reader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int idintrandomed = rnd.Next(100000000, 999999999);
                string idstringrandomed = idintrandomed.ToString();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                double APhinta = double.Parse(valitseHinta.Text);
                double ALVhinta = (APhinta * 0.24);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO palvelu (palvelu_id, alue_id, nimi, hinta, alv) VALUES (@palvelu_id, @alue_id, @nimi, @hinta, @alv)");
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@palvelu_id", idintrandomed);
                cmd.Parameters.AddWithValue("@alue_id", alueIDseuranta[valitseAlue.SelectedIndex]);
                cmd.Parameters.AddWithValue("@nimi", valitseNimi.Text);
                cmd.Parameters.AddWithValue("@hinta", APhinta);
                cmd.Parameters.AddWithValue("@alv", ALVhinta);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Palvelu lisätty onnistuneesti!");
                connection.Close();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe lisätessä palvelua tietokantaan: " + ex.Message);
            }
        }
    }
}
