using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            lastSubmitDate.Text = $"{DateTime.Now}";
            lastRange1.Text = $"{Convert.ToInt64(barcodeRange1.SelectedItem)}";
            lastRange2.Text = $"{Convert.ToInt64(barcodeRange2.SelectedItem)}";

            object barcodeData = $"{Convert.ToInt64(barcodeRange1.SelectedItem)}";
            var barcodeUrl = $"barcode.tec-it.com/barcode.ashx?translate-esc=off&data={barcodeData}&code=UPCA&authentication=None&ssid=Networkname&password=&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=000000&bgcolor=FFFFFF&qunit=Mm&quiet=0&eclevel=L";

            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("./Barcodes.pdf", FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph("Barcodes:");
                document.Add(p);
                document.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void barcodeRange1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange2.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt64(barcodeRange2.SelectedItem) - Convert.ToInt64(barcodeRange1.SelectedItem) + 1}";
            }
        }

        private void barcodeRange2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange1.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt64(barcodeRange2.SelectedItem) - Convert.ToInt64(barcodeRange1.SelectedItem) + 1}";
            }
        }

        private void lastRange1_Click(object sender, EventArgs e)
        {

        }

        private void lastRange2_Click(object sender, EventArgs e)
        {

        }

        private void rangeCount_Click(object sender, EventArgs e)
        {

        }

        private void lastSubmitDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
