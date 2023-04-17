namespace Mökkihöperö
{
    public partial class Etusivu : Form
    {
        public Etusivu()
        {
            InitializeComponent();
        }

        private void laskutusNappi_Click(object sender, EventArgs e)
        {
            Laskutus laskutus = new Laskutus() { TopLevel = false, TopMost = true };
            this.Controls.Add(laskutus);
            laskutus.Show();


        }

        private void raporttINappi_Click(object sender, EventArgs e)
        {
            paneeli.Controls.Clear();

            Raportit raportit = new Raportit() { TopLevel = false, TopMost = true };
            paneeli.Controls.Add(raportit);
            raportit.FormBorderStyle = FormBorderStyle.None;
            raportit.Show();

        }

        private void hallintaNappi_Click(object sender, EventArgs e)
        {
            paneeli.Controls.Clear();
            Hallinta hallinta = new Hallinta() { TopLevel = false, TopMost = true };
            paneeli.Controls.Add(hallinta);
            hallinta.FormBorderStyle = FormBorderStyle.None;
            hallinta.Show();

        }

        private void laskutusNappi_Click_1(object sender, EventArgs e)
        {
            paneeli.Controls.Clear();
            Laskutus laskutus = new Laskutus() { TopLevel = false, TopMost = true };
            paneeli.Controls.Add(laskutus);
            laskutus.FormBorderStyle = FormBorderStyle.None;
            laskutus.Show();

        }
    }
}