using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace MovieTheater.Framework.Common
{
    public static class PDFExporter
    {
        public static void Export()
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopLeft);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);

            // ...and start a viewer.
            // Process.Start(filename);
        }
    }
}