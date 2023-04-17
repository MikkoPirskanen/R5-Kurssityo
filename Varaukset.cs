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
    public partial class Varaukset : Form
    {

        public Varaukset()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                // Tyhjennä listboxi
                listBox2.Items.Clear();



                // Hae valitun alueen mökit
                string selectedArea = comboBox1.SelectedItem.ToString();
                string[] cabins = null;

                if (selectedArea == "Pohjois-Savo")
                {
                    cabins = new string[] { "Mökki 1", "Mökki 2", "Mökki 3" };
                }
                else if (selectedArea == "Etelä-Savo")
                {
                    cabins = new string[] { "Mökki 4", "Mökki 5", "Mökki 6" };
                }

                // Lisää mökit listboxiin
                if (cabins != null)
                {
                    foreach (string cabin in cabins)
                    {
                        listBox2.Items.Add(cabin);
                    }
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, string>> cabins = new Dictionary<string, Dictionary<string, string>>();
            cabins.Add("Mökki 1", new Dictionary<string, string>() { { "Osoite", "Katu 1" }, { "Hinta", "100€/vrk" }, { "Kuvaus", "Tunnelmallinen hirsimökki" } });
            cabins.Add("Mökki 2", new Dictionary<string, string>() { { "Osoite", "Katu 2" }, { "Hinta", "150€/vrk" }, { "Kuvaus", "Iso ja moderni huvila" } });
            cabins.Add("Mökki 3", new Dictionary<string, string>() { { "Osoite", "Katu 3" }, { "Hinta", "200€/vrk" }, { "Kuvaus", "Tyylikäs huvila" } });
            cabins.Add("Mökki 4", new Dictionary<string, string>() { { "Osoite", "Katu 4" }, { "Hinta", "250€/vrk" }, { "Kuvaus", "Tyylikäs huvila" } });
            cabins.Add("Mökki 5", new Dictionary<string, string>() { { "Osoite", "Katu 5" }, { "Hinta", "300€/vrk" }, { "Kuvaus", "Tyylikäs huvila" } });
            cabins.Add("Mökki 6", new Dictionary<string, string>() { { "Osoite", "Katu 6" }, { "Hinta", "350€/vrk" }, { "Kuvaus", "Tyylikäs huvila" } });


            // Hae valitun mökin tiedot
            string selectedCabin = listBox2.SelectedItem.ToString();
            Dictionary<string, string> cabinInfo = cabins[selectedCabin];

            // Näytä tiedot datagridviewissä
            dataGridView1.Rows.Clear();
            foreach (KeyValuePair<string, string> kvp in cabinInfo)
            {
                dataGridView1.Columns.Add(kvp.Key, kvp.Value);
                dataGridView1.Rows.Add(kvp.Key, kvp.Value);
                         
            }
        }

        



private void Varaukset_Load(object sender, EventArgs e)
        {

        }
    }
}
