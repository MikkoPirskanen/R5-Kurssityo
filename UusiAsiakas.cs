using System;
using System.Collections;
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
    public partial class UusiAsiakas : Form
    {
        string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

        public UusiAsiakas()
        {
            InitializeComponent();
        }

        private void UusiAsiakas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lisaaBtn_Click(object sender, EventArgs e)
        {
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


            string ConnectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

           try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO asiakas (etunimi, sukunimi, lahiosoite, postinro, puhelinnro, email) VALUES (@etunimi, @sukunimi, @lahiosoite, @postinro, @puhelinnro, @email)");
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@etunimi", etunimiBox.Text);
                cmd.Parameters.AddWithValue("@sukunimi", sukunimiBox.Text);
                cmd.Parameters.AddWithValue("@lahiosoite", osoiteBox.Text);
                cmd.Parameters.AddWithValue("@postinro", postinroBox.Text);
                cmd.Parameters.AddWithValue("@puhelinnro", puhnroBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.ExecuteNonQuery();


                    MessageBox.Show("Asiakas lisätty onnistuneesti!");
                    connection.Close();
                    
                    this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe lisätessä asiakasta tietokantaan: " + ex.Message);
            }



        }
    }
}
