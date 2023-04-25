
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mökkihöperö
{
    public partial class Mokit : Form
    {
        public Mokit()
        {
            InitializeComponent();
        }

        private void Mokit_Load(object sender, EventArgs e)
        {
            // Initialize the data adapter and table
            dataAdapter = new SqlDataAdapter("SELECT * FROM mokki", connectionString);
            table = new DataTable();
            dataAdapter.Fill(table);

            // Bind the table to the data grid view
            dataGridView1.DataSource = table;

            // Initialize the connection
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void hakuNappi_Click(object sender, EventArgs e)
        {
            // Get the search string from the text box
            string searchString = textBox1.Text;

            // Use a SQL query to search for the matching rows
            string query = string.Format("SELECT * FROM mokki WHERE mokki_id LIKE '%{0}%' OR alue_id LIKE '%{0}%' OR postinro LIKE '%{0}%' OR mokkinimi LIKE '%{0}%' OR katuosoite LIKE '%{0}%' OR hinta LIKE '%{0}%' OR kuvaus LIKE '%{0}%' OR henkilomaara LIKE '%{0}%' OR varustelu LIKE '%{0}%'", searchString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            table.Clear();
            dataAdapter.Fill(table);
        }

        private void lisaaNappi_Click(object sender, EventArgs e)
        {
            // Create a new row and show the MokkiDialog form to add the values
            DataRow row = table.NewRow();
            MokkiDialog dialog = new MokkiDialog(row);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Add the new row to the table and update the database
                table.Rows.Add(row);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(table);
            }
        }

        private void muokkaaNappi_Click(object sender, EventArgs e)
        {
            // Get the selected row and show the MokkiDialog form to edit the values
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView rowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                DataRow row = rowView.Row;
                MokkiDialog dialog = new MokkiDialog(row);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the row in the table and the database
                    SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(table);
                }
            }
        }

        private void poistaNappi_Click(object sender, EventArgs e)
        {
            // Get the selected row and remove it from the table and the database
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView rowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                DataRow row = rowView.Row;
                row.Delete();
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(table);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            base.Dispose(disposing);
        }
    }
}
