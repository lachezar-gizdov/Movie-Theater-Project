using MovieTheater.Framework.Common.Contracts;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace MovieTheater.Framework.Common
{
    public class PdfExporter : IExporter
    {
        public void Export(string textToExport, string fileName)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 10, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString(
                textToExport,
                font,
                XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopLeft);

            // Save the document...
            document.Save(fileName + ".pdf");

            // ...and start a viewer.
             Process.Start(fileName + ".pdf");
        }
    }
}