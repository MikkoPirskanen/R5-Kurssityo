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
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

            if (majoituksetDgv.Rows.Count > 1 ) {
                majoituksetDgv.Rows.Clear();
            }
            
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();


            string sqlQuery = @"
            SELECT a.asiakas_id, a.etunimi AS etunimi, a.sukunimi AS sukunimi, m.mokkinimi AS Mökkinimi, al.alue_id, vp.palvelu_id
FROM varaus v
JOIN asiakas a ON a.asiakas_id = v.asiakas_id
JOIN mokki m ON m.mokki_id = v.mokki_mokki_id
JOIN alue al ON al.alue_id = m.alue_id
LEFT JOIN varauksen_palvelut vp ON vp.varaus_id = v.varaus_id
WHERE v.varattu_alkupvm >= @startDate AND v.varattu_loppupvm <= @endDate;";





            MySqlCommand cmd = new MySqlCommand(sqlQuery, sqlConnection);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            majoituksetDgv.DataSource = dataSet.Tables[0];
            majoituksetDgv.Columns["Mökkinimi"].HeaderText = "Mökin nimi";

            sqlConnection.Close();


        }

        private void Raportit_Load(object sender, EventArgs e)
        {

        }
    }
}





