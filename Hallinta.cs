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
    public partial class Hallinta : Form
    {
        public Hallinta()
        {
            InitializeComponent();
        }

        private void asiakasNappi_Click(object sender, EventArgs e)
        {
            Asiakkaat asiakkaat = new Asiakkaat();

            asiakkaat.Show();

        }

        private void varausNappi_Click(object sender, EventArgs e)
        {
            Varaukset varaukset = new Varaukset();

            varaukset.Show();

        }
    }
}
