using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            barcodeRange1.SelectedItem = barcodeRange1.Top;
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
            //int r1 = Int32.Parse($"{barcodeRange1.SelectedItem}");

            var rangeValues = Enumerable.Range(1849, Int32.Parse(rangeCount.Text));

            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Barcodes for JMU EFEX Lending Library";
                PdfPage page = document.AddPage();
                page.Size = PdfSharp.PageSize.Letter;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XTextFormatter tf = new XTextFormatter(gfx);
                XFont titleFont = new XFont("Verdana", 20, XFontStyle.Underline);
                XFont barcodeFont = new XFont("Verdana", 14, XFontStyle.Regular);
                gfx.DrawString("Barcodes", titleFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);
                //for (int i = 0; i < Int32.Parse(rangeCount.Text); i++)
                //{
                //    gfx.DrawString("I am a barcode", barcodeFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                //}

                //US Letter Page Dimensions: 612 * 792
                string text = "I am a barcode";
                XRect rect = new XRect(12, 36, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 108, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 180, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 252, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 324, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 396, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 468, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 540, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 612, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(12, 684, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 36, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 108, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 180, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 252, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 324, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 396, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 468, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 540, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 612, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(313, 684, 288, 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);

                const string filename = "Barcodes.pdf";
                document.Save(filename);
                Process.Start(filename);
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
