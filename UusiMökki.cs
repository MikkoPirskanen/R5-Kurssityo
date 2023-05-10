using MySql.Data.MySqlClient;
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
    public partial class UusiMökki : Form
    {
        List<string> alueIDseuranta2 = new List<string>();
        string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";
        public UusiMökki()
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

        private void valitseAlue2_DropDown(object sender, EventArgs e)
        {


        }


        private void valitseAlue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int idintrandomed = rnd.Next(10000, 99999);
                string idstringrandomed = idintrandomed.ToString();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                
                double APhinta = double.Parse(valitseHinta.Text);
                int postinro = int.Parse(valitsePostinro.Text);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO mokki (mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES (@mokki_id, @alue_id, @postinro, @mokkinimi, @katuosoite, @hinta, @kuvaus, @henkilomaara, @varustelu)");
                
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@mokki_id", idintrandomed);
                cmd.Parameters.AddWithValue("@alue_id", alueIDseuranta2[valitseAlue2.SelectedIndex]);
                cmd.Parameters.AddWithValue("@postinro", valitsePostinro.Text);
                cmd.Parameters.AddWithValue("@mokkinimi", valitseNimi.Text);
                cmd.Parameters.AddWithValue("@katuosoite", valitseKatuosoite.Text);
                cmd.Parameters.AddWithValue("@hinta", APhinta);
                cmd.Parameters.AddWithValue("@kuvaus", valitseKuvaus.Text);
                cmd.Parameters.AddWithValue("@henkilomaara", valitseHlomaara.Text);
                cmd.Parameters.AddWithValue("@varustelu", valitseVarustelu.Text);
                
                cmd.ExecuteNonQuery();


                MessageBox.Show("Mökin lisätty onnistuneesti!");
                connection.Close();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe lisätessä mökkiä tietokantaan: " + ex.Message);
            }
        }

        private void valitseHinta_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void valitsePostinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            /* only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void valitseKatuosoite_TextChanged(object sender, EventArgs e)
        {

        }

        private void valitseHlomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void valitseAlue2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void valitseAlue2_DropDown_1(object sender, EventArgs e)
        {
            // Tyhjennä listboxi
            valitseAlue2.Items.Clear();



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
                alueIDseuranta2.Add(reader.GetString("alue_id"));
                valitseAlue2.Items.Add(mokkiNimi);
            }

            // Sulje lukija ja tietokantayhteys
            reader.Close();
            connection.Close();
        }

        private void valitseHinta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
