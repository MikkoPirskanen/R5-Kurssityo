using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mökkihöperö
{
    public partial class Laskutus : Form
    {
        public Laskutus()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kuvarajaus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tulostusnappi_Click(object sender, EventArgs e)
        {
            string tekstinotto1 = textBox1.Text; tekstinotto1.Trim();

            if (tekstinotto1 == "")
            {
                MessageBox.Show("Syötä laskutettava teksti");
                return;
            }

            ExportToPdf(tekstinotto1);
        }

        private void ExportToPdf(string textBox1Text)
        {
            string outputPath = "Cf:\\temp\\output.pdf";

            

            try {
                // Create a new PDF document
                iTextSharp.text.Document document = new iTextSharp.text.Document();

                // Set the output file path and create a new file in that location
                using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create))
                {
                    // Create a new PDF writer
                    PdfWriter.GetInstance(document, outputFileStream);

                    // Open the PDF document
                    document.Open();

                    // Add the contents of textBox1, textBox2, and textBox3 to the PDF document
                    document.Add(new Paragraph(textBox1Text));

                    // Close the PDF document
                    document.Close();
                }
                MessageBox.Show("Lomake tulostettu: " + outputPath);
            }
             catch
            {
                MessageBox.Show("Tiedostoa ei voitu luoda");
                return;
            }
            }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Laskutus_Load(object sender, EventArgs e)
        {

        }
    }
}
