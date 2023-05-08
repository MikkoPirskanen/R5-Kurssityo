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
    public partial class Raportit : Form
    {
        public Raportit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raportti.Items.Clear();
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT a.asiakas_id, m.mokki_id, al.alue_id, vp.palvelu_id
                FROM varaus v
                JOIN asiakas a ON a.asiakas_id = v.asiakas_id
                JOIN mokki m ON m.mokki_id = v.mokki_mokki_id
                JOIN alue al ON al.alue_id = m.alue_id
                LEFT JOIN varauksen_palvelut vp ON vp.varaus_id = v.varaus_id
                WHERE v.varattu_alkupvm >= @startDate AND v.varattu_loppupvm <= @endDate;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int asiakas_id = reader.GetInt32("asiakas_id");
                        int mokki_id = reader.GetInt32("mokki_id");
                        int alue_id = reader.GetInt32("alue_id");
                        string result = $"Asiakas ID: {asiakas_id}, Mokki ID: {mokki_id}, Alue ID: {alue_id}";

                        if (!reader.IsDBNull(reader.GetOrdinal("palvelu_id")))
                        {
                            int palvelu_id = reader.GetInt32("palvelu_id");
                            result += $", Palvelu ID: {palvelu_id}";
                        }

                        Raportti.Items.Add(result);
                    }
                }
            }
        }
    }
}




