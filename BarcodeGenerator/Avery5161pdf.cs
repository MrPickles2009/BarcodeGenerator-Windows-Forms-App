﻿using PdfSharp.Drawing;
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
            int barcodeCountDivTen = (barcodeCount / 10) + 1;
            int val1 = 12;
            int val2 = 36;

            for (int j = 0; j < barcodeCountDivTen; j++)
            {
                for (int i = 0; ((i < barcodeCount) && (i < 10)); i++)
                {
                    rect = new XRect(val1, val2, 288, 72);
                    gfx.DrawRectangle(XBrushes.White, rect);
                    tf.Alignment = XParagraphAlignment.Left;
                    tf.DrawString(text, barcodeFont, XBrushes.Black, rect, XStringFormats.TopLeft);
                    val2 += 72;
                }
                val2 = 36;
                val1 += 301;
                barcodeCount -= 10;
            }
            const string filename = "Barcodes.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
