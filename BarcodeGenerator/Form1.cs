using System;
using System.Linq;
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (barcodeRange1.SelectedItem != null && barcodeRange2.SelectedItem != null)
            {
                object barcodeData = $"{Convert.ToInt64(barcodeRange1.SelectedItem) + Convert.ToInt64(50000000000)}";
                var barcodeUrl = $"barcode.tec-it.com/barcode.ashx?translate-esc=off&data={barcodeData}&code=UPCA&authentication=None&ssid=Networkname&password=&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=000000&bgcolor=FFFFFF&qunit=Mm&quiet=0&eclevel=L";

                int r1 = Int32.Parse($"{barcodeRange1.SelectedItem}");
                try
                {
                    var rangeValues = Enumerable.Range(r1, Int32.Parse(rangeCount.Text));
                    try
                    {
                        Avery5161pdf.PdfGen(rangeCount.Text);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    lastSubmitDate.Text = $"{DateTime.Now}";
                    lastRange1.Text = $"{Convert.ToInt32(barcodeRange1.SelectedItem)}";
                    lastRange2.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem)}";
                }
                
                catch
                {
                    MessageBox.Show("Range cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BarcodeRange1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange2.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem) - Convert.ToInt32(barcodeRange1.SelectedItem) + 1}";
            }
        }

        private void BarcodeRange2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange1.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem) - Convert.ToInt32(barcodeRange1.SelectedItem) + 1}";
            }
        }

        private void LastRange1_Click(object sender, EventArgs e)
        {

        }

        private void LastRange2_Click(object sender, EventArgs e)
        {

        }

        private void RangeCount_Click(object sender, EventArgs e)
        {

        }

        private void LastSubmitDate_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
