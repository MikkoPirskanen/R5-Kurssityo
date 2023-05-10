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
    public partial class VarausTiedot : Form
    {
        public VarausTiedot()
        {
            InitializeComponent();
        }

        private void VarausTiedot_Load(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();



            }


            string connectionString = "server=127.0.0.1; database=vn;uid=root;pwd=VillageNewbies;";

            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            int mokkiId = Varaukset.selectedMokkiId;
            string sqlQuery = @"
            SELECT * FROM varaus WHERE mokki_mokki_id = @mokki_mokki_id";


            MySqlCommand cmd = new MySqlCommand(sqlQuery, sqlConnection);
            cmd.Parameters.AddWithValue("@mokki_mokki_id", mokkiId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];


            sqlConnection.Close();

        }

        private void uusiVarausBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
