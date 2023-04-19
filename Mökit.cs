using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MökkienHallinta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            // Hae mökkejä tietokannasta ja näytä ne datagridissä
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            // Avaa lomake uuden mökin lisäämiseksi tietokantaan
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            // Avaa lomake valitun mökin muokkaamiseksi tietokannassa
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            // Poista valittu mökki tietokannasta
        }
    }
}
