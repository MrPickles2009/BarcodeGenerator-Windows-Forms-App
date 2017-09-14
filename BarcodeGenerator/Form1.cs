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

            HttpClient client;
            async Task<T> GetAsync<T>(string url)
            {
                object barcodeData = 51000001687;
                var barcodeUrl = $"barcode.tec-it.com/barcode.ashx?translate-esc=off&data={barcodeData}&code=UPCA&authentication=None&ssid=Networkname&password=&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=000000&bgcolor=FFFFFF&qunit=Mm&quiet=0&eclevel=L";

                T result = default(T);

                HttpResponseMessage response = await client.GetAsync(barcodeUrl);
                return result;
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
