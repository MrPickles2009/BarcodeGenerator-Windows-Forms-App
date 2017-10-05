using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace BarcodeGenerator
{
    public static class Avery5161pdf
    {
        public static void PdfGen(string rangeCount)
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

            //for (int i = 0; i < Int32.Parse(barcodeCounted); i++)
            //{
            //    gfx.DrawString("I am a barcode", barcodeFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            //}

            //US Letter Page Dimensions: 612 * 792
            string text = "I am a barcode";
            XRect rect;
            int barcodeCount = int.Parse(rangeCount);
            int val1 = 12;
            int val2 = 36;
            int barcodeCountLessTen = (barcodeCount - 10);

            if (barcodeCount > 10)
            {
                barcodeCount = 10;
            }

            for (int i = 0; i < barcodeCount; i++)
            {
                rect = new XRect(x: val1, y: val2, width: 288, height: 72);
                gfx.DrawRectangle(XBrushes.White, rect);
                tf.Alignment = XParagraphAlignment.Left;
                tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);
                val2 += 72;
            }

            barcodeCount = int.Parse(rangeCount);

            if (barcodeCount > 10)
            {
                val1 = 313;
                val2 = 36;

                for (int i = 0; i < barcodeCountLessTen; i++)
                {
                    rect = new XRect(x: val1, y: val2, width: 288, height: 72);
                    gfx.DrawRectangle(XBrushes.White, rect);
                    tf.Alignment = XParagraphAlignment.Left;
                    tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);
                    val2 += 72;
                }
            }

            const string filename = "Barcodes.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
