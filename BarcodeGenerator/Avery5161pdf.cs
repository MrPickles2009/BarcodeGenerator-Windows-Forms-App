using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator
{
    public static class Avery5161pdf
    {
        public static void PdfGen()
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

            for (int i = 0; i < 5/*Int32.Parse(Form1.rangeCounted.Text)*/; i++)
            {
                gfx.DrawString("I am a barcode", barcodeFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            }

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
    }
}
